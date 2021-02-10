using Combinatorics.Collections;
using NFSRaider.Enum;
using NFSRaider.GeneratedStrings;
using NFSRaider.Hash;
using NFSRaider.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        }

        private List<RaiderResults> ListBoxDataSource { get; set; } = new List<RaiderResults>();
        private string FilePath { get; set; }
        private GenerateOption GenerateOption { get; set; } = GenerateOption.WithRepetition;
        private Endianness UnhashingEndianness { get; set; } = Endianness.BigEndian;
        private HashType HashType { get; set; } = HashType.BIN;
        private OrderOptions OrderOption { get; set; } = OrderOptions.None;
        private CaseOptions CaseOption { get; set; } = CaseOptions.None;
        private HashFactory HashFactory { get; set; } = HashFactory.GetHashType(HashType.BIN);

        private Thread BruteForceThread { get; set; }
        private bool BruteforceProcessStarted { get; set; } = false;

        public void UpdateFormDuringBruteforce(uint hash, string generatedString, bool isKnown)
        {
            ListBoxDataSource.Add(new RaiderResults() { Hash = hash, Value = generatedString, IsKnown = isKnown });
            Invoke((MethodInvoker)(() => ChangedListBoxDataSource()));
        }

        private void BtnLoadFile_Click(object sender, EventArgs e)
        {
            using (var fileDialog = new OpenFileDialog())
            {
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    FilePath = fileDialog.FileName.ToString();
                    LblStatus.Text = $"File loaded in {FilePath}";
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (RdbLoadFile.Checked)
            {
                if (!string.IsNullOrWhiteSpace(FilePath) && File.Exists(FilePath))
                {
                    var file = FormMethods.FormFile.Open(TxtFileStartOffset.Text, TxtFileEndOffset.Text, TxtFileReadHashes.Text, TxtFileSkipHashes.Text, FilePath);
                    var listBox = FormMethods.FormFile.UnhashFromFile(UnhashingEndianness, HashFactory, file, CaseOption);
                    ListBoxDataSource = listBox;
                    ChangedListBoxDataSource();
                    GC.Collect();
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

                    var bruteForce = new FormMethods.FormBruteforce(this, HashFactory, ChkUseHashesFile.Checked, ChkTryToBruteforce.Checked, TxtPrefixes.Text, TxtSuffixes.Text,
                        TxtVariations.Text, TxtWordsBetweenVariations.Text, NumericMinVariations.Text, NumericMaxVariations.Text, GenerateOption, UnhashingEndianness, CaseOption);
                    bruteForce.Unhash(TxtLoadFromText.Text);
                    BruteforceProcessStarted = true;

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
            BruteforceProcessStarted = false;
            EnableComponentsAfterBruteforce();
            GC.Collect();
            MessageBox.Show("Raid completed!", "Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            LstUnhashed.DataSource = null;
            LstUnhashed.Items.Clear();
            LblKnownHashes.Text = "0";
            LblUnknownHashes.Text = "0";
            LblTotalHashes.Text = "0";
            ListBoxDataSource = new List<RaiderResults>();
        }

        private void ChangedListBoxDataSource()
        {
            var listBoxDataSource = ListBoxDataSource;

            if (ChkReverseHashes.Checked)
            {
                listBoxDataSource = listBoxDataSource
                    .Select(c => new RaiderResults { Hash = Hashes.Reverse(c.Hash), IsKnown = c.IsKnown, Value = c.Value })
                    .ToList();
            }

            if (OrderOption == OrderOptions.Hash)
            {
                listBoxDataSource = listBoxDataSource
                    .OrderBy(c => c.Hash)
                    .ToList();
            }
            else if (OrderOption == OrderOptions.String)
            {
                listBoxDataSource = listBoxDataSource
                    .OrderBy(c => c.Value)
                    .ToList();
            }

            if (ChkIgnoreRepeatedStrings.Checked)
            {
                listBoxDataSource = listBoxDataSource
                    .GroupBy(c => c.Value)
                    .Select(c => c.First())
                    .ToList();
            }

            if (ChkIgnoreRepeatedHashes.Checked)
            {
                listBoxDataSource = listBoxDataSource
                    .GroupBy(c => c.Hash)
                    .Select(c => c.First())
                    .ToList();
            }

            var currentSelectedItem = LstUnhashed.SelectedIndex;

            if (listBoxDataSource.Count <= currentSelectedItem && listBoxDataSource.Count > 0)
            {
                currentSelectedItem = listBoxDataSource.Count - 1;
            }
            else if (listBoxDataSource.Count == 0)
            {
                currentSelectedItem = -1;
            }

            var format = TxtExportFormat.Text;

            LblKnownHashes.Text = listBoxDataSource.Where(c => c.IsKnown).Count().ToString();
            LblUnknownHashes.Text = listBoxDataSource.Where(c => !c.IsKnown).Count().ToString();
            LblTotalHashes.Text = listBoxDataSource.Count().ToString();
            LstUnhashed.DataSource = listBoxDataSource.Select(c => format.Replace("(HASH)", c.Hash.ToString("X8")).Replace("(STRING)", c.Value)).ToArray();
            LstUnhashed.SelectedIndex = currentSelectedItem;
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
            var getAllParts = new AllStrings();
            getAllParts.GetStrings();
            GC.Collect();
        }

        private void RdbBinHash_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbBinHash.Checked)
            {
                HashType = HashType.BIN;
                HashFactory = HashFactory.GetHashType(HashType);
            }
        }

        private void RdbVltHash_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbVltHash.Checked)
            {
                HashType = HashType.VLT;
                HashFactory = HashFactory.GetHashType(HashType);
            }
        }

        private void RdbVlt64Hash_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbVlt64Hash.Checked)
            {
                HashType = HashType.VLT64;
                HashFactory = HashFactory.GetHashType(HashType);
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
            if (string.IsNullOrWhiteSpace(NumericMaxVariations.Text))
                NumericMaxVariations.Text = "0";
        }

        private void RdbUnhashBigEndian_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbUnhashBigEndian.Checked)
                UnhashingEndianness = Endianness.BigEndian;
        }

        private void RdbUnhashLittleEndian_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbUnhashLittleEndian.Checked)
                UnhashingEndianness = Endianness.LittleEndian;
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

        private void CboOrderBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboOrderBy.SelectedIndex == 1)
                OrderOption = OrderOptions.Hash;
            else if (CboOrderBy.SelectedIndex == 2)
                OrderOption = OrderOptions.String;
            else
                OrderOption = OrderOptions.None;
        }

        private void CboForceHashListCase_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboForceHashListCase.SelectedIndex == 1)
                CaseOption = CaseOptions.Uppercase;
            else if (CboForceHashListCase.SelectedIndex == 2)
                CaseOption = CaseOptions.Lowercase;
            else
                CaseOption = CaseOptions.None;
        }

        private void BtnSearchPrevious_Click(object sender, EventArgs e)
        {
            for (int i = LstUnhashed.SelectedIndex - 1; i >= 0; i--)
            {
                if (ItemFound(i))
                    break;
            }
        }

        private void BtnSearchNext_Click(object sender, EventArgs e)
        {
            for (int i = LstUnhashed.SelectedIndex + 1; i <= LstUnhashed.Items.Count - 1; i++)
            {
                if (ItemFound(i))
                    break;
            }
        }

        private bool ItemFound(int i)
        {
            if (LstUnhashed.Items[i].ToString().ToUpper().Contains(TxtSearch.Text.ToUpper()))
            {
                LstUnhashed.SetSelected(i, true);
                return true;
            }
            return false;
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
            ChangedListBoxDataSource();
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
            TxtPrefixes.Enabled = true;
            TxtVariations.Enabled = true;
            TxtSuffixes.Enabled = true;
            NumericMinVariations.Enabled = true;
            NumericMaxVariations.Enabled = true;
            TxtWordsBetweenVariations.Enabled = true;
            BtnGenerateListOfHashes.Enabled = true;
            ChkUseHashesFile.Enabled = true;
            ChkBruteforceWithRepetition.Enabled = true;
            ChkTryToBruteforce.Enabled = true;
            RdbBinHash.Enabled = true;
            RdbVltHash.Enabled = true;
            RdbUnhashBigEndian.Enabled = true;
            RdbUnhashLittleEndian.Enabled = true;
            CboForceHashListCase.Enabled = true;

            BruteForceChecked();
        }

        private void DisableComponentsDuringBruteforce()
        {
            RdbLoadFromText.Enabled = false;
            RdbLoadFile.Enabled = false;
            TxtLoadFromText.Enabled = false;
            BtnClear.Enabled = false;
            TxtPrefixes.Enabled = false;
            TxtVariations.Enabled = false;
            TxtSuffixes.Enabled = false;
            NumericMinVariations.Enabled = false;
            NumericMaxVariations.Enabled = false;
            TxtWordsBetweenVariations.Enabled = false;
            BtnGenerateListOfHashes.Enabled = false;
            ChkUseHashesFile.Enabled = false;
            ChkBruteforceWithRepetition.Enabled = false;
            ChkTryToBruteforce.Enabled = false;
            RdbBinHash.Enabled = false;
            RdbVltHash.Enabled = false;
            RdbUnhashBigEndian.Enabled = false;
            RdbUnhashLittleEndian.Enabled = false;
            CboForceHashListCase.Enabled = false;
        }
    }
}
