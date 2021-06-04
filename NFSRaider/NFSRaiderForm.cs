using Combinatorics.Collections;
using NFSRaider.Enum;
using NFSRaider.GeneratedStrings;
using NFSRaider.Hash;
using NFSRaider.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
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
            LoadOptionChanged();
            CboOrderBy.SelectedIndex = 0;
            CboForceHashListCase.SelectedIndex = 0;
            CboEndianness.SelectedIndex = 0;
            CboHashTypes.SelectedIndex = 0;
            LblTimeElapsed.Text = string.Empty;
            NumericProcessorsCount.Maximum = Environment.ProcessorCount;
            NumericProcessorsCount.Value = Environment.ProcessorCount / 2;
        }

        private List<RaiderResult> ListBoxDataSource { get; set; } = new List<RaiderResult>();
        private string FilePath { get; set; }
        private GenerateOption GenerateOption { get; set; } = GenerateOption.WithRepetition;
        private Endianness UnhashingEndianness { get; set; } = Endianness.BigEndian;
        private HashType HashType { get; set; } = HashType.Bin;
        private OrderOptions OrderOption { get; set; } = OrderOptions.None;
        private CaseOptions CaseOption { get; set; } = CaseOptions.None;
        private HashFactory HashFactory { get; set; } = HashFactory.GetHashType(HashType.Bin);

        private readonly Stopwatch Timer = new Stopwatch();

        private Thread BruteForceThread { get; set; }
        private bool BruteforceProcessStarted { get; set; } = false;

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
                MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                TimerStop();
                TimerStart();
            }));
        }

        private void BtnLoadFile_Click(object sender, EventArgs e)
        {
            using (var fileDialog = new OpenFileDialog())
            {
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    FilePath = fileDialog.FileName.ToString();
                    var text = $"File loaded in {FilePath}";
                    LblStatus.Text = text.Length > 150 ? text.Substring(0, 150) + "..." : text;
                }
            }
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (RdbLoadFile.Checked)
                {
                    if (!string.IsNullOrWhiteSpace(FilePath) && File.Exists(FilePath))
                    {
                        TimerRestart();

                        var file = Raider.File.Open(TxtFileStartOffset.Text, TxtFileEndOffset.Text, TxtFileReadHashes.Text, TxtFileSkipHashes.Text, FilePath);
                        var listBox = Raider.File.UnhashFromFile(UnhashingEndianness, HashFactory, file, CaseOption);
                        ListBoxDataSource = listBox;
                        ChangedListBoxDataSource();
                        GC.Collect();

                        TimerStop();
                    }
                    else
                    {
                        MessageBox.Show("File not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (RdbLoadFromText.Checked && !BruteforceProcessStarted)
                {
                    if (!string.IsNullOrWhiteSpace(TxtLoadFromText.Text) &&
                        Convert.ToInt32(NumericMinVariations.Text) <= Convert.ToInt32(NumericMaxVariations.Text) &&
                        (!string.IsNullOrWhiteSpace(TxtPrefixes.Text) || !string.IsNullOrWhiteSpace(TxtVariations.Text) || !string.IsNullOrWhiteSpace(TxtSuffixes.Text)))
                    {
                        DisableComponentsDuringBruteforce();

                        var bruteForce = new Raider.Unhash(this, HashFactory, ChkUseHashesFile.Checked, ChkTryToBruteforce.Checked, TxtPrefixes.Text, TxtSuffixes.Text,
                            TxtVariations.Text, TxtWordsBetweenVariations.Text, NumericMinVariations.Text, NumericMaxVariations.Text, NumericProcessorsCount.Text, GenerateOption, UnhashingEndianness, CaseOption);
                        bruteForce.SplitHashes(TxtLoadFromText.Text);
                        BruteforceProcessStarted = true;

                        TimerRestart();

                        BruteForceThread = new Thread(() => { bruteForce.BruteForceThread(); Invoke((MethodInvoker)(() => BruteforceFinished())); })
                        {
                            IsBackground = true
                        };
                        BruteForceThread.Start();
                    }
                    else
                    {
                        var message = "Failed to raid:\r\n";
                        if (string.IsNullOrWhiteSpace(TxtLoadFromText.Text))
                            message += "- You must include hashes on the list.\r\n";
                        if (Convert.ToInt32(NumericMinVariations.Text) > Convert.ToInt32(NumericMaxVariations.Text))
                            message += "- Minimum amount of variations cannot be bigger than the maximum amount of variations.\r\n";
                        if (string.IsNullOrWhiteSpace(TxtPrefixes.Text) && string.IsNullOrWhiteSpace(TxtVariations.Text) && string.IsNullOrWhiteSpace(TxtSuffixes.Text))
                            message += "- You must fill at least one of those: Prefixes, Variations or Suffixes.";
                        MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                if (MessageBox.Show("An exception has occurred! You can check the details below:\r\n\r\n" + 
                    ex.ToString() +
                    "\r\n\r\nDo you want to continue anyway? The application may not work properly.", "Exception", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.No)
                {
                    Application.Exit();
                }
            }
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            if (BruteforceProcessStarted)
            {
                // TODO: Replace abort with something else
                BruteForceThread.Abort();
                BruteforceFinished();
            }
        }

        private void BruteforceFinished()
        {
            TimerStop();
            BruteforceProcessStarted = false;
            EnableComponentsAfterBruteforce();
            GC.Collect();
            MessageBox.Show("Raid completed!", "Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TimerStart()
        {
            Timer.Start();
        }

        private void TimerRestart()
        {
            Timer.Restart();
        }

        private void TimerStop()
        {
            Timer.Stop();
            LblTimeElapsed.Text = $"Time elapsed: {(int)Math.Floor(Timer.Elapsed.TotalHours):D2}{Timer.Elapsed:\\:mm\\:ss\\.fff}";
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

            var listBoxDataSource = ListBoxDataSource.AsEnumerable();

            if (ChkReverseHashes.Checked)
            {
                listBoxDataSource = listBoxDataSource
                    .Select(c => new RaiderResult { Hash = Hashes.Reverse(c.Hash), IsKnown = c.IsKnown, Value = c.Value });
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
                    .Select(c => new RaiderResult { Hash = c.Key, IsKnown = c.Any(d => d.IsKnown), Value = string.Join(" / ", c.Select(d => d.Value).Distinct()) });
            }

            var currentSelectedItem = LstUnhashed.SelectedIndex;

            var format = TxtExportFormat.Text;

            var knownHashes = 0;
            var unknownHashes = 0;

            var dataSource = new List<string>();

            foreach (var item in listBoxDataSource)
            {
                if (item.IsKnown)
                    knownHashes++;
                else
                    unknownHashes++;

                dataSource.Add(format.Replace("(HASH)", item.Hash.ToString("X8")).Replace("(STRING)", item.Value));
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

            LstUnhashed.EndUpdate();
        }

        private void RdbLoadFile_CheckedChanged(object sender, EventArgs e)
        {
            LoadOptionChanged();
        }

        private void RdbLoadFromText_CheckedChanged(object sender, EventArgs e)
        {
            LoadOptionChanged();
        }

        private void BtnGenerateListOfHashes_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will take a lot of time and will use a lot of RAM. Do you want to continue?", "Generate list of hashes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var getAllParts = new AllStrings();
                getAllParts.GetStrings();
                GC.Collect();
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

        private void ChkUseHashesFile_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkUseHashesFile.Checked)
                CboForceHashListCase.Enabled = true;
            else
                CboForceHashListCase.Enabled = false;
        }

        private void CboEndianness_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboEndianness.SelectedIndex >= 0 && CboEndianness.SelectedIndex <= 1)
                UnhashingEndianness = (Endianness)CboEndianness.SelectedIndex;
            else
                UnhashingEndianness = Endianness.LittleEndian;
        }

        private void CboHashTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboHashTypes.SelectedIndex == 1)
                HashType = HashType.Vlt;
            else if (CboHashTypes.SelectedIndex == 2)
                HashType = HashType.VltBin;
            else if (CboHashTypes.SelectedIndex == 3)
                HashType = HashType.VltVlt;
            else
                HashType = HashType.Bin;

            HashFactory = HashFactory.GetHashType(HashType);
        }

        private void CboOrderBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboOrderBy.SelectedIndex >= 0 && CboOrderBy.SelectedIndex <= 4)
                OrderOption = (OrderOptions)CboOrderBy.SelectedIndex;
            else
                OrderOption = OrderOptions.None;
        }

        private void CboForceHashListCase_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboForceHashListCase.SelectedIndex >= 0 && CboOrderBy.SelectedIndex <= 2)
                CaseOption = (CaseOptions)CboForceHashListCase.SelectedIndex;
            else
                CaseOption = CaseOptions.None;
        }

        private void BtnSearchPrevious_Click(object sender, EventArgs e)
        {
            for (int i = LstUnhashed.SelectedIndex - 1; i >= 0; i--)
            {
                if (ItemFound(i))
                {
                    LstUnhashed.ClearSelected();
                    LstUnhashed.SetSelected(i, true);
                    LstUnhashed.Focus();
                    break;
                }
            }
        }

        private void BtnSearchNext_Click(object sender, EventArgs e)
        {
            for (int i = LstUnhashed.SelectedIndex + 1; i <= LstUnhashed.Items.Count - 1; i++)
            {
                if (ItemFound(i))
                {
                    LstUnhashed.ClearSelected();
                    LstUnhashed.SetSelected(i, true);
                    LstUnhashed.Focus();
                    break;
                }
            }
        }


        private void BtnSearchAll_Click(object sender, EventArgs e)
        {
            var cleared = false;
            for (int i = 0; i <= LstUnhashed.Items.Count - 1; i++)
            {
                if (ItemFound(i))
                {
                    if (!cleared)
                    {
                        LstUnhashed.ClearSelected();
                        cleared = true;
                    }

                    LstUnhashed.SetSelected(i, true);
                }
            }
            LstUnhashed.Focus();
        }

        private bool ItemFound(int i)
        {
            return LstUnhashed.Items[i].ToString().ToUpperInvariant().Contains(TxtSearch.Text.ToUpperInvariant());
        }

        private void BtnExportHashes_Click(object sender, EventArgs e)
        {
            if (LstUnhashed.DataSource != null && ((IList<string>)LstUnhashed.DataSource).Count > 0)
            {
                using (var saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
                    saveFileDialog.DefaultExt = "txt";
                    saveFileDialog.AddExtension = true;

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllLines(saveFileDialog.FileName, (IList<string>)LstUnhashed.DataSource);

                        if (MessageBox.Show($"List exported to file:\r\n{Path.GetFileName(saveFileDialog.FileName)}\r\nDo you want to open it?", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            Process.Start(saveFileDialog.FileName);
                        }

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
            if (e.Control == true && e.KeyCode == Keys.C && LstUnhashed.SelectedItems.Count > 0)
            {
                var items = string.Join("\r\n", LstUnhashed.SelectedItems.Cast<string>());
                Clipboard.SetData(DataFormats.StringFormat, items);
            }
        }

        private void LoadOptionChanged()
        {
            if (RdbLoadFile.Checked)
            {
                TxtFileStartOffset.Enabled = true;
                TxtFileEndOffset.Enabled = true;
                BtnLoadFile.Enabled = true;
                TxtFileReadHashes.Enabled = true;
                TxtFileSkipHashes.Enabled = true;
                TxtLoadFromText.Enabled = false;
                TxtPrefixes.Enabled = false;
                TxtVariations.Enabled = false;
                TxtSuffixes.Enabled = false;
                NumericMinVariations.Enabled = false;
                NumericMaxVariations.Enabled = false;
                NumericProcessorsCount.Enabled = false;
                TxtWordsBetweenVariations.Enabled = false;
                ChkUseHashesFile.Enabled = false;
                ChkTryToBruteforce.Enabled = false;
                ChkBruteforceWithRepetition.Enabled = false;

                ChkUseHashesFile.Checked = true;
                ChkTryToBruteforce.Checked = false;
            }
            else
            {
                TxtFileStartOffset.Enabled = false;
                TxtFileEndOffset.Enabled = false;
                BtnLoadFile.Enabled = false;
                TxtFileReadHashes.Enabled = false;
                TxtFileSkipHashes.Enabled = false;
                TxtLoadFromText.Enabled = true;
                ChkUseHashesFile.Enabled = true;
                ChkTryToBruteforce.Enabled = true;
            }

        }

        private void ChkTryToBruteforce_CheckedChanged(object sender, EventArgs e)
        {
            BruteForceChecked();
        }

        private void BruteForceChecked()
        {
            if (ChkTryToBruteforce.Checked)
            {
                TxtPrefixes.Enabled = true;
                TxtVariations.Enabled = true;
                TxtSuffixes.Enabled = true;
                NumericMinVariations.Enabled = true;
                NumericMaxVariations.Enabled = true;
                NumericProcessorsCount.Enabled = true;
                TxtWordsBetweenVariations.Enabled = true;
                ChkBruteforceWithRepetition.Enabled = true;
            }
            else
            {
                TxtPrefixes.Enabled = false;
                TxtVariations.Enabled = false;
                TxtSuffixes.Enabled = false;
                NumericMinVariations.Enabled = false;
                NumericMaxVariations.Enabled = false;
                NumericProcessorsCount.Enabled = false;
                TxtWordsBetweenVariations.Enabled = false;
                ChkBruteforceWithRepetition.Enabled = false;
            }
        }

        private void EnableComponentsAfterBruteforce()
        {
            RdbLoadFromText.Enabled = true;
            RdbLoadFile.Enabled = true;
            TxtLoadFromText.Enabled = true;
            BtnClear.Enabled = true;
            BtnStart.Enabled = true;
            TxtPrefixes.Enabled = true;
            TxtVariations.Enabled = true;
            TxtSuffixes.Enabled = true;
            NumericMinVariations.Enabled = true;
            NumericMaxVariations.Enabled = true;
            NumericProcessorsCount.Enabled = true;
            TxtWordsBetweenVariations.Enabled = true;
            BtnGenerateListOfHashes.Enabled = true;
            ChkUseHashesFile.Enabled = true;
            ChkBruteforceWithRepetition.Enabled = true;
            ChkTryToBruteforce.Enabled = true;
            CboHashTypes.Enabled = true;
            CboEndianness.Enabled = true;
            CboForceHashListCase.Enabled = true;

            BruteForceChecked();
        }

        private void DisableComponentsDuringBruteforce()
        {
            RdbLoadFromText.Enabled = false;
            RdbLoadFile.Enabled = false;
            TxtLoadFromText.Enabled = false;
            BtnClear.Enabled = false;
            BtnStart.Enabled = false;
            TxtPrefixes.Enabled = false;
            TxtVariations.Enabled = false;
            TxtSuffixes.Enabled = false;
            NumericMinVariations.Enabled = false;
            NumericMaxVariations.Enabled = false;
            NumericProcessorsCount.Enabled = false;
            TxtWordsBetweenVariations.Enabled = false;
            BtnGenerateListOfHashes.Enabled = false;
            ChkUseHashesFile.Enabled = false;
            ChkBruteforceWithRepetition.Enabled = false;
            ChkTryToBruteforce.Enabled = false;
            CboHashTypes.Enabled = false;
            CboEndianness.Enabled = false;
            CboForceHashListCase.Enabled = false;
        }
    }
}
