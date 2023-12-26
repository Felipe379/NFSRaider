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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NFSRaiderForm));
            LstUnhashed = new System.Windows.Forms.ListBox();
            BtnLoadFile = new System.Windows.Forms.Button();
            TxtLoadFromText = new System.Windows.Forms.TextBox();
            GrpLoadOptions = new System.Windows.Forms.GroupBox();
            TabLoadOptions = new System.Windows.Forms.TabControl();
            TabPageFromFile = new System.Windows.Forms.TabPage();
            TxtFileReadHashes = new System.Windows.Forms.TextBox();
            LblReadHashes = new System.Windows.Forms.Label();
            LblStartOffset = new System.Windows.Forms.Label();
            TxtFileSkipHashes = new System.Windows.Forms.TextBox();
            LblEndOffset = new System.Windows.Forms.Label();
            LblSkipHashes = new System.Windows.Forms.Label();
            TxtFileStartOffset = new System.Windows.Forms.TextBox();
            TxtFileEndOffset = new System.Windows.Forms.TextBox();
            TabPageFromText = new System.Windows.Forms.TabPage();
            CboNumericBase = new System.Windows.Forms.ComboBox();
            GrpHashingOptions = new System.Windows.Forms.GroupBox();
            CboHashTypes = new System.Windows.Forms.ComboBox();
            CboEndianness = new System.Windows.Forms.ComboBox();
            TxtPrefixes = new System.Windows.Forms.TextBox();
            TxtVariations = new System.Windows.Forms.TextBox();
            TxtSuffixes = new System.Windows.Forms.TextBox();
            LblPrefixes = new System.Windows.Forms.Label();
            LblSuffixes = new System.Windows.Forms.Label();
            LblVariations = new System.Windows.Forms.Label();
            LblExportOptionsExportFormat = new System.Windows.Forms.Label();
            TxtExportFormat = new System.Windows.Forms.TextBox();
            GrpListOptions = new System.Windows.Forms.GroupBox();
            CboNumericBaseLst = new System.Windows.Forms.ComboBox();
            BtnResetFormat = new System.Windows.Forms.Button();
            ChkExportSelectedOnly = new System.Windows.Forms.CheckBox();
            ChkReverseHashes = new System.Windows.Forms.CheckBox();
            CboOrderBy = new System.Windows.Forms.ComboBox();
            ChkIgnoreRepeatedStrings = new System.Windows.Forms.CheckBox();
            BtnUpdateList = new System.Windows.Forms.Button();
            BtnExportHashes = new System.Windows.Forms.Button();
            ChkIgnoreRepeatedHashes = new System.Windows.Forms.CheckBox();
            BtnStartStop = new System.Windows.Forms.Button();
            BtnClear = new System.Windows.Forms.Button();
            ChkUseMainKeys = new System.Windows.Forms.CheckBox();
            BtnGenerateKeyList = new System.Windows.Forms.Button();
            GrpStats = new System.Windows.Forms.GroupBox();
            LblTotalHashes = new System.Windows.Forms.Label();
            LblUnknownHashes = new System.Windows.Forms.Label();
            LblKnownHashes = new System.Windows.Forms.Label();
            LblTextKnownHashes = new System.Windows.Forms.Label();
            LblTextUnknownHashes = new System.Windows.Forms.Label();
            LblTextTotalHashes = new System.Windows.Forms.Label();
            GrpBruteforceOptions = new System.Windows.Forms.GroupBox();
            NumericProcessorsCount = new System.Windows.Forms.NumericUpDown();
            LblBruteforceOptionsProcessors = new System.Windows.Forms.Label();
            NumericMaxVariations = new System.Windows.Forms.NumericUpDown();
            NumericMinVariations = new System.Windows.Forms.NumericUpDown();
            ChkBruteforceWithRepetition = new System.Windows.Forms.CheckBox();
            ChkTryToBruteforce = new System.Windows.Forms.CheckBox();
            LblWordsBetweenVariations = new System.Windows.Forms.Label();
            LblBruteforceOptionsMax = new System.Windows.Forms.Label();
            LblBruteforceOptionsMin = new System.Windows.Forms.Label();
            TxtWordsBetweenVariations = new System.Windows.Forms.TextBox();
            TxtSearch = new System.Windows.Forms.TextBox();
            BtnSearchPrevious = new System.Windows.Forms.Button();
            BtnSearchNext = new System.Windows.Forms.Button();
            LblStatus = new System.Windows.Forms.Label();
            CboForceHashListCase = new System.Windows.Forms.ComboBox();
            LblTimeElapsed = new System.Windows.Forms.Label();
            ToolTipNFSRaider = new System.Windows.Forms.ToolTip(components);
            BtnSearchAll = new System.Windows.Forms.Button();
            CboRaiderMode = new System.Windows.Forms.ComboBox();
            ChkCaseSensitive = new System.Windows.Forms.CheckBox();
            ChkUseUserKeys = new System.Windows.Forms.CheckBox();
            GrpLoadOptions.SuspendLayout();
            TabLoadOptions.SuspendLayout();
            TabPageFromFile.SuspendLayout();
            TabPageFromText.SuspendLayout();
            GrpHashingOptions.SuspendLayout();
            GrpListOptions.SuspendLayout();
            GrpStats.SuspendLayout();
            GrpBruteforceOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumericProcessorsCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumericMaxVariations).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumericMinVariations).BeginInit();
            SuspendLayout();
            // 
            // LstUnhashed
            // 
            LstUnhashed.FormattingEnabled = true;
            LstUnhashed.HorizontalScrollbar = true;
            LstUnhashed.ItemHeight = 15;
            LstUnhashed.Location = new System.Drawing.Point(14, 74);
            LstUnhashed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            LstUnhashed.Name = "LstUnhashed";
            LstUnhashed.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            LstUnhashed.Size = new System.Drawing.Size(342, 379);
            LstUnhashed.TabIndex = 6;
            LstUnhashed.KeyDown += LstUnhashed_KeyDown;
            // 
            // BtnLoadFile
            // 
            BtnLoadFile.Location = new System.Drawing.Point(7, 7);
            BtnLoadFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            BtnLoadFile.Name = "BtnLoadFile";
            BtnLoadFile.Size = new System.Drawing.Size(144, 27);
            BtnLoadFile.TabIndex = 0;
            BtnLoadFile.Text = "Load file";
            BtnLoadFile.UseVisualStyleBackColor = true;
            BtnLoadFile.Click += BtnLoadFile_Click;
            // 
            // TxtLoadFromText
            // 
            TxtLoadFromText.Location = new System.Drawing.Point(7, 35);
            TxtLoadFromText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TxtLoadFromText.MaxLength = 2147483646;
            TxtLoadFromText.Multiline = true;
            TxtLoadFromText.Name = "TxtLoadFromText";
            TxtLoadFromText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            TxtLoadFromText.Size = new System.Drawing.Size(296, 262);
            TxtLoadFromText.TabIndex = 1;
            // 
            // GrpLoadOptions
            // 
            GrpLoadOptions.Controls.Add(TabLoadOptions);
            GrpLoadOptions.Location = new System.Drawing.Point(364, 268);
            GrpLoadOptions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            GrpLoadOptions.Name = "GrpLoadOptions";
            GrpLoadOptions.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            GrpLoadOptions.Size = new System.Drawing.Size(334, 359);
            GrpLoadOptions.TabIndex = 17;
            GrpLoadOptions.TabStop = false;
            GrpLoadOptions.Text = "Load options";
            // 
            // TabLoadOptions
            // 
            TabLoadOptions.Controls.Add(TabPageFromFile);
            TabLoadOptions.Controls.Add(TabPageFromText);
            TabLoadOptions.Location = new System.Drawing.Point(7, 22);
            TabLoadOptions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TabLoadOptions.Name = "TabLoadOptions";
            TabLoadOptions.SelectedIndex = 0;
            TabLoadOptions.Size = new System.Drawing.Size(320, 331);
            TabLoadOptions.TabIndex = 0;
            TabLoadOptions.SelectedIndexChanged += TabLoadOptions_SelectedIndexChanged;
            // 
            // TabPageFromFile
            // 
            TabPageFromFile.Controls.Add(TxtFileReadHashes);
            TabPageFromFile.Controls.Add(BtnLoadFile);
            TabPageFromFile.Controls.Add(LblReadHashes);
            TabPageFromFile.Controls.Add(LblStartOffset);
            TabPageFromFile.Controls.Add(TxtFileSkipHashes);
            TabPageFromFile.Controls.Add(LblEndOffset);
            TabPageFromFile.Controls.Add(LblSkipHashes);
            TabPageFromFile.Controls.Add(TxtFileStartOffset);
            TabPageFromFile.Controls.Add(TxtFileEndOffset);
            TabPageFromFile.Location = new System.Drawing.Point(4, 24);
            TabPageFromFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TabPageFromFile.Name = "TabPageFromFile";
            TabPageFromFile.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TabPageFromFile.Size = new System.Drawing.Size(312, 303);
            TabPageFromFile.TabIndex = 0;
            TabPageFromFile.Text = "File";
            TabPageFromFile.UseVisualStyleBackColor = true;
            // 
            // TxtFileReadHashes
            // 
            TxtFileReadHashes.Location = new System.Drawing.Point(7, 148);
            TxtFileReadHashes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TxtFileReadHashes.Name = "TxtFileReadHashes";
            TxtFileReadHashes.Size = new System.Drawing.Size(144, 23);
            TxtFileReadHashes.TabIndex = 6;
            TxtFileReadHashes.Text = "0";
            TxtFileReadHashes.Leave += TxtFileReadHashes_Leave;
            // 
            // LblReadHashes
            // 
            LblReadHashes.AutoSize = true;
            LblReadHashes.Location = new System.Drawing.Point(4, 129);
            LblReadHashes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LblReadHashes.Name = "LblReadHashes";
            LblReadHashes.Size = new System.Drawing.Size(72, 15);
            LblReadHashes.TabIndex = 5;
            LblReadHashes.Text = "Read hashes";
            // 
            // LblStartOffset
            // 
            LblStartOffset.AutoSize = true;
            LblStartOffset.Location = new System.Drawing.Point(4, 37);
            LblStartOffset.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LblStartOffset.Name = "LblStartOffset";
            LblStartOffset.Size = new System.Drawing.Size(64, 15);
            LblStartOffset.TabIndex = 1;
            LblStartOffset.Text = "Start offset";
            // 
            // TxtFileSkipHashes
            // 
            TxtFileSkipHashes.Location = new System.Drawing.Point(6, 195);
            TxtFileSkipHashes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TxtFileSkipHashes.Name = "TxtFileSkipHashes";
            TxtFileSkipHashes.Size = new System.Drawing.Size(144, 23);
            TxtFileSkipHashes.TabIndex = 8;
            TxtFileSkipHashes.Text = "0";
            TxtFileSkipHashes.TextChanged += TxtFileSkipHashes_TextChanged;
            // 
            // LblEndOffset
            // 
            LblEndOffset.AutoSize = true;
            LblEndOffset.Location = new System.Drawing.Point(4, 84);
            LblEndOffset.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LblEndOffset.Name = "LblEndOffset";
            LblEndOffset.Size = new System.Drawing.Size(60, 15);
            LblEndOffset.TabIndex = 3;
            LblEndOffset.Text = "End offset";
            // 
            // LblSkipHashes
            // 
            LblSkipHashes.AutoSize = true;
            LblSkipHashes.Location = new System.Drawing.Point(4, 177);
            LblSkipHashes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LblSkipHashes.Name = "LblSkipHashes";
            LblSkipHashes.Size = new System.Drawing.Size(68, 15);
            LblSkipHashes.TabIndex = 7;
            LblSkipHashes.Text = "Skip hashes";
            // 
            // TxtFileStartOffset
            // 
            TxtFileStartOffset.Location = new System.Drawing.Point(7, 58);
            TxtFileStartOffset.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TxtFileStartOffset.Name = "TxtFileStartOffset";
            TxtFileStartOffset.Size = new System.Drawing.Size(144, 23);
            TxtFileStartOffset.TabIndex = 2;
            TxtFileStartOffset.Text = "0";
            TxtFileStartOffset.Leave += TxtFileStartOffset_Leave;
            // 
            // TxtFileEndOffset
            // 
            TxtFileEndOffset.Location = new System.Drawing.Point(7, 103);
            TxtFileEndOffset.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TxtFileEndOffset.Name = "TxtFileEndOffset";
            TxtFileEndOffset.Size = new System.Drawing.Size(144, 23);
            TxtFileEndOffset.TabIndex = 4;
            TxtFileEndOffset.Text = "0";
            TxtFileEndOffset.Leave += TxtFileEndOffset_Leave;
            // 
            // TabPageFromText
            // 
            TabPageFromText.Controls.Add(CboNumericBase);
            TabPageFromText.Controls.Add(TxtLoadFromText);
            TabPageFromText.Location = new System.Drawing.Point(4, 24);
            TabPageFromText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TabPageFromText.Name = "TabPageFromText";
            TabPageFromText.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TabPageFromText.Size = new System.Drawing.Size(312, 303);
            TabPageFromText.TabIndex = 1;
            TabPageFromText.Text = "Text";
            TabPageFromText.UseVisualStyleBackColor = true;
            // 
            // CboNumericBase
            // 
            CboNumericBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CboNumericBase.FormattingEnabled = true;
            CboNumericBase.Items.AddRange(new object[] { "Hexadecimal", "Decimal", "Octal", "Binary" });
            CboNumericBase.Location = new System.Drawing.Point(8, 6);
            CboNumericBase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            CboNumericBase.Name = "CboNumericBase";
            CboNumericBase.Size = new System.Drawing.Size(295, 23);
            CboNumericBase.TabIndex = 0;
            CboNumericBase.SelectedIndexChanged += CboNumericBase_SelectedIndexChanged;
            // 
            // GrpHashingOptions
            // 
            GrpHashingOptions.Controls.Add(CboHashTypes);
            GrpHashingOptions.Controls.Add(CboEndianness);
            GrpHashingOptions.Location = new System.Drawing.Point(710, 468);
            GrpHashingOptions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            GrpHashingOptions.Name = "GrpHashingOptions";
            GrpHashingOptions.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            GrpHashingOptions.Size = new System.Drawing.Size(307, 62);
            GrpHashingOptions.TabIndex = 23;
            GrpHashingOptions.TabStop = false;
            GrpHashingOptions.Text = "Hashing options";
            // 
            // CboHashTypes
            // 
            CboHashTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CboHashTypes.FormattingEnabled = true;
            CboHashTypes.Items.AddRange(new object[] { "BinHash", "VltHash", "VltBinHash", "VltVltHash" });
            CboHashTypes.Location = new System.Drawing.Point(187, 22);
            CboHashTypes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            CboHashTypes.Name = "CboHashTypes";
            CboHashTypes.Size = new System.Drawing.Size(112, 23);
            CboHashTypes.TabIndex = 1;
            CboHashTypes.SelectedIndexChanged += CboHashTypes_SelectedIndexChanged;
            // 
            // CboEndianness
            // 
            CboEndianness.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CboEndianness.FormattingEnabled = true;
            CboEndianness.Items.AddRange(new object[] { "Big-endian (file)", "Little-endian (memory)" });
            CboEndianness.Location = new System.Drawing.Point(8, 22);
            CboEndianness.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            CboEndianness.Name = "CboEndianness";
            CboEndianness.Size = new System.Drawing.Size(171, 23);
            CboEndianness.TabIndex = 0;
            CboEndianness.SelectedIndexChanged += CboEndianness_SelectedIndexChanged;
            // 
            // TxtPrefixes
            // 
            TxtPrefixes.AccessibleDescription = "";
            TxtPrefixes.AccessibleName = "";
            TxtPrefixes.Location = new System.Drawing.Point(478, 42);
            TxtPrefixes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TxtPrefixes.MaxLength = 2147483646;
            TxtPrefixes.Multiline = true;
            TxtPrefixes.Name = "TxtPrefixes";
            TxtPrefixes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            TxtPrefixes.Size = new System.Drawing.Size(174, 219);
            TxtPrefixes.TabIndex = 12;
            // 
            // TxtVariations
            // 
            TxtVariations.Location = new System.Drawing.Point(660, 42);
            TxtVariations.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TxtVariations.MaxLength = 2147483646;
            TxtVariations.Multiline = true;
            TxtVariations.Name = "TxtVariations";
            TxtVariations.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            TxtVariations.Size = new System.Drawing.Size(174, 219);
            TxtVariations.TabIndex = 14;
            TxtVariations.Text = "A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z,a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z,0,1,2,3,4,5,6,7,8,9,_, ,!,\",#,$,%,&,',(,),*,+,-,.,/,:,;,<,=,>,?,@,[,\\\\,],^,`,{,|,},~,\\,";
            // 
            // TxtSuffixes
            // 
            TxtSuffixes.Location = new System.Drawing.Point(842, 42);
            TxtSuffixes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TxtSuffixes.MaxLength = 2147483646;
            TxtSuffixes.Multiline = true;
            TxtSuffixes.Name = "TxtSuffixes";
            TxtSuffixes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            TxtSuffixes.Size = new System.Drawing.Size(174, 219);
            TxtSuffixes.TabIndex = 16;
            // 
            // LblPrefixes
            // 
            LblPrefixes.AutoSize = true;
            LblPrefixes.Location = new System.Drawing.Point(475, 23);
            LblPrefixes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LblPrefixes.Name = "LblPrefixes";
            LblPrefixes.Size = new System.Drawing.Size(48, 15);
            LblPrefixes.TabIndex = 11;
            LblPrefixes.Text = "Prefixes";
            ToolTipNFSRaider.SetToolTip(LblPrefixes, "Use comma (,) to separate each prefix.\r\nIf you want to use comma (,) you must escape it (\\,). Same goes for backslash (\\), you must escape it (\\\\).");
            // 
            // LblSuffixes
            // 
            LblSuffixes.AutoSize = true;
            LblSuffixes.Location = new System.Drawing.Point(839, 23);
            LblSuffixes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LblSuffixes.Name = "LblSuffixes";
            LblSuffixes.Size = new System.Drawing.Size(48, 15);
            LblSuffixes.TabIndex = 15;
            LblSuffixes.Text = "Suffixes";
            ToolTipNFSRaider.SetToolTip(LblSuffixes, "Use comma (,) to separate each suffix.\r\nIf you want to use comma (,) you must escape it (\\,). Same goes for backslash (\\), you must escape it (\\\\).");
            // 
            // LblVariations
            // 
            LblVariations.AutoSize = true;
            LblVariations.Location = new System.Drawing.Point(657, 23);
            LblVariations.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LblVariations.Name = "LblVariations";
            LblVariations.Size = new System.Drawing.Size(58, 15);
            LblVariations.TabIndex = 13;
            LblVariations.Text = "Variations";
            ToolTipNFSRaider.SetToolTip(LblVariations, resources.GetString("LblVariations.ToolTip"));
            // 
            // LblExportOptionsExportFormat
            // 
            LblExportOptionsExportFormat.AutoSize = true;
            LblExportOptionsExportFormat.Location = new System.Drawing.Point(9, 103);
            LblExportOptionsExportFormat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LblExportOptionsExportFormat.Name = "LblExportOptionsExportFormat";
            LblExportOptionsExportFormat.Size = new System.Drawing.Size(80, 15);
            LblExportOptionsExportFormat.TabIndex = 6;
            LblExportOptionsExportFormat.Text = "Export format";
            // 
            // TxtExportFormat
            // 
            TxtExportFormat.Location = new System.Drawing.Point(94, 99);
            TxtExportFormat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TxtExportFormat.Name = "TxtExportFormat";
            TxtExportFormat.Size = new System.Drawing.Size(146, 23);
            TxtExportFormat.TabIndex = 7;
            TxtExportFormat.Text = "0x(HASH) - (STRING)";
            // 
            // GrpListOptions
            // 
            GrpListOptions.Controls.Add(CboNumericBaseLst);
            GrpListOptions.Controls.Add(BtnResetFormat);
            GrpListOptions.Controls.Add(ChkExportSelectedOnly);
            GrpListOptions.Controls.Add(ChkReverseHashes);
            GrpListOptions.Controls.Add(CboOrderBy);
            GrpListOptions.Controls.Add(ChkIgnoreRepeatedStrings);
            GrpListOptions.Controls.Add(BtnUpdateList);
            GrpListOptions.Controls.Add(BtnExportHashes);
            GrpListOptions.Controls.Add(ChkIgnoreRepeatedHashes);
            GrpListOptions.Controls.Add(TxtExportFormat);
            GrpListOptions.Controls.Add(LblExportOptionsExportFormat);
            GrpListOptions.Location = new System.Drawing.Point(14, 457);
            GrpListOptions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            GrpListOptions.Name = "GrpListOptions";
            GrpListOptions.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            GrpListOptions.Size = new System.Drawing.Size(343, 170);
            GrpListOptions.TabIndex = 25;
            GrpListOptions.TabStop = false;
            GrpListOptions.Text = "List options";
            // 
            // CboNumericBaseLst
            // 
            CboNumericBaseLst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CboNumericBaseLst.FormattingEnabled = true;
            CboNumericBaseLst.Items.AddRange(new object[] { "Hexadecimal", "Decimal", "Octal", "Binary" });
            CboNumericBaseLst.Location = new System.Drawing.Point(175, 22);
            CboNumericBaseLst.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            CboNumericBaseLst.Name = "CboNumericBaseLst";
            CboNumericBaseLst.Size = new System.Drawing.Size(160, 23);
            CboNumericBaseLst.TabIndex = 1;
            CboNumericBaseLst.SelectedIndexChanged += CboNumericBaseLst_SelectedIndexChanged;
            // 
            // BtnResetFormat
            // 
            BtnResetFormat.Location = new System.Drawing.Point(248, 97);
            BtnResetFormat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            BtnResetFormat.Name = "BtnResetFormat";
            BtnResetFormat.Size = new System.Drawing.Size(87, 26);
            BtnResetFormat.TabIndex = 8;
            BtnResetFormat.Text = "Reset format";
            BtnResetFormat.UseVisualStyleBackColor = true;
            BtnResetFormat.Click += BtnResetFormat_Click;
            // 
            // ChkExportSelectedOnly
            // 
            ChkExportSelectedOnly.AutoSize = true;
            ChkExportSelectedOnly.Location = new System.Drawing.Point(180, 75);
            ChkExportSelectedOnly.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ChkExportSelectedOnly.Name = "ChkExportSelectedOnly";
            ChkExportSelectedOnly.Size = new System.Drawing.Size(132, 19);
            ChkExportSelectedOnly.TabIndex = 5;
            ChkExportSelectedOnly.Text = "Export selected only";
            ChkExportSelectedOnly.UseVisualStyleBackColor = true;
            // 
            // ChkReverseHashes
            // 
            ChkReverseHashes.AutoSize = true;
            ChkReverseHashes.Location = new System.Drawing.Point(9, 75);
            ChkReverseHashes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ChkReverseHashes.Name = "ChkReverseHashes";
            ChkReverseHashes.Size = new System.Drawing.Size(105, 19);
            ChkReverseHashes.TabIndex = 4;
            ChkReverseHashes.Text = "Reverse hashes";
            ChkReverseHashes.UseVisualStyleBackColor = true;
            // 
            // CboOrderBy
            // 
            CboOrderBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CboOrderBy.FormattingEnabled = true;
            CboOrderBy.Items.AddRange(new object[] { "None", "Hash ascending", "Hash descending", "String ascending", "String descending" });
            CboOrderBy.Location = new System.Drawing.Point(8, 22);
            CboOrderBy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            CboOrderBy.Name = "CboOrderBy";
            CboOrderBy.Size = new System.Drawing.Size(160, 23);
            CboOrderBy.TabIndex = 0;
            CboOrderBy.SelectedIndexChanged += CboOrderBy_SelectedIndexChanged;
            // 
            // ChkIgnoreRepeatedStrings
            // 
            ChkIgnoreRepeatedStrings.AutoSize = true;
            ChkIgnoreRepeatedStrings.Location = new System.Drawing.Point(180, 51);
            ChkIgnoreRepeatedStrings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ChkIgnoreRepeatedStrings.Name = "ChkIgnoreRepeatedStrings";
            ChkIgnoreRepeatedStrings.Size = new System.Drawing.Size(147, 19);
            ChkIgnoreRepeatedStrings.TabIndex = 3;
            ChkIgnoreRepeatedStrings.Text = "Ignore repeated strings";
            ChkIgnoreRepeatedStrings.UseVisualStyleBackColor = true;
            // 
            // BtnUpdateList
            // 
            BtnUpdateList.Location = new System.Drawing.Point(175, 133);
            BtnUpdateList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            BtnUpdateList.Name = "BtnUpdateList";
            BtnUpdateList.Size = new System.Drawing.Size(160, 27);
            BtnUpdateList.TabIndex = 10;
            BtnUpdateList.Text = "Update list";
            BtnUpdateList.UseVisualStyleBackColor = true;
            BtnUpdateList.Click += BtnUpdateList_Click;
            // 
            // BtnExportHashes
            // 
            BtnExportHashes.Location = new System.Drawing.Point(8, 133);
            BtnExportHashes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            BtnExportHashes.Name = "BtnExportHashes";
            BtnExportHashes.Size = new System.Drawing.Size(160, 27);
            BtnExportHashes.TabIndex = 9;
            BtnExportHashes.Text = "Export hashes";
            BtnExportHashes.UseVisualStyleBackColor = true;
            BtnExportHashes.Click += BtnExportHashes_Click;
            // 
            // ChkIgnoreRepeatedHashes
            // 
            ChkIgnoreRepeatedHashes.AutoSize = true;
            ChkIgnoreRepeatedHashes.Location = new System.Drawing.Point(9, 51);
            ChkIgnoreRepeatedHashes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ChkIgnoreRepeatedHashes.Name = "ChkIgnoreRepeatedHashes";
            ChkIgnoreRepeatedHashes.Size = new System.Drawing.Size(148, 19);
            ChkIgnoreRepeatedHashes.TabIndex = 2;
            ChkIgnoreRepeatedHashes.Text = "Ignore repeated hashes";
            ChkIgnoreRepeatedHashes.UseVisualStyleBackColor = true;
            // 
            // BtnStartStop
            // 
            BtnStartStop.Location = new System.Drawing.Point(364, 42);
            BtnStartStop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            BtnStartStop.Name = "BtnStartStop";
            BtnStartStop.Size = new System.Drawing.Size(107, 27);
            BtnStartStop.TabIndex = 7;
            BtnStartStop.Text = "Start/Stop";
            BtnStartStop.UseVisualStyleBackColor = true;
            BtnStartStop.Click += BtnStartStop_Click;
            // 
            // BtnClear
            // 
            BtnClear.Location = new System.Drawing.Point(364, 75);
            BtnClear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new System.Drawing.Size(107, 27);
            BtnClear.TabIndex = 9;
            BtnClear.Text = "Clear";
            BtnClear.UseVisualStyleBackColor = true;
            BtnClear.Click += BtnClear_Click;
            // 
            // ChkUseMainKeys
            // 
            ChkUseMainKeys.AutoSize = true;
            ChkUseMainKeys.Checked = true;
            ChkUseMainKeys.CheckState = System.Windows.Forms.CheckState.Checked;
            ChkUseMainKeys.Location = new System.Drawing.Point(896, 409);
            ChkUseMainKeys.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ChkUseMainKeys.Name = "ChkUseMainKeys";
            ChkUseMainKeys.Size = new System.Drawing.Size(123, 19);
            ChkUseMainKeys.TabIndex = 20;
            ChkUseMainKeys.Text = "Use MainKeys files";
            ChkUseMainKeys.UseVisualStyleBackColor = true;
            ChkUseMainKeys.CheckedChanged += ChkUseMainKeys_CheckedChanged;
            // 
            // BtnGenerateKeyList
            // 
            BtnGenerateKeyList.Location = new System.Drawing.Point(718, 404);
            BtnGenerateKeyList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            BtnGenerateKeyList.Name = "BtnGenerateKeyList";
            BtnGenerateKeyList.Size = new System.Drawing.Size(171, 27);
            BtnGenerateKeyList.TabIndex = 19;
            BtnGenerateKeyList.Text = "Generate list of keys";
            BtnGenerateKeyList.UseVisualStyleBackColor = true;
            BtnGenerateKeyList.Click += BtnGenerateKeyList_Click;
            // 
            // GrpStats
            // 
            GrpStats.Controls.Add(LblTotalHashes);
            GrpStats.Controls.Add(LblUnknownHashes);
            GrpStats.Controls.Add(LblKnownHashes);
            GrpStats.Controls.Add(LblTextKnownHashes);
            GrpStats.Controls.Add(LblTextUnknownHashes);
            GrpStats.Controls.Add(LblTextTotalHashes);
            GrpStats.Location = new System.Drawing.Point(712, 541);
            GrpStats.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            GrpStats.Name = "GrpStats";
            GrpStats.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            GrpStats.Size = new System.Drawing.Size(306, 85);
            GrpStats.TabIndex = 24;
            GrpStats.TabStop = false;
            GrpStats.Text = "Stats";
            // 
            // LblTotalHashes
            // 
            LblTotalHashes.AutoSize = true;
            LblTotalHashes.Location = new System.Drawing.Point(124, 58);
            LblTotalHashes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LblTotalHashes.Name = "LblTotalHashes";
            LblTotalHashes.Size = new System.Drawing.Size(13, 15);
            LblTotalHashes.TabIndex = 5;
            LblTotalHashes.Text = "0";
            // 
            // LblUnknownHashes
            // 
            LblUnknownHashes.AutoSize = true;
            LblUnknownHashes.Location = new System.Drawing.Point(124, 37);
            LblUnknownHashes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LblUnknownHashes.Name = "LblUnknownHashes";
            LblUnknownHashes.Size = new System.Drawing.Size(13, 15);
            LblUnknownHashes.TabIndex = 3;
            LblUnknownHashes.Text = "0";
            // 
            // LblKnownHashes
            // 
            LblKnownHashes.AutoSize = true;
            LblKnownHashes.Location = new System.Drawing.Point(124, 16);
            LblKnownHashes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LblKnownHashes.Name = "LblKnownHashes";
            LblKnownHashes.Size = new System.Drawing.Size(13, 15);
            LblKnownHashes.TabIndex = 1;
            LblKnownHashes.Text = "0";
            // 
            // LblTextKnownHashes
            // 
            LblTextKnownHashes.AutoSize = true;
            LblTextKnownHashes.Location = new System.Drawing.Point(4, 16);
            LblTextKnownHashes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LblTextKnownHashes.Name = "LblTextKnownHashes";
            LblTextKnownHashes.Size = new System.Drawing.Size(86, 15);
            LblTextKnownHashes.TabIndex = 0;
            LblTextKnownHashes.Text = "Known hashes:";
            // 
            // LblTextUnknownHashes
            // 
            LblTextUnknownHashes.AutoSize = true;
            LblTextUnknownHashes.Location = new System.Drawing.Point(4, 37);
            LblTextUnknownHashes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LblTextUnknownHashes.Name = "LblTextUnknownHashes";
            LblTextUnknownHashes.Size = new System.Drawing.Size(100, 15);
            LblTextUnknownHashes.TabIndex = 2;
            LblTextUnknownHashes.Text = "Unknown hashes:";
            // 
            // LblTextTotalHashes
            // 
            LblTextTotalHashes.AutoSize = true;
            LblTextTotalHashes.Location = new System.Drawing.Point(4, 58);
            LblTextTotalHashes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LblTextTotalHashes.Name = "LblTextTotalHashes";
            LblTextTotalHashes.Size = new System.Drawing.Size(88, 15);
            LblTextTotalHashes.TabIndex = 4;
            LblTextTotalHashes.Text = "Total of hashes:";
            // 
            // GrpBruteforceOptions
            // 
            GrpBruteforceOptions.Controls.Add(NumericProcessorsCount);
            GrpBruteforceOptions.Controls.Add(LblBruteforceOptionsProcessors);
            GrpBruteforceOptions.Controls.Add(NumericMaxVariations);
            GrpBruteforceOptions.Controls.Add(NumericMinVariations);
            GrpBruteforceOptions.Controls.Add(ChkBruteforceWithRepetition);
            GrpBruteforceOptions.Controls.Add(ChkTryToBruteforce);
            GrpBruteforceOptions.Controls.Add(LblWordsBetweenVariations);
            GrpBruteforceOptions.Controls.Add(LblBruteforceOptionsMax);
            GrpBruteforceOptions.Controls.Add(LblBruteforceOptionsMin);
            GrpBruteforceOptions.Controls.Add(TxtWordsBetweenVariations);
            GrpBruteforceOptions.Location = new System.Drawing.Point(705, 268);
            GrpBruteforceOptions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            GrpBruteforceOptions.Name = "GrpBruteforceOptions";
            GrpBruteforceOptions.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            GrpBruteforceOptions.Size = new System.Drawing.Size(313, 130);
            GrpBruteforceOptions.TabIndex = 18;
            GrpBruteforceOptions.TabStop = false;
            GrpBruteforceOptions.Text = "Bruteforce options";
            // 
            // NumericProcessorsCount
            // 
            NumericProcessorsCount.Location = new System.Drawing.Point(254, 74);
            NumericProcessorsCount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            NumericProcessorsCount.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            NumericProcessorsCount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NumericProcessorsCount.Name = "NumericProcessorsCount";
            NumericProcessorsCount.Size = new System.Drawing.Size(48, 23);
            NumericProcessorsCount.TabIndex = 7;
            NumericProcessorsCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            NumericProcessorsCount.Leave += NumericProcessorsCount_Leave;
            // 
            // LblBruteforceOptionsProcessors
            // 
            LblBruteforceOptionsProcessors.AutoSize = true;
            LblBruteforceOptionsProcessors.Location = new System.Drawing.Point(186, 76);
            LblBruteforceOptionsProcessors.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LblBruteforceOptionsProcessors.Name = "LblBruteforceOptionsProcessors";
            LblBruteforceOptionsProcessors.Size = new System.Drawing.Size(63, 15);
            LblBruteforceOptionsProcessors.TabIndex = 6;
            LblBruteforceOptionsProcessors.Text = "Processors";
            // 
            // NumericMaxVariations
            // 
            NumericMaxVariations.Location = new System.Drawing.Point(131, 74);
            NumericMaxVariations.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            NumericMaxVariations.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NumericMaxVariations.Name = "NumericMaxVariations";
            NumericMaxVariations.Size = new System.Drawing.Size(48, 23);
            NumericMaxVariations.TabIndex = 5;
            NumericMaxVariations.Value = new decimal(new int[] { 6, 0, 0, 0 });
            NumericMaxVariations.Leave += NumericMaxVariations_Leave;
            // 
            // NumericMinVariations
            // 
            NumericMinVariations.Location = new System.Drawing.Point(37, 74);
            NumericMinVariations.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            NumericMinVariations.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NumericMinVariations.Name = "NumericMinVariations";
            NumericMinVariations.Size = new System.Drawing.Size(48, 23);
            NumericMinVariations.TabIndex = 3;
            NumericMinVariations.Value = new decimal(new int[] { 1, 0, 0, 0 });
            NumericMinVariations.Leave += NumericMinVariations_Leave;
            // 
            // ChkBruteforceWithRepetition
            // 
            ChkBruteforceWithRepetition.AutoSize = true;
            ChkBruteforceWithRepetition.Location = new System.Drawing.Point(142, 104);
            ChkBruteforceWithRepetition.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ChkBruteforceWithRepetition.Name = "ChkBruteforceWithRepetition";
            ChkBruteforceWithRepetition.Size = new System.Drawing.Size(157, 19);
            ChkBruteforceWithRepetition.TabIndex = 9;
            ChkBruteforceWithRepetition.Text = "Variations with repetition";
            ChkBruteforceWithRepetition.UseVisualStyleBackColor = true;
            ChkBruteforceWithRepetition.CheckedChanged += ChkBruteforceWithRepetition_CheckedChanged;
            // 
            // ChkTryToBruteforce
            // 
            ChkTryToBruteforce.AutoSize = true;
            ChkTryToBruteforce.Location = new System.Drawing.Point(9, 104);
            ChkTryToBruteforce.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ChkTryToBruteforce.Name = "ChkTryToBruteforce";
            ChkTryToBruteforce.Size = new System.Drawing.Size(113, 19);
            ChkTryToBruteforce.TabIndex = 8;
            ChkTryToBruteforce.Text = "Try to bruteforce";
            ChkTryToBruteforce.UseVisualStyleBackColor = true;
            ChkTryToBruteforce.CheckedChanged += ChkTryToBruteforce_CheckedChanged;
            // 
            // LblWordsBetweenVariations
            // 
            LblWordsBetweenVariations.AutoSize = true;
            LblWordsBetweenVariations.Location = new System.Drawing.Point(6, 18);
            LblWordsBetweenVariations.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LblWordsBetweenVariations.Name = "LblWordsBetweenVariations";
            LblWordsBetweenVariations.Size = new System.Drawing.Size(143, 15);
            LblWordsBetweenVariations.TabIndex = 0;
            LblWordsBetweenVariations.Text = "Words between variations";
            ToolTipNFSRaider.SetToolTip(LblWordsBetweenVariations, "Use comma (,) to separate each word between variations.\r\nIf you want to use comma (,) you must escape it (\\,). Same goes for backslash (\\), you must escape it (\\\\).");
            // 
            // LblBruteforceOptionsMax
            // 
            LblBruteforceOptionsMax.AutoSize = true;
            LblBruteforceOptionsMax.Location = new System.Drawing.Point(96, 76);
            LblBruteforceOptionsMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LblBruteforceOptionsMax.Name = "LblBruteforceOptionsMax";
            LblBruteforceOptionsMax.Size = new System.Drawing.Size(30, 15);
            LblBruteforceOptionsMax.TabIndex = 4;
            LblBruteforceOptionsMax.Text = "Max";
            // 
            // LblBruteforceOptionsMin
            // 
            LblBruteforceOptionsMin.AutoSize = true;
            LblBruteforceOptionsMin.Location = new System.Drawing.Point(7, 76);
            LblBruteforceOptionsMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LblBruteforceOptionsMin.Name = "LblBruteforceOptionsMin";
            LblBruteforceOptionsMin.Size = new System.Drawing.Size(28, 15);
            LblBruteforceOptionsMin.TabIndex = 2;
            LblBruteforceOptionsMin.Text = "Min";
            // 
            // TxtWordsBetweenVariations
            // 
            TxtWordsBetweenVariations.Location = new System.Drawing.Point(7, 37);
            TxtWordsBetweenVariations.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TxtWordsBetweenVariations.MaxLength = 2147483646;
            TxtWordsBetweenVariations.Name = "TxtWordsBetweenVariations";
            TxtWordsBetweenVariations.Size = new System.Drawing.Size(294, 23);
            TxtWordsBetweenVariations.TabIndex = 1;
            // 
            // TxtSearch
            // 
            TxtSearch.Location = new System.Drawing.Point(14, 12);
            TxtSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.Size = new System.Drawing.Size(228, 23);
            TxtSearch.TabIndex = 1;
            // 
            // BtnSearchPrevious
            // 
            BtnSearchPrevious.Location = new System.Drawing.Point(14, 42);
            BtnSearchPrevious.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            BtnSearchPrevious.Name = "BtnSearchPrevious";
            BtnSearchPrevious.Size = new System.Drawing.Size(110, 27);
            BtnSearchPrevious.TabIndex = 3;
            BtnSearchPrevious.Text = "Previous";
            BtnSearchPrevious.UseVisualStyleBackColor = true;
            BtnSearchPrevious.Click += BtnSearchPrevious_Click;
            // 
            // BtnSearchNext
            // 
            BtnSearchNext.Location = new System.Drawing.Point(130, 42);
            BtnSearchNext.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            BtnSearchNext.Name = "BtnSearchNext";
            BtnSearchNext.Size = new System.Drawing.Size(112, 27);
            BtnSearchNext.TabIndex = 4;
            BtnSearchNext.Text = "Next";
            BtnSearchNext.UseVisualStyleBackColor = true;
            BtnSearchNext.Click += BtnSearchNext_Click;
            // 
            // LblStatus
            // 
            LblStatus.AutoSize = true;
            LblStatus.Location = new System.Drawing.Point(10, 630);
            LblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LblStatus.Name = "LblStatus";
            LblStatus.Size = new System.Drawing.Size(84, 15);
            LblStatus.TabIndex = 26;
            LblStatus.Text = "No file loaded.";
            // 
            // CboForceHashListCase
            // 
            CboForceHashListCase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CboForceHashListCase.FormattingEnabled = true;
            CboForceHashListCase.Items.AddRange(new object[] { "None", "Uppercase", "Lowercase", "All" });
            CboForceHashListCase.Location = new System.Drawing.Point(718, 438);
            CboForceHashListCase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            CboForceHashListCase.Name = "CboForceHashListCase";
            CboForceHashListCase.Size = new System.Drawing.Size(171, 23);
            CboForceHashListCase.TabIndex = 21;
            CboForceHashListCase.SelectedIndexChanged += CboForceHashListCase_SelectedIndexChanged;
            // 
            // LblTimeElapsed
            // 
            LblTimeElapsed.Location = new System.Drawing.Point(788, 630);
            LblTimeElapsed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LblTimeElapsed.Name = "LblTimeElapsed";
            LblTimeElapsed.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            LblTimeElapsed.Size = new System.Drawing.Size(233, 15);
            LblTimeElapsed.TabIndex = 27;
            LblTimeElapsed.Text = "Time elapsed: HHHH:mm:ss.fff";
            // 
            // ToolTipNFSRaider
            // 
            ToolTipNFSRaider.AutoPopDelay = 15000;
            ToolTipNFSRaider.InitialDelay = 500;
            ToolTipNFSRaider.ReshowDelay = 100;
            ToolTipNFSRaider.ToolTipTitle = "Info";
            // 
            // BtnSearchAll
            // 
            BtnSearchAll.Location = new System.Drawing.Point(247, 42);
            BtnSearchAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            BtnSearchAll.Name = "BtnSearchAll";
            BtnSearchAll.Size = new System.Drawing.Size(110, 27);
            BtnSearchAll.TabIndex = 5;
            BtnSearchAll.Text = "All";
            BtnSearchAll.UseVisualStyleBackColor = true;
            BtnSearchAll.Click += BtnSearchAll_Click;
            // 
            // CboRaiderMode
            // 
            CboRaiderMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CboRaiderMode.FormattingEnabled = true;
            CboRaiderMode.Items.AddRange(new object[] { "Unhasher", "Hasher" });
            CboRaiderMode.Location = new System.Drawing.Point(364, 108);
            CboRaiderMode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            CboRaiderMode.Name = "CboRaiderMode";
            CboRaiderMode.Size = new System.Drawing.Size(106, 23);
            CboRaiderMode.TabIndex = 10;
            CboRaiderMode.SelectedIndexChanged += CboRaiderMode_SelectedIndexChanged;
            // 
            // ChkCaseSensitive
            // 
            ChkCaseSensitive.AutoSize = true;
            ChkCaseSensitive.Location = new System.Drawing.Point(250, 14);
            ChkCaseSensitive.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ChkCaseSensitive.Name = "ChkCaseSensitive";
            ChkCaseSensitive.Size = new System.Drawing.Size(99, 19);
            ChkCaseSensitive.TabIndex = 2;
            ChkCaseSensitive.Text = "Case sensitive";
            ChkCaseSensitive.UseVisualStyleBackColor = true;
            ChkCaseSensitive.CheckedChanged += ChkCaseSensitive_CheckedChanged;
            // 
            // ChkUseUserKeys
            // 
            ChkUseUserKeys.AutoSize = true;
            ChkUseUserKeys.Checked = true;
            ChkUseUserKeys.CheckState = System.Windows.Forms.CheckState.Checked;
            ChkUseUserKeys.Location = new System.Drawing.Point(896, 440);
            ChkUseUserKeys.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ChkUseUserKeys.Name = "ChkUseUserKeys";
            ChkUseUserKeys.Size = new System.Drawing.Size(119, 19);
            ChkUseUserKeys.TabIndex = 22;
            ChkUseUserKeys.Text = "Use UserKeys files";
            ChkUseUserKeys.UseVisualStyleBackColor = true;
            ChkUseUserKeys.CheckedChanged += ChkUseUserKeys_CheckedChanged;
            // 
            // NFSRaiderForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1031, 647);
            Controls.Add(ChkUseUserKeys);
            Controls.Add(CboRaiderMode);
            Controls.Add(LblTimeElapsed);
            Controls.Add(ChkCaseSensitive);
            Controls.Add(CboForceHashListCase);
            Controls.Add(LblStatus);
            Controls.Add(GrpBruteforceOptions);
            Controls.Add(BtnSearchAll);
            Controls.Add(GrpStats);
            Controls.Add(BtnGenerateKeyList);
            Controls.Add(ChkUseMainKeys);
            Controls.Add(TxtSearch);
            Controls.Add(BtnClear);
            Controls.Add(BtnSearchNext);
            Controls.Add(BtnStartStop);
            Controls.Add(GrpListOptions);
            Controls.Add(BtnSearchPrevious);
            Controls.Add(LblVariations);
            Controls.Add(LblSuffixes);
            Controls.Add(LblPrefixes);
            Controls.Add(TxtSuffixes);
            Controls.Add(TxtVariations);
            Controls.Add(TxtPrefixes);
            Controls.Add(GrpHashingOptions);
            Controls.Add(LstUnhashed);
            Controls.Add(GrpLoadOptions);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "NFSRaiderForm";
            Text = "NFS-Raider";
            GrpLoadOptions.ResumeLayout(false);
            TabLoadOptions.ResumeLayout(false);
            TabPageFromFile.ResumeLayout(false);
            TabPageFromFile.PerformLayout();
            TabPageFromText.ResumeLayout(false);
            TabPageFromText.PerformLayout();
            GrpHashingOptions.ResumeLayout(false);
            GrpListOptions.ResumeLayout(false);
            GrpListOptions.PerformLayout();
            GrpStats.ResumeLayout(false);
            GrpStats.PerformLayout();
            GrpBruteforceOptions.ResumeLayout(false);
            GrpBruteforceOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumericProcessorsCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumericMaxVariations).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumericMinVariations).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.Button BtnStartStop;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.CheckBox ChkUseMainKeys;
        private System.Windows.Forms.Button BtnGenerateKeyList;
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
        private System.Windows.Forms.CheckBox ChkUseUserKeys;
    }
}

