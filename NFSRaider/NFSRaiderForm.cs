﻿using Combinatorics.Collections;
using NFSRaider.Case;
using NFSRaider.Enums;
using NFSRaider.Hash;
using NFSRaider.Helpers;
using NFSRaider.Keys;
using NFSRaider.Raider;
using NFSRaider.Raider.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NFSRaider
{
    public partial class NFSRaiderForm : Form
    {
        public NFSRaiderForm()
        {
            InitializeComponent();
            ComponentsChanged();
            CboOrderBy.SelectedIndex = (int)OrderOptions.None;
            ChkBruteforceWithRepetition.Checked = Convert.ToBoolean((int)GenerateOption.WithRepetition);
            ChkCaseSensitive.Checked = new[] { StringComparison.CurrentCulture, StringComparison.InvariantCulture, StringComparison.Ordinal }.Contains(StringComparison.InvariantCultureIgnoreCase);
            CboForceHashListCase.SelectedIndex = (int)CaseOptions.None;
            CboEndianness.SelectedIndex = (int)Endianness.BigEndian;
            CboHashTypes.SelectedIndex = (int)HashType.Bin;
            CboRaiderMode.SelectedIndex = (int)RaiderMode.Unhasher;
            CboNumericBase.SelectedIndex = (int)NumericBase.Hexadecimal;
            CboNumericBaseLst.SelectedIndex = (int)NumericBase.Hexadecimal;
            LblTimeElapsed.Text = string.Empty;
            NumericProcessorsCount.Maximum = Environment.ProcessorCount;
            NumericProcessorsCount.Value = Environment.ProcessorCount / 2;

#if DEBUG
            Text += " - Debug";
#endif
        }

        private HashFactory HashFactory { get; set; }
        private CaseFactory CaseFactory { get; set; }

        private List<RaiderResult> ListBoxDataSource { get; set; } = new List<RaiderResult>();
        private string FilePath { get; set; }
        private GenerateOption GenerateOption { get; set; }
        private Endianness UnhashingEndianness { get; set; }
        private OrderOptions OrderOption { get; set; }
        private RaiderMode RaiderMode { get; set; }
        private NumericBase NumericBase { get; set; }
        private NumericBase NumericBaseLst { get; set; }

        private TimeElapsed _timer;

        private StringComparison SearchOptionStringComparasion { get; set; } = StringComparison.InvariantCultureIgnoreCase;

        private CancellationTokenSource CancellationTokenSource { get; set; }
        private Task BruteforceTask { get; set; }
        private bool BruteforceTaskNotFinished() => BruteforceTask?.Status != null && !new[] { TaskStatus.Faulted, TaskStatus.Canceled, TaskStatus.RanToCompletion }.Contains(BruteforceTask.Status);

        private object LockObject { get; } = new object();

        public void UpdateFormDuringBruteforce(RaiderResult result)
        {
            lock (LockObject)
            {
                ListBoxDataSource.Add(result);
                Invoke((MethodInvoker)(() => ChangedListBoxDataSource()));
            }
        }


        public void UpdateFormDuringBruteforce(IEnumerable<RaiderResult> results)
        {
            lock (LockObject)
            {
                ListBoxDataSource.AddRange(results);
                Invoke((MethodInvoker)(() => ChangedListBoxDataSource()));
            }
        }

        public void GenericMessageBoxDuringBruteForce(string title, string text)
        {
            Invoke((MethodInvoker)(() =>
            {
                _timer.Stop();
                UpdateTimeEllapsed();
                MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                _timer.Restart();
            }));
        }

        private void BtnLoadFile_Click(object sender, EventArgs e)
        {
            using var fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                FilePath = fileDialog.FileName;
                var text = $"File loaded in {FilePath}";
                LblStatus.Text = text.Length > 150 ? string.Concat(text.AsSpan(0, 150), "...") : text;
            }
        }

        private async void BtnStartStop_Click(object sender, EventArgs e)
        {
            if (BruteforceTaskNotFinished())
            {
                CancellationTokenSource?.Cancel(true);

                return;
            }

            try
            {
                if (BruteforceTaskNotFinished())
                    return;

                var message = string.Empty;

                if (TabLoadOptions.SelectedTab == TabLoadOptions.TabPages["TabPageFromFile"])
                {
                    if (string.IsNullOrWhiteSpace(FilePath) && !File.Exists(FilePath))
                        message += $"- File not found.{Environment.NewLine}";

                    if (!(ChkUseMainKeys.Checked || ChkUseUserKeys.Checked || ChkUseMergedKeys.Checked))
                        message += $"- You must either use the keys files or try to bruteforce.{Environment.NewLine}";

                    if (string.IsNullOrWhiteSpace(message))
                    {
                        _timer = new TimeElapsed();
                        _timer.Start();

                        if (RaiderMode == RaiderMode.Unhasher)
                        {
                            var file = Raider.FileRaid.Open(TxtFileStartOffset.Text, TxtFileEndOffset.Text, TxtFileReadHashes.Text, TxtFileSkipHashes.Text, FilePath);
                            var listBox = Raider.FileRaid.UnhashFromFile(UnhashingEndianness, HashFactory, file, CaseFactory, NumericProcessorsCount.Value, ChkUseMainKeys.Checked, ChkUseUserKeys.Checked, ChkUseMergedKeys.Checked);
                            ListBoxDataSource = listBox;
                            ChangedListBoxDataSource();
                        }
                        else if (RaiderMode == RaiderMode.Hasher)
                        {
                            var file = Raider.FileRaid.Open(FilePath);
                            var listBox = Raider.FileRaid.HashFromFile(HashFactory, file);
                            ListBoxDataSource = listBox;
                            ChangedListBoxDataSource();
                        }

                        BruteforceFinished();
                    }
                    else
                    {
                        message = $"Failed to raid:{Environment.NewLine}{message}";
                        MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (TabLoadOptions.SelectedTab == TabLoadOptions.TabPages["TabPageFromText"])
                {
                    if (RaiderMode == RaiderMode.Unhasher)
                    {
                        if (!(ChkUseMainKeys.Checked || ChkUseUserKeys.Checked || ChkUseMergedKeys.Checked) && !ChkTryToBruteforce.Checked)
                            message += $"- You must either use the keys files or try to bruteforce.{Environment.NewLine}";
                        if (string.IsNullOrWhiteSpace(TxtLoadFromText.Text))
                            message += $"- You must include hashes on the list.{Environment.NewLine}";
                        if (ChkTryToBruteforce.Checked)
                        {
                            if (Convert.ToInt32(NumericMinVariations.Text) > Convert.ToInt32(NumericMaxVariations.Text))
                                message += $"- Minimum amount of variations cannot be bigger than the maximum amount of variations.{Environment.NewLine}";
                            if (string.IsNullOrWhiteSpace(TxtPrefixes.Text) && string.IsNullOrWhiteSpace(TxtVariations.Text) && string.IsNullOrWhiteSpace(TxtSuffixes.Text))
                                message += $"- You must fill at least one of those: Prefixes, Variations or Suffixes.";
                        }

                        if (string.IsNullOrWhiteSpace(message))
                        {
                            CancellationTokenSource = new CancellationTokenSource();
                            DisableComponentsDuringBruteforce();

                            var bruteForce = new Unhash(this, HashFactory, CaseFactory, GenerateOption, UnhashingEndianness, ChkUseMainKeys.Checked, ChkUseUserKeys.Checked, ChkUseMergedKeys.Checked, ChkTryToBruteforce.Checked,
                                TxtPrefixes.Text, TxtSuffixes.Text, TxtVariations.Text, TxtWordsBetweenVariations.Text, NumericMinVariations.Value, NumericMaxVariations.Value, NumericProcessorsCount.Value);
                            _timer = new TimeElapsed(bruteForce.UpdateTimeElapsed, TimeSpan.FromSeconds(1));

                            bruteForce.SplitHashes(TxtLoadFromText.Text, Numeric.Bases[NumericBase].Base);

                            _timer.Start();

                            BruteforceTask = Task.Factory.StartNew(t =>
                            {
                                bruteForce.Raid(CancellationTokenSource.Token);
                            }, default, CancellationTokenSource.Token, TaskCreationOptions.LongRunning, TaskScheduler.Default)
                            .ContinueWith(t => Invoke((MethodInvoker)(() => BruteforceFinished())));

                            await BruteforceTask;

                            ComponentsChanged();
                        }
                        else
                        {
                            message = $"Failed to raid:{Environment.NewLine}{message}";
                            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (RaiderMode == RaiderMode.Hasher)
                    {
                        if (string.IsNullOrWhiteSpace(TxtLoadFromText.Text))
                            message += $"- You must include hashes on the list.{Environment.NewLine}";

                        if (string.IsNullOrWhiteSpace(message))
                        {
                            CancellationTokenSource = new CancellationTokenSource();
                            DisableComponentsDuringBruteforce();

                            _timer = new TimeElapsed();
                            _timer.Start();

                            var hashStrings = new Raider.Hash(this, HashFactory);
                            hashStrings.SplitStrings(TxtLoadFromText.Text);

                            BruteforceTask = Task.Run(() =>
                            {
                                hashStrings.HashStrings(CancellationTokenSource.Token);
                            }, CancellationTokenSource.Token).ContinueWith(t => Invoke((MethodInvoker)(() => BruteforceFinished())));

                            await BruteforceTask;

                            ComponentsChanged();
                        }
                        else
                        {
                            message = $"Failed to raid:{Environment.NewLine}{message}";
                            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                if (MessageBox.Show($"An exception has occurred! You can check the details below:{Environment.NewLine}{Environment.NewLine}" +
                    ex.ToString() +
                    $"{Environment.NewLine}{Environment.NewLine}Do you want to continue anyway? The application may not work properly.", "Exception", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.No)
                {
                    Application.Exit();
                }
            }
        }

        private void BruteforceFinished()
        {
            _timer.StopAndDispose();
            UpdateTimeEllapsed();
            _timer = null;
            GC.Collect();
            MessageBox.Show("Completed!", "Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            LstUnhashed.DataSource = null;
            LstUnhashed.Items.Clear();
            LblKnownHashes.Text = "0";
            LblUnknownHashes.Text = "0";
            LblTotalHashes.Text = "0";
            ListBoxDataSource = new List<RaiderResult>();
        }

        private void ChangedListBoxDataSource()
        {
            LstUnhashed.BeginUpdate();

            var listBoxDataSource = ListBoxDataSource
                .Select(c => new RaiderResult { Hash = (c.Hash), IsKnown = c.IsKnown, Value = c.Value });

            if (ChkReverseHashes.Checked)
            {
                listBoxDataSource = listBoxDataSource.Select(c =>
                {
                    c.Hash = Hashes.Reverse(c.Hash);
                    return c;
                });
            }

            switch (OrderOption)
            {
                case OrderOptions.HashAsc:
                    listBoxDataSource = listBoxDataSource
                        .OrderBy(c => c.Hash);
                    break;
                case OrderOptions.HashDesc:
                    listBoxDataSource = listBoxDataSource
                        .OrderByDescending(c => c.Hash);
                    break;
                case OrderOptions.StringAsc:
                    listBoxDataSource = listBoxDataSource
                        .OrderBy(c => c.Value);
                    break;
                case OrderOptions.StringDesc:
                    listBoxDataSource = listBoxDataSource
                        .OrderByDescending(c => c.Value);
                    break;
                default:
                    break;
            }

            if (ChkIgnoreRepeatedStrings.Checked)
            {
                listBoxDataSource = listBoxDataSource
                    .GroupBy(c => c.Value)
                    .Select(c => c.First());
            }

            if (ChkIgnoreRepeatedHashes.Checked)
            {
                listBoxDataSource = listBoxDataSource
                    .GroupBy(c => c.Hash)
                    .Select(c =>
                    {
                        return c.Select(d =>
                        {
                            d.IsKnown = c.Any(e => e.IsKnown);
                            d.Value = string.Join(" / ", c.Select(e => e.Value).Distinct());
                            return d;
                        }).First();
                    });
            }

            var currentSelectedItem = LstUnhashed.SelectedIndex;

            var format = TxtExportFormat.Text;

            var knownHashes = 0;
            var unknownHashes = 0;

            var dataSource = new List<string>();
            var currentString = string.Empty;

            foreach (var item in listBoxDataSource)
            {
                if (item.IsKnown)
                    knownHashes++;
                else
                    unknownHashes++;

                dataSource.Add(format.Replace("(HASH)", Convert.ToString(item.Hash, Numeric.Bases[NumericBaseLst].Base).PadLeft(Numeric.Bases[NumericBaseLst].Chars, '0')).Replace("(STRING)", item.Value));
            }

            var listBoxDataSourceCount = knownHashes + unknownHashes;

            if (listBoxDataSourceCount <= currentSelectedItem && listBoxDataSourceCount > 0)
            {
                currentSelectedItem = listBoxDataSourceCount - 1;
            }
            else if (listBoxDataSourceCount == 0)
            {
                currentSelectedItem = -1;
            }

            LblKnownHashes.Text = knownHashes.ToString();
            LblUnknownHashes.Text = unknownHashes.ToString();
            LblTotalHashes.Text = listBoxDataSourceCount.ToString();
            LstUnhashed.DataSource = dataSource;
            LstUnhashed.ClearSelected();
            LstUnhashed.SelectedIndex = currentSelectedItem;

            UpdateTimeEllapsed();

            LstUnhashed.EndUpdate();
        }

        private void UpdateTimeEllapsed()
        {
            if (_timer != null)
                LblTimeElapsed.Text = $"Time elapsed: {_timer}";
        }

        private void TabLoadOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComponentsChanged();
        }

        private void CreateMergedKeysFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var keysToCombine = new List<string>();

            if (ChkUseMainKeys.Checked)
                keysToCombine.Add("\"Keys\\MainKeys\"");

            if (ChkUseUserKeys.Checked)
                keysToCombine.Add("\"Keys\\UserKeys\"");

            if (MessageBox.Show($"This will merge all the files in the folders {string.Join(" and ", keysToCombine)} into a single file, may take some time and can use a lot of RAM memory if there are a lot of .txt files.{Environment.NewLine}Do you want to continue?", "Create merged list of keys", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var getAllKeys = new BuildKeys(HashFactory, CaseFactory, ChkUseMainKeys.Checked, ChkUseUserKeys.Checked, ChkUseMergedKeys.Checked, NumericProcessorsCount.Value);
                getAllKeys.WriteKeysToFile();
                GC.Collect();
                MessageBox.Show("Keys file created!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TxtFileStartOffset_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtFileStartOffset.Text))
                TxtFileStartOffset.Text = "0";
        }

        private void TxtFileEndOffset_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtFileEndOffset.Text))
                TxtFileEndOffset.Text = "0";
        }

        private void TxtFileReadHashes_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtFileReadHashes.Text))
                TxtFileReadHashes.Text = "0";
        }

        private void TxtFileSkipHashes_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtFileSkipHashes.Text))
                TxtFileSkipHashes.Text = "0";
        }

        private void NumericMinVariations_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NumericMinVariations.Text))
                NumericMinVariations.Text = "0";
        }

        private void NumericMaxVariations_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NumericProcessorsCount.Text))
                NumericProcessorsCount.Text = "0";
        }


        private void NumericProcessorsCount_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NumericMaxVariations.Text))
                NumericMaxVariations.Text = "1";
        }

        private void ChkBruteforceWithRepetition_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkBruteforceWithRepetition.Checked)
                GenerateOption = GenerateOption.WithRepetition;
            else
                GenerateOption = GenerateOption.WithoutRepetition;
        }

        private void ChkUseMainKeys_CheckedChanged(object sender, EventArgs e)
        {
            KeyListChanged();
        }


        private void ChkUseUserKeys_CheckedChanged(object sender, EventArgs e)
        {
            KeyListChanged();
        }

        private void ChkUseMergedKeys_CheckedChanged(object sender, EventArgs e)
        {
            KeyListChanged();
        }

        private void KeyListChanged()
        {
            CboForceHashListCase.Enabled = ChkUseMainKeys.Checked || ChkUseUserKeys.Checked || ChkUseMergedKeys.Checked;
            CreateMergedKeysFileToolStripMenuItem.Enabled = ChkUseMainKeys.Checked || ChkUseUserKeys.Checked;

            ChkUseMainKeys.Enabled = !ChkUseMergedKeys.Checked;
            ChkUseUserKeys.Enabled = !ChkUseMergedKeys.Checked;
        }

        private void CboNumericBase_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Enum.IsDefined(typeof(NumericBase), CboNumericBase.SelectedIndex))
                NumericBase = (NumericBase)CboNumericBase.SelectedIndex;
            else
                NumericBase = NumericBase.Hexadecimal;
        }

        private void CboRaiderMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Enum.IsDefined(typeof(RaiderMode), CboRaiderMode.SelectedIndex))
                RaiderMode = (RaiderMode)CboRaiderMode.SelectedIndex;
            else
                RaiderMode = RaiderMode.Unhasher;

            ComponentsChanged();
        }

        private void CboEndianness_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Enum.IsDefined(typeof(Endianness), CboEndianness.SelectedIndex))
                UnhashingEndianness = (Endianness)CboEndianness.SelectedIndex;
            else
                UnhashingEndianness = Endianness.LittleEndian;
        }

        private void CboHashTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            var hashType = HashType.Bin;
            if (Enum.IsDefined(typeof(HashType), CboHashTypes.SelectedIndex))
                hashType = (HashType)CboHashTypes.SelectedIndex;

            HashFactory = HashFactory.GetHashType(hashType);
        }

        private void CboOrderBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Enum.IsDefined(typeof(OrderOptions), CboOrderBy.SelectedIndex))
                OrderOption = (OrderOptions)CboOrderBy.SelectedIndex;
            else
                OrderOption = OrderOptions.None;
        }


        private void CboNumericBaseLst_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Enum.IsDefined(typeof(NumericBase), CboNumericBaseLst.SelectedIndex))
                NumericBaseLst = (NumericBase)CboNumericBaseLst.SelectedIndex;
            else
                NumericBaseLst = NumericBase.Hexadecimal;
        }

        private void CboForceHashListCase_SelectedIndexChanged(object sender, EventArgs e)
        {
            var caseOption = CaseOptions.None;
            if (Enum.IsDefined(typeof(CaseOptions), CboForceHashListCase.SelectedIndex))
                caseOption = (CaseOptions)CboForceHashListCase.SelectedIndex;

            CaseFactory = CaseFactory.GetCaseType(caseOption);
        }


        private void Search(bool forward)
        {
            if (LstUnhashed.Items.Count <= 0)
                return;

            if (string.IsNullOrWhiteSpace(TxtSearch.Text))
            {
                LstUnhashed.ClearSelected();
                return;
            }

            var selected = LstUnhashed.SelectedIndex < 0 ? 0 : LstUnhashed.SelectedIndex;

            var rowStart = selected;
            var rowEnd = LstUnhashed.Items.Count - 1;
            var rowStep = forward ? 1 : -1;

            var found = false;
            var doneFullLoop = false;

            while (!found)
            {
                for (; rowStart <= rowEnd && rowStart >= 0; rowStart += rowStep)
                {
                    if (rowStart == selected)
                    {
                        if (doneFullLoop)
                            return;

                        continue;
                    }

                    if (ItemFound(rowStart))
                    {
                        found = true;
                        LstUnhashed.ClearSelected();
                        LstUnhashed.SetSelected(rowStart, true);
                        LstUnhashed.Focus();
                        break;
                    }
                }
                rowStart = forward ? 0 : LstUnhashed.Items.Count - 1;
                doneFullLoop = true;
            }
        }


        private void BtnSearchPrevious_Click(object sender, EventArgs e)
        {
            Search(false);
        }

        private void BtnSearchNext_Click(object sender, EventArgs e)
        {
            Search(true);
        }


        private void BtnSearchAll_Click(object sender, EventArgs e)
        {
            var listOfItems = new List<int>();
            for (int i = 0; i <= LstUnhashed.Items.Count - 1; i++)
            {
                if (ItemFound(i))
                {
                    listOfItems.Add(i);
                }
            }

            if (listOfItems.Any())
            {
                LstUnhashed.ClearSelected();

                LstUnhashed.BeginUpdate();

                foreach (var item in listOfItems)
                {
                    LstUnhashed.SetSelected(item, true);
                }

                LstUnhashed.EndUpdate();
            }
            LstUnhashed.Focus();
        }

        private bool ItemFound(int i)
        {
            return LstUnhashed.Items[i].ToString().Contains(TxtSearch.Text, SearchOptionStringComparasion);
        }

        private void ChkCaseSensitive_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkCaseSensitive.Checked)
                SearchOptionStringComparasion = StringComparison.InvariantCulture;
            else
                SearchOptionStringComparasion = StringComparison.InvariantCultureIgnoreCase;
        }

        private void BtnResetFormat_Click(object sender, EventArgs e)
        {
            TxtExportFormat.Text = "0x(HASH) - (STRING)";
        }

        private void BtnExportHashes_Click(object sender, EventArgs e)
        {
            var dataToExport = ChkExportSelectedOnly.Checked ? LstUnhashed.SelectedItems.Cast<string>() : (IList<string>)LstUnhashed.DataSource;
            if (dataToExport != null && dataToExport.Any())
            {
                using var saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
                saveFileDialog.DefaultExt = "txt";
                saveFileDialog.AddExtension = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllLines(saveFileDialog.FileName, dataToExport);

                    if (MessageBox.Show($"List exported to file:{Environment.NewLine}{Path.GetFileName(saveFileDialog.FileName)}{Environment.NewLine}Do you want to open it?",
                        "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = saveFileDialog.FileName,
                            UseShellExecute = true
                        });
                    }
                }
            }
            else
            {
                MessageBox.Show("No hashes to export.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnUpdateList_Click(object sender, EventArgs e)
        {
            lock (LockObject)
            {
                ChangedListBoxDataSource();
            }
        }

        private void LstUnhashed_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == System.Windows.Forms.Keys.C && LstUnhashed.SelectedItems.Count > 0)
            {
                var items = string.Join(Environment.NewLine, LstUnhashed.SelectedItems.Cast<string>());
                Clipboard.SetData(DataFormats.StringFormat, items);
            }
        }

        private void ComponentsChanged()
        {
            if (BruteforceTaskNotFinished())
                return;

            BtnStartStop.Text = "Start";
            ImportBruteforceConfigurationToolStripMenuItem.Enabled = true;
            BtnClear.Enabled = true;
            CreateMergedKeysFileToolStripMenuItem.Enabled = ChkUseMainKeys.Checked || ChkUseUserKeys.Checked;
            CboRaiderMode.Enabled = true;
            CboHashTypes.Enabled = true;

            if (TabLoadOptions.SelectedTab == TabLoadOptions.TabPages["TabPageFromFile"])
            {
                BtnLoadFile.Enabled = true;
                TxtLoadFromText.Enabled = false;
                TxtPrefixes.Enabled = false;
                TxtVariations.Enabled = false;
                TxtSuffixes.Enabled = false;
                NumericMinVariations.Enabled = false;
                NumericMaxVariations.Enabled = false;
                NumericProcessorsCount.Enabled = false;
                TxtWordsBetweenVariations.Enabled = false;
                ChkTryToBruteforce.Enabled = false;
                ChkBruteforceWithRepetition.Enabled = false;
                CboNumericBase.Enabled = false;

                if (RaiderMode == RaiderMode.Unhasher)
                {
                    ChkUseMainKeys.Enabled = !ChkUseMergedKeys.Checked;
                    ChkUseUserKeys.Enabled = !ChkUseMergedKeys.Checked;
                    ChkUseMergedKeys.Enabled = true;
                    TxtFileStartOffset.Enabled = true;
                    TxtFileEndOffset.Enabled = true;
                    TxtFileReadHashes.Enabled = true;
                    TxtFileSkipHashes.Enabled = true;
                    CboEndianness.Enabled = true;
                    CboForceHashListCase.Enabled = ChkUseMainKeys.Checked || ChkUseUserKeys.Checked || ChkUseMergedKeys.Checked;
                }
                else
                {
                    ChkUseMainKeys.Enabled = false;
                    ChkUseUserKeys.Enabled = false;
                    ChkUseMergedKeys.Enabled = false;
                    TxtFileStartOffset.Enabled = false;
                    TxtFileEndOffset.Enabled = false;
                    TxtFileReadHashes.Enabled = false;
                    TxtFileSkipHashes.Enabled = false;
                    CboEndianness.Enabled = false;
                    CboForceHashListCase.Enabled = false;
                }
            }
            else
            {
                TxtFileStartOffset.Enabled = false;
                TxtFileEndOffset.Enabled = false;
                BtnLoadFile.Enabled = false;
                TxtFileReadHashes.Enabled = false;
                TxtFileSkipHashes.Enabled = false;
                TxtLoadFromText.Enabled = true;
                TxtPrefixes.Enabled = false;
                TxtVariations.Enabled = false;
                TxtSuffixes.Enabled = false;
                NumericMinVariations.Enabled = false;
                NumericMaxVariations.Enabled = false;
                NumericProcessorsCount.Enabled = false;
                TxtWordsBetweenVariations.Enabled = false;
                ChkBruteforceWithRepetition.Enabled = false;

                if (RaiderMode == RaiderMode.Unhasher)
                {
                    ChkUseMainKeys.Enabled = !ChkUseMergedKeys.Checked;
                    ChkUseUserKeys.Enabled = !ChkUseMergedKeys.Checked;
                    ChkUseMergedKeys.Enabled = true;
                    ChkTryToBruteforce.Enabled = true;
                    CboEndianness.Enabled = true;
                    CboNumericBase.Enabled = true;
                    CboForceHashListCase.Enabled = ChkUseMainKeys.Checked || ChkUseUserKeys.Checked || ChkUseMergedKeys.Checked;

                    BruteForceChecked();
                }
                else
                {
                    ChkUseMainKeys.Enabled = false;
                    ChkUseUserKeys.Enabled = false;
                    ChkUseMergedKeys.Enabled = false;
                    ChkTryToBruteforce.Enabled = false;
                    CboEndianness.Enabled = false;
                    CboNumericBase.Enabled = false;
                    CboForceHashListCase.Enabled = false;
                }
            }
        }

        private void ChkTryToBruteforce_CheckedChanged(object sender, EventArgs e)
        {
            BruteForceChecked();
        }

        private void BruteForceChecked()
        {
            TxtPrefixes.Enabled = ChkTryToBruteforce.Checked;
            TxtVariations.Enabled = ChkTryToBruteforce.Checked;
            TxtSuffixes.Enabled = ChkTryToBruteforce.Checked;
            NumericMinVariations.Enabled = ChkTryToBruteforce.Checked;
            NumericMaxVariations.Enabled = ChkTryToBruteforce.Checked;
            NumericProcessorsCount.Enabled = ChkTryToBruteforce.Checked;
            TxtWordsBetweenVariations.Enabled = ChkTryToBruteforce.Checked;
            ChkBruteforceWithRepetition.Enabled = ChkTryToBruteforce.Checked;

        }

        private void DisableComponentsDuringBruteforce()
        {
            BtnStartStop.Text = "Stop";

            ImportBruteforceConfigurationToolStripMenuItem.Enabled = false;
            TxtLoadFromText.Enabled = false;
            BtnClear.Enabled = false;
            TxtPrefixes.Enabled = false;
            TxtVariations.Enabled = false;
            TxtSuffixes.Enabled = false;
            NumericMinVariations.Enabled = false;
            NumericMaxVariations.Enabled = false;
            NumericProcessorsCount.Enabled = false;
            TxtWordsBetweenVariations.Enabled = false;
            CreateMergedKeysFileToolStripMenuItem.Enabled = false;
            ChkUseMainKeys.Enabled = false;
            ChkUseUserKeys.Enabled = false;
            ChkUseMergedKeys.Enabled = false;
            ChkBruteforceWithRepetition.Enabled = false;
            ChkTryToBruteforce.Enabled = false;
            CboHashTypes.Enabled = false;
            CboEndianness.Enabled = false;
            CboForceHashListCase.Enabled = false;
            CboRaiderMode.Enabled = false;
            CboNumericBase.Enabled = false;
        }

        private void ImportBruteforceConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                using (var r = new StreamReader(fileDialog.FileName))
                {
                    var json = r.ReadToEnd();
                    var importedData = JsonSerializer.Deserialize<RaiderConfiguration>(json, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });

                    if (importedData == null)
                        return;

                    NumericMinVariations.Value = importedData.MinVariations ?? NumericMinVariations.Value;
                    NumericMaxVariations.Value = importedData.MaxVariations ?? NumericMaxVariations.Value;
                    NumericProcessorsCount.Value = importedData.ProcessorsCount ?? NumericProcessorsCount.Value;
                    CboNumericBase.SelectedIndex = importedData.NumericBase ?? CboNumericBase.SelectedIndex;
                    ChkBruteforceWithRepetition.Checked = importedData.WithRepetition ?? ChkBruteforceWithRepetition.Checked;
                    CboEndianness.SelectedIndex = importedData.Endianess ?? CboEndianness.SelectedIndex;
                    CboHashTypes.SelectedIndex = importedData.HashType ?? CboHashTypes.SelectedIndex;

                    if (!string.IsNullOrWhiteSpace(importedData.Prefixes))
                        TxtPrefixes.Text = importedData.Prefixes;

                    if (!string.IsNullOrWhiteSpace(importedData.Suffixes))
                        TxtSuffixes.Text = importedData.Suffixes;

                    if (!string.IsNullOrWhiteSpace(importedData.WordsBetweenVariations))
                        TxtWordsBetweenVariations.Text = importedData.WordsBetweenVariations;

                    if (!string.IsNullOrWhiteSpace(importedData.Variations))
                        TxtVariations.Text = importedData.Variations;

                    if (!string.IsNullOrWhiteSpace(importedData.LoadedFromText))
                        TxtLoadFromText.Text = importedData.LoadedFromText;
                }
            }
        }

        private void MenuExportBruteforceConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fields = new string[] { TxtPrefixes.Text, TxtSuffixes.Text, TxtWordsBetweenVariations.Text, TxtVariations.Text, TxtLoadFromText.Text };
            if (!fields.All(t => string.IsNullOrEmpty(t)))
            {
                var dataToExport = new RaiderConfiguration
                {
                    Prefixes = TxtPrefixes.Text,
                    Suffixes = TxtSuffixes.Text,
                    WordsBetweenVariations = TxtWordsBetweenVariations.Text,
                    Variations = TxtVariations.Text,
                    LoadedFromText = TxtLoadFromText.Text,
                    MinVariations = NumericMinVariations.Value,
                    MaxVariations = NumericMaxVariations.Value,
                    ProcessorsCount = NumericProcessorsCount.Value,
                    NumericBase = CboNumericBase.SelectedIndex,
                    WithRepetition = ChkBruteforceWithRepetition.Checked,
                    Endianess = CboEndianness.SelectedIndex,
                    HashType = CboHashTypes.SelectedIndex,
                };

                var dataToExportJson = JsonSerializer.Serialize(dataToExport);

                using var saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text Files (*.json)|*.json";
                saveFileDialog.DefaultExt = "json";
                saveFileDialog.AddExtension = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, dataToExportJson);

                    if (MessageBox.Show($"List exported to file:{Environment.NewLine}{Path.GetFileName(saveFileDialog.FileName)}{Environment.NewLine}Do you want to open it?",
                        "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = saveFileDialog.FileName,
                            UseShellExecute = true
                        });
                    }
                }
            }
            else
            {
                MessageBox.Show("No configuration to export.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
