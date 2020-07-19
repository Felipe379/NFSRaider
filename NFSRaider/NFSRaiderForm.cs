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
        }

        private List<(uint HashValue, string StringValue)> ListBoxDataSource { get; set; } = new List<(uint HashValue, string StringValue)>();
        private string FilePath { get; set; }
        private GenerateOption GenerateOption { get; set; } = GenerateOption.WithRepetition;
        private Endianness UnhashingEndianness { get; set; } = Endianness.BigEndian;
        private Endianness ListEndianness { get; set; } = Endianness.BigEndian;
        private HashType HashType { get; set; } = HashType.BIN;
        private HashFactory HashFactory { get; set; } = HashFactory.GetHashType(HashType.BIN);

        private Thread BruteForceThread { get; set; }
        private bool BruteforceProcessStarted { get; set; } = false;

        public void UpdateFormDuringBruteforce(uint hash, string generatedString)
        {
            ListBoxDataSource.Add((hash, generatedString));
            ThreadHelperClass.SetText(this, LblTotalHashes, ListBoxDataSource.Count.ToString());
            Invoke((MethodInvoker)(() => ChangedListBoxDataSource()));
        }

        private void BtnLoadFile_Click(object sender, EventArgs e)
        {
            var fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                FilePath = fileDialog.FileName.ToString();
                LblStatus.Text = $"File loaded in {FilePath}";
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (RdbLoadFile.Checked)
            {
                var file = FormMethods.FormFile.Open(TxtFileStartOffset.Text, TxtFileEndOffset.Text, TxtFileReadHashes.Text, TxtFileSkipHashes.Text, FilePath);
                var data = FormMethods.FormFile.UnhashFromFile(UnhashingEndianness, ListEndianness, HashFactory, file);
                ListBoxDataSource = data.listBox;
                ChangedListBoxDataSource();
                LblKnownHashes.Text = data.knownHashes.ToString();
                LblUnknownHashes.Text = data.unknownHashes.ToString();
                LblTotalHashes.Text = (data.knownHashes + data.unknownHashes).ToString();
                GC.Collect();
            }
            else if (RdbLoadFromText.Checked && !BruteforceProcessStarted)
            {
                DisableComponentsDuringBruteforce();

                var bruteForce = new FormMethods.FormBruteforce(this, HashFactory, ChkUseHashesFile.Checked, ChkTryToBruteforce.Checked, TxtPrefixes.Text, TxtSufixes.Text,
                    TxtVariations.Text, TxtWordsBetweenVariations.Text, TxtMinVariations.Text, TxtMaxVariations.Text, GenerateOption, UnhashingEndianness);
                bruteForce.Unhash(TxtLoadFromText.Text);
                BruteforceProcessStarted = true;

                BruteForceThread = new Thread(() => { bruteForce.BruteForceThread(); Invoke((MethodInvoker)(() => BruteforceFinished())); })
                {
                    IsBackground = true
                };
                BruteForceThread.Start();
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
            MessageBox.Show("Raid completed!");
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            LstUnhashed.DataSource = null;
            LstUnhashed.Items.Clear();
            LblKnownHashes.Text = "0";
            LblUnknownHashes.Text = "0";
            LblTotalHashes.Text = "0";
            ListBoxDataSource = new List<(uint HashValue, string StringValue)>();
        }

        private void ChangedListBoxDataSource()
        {
            var listBoxDataSource = ListBoxDataSource;

            if (ChkIgnoreRepeatedStrings.Checked)
            {
                listBoxDataSource = listBoxDataSource
                    .GroupBy(c => c.StringValue)
                    .Select(c => c.First())
                    .ToList();
            }

            if (ChkIgnoreRepeatedHashes.Checked)
            {
                listBoxDataSource = listBoxDataSource
                    .GroupBy(c => c.HashValue)
                    .Select(c => c.First())
                    .ToList();
            }

            var format = TxtExportFormat.Text;
            var dataSource = ListEndianness == Endianness.BigEndian
                ? listBoxDataSource.Select(c => format.Replace("(HASH)", Hashes.Reverse(c.HashValue).ToString("X8")).Replace("(STRING)", c.StringValue))
                : listBoxDataSource.Select(c => format.Replace("(HASH)", c.HashValue.ToString("X8")).Replace("(STRING)", c.StringValue));

            LstUnhashed.DataSource = dataSource.ToArray();
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
            var getAllParts = new AllParts();
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

        private void TxtMinVariations_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtMinVariations.Text))
                TxtMinVariations.Text = "0";
        }

        private void TxtMaxVariations_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtMaxVariations.Text))
                TxtMaxVariations.Text = "0";
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

        private void RdbExportBigEndian_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbExportBigEndian.Checked)
                ListEndianness = Endianness.BigEndian;
        }

        private void RdbExportLittleEndian_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbExportLittleEndian.Checked)
                ListEndianness = Endianness.LittleEndian;
        }

        private void ChkBruteforceWithRepetition_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkBruteforceWithRepetition.Checked)
                GenerateOption = GenerateOption.WithRepetition;
            else
                GenerateOption = GenerateOption.WithoutRepetition;
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
            var saveFileDialog = new SaveFileDialog()
            {
                Filter = "Text Files (*.txt)|*.txt",
                DefaultExt = "txt",
                AddExtension = true
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllLines(saveFileDialog.FileName, (IList<string>)LstUnhashed.DataSource);
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
                TxtSufixes.Enabled = false;
                TxtMinVariations.Enabled = false;
                TxtMaxVariations.Enabled = false;
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
                TxtSufixes.Enabled = true;
                TxtMinVariations.Enabled = true;
                TxtMaxVariations.Enabled = true;
                TxtWordsBetweenVariations.Enabled = true;
                ChkBruteforceWithRepetition.Enabled = true;
            }
            else
            {
                TxtPrefixes.Enabled = false;
                TxtVariations.Enabled = false;
                TxtSufixes.Enabled = false;
                TxtMinVariations.Enabled = false;
                TxtMaxVariations.Enabled = false;
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
            TxtSufixes.Enabled = true;
            TxtMinVariations.Enabled = true;
            TxtMaxVariations.Enabled = true;
            TxtWordsBetweenVariations.Enabled = true;
            BtnGenerateListOfHashes.Enabled = true;
            ChkUseHashesFile.Enabled = true;
            ChkBruteforceWithRepetition.Enabled = true;
            ChkTryToBruteforce.Enabled = true;
            RdbBinHash.Enabled = true;
            RdbVltHash.Enabled = true;
            RdbUnhashBigEndian.Enabled = true;
            RdbUnhashLittleEndian.Enabled = true;

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
            TxtSufixes.Enabled = false;
            TxtMinVariations.Enabled = false;
            TxtMaxVariations.Enabled = false;
            TxtWordsBetweenVariations.Enabled = false;
            BtnGenerateListOfHashes.Enabled = false;
            ChkUseHashesFile.Enabled = false;
            ChkBruteforceWithRepetition.Enabled = false;
            ChkTryToBruteforce.Enabled = false;
            RdbBinHash.Enabled = false;
            RdbVltHash.Enabled = false;
            RdbUnhashBigEndian.Enabled = false;
            RdbUnhashLittleEndian.Enabled = false;
        }
    }
}
