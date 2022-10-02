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
            this.TabLoadOptions = new System.Windows.Forms.TabControl();
            this.TabPageFromFile = new System.Windows.Forms.TabPage();
            this.TxtFileReadHashes = new System.Windows.Forms.TextBox();
            this.LblReadHashes = new System.Windows.Forms.Label();
            this.LblStartOffset = new System.Windows.Forms.Label();
            this.TxtFileSkipHashes = new System.Windows.Forms.TextBox();
            this.LblEndOffset = new System.Windows.Forms.Label();
            this.LblSkipHashes = new System.Windows.Forms.Label();
            this.TxtFileStartOffset = new System.Windows.Forms.TextBox();
            this.TxtFileEndOffset = new System.Windows.Forms.TextBox();
            this.TabPageFromText = new System.Windows.Forms.TabPage();
            this.CboNumericBase = new System.Windows.Forms.ComboBox();
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
            this.GrpListOptions = new System.Windows.Forms.GroupBox();
            this.CboNumericBaseLst = new System.Windows.Forms.ComboBox();
            this.BtnResetFormat = new System.Windows.Forms.Button();
            this.ChkExportSelectedOnly = new System.Windows.Forms.CheckBox();
            this.ChkReverseHashes = new System.Windows.Forms.CheckBox();
            this.CboOrderBy = new System.Windows.Forms.ComboBox();
            this.ChkIgnoreRepeatedStrings = new System.Windows.Forms.CheckBox();
            this.BtnUpdateList = new System.Windows.Forms.Button();
            this.BtnExportHashes = new System.Windows.Forms.Button();
            this.ChkIgnoreRepeatedHashes = new System.Windows.Forms.CheckBox();
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
            this.CboRaiderMode = new System.Windows.Forms.ComboBox();
            this.ChkCaseSensitive = new System.Windows.Forms.CheckBox();
            this.GrpLoadOptions.SuspendLayout();
            this.TabLoadOptions.SuspendLayout();
            this.TabPageFromFile.SuspendLayout();
            this.TabPageFromText.SuspendLayout();
            this.GrpHashingOptions.SuspendLayout();
            this.GrpListOptions.SuspendLayout();
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
            this.LstUnhashed.ItemHeight = 15;
            this.LstUnhashed.Location = new System.Drawing.Point(14, 74);
            this.LstUnhashed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LstUnhashed.Name = "LstUnhashed";
            this.LstUnhashed.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.LstUnhashed.Size = new System.Drawing.Size(342, 379);
            this.LstUnhashed.TabIndex = 6;
            this.LstUnhashed.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LstUnhashed_KeyDown);
            // 
            // BtnLoadFile
            // 
            this.BtnLoadFile.Location = new System.Drawing.Point(7, 7);
            this.BtnLoadFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnLoadFile.Name = "BtnLoadFile";
            this.BtnLoadFile.Size = new System.Drawing.Size(144, 27);
            this.BtnLoadFile.TabIndex = 0;
            this.BtnLoadFile.Text = "Load file";
            this.BtnLoadFile.UseVisualStyleBackColor = true;
            this.BtnLoadFile.Click += new System.EventHandler(this.BtnLoadFile_Click);
            // 
            // TxtLoadFromText
            // 
            this.TxtLoadFromText.Location = new System.Drawing.Point(7, 35);
            this.TxtLoadFromText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtLoadFromText.MaxLength = 2147483647;
            this.TxtLoadFromText.Multiline = true;
            this.TxtLoadFromText.Name = "TxtLoadFromText";
            this.TxtLoadFromText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtLoadFromText.Size = new System.Drawing.Size(296, 262);
            this.TxtLoadFromText.TabIndex = 1;
            // 
            // GrpLoadOptions
            // 
            this.GrpLoadOptions.Controls.Add(this.TabLoadOptions);
            this.GrpLoadOptions.Location = new System.Drawing.Point(364, 268);
            this.GrpLoadOptions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GrpLoadOptions.Name = "GrpLoadOptions";
            this.GrpLoadOptions.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GrpLoadOptions.Size = new System.Drawing.Size(334, 359);
            this.GrpLoadOptions.TabIndex = 17;
            this.GrpLoadOptions.TabStop = false;
            this.GrpLoadOptions.Text = "Load options";
            // 
            // TabLoadOptions
            // 
            this.TabLoadOptions.Controls.Add(this.TabPageFromFile);
            this.TabLoadOptions.Controls.Add(this.TabPageFromText);
            this.TabLoadOptions.Location = new System.Drawing.Point(7, 22);
            this.TabLoadOptions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TabLoadOptions.Name = "TabLoadOptions";
            this.TabLoadOptions.SelectedIndex = 0;
            this.TabLoadOptions.Size = new System.Drawing.Size(320, 331);
            this.TabLoadOptions.TabIndex = 0;
            this.TabLoadOptions.SelectedIndexChanged += new System.EventHandler(this.TabLoadOptions_SelectedIndexChanged);
            // 
            // TabPageFromFile
            // 
            this.TabPageFromFile.Controls.Add(this.TxtFileReadHashes);
            this.TabPageFromFile.Controls.Add(this.BtnLoadFile);
            this.TabPageFromFile.Controls.Add(this.LblReadHashes);
            this.TabPageFromFile.Controls.Add(this.LblStartOffset);
            this.TabPageFromFile.Controls.Add(this.TxtFileSkipHashes);
            this.TabPageFromFile.Controls.Add(this.LblEndOffset);
            this.TabPageFromFile.Controls.Add(this.LblSkipHashes);
            this.TabPageFromFile.Controls.Add(this.TxtFileStartOffset);
            this.TabPageFromFile.Controls.Add(this.TxtFileEndOffset);
            this.TabPageFromFile.Location = new System.Drawing.Point(4, 24);
            this.TabPageFromFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TabPageFromFile.Name = "TabPageFromFile";
            this.TabPageFromFile.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TabPageFromFile.Size = new System.Drawing.Size(312, 303);
            this.TabPageFromFile.TabIndex = 0;
            this.TabPageFromFile.Text = "File";
            this.TabPageFromFile.UseVisualStyleBackColor = true;
            // 
            // TxtFileReadHashes
            // 
            this.TxtFileReadHashes.Location = new System.Drawing.Point(7, 148);
            this.TxtFileReadHashes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtFileReadHashes.Name = "TxtFileReadHashes";
            this.TxtFileReadHashes.Size = new System.Drawing.Size(144, 23);
            this.TxtFileReadHashes.TabIndex = 6;
            this.TxtFileReadHashes.Text = "0";
            this.TxtFileReadHashes.Leave += new System.EventHandler(this.TxtFileReadHashes_Leave);
            // 
            // LblReadHashes
            // 
            this.LblReadHashes.AutoSize = true;
            this.LblReadHashes.Location = new System.Drawing.Point(4, 129);
            this.LblReadHashes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblReadHashes.Name = "LblReadHashes";
            this.LblReadHashes.Size = new System.Drawing.Size(72, 15);
            this.LblReadHashes.TabIndex = 5;
            this.LblReadHashes.Text = "Read hashes";
            // 
            // LblStartOffset
            // 
            this.LblStartOffset.AutoSize = true;
            this.LblStartOffset.Location = new System.Drawing.Point(4, 37);
            this.LblStartOffset.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblStartOffset.Name = "LblStartOffset";
            this.LblStartOffset.Size = new System.Drawing.Size(64, 15);
            this.LblStartOffset.TabIndex = 1;
            this.LblStartOffset.Text = "Start offset";
            // 
            // TxtFileSkipHashes
            // 
            this.TxtFileSkipHashes.Location = new System.Drawing.Point(6, 195);
            this.TxtFileSkipHashes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtFileSkipHashes.Name = "TxtFileSkipHashes";
            this.TxtFileSkipHashes.Size = new System.Drawing.Size(144, 23);
            this.TxtFileSkipHashes.TabIndex = 8;
            this.TxtFileSkipHashes.Text = "0";
            this.TxtFileSkipHashes.TextChanged += new System.EventHandler(this.TxtFileSkipHashes_TextChanged);
            // 
            // LblEndOffset
            // 
            this.LblEndOffset.AutoSize = true;
            this.LblEndOffset.Location = new System.Drawing.Point(4, 84);
            this.LblEndOffset.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblEndOffset.Name = "LblEndOffset";
            this.LblEndOffset.Size = new System.Drawing.Size(60, 15);
            this.LblEndOffset.TabIndex = 3;
            this.LblEndOffset.Text = "End offset";
            // 
            // LblSkipHashes
            // 
            this.LblSkipHashes.AutoSize = true;
            this.LblSkipHashes.Location = new System.Drawing.Point(4, 177);
            this.LblSkipHashes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSkipHashes.Name = "LblSkipHashes";
            this.LblSkipHashes.Size = new System.Drawing.Size(68, 15);
            this.LblSkipHashes.TabIndex = 7;
            this.LblSkipHashes.Text = "Skip hashes";
            // 
            // TxtFileStartOffset
            // 
            this.TxtFileStartOffset.Location = new System.Drawing.Point(7, 58);
            this.TxtFileStartOffset.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtFileStartOffset.Name = "TxtFileStartOffset";
            this.TxtFileStartOffset.Size = new System.Drawing.Size(144, 23);
            this.TxtFileStartOffset.TabIndex = 2;
            this.TxtFileStartOffset.Text = "0";
            this.TxtFileStartOffset.Leave += new System.EventHandler(this.TxtFileStartOffset_Leave);
            // 
            // TxtFileEndOffset
            // 
            this.TxtFileEndOffset.Location = new System.Drawing.Point(7, 103);
            this.TxtFileEndOffset.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtFileEndOffset.Name = "TxtFileEndOffset";
            this.TxtFileEndOffset.Size = new System.Drawing.Size(144, 23);
            this.TxtFileEndOffset.TabIndex = 4;
            this.TxtFileEndOffset.Text = "0";
            this.TxtFileEndOffset.Leave += new System.EventHandler(this.TxtFileEndOffset_Leave);
            // 
            // TabPageFromText
            // 
            this.TabPageFromText.Controls.Add(this.CboNumericBase);
            this.TabPageFromText.Controls.Add(this.TxtLoadFromText);
            this.TabPageFromText.Location = new System.Drawing.Point(4, 24);
            this.TabPageFromText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TabPageFromText.Name = "TabPageFromText";
            this.TabPageFromText.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TabPageFromText.Size = new System.Drawing.Size(312, 303);
            this.TabPageFromText.TabIndex = 1;
            this.TabPageFromText.Text = "Text";
            this.TabPageFromText.UseVisualStyleBackColor = true;
            // 
            // CboNumericBase
            // 
            this.CboNumericBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboNumericBase.FormattingEnabled = true;
            this.CboNumericBase.Items.AddRange(new object[] {
            "Hexadecimal",
            "Decimal",
            "Octal",
            "Binary"});
            this.CboNumericBase.Location = new System.Drawing.Point(8, 6);
            this.CboNumericBase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CboNumericBase.Name = "CboNumericBase";
            this.CboNumericBase.Size = new System.Drawing.Size(295, 23);
            this.CboNumericBase.TabIndex = 0;
            this.CboNumericBase.SelectedIndexChanged += new System.EventHandler(this.CboNumericBase_SelectedIndexChanged);
            // 
            // GrpHashingOptions
            // 
            this.GrpHashingOptions.Controls.Add(this.CboHashTypes);
            this.GrpHashingOptions.Controls.Add(this.CboEndianness);
            this.GrpHashingOptions.Location = new System.Drawing.Point(710, 468);
            this.GrpHashingOptions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GrpHashingOptions.Name = "GrpHashingOptions";
            this.GrpHashingOptions.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GrpHashingOptions.Size = new System.Drawing.Size(307, 62);
            this.GrpHashingOptions.TabIndex = 23;
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
            this.CboHashTypes.Location = new System.Drawing.Point(187, 22);
            this.CboHashTypes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CboHashTypes.Name = "CboHashTypes";
            this.CboHashTypes.Size = new System.Drawing.Size(112, 23);
            this.CboHashTypes.TabIndex = 1;
            this.CboHashTypes.SelectedIndexChanged += new System.EventHandler(this.CboHashTypes_SelectedIndexChanged);
            // 
            // CboEndianness
            // 
            this.CboEndianness.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboEndianness.FormattingEnabled = true;
            this.CboEndianness.Items.AddRange(new object[] {
            "Big-endian (file)",
            "Little-endian (memory)"});
            this.CboEndianness.Location = new System.Drawing.Point(8, 22);
            this.CboEndianness.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CboEndianness.Name = "CboEndianness";
            this.CboEndianness.Size = new System.Drawing.Size(171, 23);
            this.CboEndianness.TabIndex = 0;
            this.CboEndianness.SelectedIndexChanged += new System.EventHandler(this.CboEndianness_SelectedIndexChanged);
            // 
            // TxtPrefixes
            // 
            this.TxtPrefixes.AccessibleDescription = "";
            this.TxtPrefixes.AccessibleName = "";
            this.TxtPrefixes.Location = new System.Drawing.Point(478, 42);
            this.TxtPrefixes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtPrefixes.MaxLength = 2147483647;
            this.TxtPrefixes.Multiline = true;
            this.TxtPrefixes.Name = "TxtPrefixes";
            this.TxtPrefixes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtPrefixes.Size = new System.Drawing.Size(174, 219);
            this.TxtPrefixes.TabIndex = 12;
            // 
            // TxtVariations
            // 
            this.TxtVariations.Location = new System.Drawing.Point(660, 42);
            this.TxtVariations.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtVariations.MaxLength = 2147483647;
            this.TxtVariations.Multiline = true;
            this.TxtVariations.Name = "TxtVariations";
            this.TxtVariations.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtVariations.Size = new System.Drawing.Size(174, 219);
            this.TxtVariations.TabIndex = 14;
            this.TxtVariations.Text = "A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z,a,b,c,d,e,f,g,h,i,j,k,l,m,n,o" +
    ",p,q,r,s,t,u,v,w,x,y,z,0,1,2,3,4,5,6,7,8,9,_, ,!,\",#,$,%,&,\',(,),*,+,-,.,/,:,;,<" +
    ",=,>,?,@,[,\\\\,],^,`,{,|,},~,\\,";
            // 
            // TxtSuffixes
            // 
            this.TxtSuffixes.Location = new System.Drawing.Point(842, 42);
            this.TxtSuffixes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtSuffixes.MaxLength = 2147483647;
            this.TxtSuffixes.Multiline = true;
            this.TxtSuffixes.Name = "TxtSuffixes";
            this.TxtSuffixes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtSuffixes.Size = new System.Drawing.Size(174, 219);
            this.TxtSuffixes.TabIndex = 16;
            // 
            // LblPrefixes
            // 
            this.LblPrefixes.AutoSize = true;
            this.LblPrefixes.Location = new System.Drawing.Point(475, 23);
            this.LblPrefixes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPrefixes.Name = "LblPrefixes";
            this.LblPrefixes.Size = new System.Drawing.Size(48, 15);
            this.LblPrefixes.TabIndex = 11;
            this.LblPrefixes.Text = "Prefixes";
            this.ToolTipNFSRaider.SetToolTip(this.LblPrefixes, "Use comma (,) to separate each prefix.\r\nIf you want to use comma (,) you must esc" +
        "ape it (\\,). Same goes for backslash (\\), you must escape it (\\\\).");
            // 
            // LblSuffixes
            // 
            this.LblSuffixes.AutoSize = true;
            this.LblSuffixes.Location = new System.Drawing.Point(839, 23);
            this.LblSuffixes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSuffixes.Name = "LblSuffixes";
            this.LblSuffixes.Size = new System.Drawing.Size(48, 15);
            this.LblSuffixes.TabIndex = 15;
            this.LblSuffixes.Text = "Suffixes";
            this.ToolTipNFSRaider.SetToolTip(this.LblSuffixes, "Use comma (,) to separate each suffix.\r\nIf you want to use comma (,) you must esc" +
        "ape it (\\,). Same goes for backslash (\\), you must escape it (\\\\).");
            // 
            // LblVariations
            // 
            this.LblVariations.AutoSize = true;
            this.LblVariations.Location = new System.Drawing.Point(657, 23);
            this.LblVariations.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblVariations.Name = "LblVariations";
            this.LblVariations.Size = new System.Drawing.Size(58, 15);
            this.LblVariations.TabIndex = 13;
            this.LblVariations.Text = "Variations";
            this.ToolTipNFSRaider.SetToolTip(this.LblVariations, resources.GetString("LblVariations.ToolTip"));
            // 
            // LblExportOptionsExportFormat
            // 
            this.LblExportOptionsExportFormat.AutoSize = true;
            this.LblExportOptionsExportFormat.Location = new System.Drawing.Point(9, 103);
            this.LblExportOptionsExportFormat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblExportOptionsExportFormat.Name = "LblExportOptionsExportFormat";
            this.LblExportOptionsExportFormat.Size = new System.Drawing.Size(80, 15);
            this.LblExportOptionsExportFormat.TabIndex = 6;
            this.LblExportOptionsExportFormat.Text = "Export format";
            // 
            // TxtExportFormat
            // 
            this.TxtExportFormat.Location = new System.Drawing.Point(94, 99);
            this.TxtExportFormat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtExportFormat.Name = "TxtExportFormat";
            this.TxtExportFormat.Size = new System.Drawing.Size(146, 23);
            this.TxtExportFormat.TabIndex = 7;
            this.TxtExportFormat.Text = "0x(HASH) - (STRING)";
            // 
            // GrpListOptions
            // 
            this.GrpListOptions.Controls.Add(this.CboNumericBaseLst);
            this.GrpListOptions.Controls.Add(this.BtnResetFormat);
            this.GrpListOptions.Controls.Add(this.ChkExportSelectedOnly);
            this.GrpListOptions.Controls.Add(this.ChkReverseHashes);
            this.GrpListOptions.Controls.Add(this.CboOrderBy);
            this.GrpListOptions.Controls.Add(this.ChkIgnoreRepeatedStrings);
            this.GrpListOptions.Controls.Add(this.BtnUpdateList);
            this.GrpListOptions.Controls.Add(this.BtnExportHashes);
            this.GrpListOptions.Controls.Add(this.ChkIgnoreRepeatedHashes);
            this.GrpListOptions.Controls.Add(this.TxtExportFormat);
            this.GrpListOptions.Controls.Add(this.LblExportOptionsExportFormat);
            this.GrpListOptions.Location = new System.Drawing.Point(14, 457);
            this.GrpListOptions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GrpListOptions.Name = "GrpListOptions";
            this.GrpListOptions.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GrpListOptions.Size = new System.Drawing.Size(343, 170);
            this.GrpListOptions.TabIndex = 25;
            this.GrpListOptions.TabStop = false;
            this.GrpListOptions.Text = "List options";
            // 
            // CboNumericBaseLst
            // 
            this.CboNumericBaseLst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboNumericBaseLst.FormattingEnabled = true;
            this.CboNumericBaseLst.Items.AddRange(new object[] {
            "Hexadecimal",
            "Decimal",
            "Octal",
            "Binary"});
            this.CboNumericBaseLst.Location = new System.Drawing.Point(175, 22);
            this.CboNumericBaseLst.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CboNumericBaseLst.Name = "CboNumericBaseLst";
            this.CboNumericBaseLst.Size = new System.Drawing.Size(160, 23);
            this.CboNumericBaseLst.TabIndex = 1;
            this.CboNumericBaseLst.SelectedIndexChanged += new System.EventHandler(this.CboNumericBaseLst_SelectedIndexChanged);
            // 
            // BtnResetFormat
            // 
            this.BtnResetFormat.Location = new System.Drawing.Point(248, 97);
            this.BtnResetFormat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnResetFormat.Name = "BtnResetFormat";
            this.BtnResetFormat.Size = new System.Drawing.Size(87, 26);
            this.BtnResetFormat.TabIndex = 8;
            this.BtnResetFormat.Text = "Reset format";
            this.BtnResetFormat.UseVisualStyleBackColor = true;
            this.BtnResetFormat.Click += new System.EventHandler(this.BtnResetFormat_Click);
            // 
            // ChkExportSelectedOnly
            // 
            this.ChkExportSelectedOnly.AutoSize = true;
            this.ChkExportSelectedOnly.Location = new System.Drawing.Point(180, 75);
            this.ChkExportSelectedOnly.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ChkExportSelectedOnly.Name = "ChkExportSelectedOnly";
            this.ChkExportSelectedOnly.Size = new System.Drawing.Size(132, 19);
            this.ChkExportSelectedOnly.TabIndex = 5;
            this.ChkExportSelectedOnly.Text = "Export selected only";
            this.ChkExportSelectedOnly.UseVisualStyleBackColor = true;
            // 
            // ChkReverseHashes
            // 
            this.ChkReverseHashes.AutoSize = true;
            this.ChkReverseHashes.Location = new System.Drawing.Point(9, 75);
            this.ChkReverseHashes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ChkReverseHashes.Name = "ChkReverseHashes";
            this.ChkReverseHashes.Size = new System.Drawing.Size(105, 19);
            this.ChkReverseHashes.TabIndex = 4;
            this.ChkReverseHashes.Text = "Reverse hashes";
            this.ChkReverseHashes.UseVisualStyleBackColor = true;
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
            this.CboOrderBy.Location = new System.Drawing.Point(8, 22);
            this.CboOrderBy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CboOrderBy.Name = "CboOrderBy";
            this.CboOrderBy.Size = new System.Drawing.Size(160, 23);
            this.CboOrderBy.TabIndex = 0;
            this.CboOrderBy.SelectedIndexChanged += new System.EventHandler(this.CboOrderBy_SelectedIndexChanged);
            // 
            // ChkIgnoreRepeatedStrings
            // 
            this.ChkIgnoreRepeatedStrings.AutoSize = true;
            this.ChkIgnoreRepeatedStrings.Location = new System.Drawing.Point(180, 51);
            this.ChkIgnoreRepeatedStrings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ChkIgnoreRepeatedStrings.Name = "ChkIgnoreRepeatedStrings";
            this.ChkIgnoreRepeatedStrings.Size = new System.Drawing.Size(147, 19);
            this.ChkIgnoreRepeatedStrings.TabIndex = 3;
            this.ChkIgnoreRepeatedStrings.Text = "Ignore repeated strings";
            this.ChkIgnoreRepeatedStrings.UseVisualStyleBackColor = true;
            // 
            // BtnUpdateList
            // 
            this.BtnUpdateList.Location = new System.Drawing.Point(175, 133);
            this.BtnUpdateList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnUpdateList.Name = "BtnUpdateList";
            this.BtnUpdateList.Size = new System.Drawing.Size(160, 27);
            this.BtnUpdateList.TabIndex = 10;
            this.BtnUpdateList.Text = "Update list";
            this.BtnUpdateList.UseVisualStyleBackColor = true;
            this.BtnUpdateList.Click += new System.EventHandler(this.BtnUpdateList_Click);
            // 
            // BtnExportHashes
            // 
            this.BtnExportHashes.Location = new System.Drawing.Point(8, 133);
            this.BtnExportHashes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnExportHashes.Name = "BtnExportHashes";
            this.BtnExportHashes.Size = new System.Drawing.Size(160, 27);
            this.BtnExportHashes.TabIndex = 9;
            this.BtnExportHashes.Text = "Export hashes";
            this.BtnExportHashes.UseVisualStyleBackColor = true;
            this.BtnExportHashes.Click += new System.EventHandler(this.BtnExportHashes_Click);
            // 
            // ChkIgnoreRepeatedHashes
            // 
            this.ChkIgnoreRepeatedHashes.AutoSize = true;
            this.ChkIgnoreRepeatedHashes.Location = new System.Drawing.Point(9, 51);
            this.ChkIgnoreRepeatedHashes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ChkIgnoreRepeatedHashes.Name = "ChkIgnoreRepeatedHashes";
            this.ChkIgnoreRepeatedHashes.Size = new System.Drawing.Size(148, 19);
            this.ChkIgnoreRepeatedHashes.TabIndex = 2;
            this.ChkIgnoreRepeatedHashes.Text = "Ignore repeated hashes";
            this.ChkIgnoreRepeatedHashes.UseVisualStyleBackColor = true;
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(364, 42);
            this.BtnStart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(107, 27);
            this.BtnStart.TabIndex = 7;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.Location = new System.Drawing.Point(364, 75);
            this.BtnStop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(107, 27);
            this.BtnStop.TabIndex = 8;
            this.BtnStop.Text = "Stop";
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(364, 108);
            this.BtnClear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(107, 27);
            this.BtnClear.TabIndex = 9;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // ChkUseHashesFile
            // 
            this.ChkUseHashesFile.AutoSize = true;
            this.ChkUseHashesFile.Location = new System.Drawing.Point(896, 409);
            this.ChkUseHashesFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ChkUseHashesFile.Name = "ChkUseHashesFile";
            this.ChkUseHashesFile.Size = new System.Drawing.Size(108, 19);
            this.ChkUseHashesFile.TabIndex = 20;
            this.ChkUseHashesFile.Text = "Use hashes files";
            this.ChkUseHashesFile.UseVisualStyleBackColor = true;
            this.ChkUseHashesFile.CheckedChanged += new System.EventHandler(this.ChkUseHashesFile_CheckedChanged);
            // 
            // BtnGenerateListOfHashes
            // 
            this.BtnGenerateListOfHashes.Location = new System.Drawing.Point(718, 404);
            this.BtnGenerateListOfHashes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnGenerateListOfHashes.Name = "BtnGenerateListOfHashes";
            this.BtnGenerateListOfHashes.Size = new System.Drawing.Size(171, 27);
            this.BtnGenerateListOfHashes.TabIndex = 19;
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
            this.GrpStats.Location = new System.Drawing.Point(712, 541);
            this.GrpStats.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GrpStats.Name = "GrpStats";
            this.GrpStats.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GrpStats.Size = new System.Drawing.Size(306, 85);
            this.GrpStats.TabIndex = 24;
            this.GrpStats.TabStop = false;
            this.GrpStats.Text = "Stats";
            // 
            // LblTotalHashes
            // 
            this.LblTotalHashes.AutoSize = true;
            this.LblTotalHashes.Location = new System.Drawing.Point(124, 58);
            this.LblTotalHashes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTotalHashes.Name = "LblTotalHashes";
            this.LblTotalHashes.Size = new System.Drawing.Size(13, 15);
            this.LblTotalHashes.TabIndex = 5;
            this.LblTotalHashes.Text = "0";
            // 
            // LblUnknownHashes
            // 
            this.LblUnknownHashes.AutoSize = true;
            this.LblUnknownHashes.Location = new System.Drawing.Point(124, 37);
            this.LblUnknownHashes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblUnknownHashes.Name = "LblUnknownHashes";
            this.LblUnknownHashes.Size = new System.Drawing.Size(13, 15);
            this.LblUnknownHashes.TabIndex = 3;
            this.LblUnknownHashes.Text = "0";
            // 
            // LblKnownHashes
            // 
            this.LblKnownHashes.AutoSize = true;
            this.LblKnownHashes.Location = new System.Drawing.Point(124, 16);
            this.LblKnownHashes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblKnownHashes.Name = "LblKnownHashes";
            this.LblKnownHashes.Size = new System.Drawing.Size(13, 15);
            this.LblKnownHashes.TabIndex = 1;
            this.LblKnownHashes.Text = "0";
            // 
            // LblTextKnownHashes
            // 
            this.LblTextKnownHashes.AutoSize = true;
            this.LblTextKnownHashes.Location = new System.Drawing.Point(4, 16);
            this.LblTextKnownHashes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTextKnownHashes.Name = "LblTextKnownHashes";
            this.LblTextKnownHashes.Size = new System.Drawing.Size(86, 15);
            this.LblTextKnownHashes.TabIndex = 0;
            this.LblTextKnownHashes.Text = "Known hashes:";
            // 
            // LblTextUnknownHashes
            // 
            this.LblTextUnknownHashes.AutoSize = true;
            this.LblTextUnknownHashes.Location = new System.Drawing.Point(4, 37);
            this.LblTextUnknownHashes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTextUnknownHashes.Name = "LblTextUnknownHashes";
            this.LblTextUnknownHashes.Size = new System.Drawing.Size(100, 15);
            this.LblTextUnknownHashes.TabIndex = 2;
            this.LblTextUnknownHashes.Text = "Unknown hashes:";
            // 
            // LblTextTotalHashes
            // 
            this.LblTextTotalHashes.AutoSize = true;
            this.LblTextTotalHashes.Location = new System.Drawing.Point(4, 58);
            this.LblTextTotalHashes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTextTotalHashes.Name = "LblTextTotalHashes";
            this.LblTextTotalHashes.Size = new System.Drawing.Size(88, 15);
            this.LblTextTotalHashes.TabIndex = 4;
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
            this.GrpBruteforceOptions.Location = new System.Drawing.Point(705, 268);
            this.GrpBruteforceOptions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GrpBruteforceOptions.Name = "GrpBruteforceOptions";
            this.GrpBruteforceOptions.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GrpBruteforceOptions.Size = new System.Drawing.Size(313, 130);
            this.GrpBruteforceOptions.TabIndex = 18;
            this.GrpBruteforceOptions.TabStop = false;
            this.GrpBruteforceOptions.Text = "Bruteforce options";
            // 
            // NumericProcessorsCount
            // 
            this.NumericProcessorsCount.Location = new System.Drawing.Point(254, 74);
            this.NumericProcessorsCount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
            this.NumericProcessorsCount.Size = new System.Drawing.Size(48, 23);
            this.NumericProcessorsCount.TabIndex = 7;
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
            this.LblBruteforceOptionsProcessors.Location = new System.Drawing.Point(186, 76);
            this.LblBruteforceOptionsProcessors.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblBruteforceOptionsProcessors.Name = "LblBruteforceOptionsProcessors";
            this.LblBruteforceOptionsProcessors.Size = new System.Drawing.Size(63, 15);
            this.LblBruteforceOptionsProcessors.TabIndex = 6;
            this.LblBruteforceOptionsProcessors.Text = "Processors";
            // 
            // NumericMaxVariations
            // 
            this.NumericMaxVariations.Location = new System.Drawing.Point(131, 74);
            this.NumericMaxVariations.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NumericMaxVariations.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericMaxVariations.Name = "NumericMaxVariations";
            this.NumericMaxVariations.Size = new System.Drawing.Size(48, 23);
            this.NumericMaxVariations.TabIndex = 5;
            this.NumericMaxVariations.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.NumericMaxVariations.Leave += new System.EventHandler(this.NumericMaxVariations_Leave);
            // 
            // NumericMinVariations
            // 
            this.NumericMinVariations.Location = new System.Drawing.Point(37, 74);
            this.NumericMinVariations.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NumericMinVariations.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericMinVariations.Name = "NumericMinVariations";
            this.NumericMinVariations.Size = new System.Drawing.Size(48, 23);
            this.NumericMinVariations.TabIndex = 3;
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
            this.ChkBruteforceWithRepetition.Location = new System.Drawing.Point(142, 104);
            this.ChkBruteforceWithRepetition.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ChkBruteforceWithRepetition.Name = "ChkBruteforceWithRepetition";
            this.ChkBruteforceWithRepetition.Size = new System.Drawing.Size(157, 19);
            this.ChkBruteforceWithRepetition.TabIndex = 9;
            this.ChkBruteforceWithRepetition.Text = "Variations with repetition";
            this.ChkBruteforceWithRepetition.UseVisualStyleBackColor = true;
            this.ChkBruteforceWithRepetition.CheckedChanged += new System.EventHandler(this.ChkBruteforceWithRepetition_CheckedChanged);
            // 
            // ChkTryToBruteforce
            // 
            this.ChkTryToBruteforce.AutoSize = true;
            this.ChkTryToBruteforce.Location = new System.Drawing.Point(9, 104);
            this.ChkTryToBruteforce.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ChkTryToBruteforce.Name = "ChkTryToBruteforce";
            this.ChkTryToBruteforce.Size = new System.Drawing.Size(113, 19);
            this.ChkTryToBruteforce.TabIndex = 8;
            this.ChkTryToBruteforce.Text = "Try to bruteforce";
            this.ChkTryToBruteforce.UseVisualStyleBackColor = true;
            this.ChkTryToBruteforce.CheckedChanged += new System.EventHandler(this.ChkTryToBruteforce_CheckedChanged);
            // 
            // LblWordsBetweenVariations
            // 
            this.LblWordsBetweenVariations.AutoSize = true;
            this.LblWordsBetweenVariations.Location = new System.Drawing.Point(6, 18);
            this.LblWordsBetweenVariations.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblWordsBetweenVariations.Name = "LblWordsBetweenVariations";
            this.LblWordsBetweenVariations.Size = new System.Drawing.Size(143, 15);
            this.LblWordsBetweenVariations.TabIndex = 0;
            this.LblWordsBetweenVariations.Text = "Words between variations";
            this.ToolTipNFSRaider.SetToolTip(this.LblWordsBetweenVariations, "Use comma (,) to separate each word between variations.\r\nIf you want to use comma" +
        " (,) you must escape it (\\,). Same goes for backslash (\\), you must escape it (\\" +
        "\\).");
            // 
            // LblBruteforceOptionsMax
            // 
            this.LblBruteforceOptionsMax.AutoSize = true;
            this.LblBruteforceOptionsMax.Location = new System.Drawing.Point(96, 76);
            this.LblBruteforceOptionsMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblBruteforceOptionsMax.Name = "LblBruteforceOptionsMax";
            this.LblBruteforceOptionsMax.Size = new System.Drawing.Size(30, 15);
            this.LblBruteforceOptionsMax.TabIndex = 4;
            this.LblBruteforceOptionsMax.Text = "Max";
            // 
            // LblBruteforceOptionsMin
            // 
            this.LblBruteforceOptionsMin.AutoSize = true;
            this.LblBruteforceOptionsMin.Location = new System.Drawing.Point(7, 76);
            this.LblBruteforceOptionsMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblBruteforceOptionsMin.Name = "LblBruteforceOptionsMin";
            this.LblBruteforceOptionsMin.Size = new System.Drawing.Size(28, 15);
            this.LblBruteforceOptionsMin.TabIndex = 2;
            this.LblBruteforceOptionsMin.Text = "Min";
            // 
            // TxtWordsBetweenVariations
            // 
            this.TxtWordsBetweenVariations.Location = new System.Drawing.Point(7, 37);
            this.TxtWordsBetweenVariations.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtWordsBetweenVariations.MaxLength = 2147483647;
            this.TxtWordsBetweenVariations.Name = "TxtWordsBetweenVariations";
            this.TxtWordsBetweenVariations.Size = new System.Drawing.Size(294, 23);
            this.TxtWordsBetweenVariations.TabIndex = 1;
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(14, 12);
            this.TxtSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(228, 23);
            this.TxtSearch.TabIndex = 1;
            // 
            // BtnSearchPrevious
            // 
            this.BtnSearchPrevious.Location = new System.Drawing.Point(14, 42);
            this.BtnSearchPrevious.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnSearchPrevious.Name = "BtnSearchPrevious";
            this.BtnSearchPrevious.Size = new System.Drawing.Size(110, 27);
            this.BtnSearchPrevious.TabIndex = 3;
            this.BtnSearchPrevious.Text = "Previous";
            this.BtnSearchPrevious.UseVisualStyleBackColor = true;
            this.BtnSearchPrevious.Click += new System.EventHandler(this.BtnSearchPrevious_Click);
            // 
            // BtnSearchNext
            // 
            this.BtnSearchNext.Location = new System.Drawing.Point(130, 42);
            this.BtnSearchNext.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnSearchNext.Name = "BtnSearchNext";
            this.BtnSearchNext.Size = new System.Drawing.Size(112, 27);
            this.BtnSearchNext.TabIndex = 4;
            this.BtnSearchNext.Text = "Next";
            this.BtnSearchNext.UseVisualStyleBackColor = true;
            this.BtnSearchNext.Click += new System.EventHandler(this.BtnSearchNext_Click);
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Location = new System.Drawing.Point(10, 630);
            this.LblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(84, 15);
            this.LblStatus.TabIndex = 26;
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
            this.CboForceHashListCase.Location = new System.Drawing.Point(718, 438);
            this.CboForceHashListCase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CboForceHashListCase.Name = "CboForceHashListCase";
            this.CboForceHashListCase.Size = new System.Drawing.Size(171, 23);
            this.CboForceHashListCase.TabIndex = 21;
            this.CboForceHashListCase.SelectedIndexChanged += new System.EventHandler(this.CboForceHashListCase_SelectedIndexChanged);
            // 
            // LblTimeElapsed
            // 
            this.LblTimeElapsed.Location = new System.Drawing.Point(788, 630);
            this.LblTimeElapsed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTimeElapsed.Name = "LblTimeElapsed";
            this.LblTimeElapsed.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblTimeElapsed.Size = new System.Drawing.Size(233, 15);
            this.LblTimeElapsed.TabIndex = 27;
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
            this.BtnSearchAll.Location = new System.Drawing.Point(247, 42);
            this.BtnSearchAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnSearchAll.Name = "BtnSearchAll";
            this.BtnSearchAll.Size = new System.Drawing.Size(110, 27);
            this.BtnSearchAll.TabIndex = 5;
            this.BtnSearchAll.Text = "All";
            this.BtnSearchAll.UseVisualStyleBackColor = true;
            this.BtnSearchAll.Click += new System.EventHandler(this.BtnSearchAll_Click);
            // 
            // CboRaiderMode
            // 
            this.CboRaiderMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboRaiderMode.FormattingEnabled = true;
            this.CboRaiderMode.Items.AddRange(new object[] {
            "Unhasher",
            "Hasher"});
            this.CboRaiderMode.Location = new System.Drawing.Point(364, 142);
            this.CboRaiderMode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CboRaiderMode.Name = "CboRaiderMode";
            this.CboRaiderMode.Size = new System.Drawing.Size(107, 23);
            this.CboRaiderMode.TabIndex = 10;
            this.CboRaiderMode.SelectedIndexChanged += new System.EventHandler(this.CboRaiderMode_SelectedIndexChanged);
            // 
            // ChkCaseSensitive
            // 
            this.ChkCaseSensitive.AutoSize = true;
            this.ChkCaseSensitive.Location = new System.Drawing.Point(250, 14);
            this.ChkCaseSensitive.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ChkCaseSensitive.Name = "ChkCaseSensitive";
            this.ChkCaseSensitive.Size = new System.Drawing.Size(99, 19);
            this.ChkCaseSensitive.TabIndex = 2;
            this.ChkCaseSensitive.Text = "Case sensitive";
            this.ChkCaseSensitive.UseVisualStyleBackColor = true;
            this.ChkCaseSensitive.CheckedChanged += new System.EventHandler(this.ChkCaseSensitive_CheckedChanged);
            // 
            // NFSRaiderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 647);
            this.Controls.Add(this.CboRaiderMode);
            this.Controls.Add(this.LblTimeElapsed);
            this.Controls.Add(this.ChkCaseSensitive);
            this.Controls.Add(this.CboForceHashListCase);
            this.Controls.Add(this.LblStatus);
            this.Controls.Add(this.GrpBruteforceOptions);
            this.Controls.Add(this.BtnSearchAll);
            this.Controls.Add(this.GrpStats);
            this.Controls.Add(this.BtnGenerateListOfHashes);
            this.Controls.Add(this.ChkUseHashesFile);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.BtnSearchNext);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.GrpListOptions);
            this.Controls.Add(this.BtnSearchPrevious);
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
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "NFSRaiderForm";
            this.Text = "NFS-Raider";
            this.GrpLoadOptions.ResumeLayout(false);
            this.TabLoadOptions.ResumeLayout(false);
            this.TabPageFromFile.ResumeLayout(false);
            this.TabPageFromFile.PerformLayout();
            this.TabPageFromText.ResumeLayout(false);
            this.TabPageFromText.PerformLayout();
            this.GrpHashingOptions.ResumeLayout(false);
            this.GrpListOptions.ResumeLayout(false);
            this.GrpListOptions.PerformLayout();
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
        private System.Windows.Forms.GroupBox GrpHashingOptions;
        private System.Windows.Forms.TextBox TxtPrefixes;
        private System.Windows.Forms.TextBox TxtVariations;
        private System.Windows.Forms.TextBox TxtSuffixes;
        private System.Windows.Forms.Label LblPrefixes;
        private System.Windows.Forms.Label LblSuffixes;
        private System.Windows.Forms.Label LblVariations;
        private System.Windows.Forms.Label LblExportOptionsExportFormat;
        private System.Windows.Forms.TextBox TxtExportFormat;
        private System.Windows.Forms.GroupBox GrpListOptions;
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
        private System.Windows.Forms.TabControl TabLoadOptions;
        private System.Windows.Forms.TabPage TabPageFromFile;
        private System.Windows.Forms.TabPage TabPageFromText;
        private System.Windows.Forms.ComboBox CboRaiderMode;
        private System.Windows.Forms.CheckBox ChkCaseSensitive;
        private System.Windows.Forms.Button BtnResetFormat;
        private System.Windows.Forms.CheckBox ChkExportSelectedOnly;
        private System.Windows.Forms.ComboBox CboNumericBase;
        private System.Windows.Forms.ComboBox CboNumericBaseLst;
    }
}

