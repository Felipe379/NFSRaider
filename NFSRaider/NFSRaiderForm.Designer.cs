namespace NFSRaider
{
    partial class NFSRaiderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LstUnhashed = new System.Windows.Forms.ListBox();
            this.BtnLoadFile = new System.Windows.Forms.Button();
            this.TxtLoadFromText = new System.Windows.Forms.TextBox();
            this.GrpLoadOptions = new System.Windows.Forms.GroupBox();
            this.TxtFileReadHashes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtFileSkipHashes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblEndOffset = new System.Windows.Forms.Label();
            this.LblStartOffset = new System.Windows.Forms.Label();
            this.RdbLoadFromText = new System.Windows.Forms.RadioButton();
            this.RdbLoadFile = new System.Windows.Forms.RadioButton();
            this.GrpHashType = new System.Windows.Forms.GroupBox();
            this.RdbVlt64Hash = new System.Windows.Forms.RadioButton();
            this.RdbVltHash = new System.Windows.Forms.RadioButton();
            this.RdbBinHash = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RdbUnhashLittleEndian = new System.Windows.Forms.RadioButton();
            this.RdbUnhashBigEndian = new System.Windows.Forms.RadioButton();
            this.TxtPrefixes = new System.Windows.Forms.TextBox();
            this.TxtVariations = new System.Windows.Forms.TextBox();
            this.TxtSuffixes = new System.Windows.Forms.TextBox();
            this.LblPrefixes = new System.Windows.Forms.Label();
            this.LblSuffixes = new System.Windows.Forms.Label();
            this.LblCombinationsAndPermutations = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtExportFormat = new System.Windows.Forms.TextBox();
            this.GrpExportOptions = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CboOrderBy = new System.Windows.Forms.ComboBox();
            this.ChkIgnoreRepeatedStrings = new System.Windows.Forms.CheckBox();
            this.BtnUpdateList = new System.Windows.Forms.Button();
            this.BtnExportHashes = new System.Windows.Forms.Button();
            this.ChkIgnoreRepeatedHashes = new System.Windows.Forms.CheckBox();
            this.RdbExportLittleEndian = new System.Windows.Forms.RadioButton();
            this.RdbExportBigEndian = new System.Windows.Forms.RadioButton();
            this.TxtFileStartOffset = new System.Windows.Forms.TextBox();
            this.TxtFileEndOffset = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.ChkUseHashesFile = new System.Windows.Forms.CheckBox();
            this.BtnGenerateListOfHashes = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LblTotalHashes = new System.Windows.Forms.Label();
            this.LblUnknownHashes = new System.Windows.Forms.Label();
            this.LblKnownHashes = new System.Windows.Forms.Label();
            this.LblTextKnownHashes = new System.Windows.Forms.Label();
            this.LblTextUnknownHashes = new System.Windows.Forms.Label();
            this.LblTextTotalHashes = new System.Windows.Forms.Label();
            this.GrpVariationsOptions = new System.Windows.Forms.GroupBox();
            this.TxtMinVariations = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtWordsBetweenVariations = new System.Windows.Forms.TextBox();
            this.TxtMaxVariations = new System.Windows.Forms.TextBox();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.BtnSearchPrevious = new System.Windows.Forms.Button();
            this.BtnSearchNext = new System.Windows.Forms.Button();
            this.LblStatus = new System.Windows.Forms.Label();
            this.ChkTryToBruteforce = new System.Windows.Forms.CheckBox();
            this.ChkBruteforceWithRepetition = new System.Windows.Forms.CheckBox();
            this.GrpLoadOptions.SuspendLayout();
            this.GrpHashType.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.GrpExportOptions.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.GrpVariationsOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // LstUnhashed
            // 
            this.LstUnhashed.FormattingEnabled = true;
            this.LstUnhashed.HorizontalScrollbar = true;
            this.LstUnhashed.Location = new System.Drawing.Point(12, 38);
            this.LstUnhashed.Name = "LstUnhashed";
            this.LstUnhashed.Size = new System.Drawing.Size(294, 381);
            this.LstUnhashed.TabIndex = 4;
            // 
            // BtnLoadFile
            // 
            this.BtnLoadFile.Location = new System.Drawing.Point(157, 41);
            this.BtnLoadFile.Name = "BtnLoadFile";
            this.BtnLoadFile.Size = new System.Drawing.Size(123, 23);
            this.BtnLoadFile.TabIndex = 18;
            this.BtnLoadFile.Text = "Load file";
            this.BtnLoadFile.UseVisualStyleBackColor = true;
            this.BtnLoadFile.Click += new System.EventHandler(this.BtnLoadFile_Click);
            // 
            // TxtLoadFromText
            // 
            this.TxtLoadFromText.Location = new System.Drawing.Point(6, 41);
            this.TxtLoadFromText.Multiline = true;
            this.TxtLoadFromText.Name = "TxtLoadFromText";
            this.TxtLoadFromText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtLoadFromText.Size = new System.Drawing.Size(133, 251);
            this.TxtLoadFromText.TabIndex = 17;
            // 
            // GrpLoadOptions
            // 
            this.GrpLoadOptions.Controls.Add(this.TxtFileReadHashes);
            this.GrpLoadOptions.Controls.Add(this.label6);
            this.GrpLoadOptions.Controls.Add(this.TxtFileSkipHashes);
            this.GrpLoadOptions.Controls.Add(this.label1);
            this.GrpLoadOptions.Controls.Add(this.LblEndOffset);
            this.GrpLoadOptions.Controls.Add(this.LblStartOffset);
            this.GrpLoadOptions.Controls.Add(this.BtnLoadFile);
            this.GrpLoadOptions.Controls.Add(this.RdbLoadFromText);
            this.GrpLoadOptions.Controls.Add(this.TxtLoadFromText);
            this.GrpLoadOptions.Controls.Add(this.RdbLoadFile);
            this.GrpLoadOptions.Location = new System.Drawing.Point(312, 232);
            this.GrpLoadOptions.Name = "GrpLoadOptions";
            this.GrpLoadOptions.Size = new System.Drawing.Size(286, 311);
            this.GrpLoadOptions.TabIndex = 14;
            this.GrpLoadOptions.TabStop = false;
            this.GrpLoadOptions.Text = "Load options";
            // 
            // TxtFileReadHashes
            // 
            this.TxtFileReadHashes.Location = new System.Drawing.Point(157, 174);
            this.TxtFileReadHashes.Name = "TxtFileReadHashes";
            this.TxtFileReadHashes.Size = new System.Drawing.Size(124, 20);
            this.TxtFileReadHashes.TabIndex = 24;
            this.TxtFileReadHashes.Text = "0";
            this.TxtFileReadHashes.Leave += new System.EventHandler(this.TxtFileReadHashes_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(154, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Read hashes";
            // 
            // TxtFileSkipHashes
            // 
            this.TxtFileSkipHashes.Location = new System.Drawing.Point(156, 215);
            this.TxtFileSkipHashes.Name = "TxtFileSkipHashes";
            this.TxtFileSkipHashes.Size = new System.Drawing.Size(124, 20);
            this.TxtFileSkipHashes.TabIndex = 26;
            this.TxtFileSkipHashes.Text = "0";
            this.TxtFileSkipHashes.TextChanged += new System.EventHandler(this.TxtFileSkipHashes_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Skip hashes";
            // 
            // LblEndOffset
            // 
            this.LblEndOffset.AutoSize = true;
            this.LblEndOffset.Location = new System.Drawing.Point(154, 119);
            this.LblEndOffset.Name = "LblEndOffset";
            this.LblEndOffset.Size = new System.Drawing.Size(55, 13);
            this.LblEndOffset.TabIndex = 21;
            this.LblEndOffset.Text = "End offset";
            // 
            // LblStartOffset
            // 
            this.LblStartOffset.AutoSize = true;
            this.LblStartOffset.Location = new System.Drawing.Point(154, 78);
            this.LblStartOffset.Name = "LblStartOffset";
            this.LblStartOffset.Size = new System.Drawing.Size(58, 13);
            this.LblStartOffset.TabIndex = 19;
            this.LblStartOffset.Text = "Start offset";
            // 
            // RdbLoadFromText
            // 
            this.RdbLoadFromText.AutoSize = true;
            this.RdbLoadFromText.Location = new System.Drawing.Point(6, 18);
            this.RdbLoadFromText.Name = "RdbLoadFromText";
            this.RdbLoadFromText.Size = new System.Drawing.Size(92, 17);
            this.RdbLoadFromText.TabIndex = 15;
            this.RdbLoadFromText.Text = "Load from text";
            this.RdbLoadFromText.UseVisualStyleBackColor = true;
            this.RdbLoadFromText.CheckedChanged += new System.EventHandler(this.RdbLoadFromText_CheckedChanged);
            // 
            // RdbLoadFile
            // 
            this.RdbLoadFile.AutoSize = true;
            this.RdbLoadFile.Checked = true;
            this.RdbLoadFile.Location = new System.Drawing.Point(157, 17);
            this.RdbLoadFile.Name = "RdbLoadFile";
            this.RdbLoadFile.Size = new System.Drawing.Size(88, 17);
            this.RdbLoadFile.TabIndex = 16;
            this.RdbLoadFile.TabStop = true;
            this.RdbLoadFile.Text = "Load from file";
            this.RdbLoadFile.UseVisualStyleBackColor = true;
            this.RdbLoadFile.CheckedChanged += new System.EventHandler(this.RdbLoadFile_CheckedChanged);
            // 
            // GrpHashType
            // 
            this.GrpHashType.Controls.Add(this.RdbVlt64Hash);
            this.GrpHashType.Controls.Add(this.RdbVltHash);
            this.GrpHashType.Controls.Add(this.RdbBinHash);
            this.GrpHashType.Location = new System.Drawing.Point(609, 350);
            this.GrpHashType.Name = "GrpHashType";
            this.GrpHashType.Size = new System.Drawing.Size(268, 57);
            this.GrpHashType.TabIndex = 38;
            this.GrpHashType.TabStop = false;
            this.GrpHashType.Text = "Hash type";
            // 
            // RdbVlt64Hash
            // 
            this.RdbVlt64Hash.AutoSize = true;
            this.RdbVlt64Hash.Enabled = false;
            this.RdbVlt64Hash.Location = new System.Drawing.Point(145, 22);
            this.RdbVlt64Hash.Name = "RdbVlt64Hash";
            this.RdbVlt64Hash.Size = new System.Drawing.Size(74, 17);
            this.RdbVlt64Hash.TabIndex = 41;
            this.RdbVlt64Hash.Text = "Vlt64Hash";
            this.RdbVlt64Hash.UseVisualStyleBackColor = true;
            this.RdbVlt64Hash.CheckedChanged += new System.EventHandler(this.RdbVlt64Hash_CheckedChanged);
            // 
            // RdbVltHash
            // 
            this.RdbVltHash.AutoSize = true;
            this.RdbVltHash.Location = new System.Drawing.Point(77, 22);
            this.RdbVltHash.Name = "RdbVltHash";
            this.RdbVltHash.Size = new System.Drawing.Size(62, 17);
            this.RdbVltHash.TabIndex = 40;
            this.RdbVltHash.Text = "VltHash";
            this.RdbVltHash.UseVisualStyleBackColor = true;
            this.RdbVltHash.CheckedChanged += new System.EventHandler(this.RdbVltHash_CheckedChanged);
            // 
            // RdbBinHash
            // 
            this.RdbBinHash.AutoSize = true;
            this.RdbBinHash.Checked = true;
            this.RdbBinHash.Location = new System.Drawing.Point(6, 22);
            this.RdbBinHash.Name = "RdbBinHash";
            this.RdbBinHash.Size = new System.Drawing.Size(65, 17);
            this.RdbBinHash.TabIndex = 39;
            this.RdbBinHash.TabStop = true;
            this.RdbBinHash.Text = "BinHash";
            this.RdbBinHash.UseVisualStyleBackColor = true;
            this.RdbBinHash.CheckedChanged += new System.EventHandler(this.RdbBinHash_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RdbUnhashLittleEndian);
            this.groupBox1.Controls.Add(this.RdbUnhashBigEndian);
            this.groupBox1.Location = new System.Drawing.Point(609, 413);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 57);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Endianness";
            // 
            // RdbUnhashLittleEndian
            // 
            this.RdbUnhashLittleEndian.AutoSize = true;
            this.RdbUnhashLittleEndian.Location = new System.Drawing.Point(137, 22);
            this.RdbUnhashLittleEndian.Name = "RdbUnhashLittleEndian";
            this.RdbUnhashLittleEndian.Size = new System.Drawing.Size(127, 17);
            this.RdbUnhashLittleEndian.TabIndex = 44;
            this.RdbUnhashLittleEndian.Text = "Little-endian (memory)";
            this.RdbUnhashLittleEndian.UseVisualStyleBackColor = true;
            this.RdbUnhashLittleEndian.CheckedChanged += new System.EventHandler(this.RdbUnhashLittleEndian_CheckedChanged);
            // 
            // RdbUnhashBigEndian
            // 
            this.RdbUnhashBigEndian.AutoSize = true;
            this.RdbUnhashBigEndian.Checked = true;
            this.RdbUnhashBigEndian.Location = new System.Drawing.Point(6, 22);
            this.RdbUnhashBigEndian.Name = "RdbUnhashBigEndian";
            this.RdbUnhashBigEndian.Size = new System.Drawing.Size(97, 17);
            this.RdbUnhashBigEndian.TabIndex = 43;
            this.RdbUnhashBigEndian.TabStop = true;
            this.RdbUnhashBigEndian.Text = "Big-endian (file)";
            this.RdbUnhashBigEndian.UseVisualStyleBackColor = true;
            this.RdbUnhashBigEndian.CheckedChanged += new System.EventHandler(this.RdbUnhashBigEndian_CheckedChanged);
            // 
            // TxtPrefixes
            // 
            this.TxtPrefixes.Location = new System.Drawing.Point(410, 36);
            this.TxtPrefixes.Multiline = true;
            this.TxtPrefixes.Name = "TxtPrefixes";
            this.TxtPrefixes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtPrefixes.Size = new System.Drawing.Size(150, 190);
            this.TxtPrefixes.TabIndex = 9;
            // 
            // TxtVariations
            // 
            this.TxtVariations.Location = new System.Drawing.Point(566, 36);
            this.TxtVariations.Multiline = true;
            this.TxtVariations.Name = "TxtVariations";
            this.TxtVariations.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtVariations.Size = new System.Drawing.Size(150, 190);
            this.TxtVariations.TabIndex = 11;
            this.TxtVariations.Text = "A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z,a,b,c,d,e,f,g,h,i,j,k,l,m,n,o" +
    ",p,q,r,s,t,u,v,w,x,y,z,0,1,2,3,4,5,6,7,8,9,_";
            // 
            // TxtSuffixes
            // 
            this.TxtSuffixes.Location = new System.Drawing.Point(722, 36);
            this.TxtSuffixes.Multiline = true;
            this.TxtSuffixes.Name = "TxtSuffixes";
            this.TxtSuffixes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtSuffixes.Size = new System.Drawing.Size(150, 190);
            this.TxtSuffixes.TabIndex = 13;
            // 
            // LblPrefixes
            // 
            this.LblPrefixes.AutoSize = true;
            this.LblPrefixes.Location = new System.Drawing.Point(407, 20);
            this.LblPrefixes.Name = "LblPrefixes";
            this.LblPrefixes.Size = new System.Drawing.Size(44, 13);
            this.LblPrefixes.TabIndex = 8;
            this.LblPrefixes.Text = "Prefixes";
            // 
            // LblSuffixes
            // 
            this.LblSuffixes.AutoSize = true;
            this.LblSuffixes.Location = new System.Drawing.Point(719, 20);
            this.LblSuffixes.Name = "LblSuffixes";
            this.LblSuffixes.Size = new System.Drawing.Size(44, 13);
            this.LblSuffixes.TabIndex = 12;
            this.LblSuffixes.Text = "Suffixes";
            // 
            // LblCombinationsAndPermutations
            // 
            this.LblCombinationsAndPermutations.AutoSize = true;
            this.LblCombinationsAndPermutations.Location = new System.Drawing.Point(563, 20);
            this.LblCombinationsAndPermutations.Name = "LblCombinationsAndPermutations";
            this.LblCombinationsAndPermutations.Size = new System.Drawing.Size(53, 13);
            this.LblCombinationsAndPermutations.TabIndex = 10;
            this.LblCombinationsAndPermutations.Text = "Variations";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 60;
            this.label4.Text = "Export format";
            // 
            // TxtExportFormat
            // 
            this.TxtExportFormat.Location = new System.Drawing.Point(81, 92);
            this.TxtExportFormat.Name = "TxtExportFormat";
            this.TxtExportFormat.Size = new System.Drawing.Size(126, 20);
            this.TxtExportFormat.TabIndex = 61;
            this.TxtExportFormat.Text = "(HASH) - (STRING)";
            // 
            // GrpExportOptions
            // 
            this.GrpExportOptions.Controls.Add(this.label7);
            this.GrpExportOptions.Controls.Add(this.CboOrderBy);
            this.GrpExportOptions.Controls.Add(this.ChkIgnoreRepeatedStrings);
            this.GrpExportOptions.Controls.Add(this.BtnUpdateList);
            this.GrpExportOptions.Controls.Add(this.BtnExportHashes);
            this.GrpExportOptions.Controls.Add(this.ChkIgnoreRepeatedHashes);
            this.GrpExportOptions.Controls.Add(this.RdbExportLittleEndian);
            this.GrpExportOptions.Controls.Add(this.TxtExportFormat);
            this.GrpExportOptions.Controls.Add(this.RdbExportBigEndian);
            this.GrpExportOptions.Controls.Add(this.label4);
            this.GrpExportOptions.Location = new System.Drawing.Point(12, 425);
            this.GrpExportOptions.Name = "GrpExportOptions";
            this.GrpExportOptions.Size = new System.Drawing.Size(294, 118);
            this.GrpExportOptions.TabIndex = 52;
            this.GrpExportOptions.TabStop = false;
            this.GrpExportOptions.Text = "Export options";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 53;
            this.label7.Text = "Order by";
            // 
            // CboOrderBy
            // 
            this.CboOrderBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboOrderBy.FormattingEnabled = true;
            this.CboOrderBy.Items.AddRange(new object[] {
            "None",
            "Hash",
            "String"});
            this.CboOrderBy.Location = new System.Drawing.Point(59, 19);
            this.CboOrderBy.Name = "CboOrderBy";
            this.CboOrderBy.Size = new System.Drawing.Size(228, 21);
            this.CboOrderBy.TabIndex = 54;
            // 
            // ChkIgnoreRepeatedStrings
            // 
            this.ChkIgnoreRepeatedStrings.AutoSize = true;
            this.ChkIgnoreRepeatedStrings.Location = new System.Drawing.Point(153, 44);
            this.ChkIgnoreRepeatedStrings.Name = "ChkIgnoreRepeatedStrings";
            this.ChkIgnoreRepeatedStrings.Size = new System.Drawing.Size(134, 17);
            this.ChkIgnoreRepeatedStrings.TabIndex = 56;
            this.ChkIgnoreRepeatedStrings.Text = "Ignore repeated strings";
            this.ChkIgnoreRepeatedStrings.UseVisualStyleBackColor = true;
            // 
            // BtnUpdateList
            // 
            this.BtnUpdateList.Location = new System.Drawing.Point(213, 90);
            this.BtnUpdateList.Name = "BtnUpdateList";
            this.BtnUpdateList.Size = new System.Drawing.Size(75, 23);
            this.BtnUpdateList.TabIndex = 62;
            this.BtnUpdateList.Text = "Update list";
            this.BtnUpdateList.UseVisualStyleBackColor = true;
            this.BtnUpdateList.Click += new System.EventHandler(this.BtnUpdateList_Click);
            // 
            // BtnExportHashes
            // 
            this.BtnExportHashes.Location = new System.Drawing.Point(171, 67);
            this.BtnExportHashes.Name = "BtnExportHashes";
            this.BtnExportHashes.Size = new System.Drawing.Size(117, 20);
            this.BtnExportHashes.TabIndex = 59;
            this.BtnExportHashes.Text = "Export hashes";
            this.BtnExportHashes.UseVisualStyleBackColor = true;
            this.BtnExportHashes.Click += new System.EventHandler(this.BtnExportHashes_Click);
            // 
            // ChkIgnoreRepeatedHashes
            // 
            this.ChkIgnoreRepeatedHashes.AutoSize = true;
            this.ChkIgnoreRepeatedHashes.Location = new System.Drawing.Point(6, 46);
            this.ChkIgnoreRepeatedHashes.Name = "ChkIgnoreRepeatedHashes";
            this.ChkIgnoreRepeatedHashes.Size = new System.Drawing.Size(138, 17);
            this.ChkIgnoreRepeatedHashes.TabIndex = 55;
            this.ChkIgnoreRepeatedHashes.Text = "Ignore repeated hashes";
            this.ChkIgnoreRepeatedHashes.UseVisualStyleBackColor = true;
            // 
            // RdbExportLittleEndian
            // 
            this.RdbExportLittleEndian.AutoSize = true;
            this.RdbExportLittleEndian.Location = new System.Drawing.Point(83, 67);
            this.RdbExportLittleEndian.Name = "RdbExportLittleEndian";
            this.RdbExportLittleEndian.Size = new System.Drawing.Size(82, 17);
            this.RdbExportLittleEndian.TabIndex = 58;
            this.RdbExportLittleEndian.Text = "Little-endian";
            this.RdbExportLittleEndian.UseVisualStyleBackColor = true;
            this.RdbExportLittleEndian.CheckedChanged += new System.EventHandler(this.RdbExportLittleEndian_CheckedChanged);
            // 
            // RdbExportBigEndian
            // 
            this.RdbExportBigEndian.AutoSize = true;
            this.RdbExportBigEndian.Checked = true;
            this.RdbExportBigEndian.Location = new System.Drawing.Point(6, 69);
            this.RdbExportBigEndian.Name = "RdbExportBigEndian";
            this.RdbExportBigEndian.Size = new System.Drawing.Size(75, 17);
            this.RdbExportBigEndian.TabIndex = 57;
            this.RdbExportBigEndian.TabStop = true;
            this.RdbExportBigEndian.Text = "Big-endian";
            this.RdbExportBigEndian.UseVisualStyleBackColor = true;
            this.RdbExportBigEndian.CheckedChanged += new System.EventHandler(this.RdbExportBigEndian_CheckedChanged);
            // 
            // TxtFileStartOffset
            // 
            this.TxtFileStartOffset.Location = new System.Drawing.Point(468, 329);
            this.TxtFileStartOffset.Name = "TxtFileStartOffset";
            this.TxtFileStartOffset.Size = new System.Drawing.Size(124, 20);
            this.TxtFileStartOffset.TabIndex = 20;
            this.TxtFileStartOffset.Text = "0";
            this.TxtFileStartOffset.Leave += new System.EventHandler(this.TxtFileStartOffset_Leave);
            // 
            // TxtFileEndOffset
            // 
            this.TxtFileEndOffset.Location = new System.Drawing.Point(468, 370);
            this.TxtFileEndOffset.Name = "TxtFileEndOffset";
            this.TxtFileEndOffset.Size = new System.Drawing.Size(124, 20);
            this.TxtFileEndOffset.TabIndex = 22;
            this.TxtFileEndOffset.Text = "0";
            this.TxtFileEndOffset.Leave += new System.EventHandler(this.TxtFileEndOffset_Leave);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(312, 36);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(92, 23);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.Location = new System.Drawing.Point(312, 65);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(92, 23);
            this.BtnStop.TabIndex = 6;
            this.BtnStop.Text = "Stop";
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(312, 94);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(92, 23);
            this.BtnClear.TabIndex = 7;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // ChkUseHashesFile
            // 
            this.ChkUseHashesFile.AutoSize = true;
            this.ChkUseHashesFile.Location = new System.Drawing.Point(738, 299);
            this.ChkUseHashesFile.Name = "ChkUseHashesFile";
            this.ChkUseHashesFile.Size = new System.Drawing.Size(112, 17);
            this.ChkUseHashesFile.TabIndex = 35;
            this.ChkUseHashesFile.Text = "Use hashes.txt file";
            this.ChkUseHashesFile.UseVisualStyleBackColor = true;
            // 
            // BtnGenerateListOfHashes
            // 
            this.BtnGenerateListOfHashes.Location = new System.Drawing.Point(609, 295);
            this.BtnGenerateListOfHashes.Name = "BtnGenerateListOfHashes";
            this.BtnGenerateListOfHashes.Size = new System.Drawing.Size(123, 23);
            this.BtnGenerateListOfHashes.TabIndex = 34;
            this.BtnGenerateListOfHashes.Text = "Generate list of hashes";
            this.BtnGenerateListOfHashes.UseVisualStyleBackColor = true;
            this.BtnGenerateListOfHashes.Click += new System.EventHandler(this.BtnGenerateListOfHashes_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LblTotalHashes);
            this.groupBox2.Controls.Add(this.LblUnknownHashes);
            this.groupBox2.Controls.Add(this.LblKnownHashes);
            this.groupBox2.Controls.Add(this.LblTextKnownHashes);
            this.groupBox2.Controls.Add(this.LblTextUnknownHashes);
            this.groupBox2.Controls.Add(this.LblTextTotalHashes);
            this.groupBox2.Location = new System.Drawing.Point(609, 475);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 68);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stats";
            // 
            // LblTotalHashes
            // 
            this.LblTotalHashes.AutoSize = true;
            this.LblTotalHashes.Location = new System.Drawing.Point(106, 50);
            this.LblTotalHashes.Name = "LblTotalHashes";
            this.LblTotalHashes.Size = new System.Drawing.Size(13, 13);
            this.LblTotalHashes.TabIndex = 51;
            this.LblTotalHashes.Text = "0";
            // 
            // LblUnknownHashes
            // 
            this.LblUnknownHashes.AutoSize = true;
            this.LblUnknownHashes.Location = new System.Drawing.Point(106, 32);
            this.LblUnknownHashes.Name = "LblUnknownHashes";
            this.LblUnknownHashes.Size = new System.Drawing.Size(13, 13);
            this.LblUnknownHashes.TabIndex = 49;
            this.LblUnknownHashes.Text = "0";
            // 
            // LblKnownHashes
            // 
            this.LblKnownHashes.AutoSize = true;
            this.LblKnownHashes.Location = new System.Drawing.Point(106, 14);
            this.LblKnownHashes.Name = "LblKnownHashes";
            this.LblKnownHashes.Size = new System.Drawing.Size(13, 13);
            this.LblKnownHashes.TabIndex = 47;
            this.LblKnownHashes.Text = "0";
            // 
            // LblTextKnownHashes
            // 
            this.LblTextKnownHashes.AutoSize = true;
            this.LblTextKnownHashes.Location = new System.Drawing.Point(3, 14);
            this.LblTextKnownHashes.Name = "LblTextKnownHashes";
            this.LblTextKnownHashes.Size = new System.Drawing.Size(80, 13);
            this.LblTextKnownHashes.TabIndex = 46;
            this.LblTextKnownHashes.Text = "Known hashes:";
            // 
            // LblTextUnknownHashes
            // 
            this.LblTextUnknownHashes.AutoSize = true;
            this.LblTextUnknownHashes.Location = new System.Drawing.Point(3, 32);
            this.LblTextUnknownHashes.Name = "LblTextUnknownHashes";
            this.LblTextUnknownHashes.Size = new System.Drawing.Size(93, 13);
            this.LblTextUnknownHashes.TabIndex = 48;
            this.LblTextUnknownHashes.Text = "Unknown hashes:";
            // 
            // LblTextTotalHashes
            // 
            this.LblTextTotalHashes.AutoSize = true;
            this.LblTextTotalHashes.Location = new System.Drawing.Point(3, 50);
            this.LblTextTotalHashes.Name = "LblTextTotalHashes";
            this.LblTextTotalHashes.Size = new System.Drawing.Size(83, 13);
            this.LblTextTotalHashes.TabIndex = 50;
            this.LblTextTotalHashes.Text = "Total of hashes:";
            // 
            // GrpVariationsOptions
            // 
            this.GrpVariationsOptions.Controls.Add(this.TxtMinVariations);
            this.GrpVariationsOptions.Controls.Add(this.label5);
            this.GrpVariationsOptions.Controls.Add(this.label3);
            this.GrpVariationsOptions.Controls.Add(this.label2);
            this.GrpVariationsOptions.Controls.Add(this.TxtWordsBetweenVariations);
            this.GrpVariationsOptions.Controls.Add(this.TxtMaxVariations);
            this.GrpVariationsOptions.Location = new System.Drawing.Point(604, 232);
            this.GrpVariationsOptions.Name = "GrpVariationsOptions";
            this.GrpVariationsOptions.Size = new System.Drawing.Size(268, 57);
            this.GrpVariationsOptions.TabIndex = 27;
            this.GrpVariationsOptions.TabStop = false;
            this.GrpVariationsOptions.Text = "Variations options";
            // 
            // TxtMinVariations
            // 
            this.TxtMinVariations.Location = new System.Drawing.Point(6, 32);
            this.TxtMinVariations.Name = "TxtMinVariations";
            this.TxtMinVariations.Size = new System.Drawing.Size(52, 20);
            this.TxtMinVariations.TabIndex = 29;
            this.TxtMinVariations.Text = "1";
            this.TxtMinVariations.Leave += new System.EventHandler(this.TxtMinVariations_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(119, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Words between variations";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Max";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Min";
            // 
            // TxtWordsBetweenVariations
            // 
            this.TxtWordsBetweenVariations.Location = new System.Drawing.Point(122, 31);
            this.TxtWordsBetweenVariations.Name = "TxtWordsBetweenVariations";
            this.TxtWordsBetweenVariations.Size = new System.Drawing.Size(140, 20);
            this.TxtWordsBetweenVariations.TabIndex = 33;
            // 
            // TxtMaxVariations
            // 
            this.TxtMaxVariations.Location = new System.Drawing.Point(64, 31);
            this.TxtMaxVariations.Name = "TxtMaxVariations";
            this.TxtMaxVariations.Size = new System.Drawing.Size(52, 20);
            this.TxtMaxVariations.TabIndex = 31;
            this.TxtMaxVariations.Text = "6";
            this.TxtMaxVariations.Leave += new System.EventHandler(this.TxtMaxVariations_Leave);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(12, 12);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(162, 20);
            this.TxtSearch.TabIndex = 1;
            // 
            // BtnSearchPrevious
            // 
            this.BtnSearchPrevious.Location = new System.Drawing.Point(180, 12);
            this.BtnSearchPrevious.Name = "BtnSearchPrevious";
            this.BtnSearchPrevious.Size = new System.Drawing.Size(60, 20);
            this.BtnSearchPrevious.TabIndex = 2;
            this.BtnSearchPrevious.Text = "Previous";
            this.BtnSearchPrevious.UseVisualStyleBackColor = true;
            this.BtnSearchPrevious.Click += new System.EventHandler(this.BtnSearchPrevious_Click);
            // 
            // BtnSearchNext
            // 
            this.BtnSearchNext.Location = new System.Drawing.Point(246, 13);
            this.BtnSearchNext.Name = "BtnSearchNext";
            this.BtnSearchNext.Size = new System.Drawing.Size(60, 20);
            this.BtnSearchNext.TabIndex = 3;
            this.BtnSearchNext.Text = "Next";
            this.BtnSearchNext.UseVisualStyleBackColor = true;
            this.BtnSearchNext.Click += new System.EventHandler(this.BtnSearchNext_Click);
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Location = new System.Drawing.Point(9, 546);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(75, 13);
            this.LblStatus.TabIndex = 63;
            this.LblStatus.Text = "No file loaded.";
            // 
            // ChkTryToBruteforce
            // 
            this.ChkTryToBruteforce.AutoSize = true;
            this.ChkTryToBruteforce.Location = new System.Drawing.Point(612, 324);
            this.ChkTryToBruteforce.Name = "ChkTryToBruteforce";
            this.ChkTryToBruteforce.Size = new System.Drawing.Size(104, 17);
            this.ChkTryToBruteforce.TabIndex = 26;
            this.ChkTryToBruteforce.Text = "Try to bruteforce";
            this.ChkTryToBruteforce.UseVisualStyleBackColor = true;
            this.ChkTryToBruteforce.CheckedChanged += new System.EventHandler(this.ChkTryToBruteforce_CheckedChanged);
            // 
            // ChkBruteforceWithRepetition
            // 
            this.ChkBruteforceWithRepetition.AutoSize = true;
            this.ChkBruteforceWithRepetition.Location = new System.Drawing.Point(738, 324);
            this.ChkBruteforceWithRepetition.Name = "ChkBruteforceWithRepetition";
            this.ChkBruteforceWithRepetition.Size = new System.Drawing.Size(140, 17);
            this.ChkBruteforceWithRepetition.TabIndex = 37;
            this.ChkBruteforceWithRepetition.Text = "Variations with repetition";
            this.ChkBruteforceWithRepetition.UseVisualStyleBackColor = true;
            this.ChkBruteforceWithRepetition.CheckedChanged += new System.EventHandler(this.ChkBruteforceWithRepetition_CheckedChanged);
            // 
            // NFSRaiderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.ChkBruteforceWithRepetition);
            this.Controls.Add(this.ChkTryToBruteforce);
            this.Controls.Add(this.LblStatus);
            this.Controls.Add(this.BtnSearchNext);
            this.Controls.Add(this.BtnSearchPrevious);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.GrpVariationsOptions);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BtnGenerateListOfHashes);
            this.Controls.Add(this.ChkUseHashesFile);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.TxtFileEndOffset);
            this.Controls.Add(this.TxtFileStartOffset);
            this.Controls.Add(this.GrpExportOptions);
            this.Controls.Add(this.LblCombinationsAndPermutations);
            this.Controls.Add(this.LblSuffixes);
            this.Controls.Add(this.LblPrefixes);
            this.Controls.Add(this.TxtSuffixes);
            this.Controls.Add(this.TxtVariations);
            this.Controls.Add(this.TxtPrefixes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GrpHashType);
            this.Controls.Add(this.LstUnhashed);
            this.Controls.Add(this.GrpLoadOptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "NFSRaiderForm";
            this.Text = "NFS-Raider";
            this.GrpLoadOptions.ResumeLayout(false);
            this.GrpLoadOptions.PerformLayout();
            this.GrpHashType.ResumeLayout(false);
            this.GrpHashType.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GrpExportOptions.ResumeLayout(false);
            this.GrpExportOptions.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.GrpVariationsOptions.ResumeLayout(false);
            this.GrpVariationsOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstUnhashed;
        private System.Windows.Forms.Button BtnLoadFile;
        private System.Windows.Forms.TextBox TxtLoadFromText;
        private System.Windows.Forms.GroupBox GrpLoadOptions;
        private System.Windows.Forms.Label LblEndOffset;
        private System.Windows.Forms.Label LblStartOffset;
        private System.Windows.Forms.RadioButton RdbLoadFromText;
        private System.Windows.Forms.RadioButton RdbLoadFile;
        private System.Windows.Forms.GroupBox GrpHashType;
        private System.Windows.Forms.RadioButton RdbVlt64Hash;
        private System.Windows.Forms.RadioButton RdbVltHash;
        private System.Windows.Forms.RadioButton RdbBinHash;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RdbUnhashLittleEndian;
        private System.Windows.Forms.RadioButton RdbUnhashBigEndian;
        private System.Windows.Forms.TextBox TxtPrefixes;
        private System.Windows.Forms.TextBox TxtVariations;
        private System.Windows.Forms.TextBox TxtSuffixes;
        private System.Windows.Forms.Label LblPrefixes;
        private System.Windows.Forms.Label LblSuffixes;
        private System.Windows.Forms.Label LblCombinationsAndPermutations;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtExportFormat;
        private System.Windows.Forms.GroupBox GrpExportOptions;
        private System.Windows.Forms.Button BtnExportHashes;
        private System.Windows.Forms.RadioButton RdbExportLittleEndian;
        private System.Windows.Forms.RadioButton RdbExportBigEndian;
        private System.Windows.Forms.TextBox TxtFileStartOffset;
        private System.Windows.Forms.TextBox TxtFileEndOffset;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.CheckBox ChkUseHashesFile;
        private System.Windows.Forms.Button BtnGenerateListOfHashes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LblTotalHashes;
        private System.Windows.Forms.Label LblUnknownHashes;
        private System.Windows.Forms.Label LblKnownHashes;
        private System.Windows.Forms.Label LblTextKnownHashes;
        private System.Windows.Forms.Label LblTextUnknownHashes;
        private System.Windows.Forms.Label LblTextTotalHashes;
        private System.Windows.Forms.TextBox TxtFileSkipHashes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GrpVariationsOptions;
        private System.Windows.Forms.TextBox TxtMinVariations;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtWordsBetweenVariations;
        private System.Windows.Forms.TextBox TxtMaxVariations;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Button BtnSearchPrevious;
        private System.Windows.Forms.Button BtnSearchNext;
        private System.Windows.Forms.TextBox TxtFileReadHashes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnUpdateList;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.CheckBox ChkTryToBruteforce;
        private System.Windows.Forms.CheckBox ChkBruteforceWithRepetition;
        private System.Windows.Forms.CheckBox ChkIgnoreRepeatedStrings;
        private System.Windows.Forms.CheckBox ChkIgnoreRepeatedHashes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CboOrderBy;
    }
}

