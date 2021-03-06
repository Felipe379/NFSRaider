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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NFSRaiderForm));
            this.LstUnhashed = new System.Windows.Forms.ListBox();
            this.BtnLoadFile = new System.Windows.Forms.Button();
            this.TxtLoadFromText = new System.Windows.Forms.TextBox();
            this.GrpLoadOptions = new System.Windows.Forms.GroupBox();
            this.TxtFileReadHashes = new System.Windows.Forms.TextBox();
            this.LblReadHashes = new System.Windows.Forms.Label();
            this.TxtFileSkipHashes = new System.Windows.Forms.TextBox();
            this.LblSkipHashes = new System.Windows.Forms.Label();
            this.LblEndOffset = new System.Windows.Forms.Label();
            this.LblStartOffset = new System.Windows.Forms.Label();
            this.RdbLoadFromText = new System.Windows.Forms.RadioButton();
            this.RdbLoadFile = new System.Windows.Forms.RadioButton();
            this.GrpHashingOptions = new System.Windows.Forms.GroupBox();
            this.CboHashTypes = new System.Windows.Forms.ComboBox();
            this.CboEndianness = new System.Windows.Forms.ComboBox();
            this.TxtPrefixes = new System.Windows.Forms.TextBox();
            this.TxtVariations = new System.Windows.Forms.TextBox();
            this.TxtSuffixes = new System.Windows.Forms.TextBox();
            this.LblPrefixes = new System.Windows.Forms.Label();
            this.LblSuffixes = new System.Windows.Forms.Label();
            this.LblVariations = new System.Windows.Forms.Label();
            this.LblExportOptionsExportFormat = new System.Windows.Forms.Label();
            this.TxtExportFormat = new System.Windows.Forms.TextBox();
            this.GrpExportOptions = new System.Windows.Forms.GroupBox();
            this.ChkReverseHashes = new System.Windows.Forms.CheckBox();
            this.LblExportOptionsOrderBy = new System.Windows.Forms.Label();
            this.CboOrderBy = new System.Windows.Forms.ComboBox();
            this.ChkIgnoreRepeatedStrings = new System.Windows.Forms.CheckBox();
            this.BtnUpdateList = new System.Windows.Forms.Button();
            this.BtnExportHashes = new System.Windows.Forms.Button();
            this.ChkIgnoreRepeatedHashes = new System.Windows.Forms.CheckBox();
            this.TxtFileStartOffset = new System.Windows.Forms.TextBox();
            this.TxtFileEndOffset = new System.Windows.Forms.TextBox();
            this.BtnStart = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.ChkUseHashesFile = new System.Windows.Forms.CheckBox();
            this.BtnGenerateListOfHashes = new System.Windows.Forms.Button();
            this.GrpStats = new System.Windows.Forms.GroupBox();
            this.LblTotalHashes = new System.Windows.Forms.Label();
            this.LblUnknownHashes = new System.Windows.Forms.Label();
            this.LblKnownHashes = new System.Windows.Forms.Label();
            this.LblTextKnownHashes = new System.Windows.Forms.Label();
            this.LblTextUnknownHashes = new System.Windows.Forms.Label();
            this.LblTextTotalHashes = new System.Windows.Forms.Label();
            this.GrpBruteforceOptions = new System.Windows.Forms.GroupBox();
            this.NumericProcessorsCount = new System.Windows.Forms.NumericUpDown();
            this.LblBruteforceOptionsProcessors = new System.Windows.Forms.Label();
            this.NumericMaxVariations = new System.Windows.Forms.NumericUpDown();
            this.NumericMinVariations = new System.Windows.Forms.NumericUpDown();
            this.ChkBruteforceWithRepetition = new System.Windows.Forms.CheckBox();
            this.ChkTryToBruteforce = new System.Windows.Forms.CheckBox();
            this.LblWordsBetweenVariations = new System.Windows.Forms.Label();
            this.LblBruteforceOptionsMax = new System.Windows.Forms.Label();
            this.LblBruteforceOptionsMin = new System.Windows.Forms.Label();
            this.TxtWordsBetweenVariations = new System.Windows.Forms.TextBox();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.BtnSearchPrevious = new System.Windows.Forms.Button();
            this.BtnSearchNext = new System.Windows.Forms.Button();
            this.LblStatus = new System.Windows.Forms.Label();
            this.CboForceHashListCase = new System.Windows.Forms.ComboBox();
            this.LblTimeElapsed = new System.Windows.Forms.Label();
            this.ToolTipNFSRaider = new System.Windows.Forms.ToolTip(this.components);
            this.BtnSearchAll = new System.Windows.Forms.Button();
            this.GrpLoadOptions.SuspendLayout();
            this.GrpHashingOptions.SuspendLayout();
            this.GrpExportOptions.SuspendLayout();
            this.GrpStats.SuspendLayout();
            this.GrpBruteforceOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericProcessorsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericMaxVariations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericMinVariations)).BeginInit();
            this.SuspendLayout();
            // 
            // LstUnhashed
            // 
            this.LstUnhashed.FormattingEnabled = true;
            this.LstUnhashed.HorizontalScrollbar = true;
            this.LstUnhashed.Location = new System.Drawing.Point(12, 64);
            this.LstUnhashed.Name = "LstUnhashed";
            this.LstUnhashed.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.LstUnhashed.Size = new System.Drawing.Size(294, 355);
            this.LstUnhashed.TabIndex = 4;
            this.LstUnhashed.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LstUnhashed_KeyDown);
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
            this.TxtLoadFromText.MaxLength = 65535;
            this.TxtLoadFromText.Multiline = true;
            this.TxtLoadFromText.Name = "TxtLoadFromText";
            this.TxtLoadFromText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtLoadFromText.Size = new System.Drawing.Size(133, 251);
            this.TxtLoadFromText.TabIndex = 17;
            // 
            // GrpLoadOptions
            // 
            this.GrpLoadOptions.Controls.Add(this.TxtFileReadHashes);
            this.GrpLoadOptions.Controls.Add(this.LblReadHashes);
            this.GrpLoadOptions.Controls.Add(this.TxtFileSkipHashes);
            this.GrpLoadOptions.Controls.Add(this.LblSkipHashes);
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
            // LblReadHashes
            // 
            this.LblReadHashes.AutoSize = true;
            this.LblReadHashes.Location = new System.Drawing.Point(154, 158);
            this.LblReadHashes.Name = "LblReadHashes";
            this.LblReadHashes.Size = new System.Drawing.Size(70, 13);
            this.LblReadHashes.TabIndex = 23;
            this.LblReadHashes.Text = "Read hashes";
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
            // LblSkipHashes
            // 
            this.LblSkipHashes.AutoSize = true;
            this.LblSkipHashes.Location = new System.Drawing.Point(154, 199);
            this.LblSkipHashes.Name = "LblSkipHashes";
            this.LblSkipHashes.Size = new System.Drawing.Size(65, 13);
            this.LblSkipHashes.TabIndex = 25;
            this.LblSkipHashes.Text = "Skip hashes";
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
            this.ToolTipNFSRaider.SetToolTip(this.RdbLoadFromText, "Load the set of hashes from the textbox.\r\nHashes must be separated by a new line." +
        "");
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
            this.ToolTipNFSRaider.SetToolTip(this.RdbLoadFile, "Load the set of hashes from binary files.");
            this.RdbLoadFile.UseVisualStyleBackColor = true;
            this.RdbLoadFile.CheckedChanged += new System.EventHandler(this.RdbLoadFile_CheckedChanged);
            // 
            // GrpHashingOptions
            // 
            this.GrpHashingOptions.Controls.Add(this.CboHashTypes);
            this.GrpHashingOptions.Controls.Add(this.CboEndianness);
            this.GrpHashingOptions.Location = new System.Drawing.Point(609, 406);
            this.GrpHashingOptions.Name = "GrpHashingOptions";
            this.GrpHashingOptions.Size = new System.Drawing.Size(263, 54);
            this.GrpHashingOptions.TabIndex = 42;
            this.GrpHashingOptions.TabStop = false;
            this.GrpHashingOptions.Text = "Hashing options";
            // 
            // CboHashTypes
            // 
            this.CboHashTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboHashTypes.FormattingEnabled = true;
            this.CboHashTypes.Items.AddRange(new object[] {
            "BinHash",
            "VltHash",
            "VltBinHash",
            "VltVltHash"});
            this.CboHashTypes.Location = new System.Drawing.Point(160, 19);
            this.CboHashTypes.Name = "CboHashTypes";
            this.CboHashTypes.Size = new System.Drawing.Size(97, 21);
            this.CboHashTypes.TabIndex = 65;
            this.CboHashTypes.SelectedIndexChanged += new System.EventHandler(this.CboHashTypes_SelectedIndexChanged);
            // 
            // CboEndianness
            // 
            this.CboEndianness.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboEndianness.FormattingEnabled = true;
            this.CboEndianness.Items.AddRange(new object[] {
            "Big-endian (file)",
            "Little-endian (memory)"});
            this.CboEndianness.Location = new System.Drawing.Point(7, 19);
            this.CboEndianness.Name = "CboEndianness";
            this.CboEndianness.Size = new System.Drawing.Size(147, 21);
            this.CboEndianness.TabIndex = 64;
            this.CboEndianness.SelectedIndexChanged += new System.EventHandler(this.CboEndianness_SelectedIndexChanged);
            // 
            // TxtPrefixes
            // 
            this.TxtPrefixes.AccessibleDescription = "";
            this.TxtPrefixes.AccessibleName = "";
            this.TxtPrefixes.Location = new System.Drawing.Point(410, 36);
            this.TxtPrefixes.MaxLength = 65535;
            this.TxtPrefixes.Multiline = true;
            this.TxtPrefixes.Name = "TxtPrefixes";
            this.TxtPrefixes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtPrefixes.Size = new System.Drawing.Size(150, 190);
            this.TxtPrefixes.TabIndex = 9;
            // 
            // TxtVariations
            // 
            this.TxtVariations.Location = new System.Drawing.Point(566, 36);
            this.TxtVariations.MaxLength = 65535;
            this.TxtVariations.Multiline = true;
            this.TxtVariations.Name = "TxtVariations";
            this.TxtVariations.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtVariations.Size = new System.Drawing.Size(150, 190);
            this.TxtVariations.TabIndex = 11;
            this.TxtVariations.Text = "A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z,a,b,c,d,e,f,g,h,i,j,k,l,m,n,o" +
    ",p,q,r,s,t,u,v,w,x,y,z,0,1,2,3,4,5,6,7,8,9,_, ,!,\",#,$,%,&,\',(,),*,+,-,.,/,:,;,<" +
    ",=,>,?,@,[,\\\\,],^,`,{,|,},~,\\,";
            // 
            // TxtSuffixes
            // 
            this.TxtSuffixes.Location = new System.Drawing.Point(722, 36);
            this.TxtSuffixes.MaxLength = 65535;
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
            this.ToolTipNFSRaider.SetToolTip(this.LblPrefixes, "Use comma (,) to separate each prefix.\r\nIf you want to use comma (,) you must esc" +
        "ape it (\\,). Same goes for backslash (\\), you must escape it (\\\\).");
            // 
            // LblSuffixes
            // 
            this.LblSuffixes.AutoSize = true;
            this.LblSuffixes.Location = new System.Drawing.Point(719, 20);
            this.LblSuffixes.Name = "LblSuffixes";
            this.LblSuffixes.Size = new System.Drawing.Size(44, 13);
            this.LblSuffixes.TabIndex = 12;
            this.LblSuffixes.Text = "Suffixes";
            this.ToolTipNFSRaider.SetToolTip(this.LblSuffixes, "Use comma (,) to separate each suffix.\r\nIf you want to use comma (,) you must esc" +
        "ape it (\\,). Same goes for backslash (\\), you must escape it (\\\\).");
            // 
            // LblVariations
            // 
            this.LblVariations.AutoSize = true;
            this.LblVariations.Location = new System.Drawing.Point(563, 20);
            this.LblVariations.Name = "LblVariations";
            this.LblVariations.Size = new System.Drawing.Size(53, 13);
            this.LblVariations.TabIndex = 10;
            this.LblVariations.Text = "Variations";
            this.ToolTipNFSRaider.SetToolTip(this.LblVariations, resources.GetString("LblVariations.ToolTip"));
            // 
            // LblExportOptionsExportFormat
            // 
            this.LblExportOptionsExportFormat.AutoSize = true;
            this.LblExportOptionsExportFormat.Location = new System.Drawing.Point(6, 95);
            this.LblExportOptionsExportFormat.Name = "LblExportOptionsExportFormat";
            this.LblExportOptionsExportFormat.Size = new System.Drawing.Size(69, 13);
            this.LblExportOptionsExportFormat.TabIndex = 60;
            this.LblExportOptionsExportFormat.Text = "Export format";
            // 
            // TxtExportFormat
            // 
            this.TxtExportFormat.Location = new System.Drawing.Point(81, 92);
            this.TxtExportFormat.Name = "TxtExportFormat";
            this.TxtExportFormat.Size = new System.Drawing.Size(126, 20);
            this.TxtExportFormat.TabIndex = 61;
            this.TxtExportFormat.Text = "0x(HASH) - (STRING)";
            // 
            // GrpExportOptions
            // 
            this.GrpExportOptions.Controls.Add(this.ChkReverseHashes);
            this.GrpExportOptions.Controls.Add(this.LblExportOptionsOrderBy);
            this.GrpExportOptions.Controls.Add(this.CboOrderBy);
            this.GrpExportOptions.Controls.Add(this.ChkIgnoreRepeatedStrings);
            this.GrpExportOptions.Controls.Add(this.BtnUpdateList);
            this.GrpExportOptions.Controls.Add(this.BtnExportHashes);
            this.GrpExportOptions.Controls.Add(this.ChkIgnoreRepeatedHashes);
            this.GrpExportOptions.Controls.Add(this.TxtExportFormat);
            this.GrpExportOptions.Controls.Add(this.LblExportOptionsExportFormat);
            this.GrpExportOptions.Location = new System.Drawing.Point(12, 425);
            this.GrpExportOptions.Name = "GrpExportOptions";
            this.GrpExportOptions.Size = new System.Drawing.Size(294, 118);
            this.GrpExportOptions.TabIndex = 52;
            this.GrpExportOptions.TabStop = false;
            this.GrpExportOptions.Text = "Export options";
            // 
            // ChkReverseHashes
            // 
            this.ChkReverseHashes.AutoSize = true;
            this.ChkReverseHashes.Location = new System.Drawing.Point(6, 67);
            this.ChkReverseHashes.Name = "ChkReverseHashes";
            this.ChkReverseHashes.Size = new System.Drawing.Size(103, 17);
            this.ChkReverseHashes.TabIndex = 63;
            this.ChkReverseHashes.Text = "Reverse hashes";
            this.ChkReverseHashes.UseVisualStyleBackColor = true;
            // 
            // LblExportOptionsOrderBy
            // 
            this.LblExportOptionsOrderBy.AutoSize = true;
            this.LblExportOptionsOrderBy.Location = new System.Drawing.Point(6, 22);
            this.LblExportOptionsOrderBy.Name = "LblExportOptionsOrderBy";
            this.LblExportOptionsOrderBy.Size = new System.Drawing.Size(47, 13);
            this.LblExportOptionsOrderBy.TabIndex = 53;
            this.LblExportOptionsOrderBy.Text = "Order by";
            // 
            // CboOrderBy
            // 
            this.CboOrderBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboOrderBy.FormattingEnabled = true;
            this.CboOrderBy.Items.AddRange(new object[] {
            "None",
            "Hash ascending",
            "Hash descending",
            "String ascending",
            "String descending"});
            this.CboOrderBy.Location = new System.Drawing.Point(59, 19);
            this.CboOrderBy.Name = "CboOrderBy";
            this.CboOrderBy.Size = new System.Drawing.Size(228, 21);
            this.CboOrderBy.TabIndex = 54;
            this.CboOrderBy.SelectedIndexChanged += new System.EventHandler(this.CboOrderBy_SelectedIndexChanged);
            // 
            // ChkIgnoreRepeatedStrings
            // 
            this.ChkIgnoreRepeatedStrings.AutoSize = true;
            this.ChkIgnoreRepeatedStrings.Location = new System.Drawing.Point(153, 46);
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
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(312, 36);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(92, 23);
            this.BtnStart.TabIndex = 5;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
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
            this.ChkUseHashesFile.Location = new System.Drawing.Point(769, 355);
            this.ChkUseHashesFile.Name = "ChkUseHashesFile";
            this.ChkUseHashesFile.Size = new System.Drawing.Size(103, 17);
            this.ChkUseHashesFile.TabIndex = 35;
            this.ChkUseHashesFile.Text = "Use hashes files";
            this.ChkUseHashesFile.UseVisualStyleBackColor = true;
            this.ChkUseHashesFile.CheckedChanged += new System.EventHandler(this.ChkUseHashesFile_CheckedChanged);
            // 
            // BtnGenerateListOfHashes
            // 
            this.BtnGenerateListOfHashes.Location = new System.Drawing.Point(609, 351);
            this.BtnGenerateListOfHashes.Name = "BtnGenerateListOfHashes";
            this.BtnGenerateListOfHashes.Size = new System.Drawing.Size(153, 23);
            this.BtnGenerateListOfHashes.TabIndex = 34;
            this.BtnGenerateListOfHashes.Text = "Generate list of hashes";
            this.BtnGenerateListOfHashes.UseVisualStyleBackColor = true;
            this.BtnGenerateListOfHashes.Click += new System.EventHandler(this.BtnGenerateListOfHashes_Click);
            // 
            // GrpStats
            // 
            this.GrpStats.Controls.Add(this.LblTotalHashes);
            this.GrpStats.Controls.Add(this.LblUnknownHashes);
            this.GrpStats.Controls.Add(this.LblKnownHashes);
            this.GrpStats.Controls.Add(this.LblTextKnownHashes);
            this.GrpStats.Controls.Add(this.LblTextUnknownHashes);
            this.GrpStats.Controls.Add(this.LblTextTotalHashes);
            this.GrpStats.Location = new System.Drawing.Point(610, 469);
            this.GrpStats.Name = "GrpStats";
            this.GrpStats.Size = new System.Drawing.Size(262, 74);
            this.GrpStats.TabIndex = 45;
            this.GrpStats.TabStop = false;
            this.GrpStats.Text = "Stats";
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
            // GrpBruteforceOptions
            // 
            this.GrpBruteforceOptions.Controls.Add(this.NumericProcessorsCount);
            this.GrpBruteforceOptions.Controls.Add(this.LblBruteforceOptionsProcessors);
            this.GrpBruteforceOptions.Controls.Add(this.NumericMaxVariations);
            this.GrpBruteforceOptions.Controls.Add(this.NumericMinVariations);
            this.GrpBruteforceOptions.Controls.Add(this.ChkBruteforceWithRepetition);
            this.GrpBruteforceOptions.Controls.Add(this.ChkTryToBruteforce);
            this.GrpBruteforceOptions.Controls.Add(this.LblWordsBetweenVariations);
            this.GrpBruteforceOptions.Controls.Add(this.LblBruteforceOptionsMax);
            this.GrpBruteforceOptions.Controls.Add(this.LblBruteforceOptionsMin);
            this.GrpBruteforceOptions.Controls.Add(this.TxtWordsBetweenVariations);
            this.GrpBruteforceOptions.Location = new System.Drawing.Point(604, 232);
            this.GrpBruteforceOptions.Name = "GrpBruteforceOptions";
            this.GrpBruteforceOptions.Size = new System.Drawing.Size(268, 113);
            this.GrpBruteforceOptions.TabIndex = 27;
            this.GrpBruteforceOptions.TabStop = false;
            this.GrpBruteforceOptions.Text = "Bruteforce options";
            // 
            // NumericProcessorsCount
            // 
            this.NumericProcessorsCount.Location = new System.Drawing.Point(218, 64);
            this.NumericProcessorsCount.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericProcessorsCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericProcessorsCount.Name = "NumericProcessorsCount";
            this.NumericProcessorsCount.Size = new System.Drawing.Size(41, 20);
            this.NumericProcessorsCount.TabIndex = 40;
            this.NumericProcessorsCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericProcessorsCount.Leave += new System.EventHandler(this.NumericProcessorsCount_Leave);
            // 
            // LblBruteforceOptionsProcessors
            // 
            this.LblBruteforceOptionsProcessors.AutoSize = true;
            this.LblBruteforceOptionsProcessors.Location = new System.Drawing.Point(159, 66);
            this.LblBruteforceOptionsProcessors.Name = "LblBruteforceOptionsProcessors";
            this.LblBruteforceOptionsProcessors.Size = new System.Drawing.Size(59, 13);
            this.LblBruteforceOptionsProcessors.TabIndex = 39;
            this.LblBruteforceOptionsProcessors.Text = "Processors";
            // 
            // NumericMaxVariations
            // 
            this.NumericMaxVariations.Location = new System.Drawing.Point(112, 64);
            this.NumericMaxVariations.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericMaxVariations.Name = "NumericMaxVariations";
            this.NumericMaxVariations.Size = new System.Drawing.Size(41, 20);
            this.NumericMaxVariations.TabIndex = 38;
            this.NumericMaxVariations.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.NumericMaxVariations.Leave += new System.EventHandler(this.NumericMaxVariations_Leave);
            // 
            // NumericMinVariations
            // 
            this.NumericMinVariations.Location = new System.Drawing.Point(32, 64);
            this.NumericMinVariations.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericMinVariations.Name = "NumericMinVariations";
            this.NumericMinVariations.Size = new System.Drawing.Size(41, 20);
            this.NumericMinVariations.TabIndex = 27;
            this.NumericMinVariations.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericMinVariations.Leave += new System.EventHandler(this.NumericMinVariations_Leave);
            // 
            // ChkBruteforceWithRepetition
            // 
            this.ChkBruteforceWithRepetition.AutoSize = true;
            this.ChkBruteforceWithRepetition.Location = new System.Drawing.Point(122, 90);
            this.ChkBruteforceWithRepetition.Name = "ChkBruteforceWithRepetition";
            this.ChkBruteforceWithRepetition.Size = new System.Drawing.Size(140, 17);
            this.ChkBruteforceWithRepetition.TabIndex = 37;
            this.ChkBruteforceWithRepetition.Text = "Variations with repetition";
            this.ChkBruteforceWithRepetition.UseVisualStyleBackColor = true;
            this.ChkBruteforceWithRepetition.CheckedChanged += new System.EventHandler(this.ChkBruteforceWithRepetition_CheckedChanged);
            // 
            // ChkTryToBruteforce
            // 
            this.ChkTryToBruteforce.AutoSize = true;
            this.ChkTryToBruteforce.Location = new System.Drawing.Point(8, 90);
            this.ChkTryToBruteforce.Name = "ChkTryToBruteforce";
            this.ChkTryToBruteforce.Size = new System.Drawing.Size(104, 17);
            this.ChkTryToBruteforce.TabIndex = 26;
            this.ChkTryToBruteforce.Text = "Try to bruteforce";
            this.ChkTryToBruteforce.UseVisualStyleBackColor = true;
            this.ChkTryToBruteforce.CheckedChanged += new System.EventHandler(this.ChkTryToBruteforce_CheckedChanged);
            // 
            // LblWordsBetweenVariations
            // 
            this.LblWordsBetweenVariations.AutoSize = true;
            this.LblWordsBetweenVariations.Location = new System.Drawing.Point(5, 16);
            this.LblWordsBetweenVariations.Name = "LblWordsBetweenVariations";
            this.LblWordsBetweenVariations.Size = new System.Drawing.Size(130, 13);
            this.LblWordsBetweenVariations.TabIndex = 32;
            this.LblWordsBetweenVariations.Text = "Words between variations";
            this.ToolTipNFSRaider.SetToolTip(this.LblWordsBetweenVariations, "Use comma (,) to separate each word between variations.\r\nIf you want to use comma" +
        " (,) you must escape it (\\,). Same goes for backslash (\\), you must escape it (\\" +
        "\\).");
            // 
            // LblBruteforceOptionsMax
            // 
            this.LblBruteforceOptionsMax.AutoSize = true;
            this.LblBruteforceOptionsMax.Location = new System.Drawing.Point(82, 66);
            this.LblBruteforceOptionsMax.Name = "LblBruteforceOptionsMax";
            this.LblBruteforceOptionsMax.Size = new System.Drawing.Size(27, 13);
            this.LblBruteforceOptionsMax.TabIndex = 30;
            this.LblBruteforceOptionsMax.Text = "Max";
            // 
            // LblBruteforceOptionsMin
            // 
            this.LblBruteforceOptionsMin.AutoSize = true;
            this.LblBruteforceOptionsMin.Location = new System.Drawing.Point(6, 66);
            this.LblBruteforceOptionsMin.Name = "LblBruteforceOptionsMin";
            this.LblBruteforceOptionsMin.Size = new System.Drawing.Size(24, 13);
            this.LblBruteforceOptionsMin.TabIndex = 28;
            this.LblBruteforceOptionsMin.Text = "Min";
            // 
            // TxtWordsBetweenVariations
            // 
            this.TxtWordsBetweenVariations.Location = new System.Drawing.Point(6, 32);
            this.TxtWordsBetweenVariations.Name = "TxtWordsBetweenVariations";
            this.TxtWordsBetweenVariations.Size = new System.Drawing.Size(253, 20);
            this.TxtWordsBetweenVariations.TabIndex = 33;
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(12, 8);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(294, 20);
            this.TxtSearch.TabIndex = 1;
            // 
            // BtnSearchPrevious
            // 
            this.BtnSearchPrevious.Location = new System.Drawing.Point(12, 36);
            this.BtnSearchPrevious.Name = "BtnSearchPrevious";
            this.BtnSearchPrevious.Size = new System.Drawing.Size(94, 23);
            this.BtnSearchPrevious.TabIndex = 2;
            this.BtnSearchPrevious.Text = "Previous";
            this.BtnSearchPrevious.UseVisualStyleBackColor = true;
            this.BtnSearchPrevious.Click += new System.EventHandler(this.BtnSearchPrevious_Click);
            // 
            // BtnSearchNext
            // 
            this.BtnSearchNext.Location = new System.Drawing.Point(111, 36);
            this.BtnSearchNext.Name = "BtnSearchNext";
            this.BtnSearchNext.Size = new System.Drawing.Size(96, 23);
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
            // CboForceHashListCase
            // 
            this.CboForceHashListCase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboForceHashListCase.FormattingEnabled = true;
            this.CboForceHashListCase.Items.AddRange(new object[] {
            "None",
            "Uppercase",
            "Lowercase"});
            this.CboForceHashListCase.Location = new System.Drawing.Point(610, 382);
            this.CboForceHashListCase.Name = "CboForceHashListCase";
            this.CboForceHashListCase.Size = new System.Drawing.Size(152, 21);
            this.CboForceHashListCase.TabIndex = 64;
            this.CboForceHashListCase.SelectedIndexChanged += new System.EventHandler(this.CboForceHashListCase_SelectedIndexChanged);
            // 
            // LblTimeElapsed
            // 
            this.LblTimeElapsed.Location = new System.Drawing.Point(675, 546);
            this.LblTimeElapsed.Name = "LblTimeElapsed";
            this.LblTimeElapsed.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblTimeElapsed.Size = new System.Drawing.Size(200, 13);
            this.LblTimeElapsed.TabIndex = 65;
            this.LblTimeElapsed.Text = "Time elapsed: HHHH:mm:ss.fff";
            // 
            // ToolTipNFSRaider
            // 
            this.ToolTipNFSRaider.AutoPopDelay = 15000;
            this.ToolTipNFSRaider.InitialDelay = 500;
            this.ToolTipNFSRaider.ReshowDelay = 100;
            this.ToolTipNFSRaider.ToolTipTitle = "Info";
            // 
            // BtnSearchAll
            // 
            this.BtnSearchAll.Location = new System.Drawing.Point(212, 36);
            this.BtnSearchAll.Name = "BtnSearchAll";
            this.BtnSearchAll.Size = new System.Drawing.Size(94, 23);
            this.BtnSearchAll.TabIndex = 66;
            this.BtnSearchAll.Text = "All";
            this.BtnSearchAll.UseVisualStyleBackColor = true;
            this.BtnSearchAll.Click += new System.EventHandler(this.BtnSearchAll_Click);
            // 
            // NFSRaiderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.BtnSearchAll);
            this.Controls.Add(this.LblTimeElapsed);
            this.Controls.Add(this.CboForceHashListCase);
            this.Controls.Add(this.LblStatus);
            this.Controls.Add(this.BtnSearchNext);
            this.Controls.Add(this.BtnSearchPrevious);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.GrpBruteforceOptions);
            this.Controls.Add(this.GrpStats);
            this.Controls.Add(this.BtnGenerateListOfHashes);
            this.Controls.Add(this.ChkUseHashesFile);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.TxtFileEndOffset);
            this.Controls.Add(this.TxtFileStartOffset);
            this.Controls.Add(this.GrpExportOptions);
            this.Controls.Add(this.LblVariations);
            this.Controls.Add(this.LblSuffixes);
            this.Controls.Add(this.LblPrefixes);
            this.Controls.Add(this.TxtSuffixes);
            this.Controls.Add(this.TxtVariations);
            this.Controls.Add(this.TxtPrefixes);
            this.Controls.Add(this.GrpHashingOptions);
            this.Controls.Add(this.LstUnhashed);
            this.Controls.Add(this.GrpLoadOptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "NFSRaiderForm";
            this.Text = "NFS-Raider";
            this.GrpLoadOptions.ResumeLayout(false);
            this.GrpLoadOptions.PerformLayout();
            this.GrpHashingOptions.ResumeLayout(false);
            this.GrpExportOptions.ResumeLayout(false);
            this.GrpExportOptions.PerformLayout();
            this.GrpStats.ResumeLayout(false);
            this.GrpStats.PerformLayout();
            this.GrpBruteforceOptions.ResumeLayout(false);
            this.GrpBruteforceOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericProcessorsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericMaxVariations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericMinVariations)).EndInit();
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
        private System.Windows.Forms.GroupBox GrpHashingOptions;
        private System.Windows.Forms.TextBox TxtPrefixes;
        private System.Windows.Forms.TextBox TxtVariations;
        private System.Windows.Forms.TextBox TxtSuffixes;
        private System.Windows.Forms.Label LblPrefixes;
        private System.Windows.Forms.Label LblSuffixes;
        private System.Windows.Forms.Label LblVariations;
        private System.Windows.Forms.Label LblExportOptionsExportFormat;
        private System.Windows.Forms.TextBox TxtExportFormat;
        private System.Windows.Forms.GroupBox GrpExportOptions;
        private System.Windows.Forms.Button BtnExportHashes;
        private System.Windows.Forms.TextBox TxtFileStartOffset;
        private System.Windows.Forms.TextBox TxtFileEndOffset;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.CheckBox ChkUseHashesFile;
        private System.Windows.Forms.Button BtnGenerateListOfHashes;
        private System.Windows.Forms.GroupBox GrpStats;
        private System.Windows.Forms.Label LblTotalHashes;
        private System.Windows.Forms.Label LblUnknownHashes;
        private System.Windows.Forms.Label LblKnownHashes;
        private System.Windows.Forms.Label LblTextKnownHashes;
        private System.Windows.Forms.Label LblTextUnknownHashes;
        private System.Windows.Forms.Label LblTextTotalHashes;
        private System.Windows.Forms.TextBox TxtFileSkipHashes;
        private System.Windows.Forms.Label LblSkipHashes;
        private System.Windows.Forms.GroupBox GrpBruteforceOptions;
        private System.Windows.Forms.Label LblWordsBetweenVariations;
        private System.Windows.Forms.Label LblBruteforceOptionsMax;
        private System.Windows.Forms.Label LblBruteforceOptionsMin;
        private System.Windows.Forms.TextBox TxtWordsBetweenVariations;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Button BtnSearchPrevious;
        private System.Windows.Forms.Button BtnSearchNext;
        private System.Windows.Forms.TextBox TxtFileReadHashes;
        private System.Windows.Forms.Label LblReadHashes;
        private System.Windows.Forms.Button BtnUpdateList;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.CheckBox ChkTryToBruteforce;
        private System.Windows.Forms.CheckBox ChkBruteforceWithRepetition;
        private System.Windows.Forms.CheckBox ChkIgnoreRepeatedStrings;
        private System.Windows.Forms.CheckBox ChkIgnoreRepeatedHashes;
        private System.Windows.Forms.Label LblExportOptionsOrderBy;
        private System.Windows.Forms.ComboBox CboOrderBy;
        private System.Windows.Forms.ComboBox CboForceHashListCase;
        private System.Windows.Forms.NumericUpDown NumericMinVariations;
        private System.Windows.Forms.NumericUpDown NumericMaxVariations;
        private System.Windows.Forms.CheckBox ChkReverseHashes;
        private System.Windows.Forms.Label LblTimeElapsed;
        private System.Windows.Forms.ComboBox CboHashTypes;
        private System.Windows.Forms.ComboBox CboEndianness;
        private System.Windows.Forms.NumericUpDown NumericProcessorsCount;
        private System.Windows.Forms.Label LblBruteforceOptionsProcessors;
        private System.Windows.Forms.ToolTip ToolTipNFSRaider;
        private System.Windows.Forms.Button BtnSearchAll;
    }
}

