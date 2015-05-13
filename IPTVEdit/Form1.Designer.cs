namespace IPTVEdit
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TSMFile = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMNew = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMAddCode = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMSave = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMTools = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMBlacklist = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMOpenBlacklistEditor = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMLoadBlacklist = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMDuplicate = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMLogo = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMChangeLogoPath = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMLogoUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMEPG = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMLoadEPG = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMEpgCheckSimpleIPTV = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMSortby = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMSortbyName = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMSortbyFavourite = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMSortbyFile = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMOthers = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMEng = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIta = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMGer = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.OFDSort = new System.Windows.Forms.OpenFileDialog();
            this.OFDBlacklist = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.OFDEpg = new System.Windows.Forms.OpenFileDialog();
            this.FBDLogo = new System.Windows.Forms.FolderBrowserDialog();
            this.DGChannel = new System.Windows.Forms.DataGridView();
            this.grpChange = new System.Windows.Forms.GroupBox();
            this.lblChangeEPGID = new System.Windows.Forms.Label();
            this.txtChangeIDEPG = new System.Windows.Forms.TextBox();
            this.CBTVRadio = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtChangeEPGShift = new System.Windows.Forms.TextBox();
            this.btnAddChannel = new System.Windows.Forms.Button();
            this.txtSort = new System.Windows.Forms.TextBox();
            this.lblSort = new System.Windows.Forms.Label();
            this.lblChangeEPGShift = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAddClose = new System.Windows.Forms.Button();
            this.btnChangeOK = new System.Windows.Forms.Button();
            this.lblChangeIP = new System.Windows.Forms.Label();
            this.lblChangeLogo = new System.Windows.Forms.Label();
            this.lblChangeGroup = new System.Windows.Forms.Label();
            this.lblChangeNameEPG = new System.Windows.Forms.Label();
            this.lblChangeName = new System.Windows.Forms.Label();
            this.txtChangeLogo = new System.Windows.Forms.TextBox();
            this.txtChangeIP = new System.Windows.Forms.TextBox();
            this.txtChangeGroup = new System.Windows.Forms.TextBox();
            this.txtChangeNameEPG = new System.Windows.Forms.TextBox();
            this.txtChangeName = new System.Windows.Forms.TextBox();
            this.PbLoad = new System.Windows.Forms.ProgressBar();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGChannel)).BeginInit();
            this.grpChange.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMFile,
            this.TSMTools,
            this.TSMSortby,
            this.TSMOthers});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(933, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TSMFile
            // 
            this.TSMFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMNew,
            this.TSMOpen,
            this.TSMAddCode,
            this.TSMSave});
            this.TSMFile.Name = "TSMFile";
            this.TSMFile.Size = new System.Drawing.Size(46, 20);
            this.TSMFile.Text = "Datei";
            // 
            // TSMNew
            // 
            this.TSMNew.Name = "TSMNew";
            this.TSMNew.Size = new System.Drawing.Size(255, 22);
            this.TSMNew.Text = "Erstelle eine neue Datei";
            this.TSMNew.Click += new System.EventHandler(this.TSMNew_Click);
            // 
            // TSMOpen
            // 
            this.TSMOpen.Name = "TSMOpen";
            this.TSMOpen.Size = new System.Drawing.Size(255, 22);
            this.TSMOpen.Text = "M3U-Datei hinzufügen";
            this.TSMOpen.Click += new System.EventHandler(this.TSMOpen_Click);
            // 
            // TSMAddCode
            // 
            this.TSMAddCode.Name = "TSMAddCode";
            this.TSMAddCode.Size = new System.Drawing.Size(255, 22);
            this.TSMAddCode.Text = "Sender mit M3U-Code hinzufügen";
            this.TSMAddCode.Click += new System.EventHandler(this.TSMAddCode_Click);
            // 
            // TSMSave
            // 
            this.TSMSave.Name = "TSMSave";
            this.TSMSave.Size = new System.Drawing.Size(255, 22);
            this.TSMSave.Text = "Speichern unter...";
            this.TSMSave.Click += new System.EventHandler(this.TSMSave_Click);
            // 
            // TSMTools
            // 
            this.TSMTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMBlacklist,
            this.TSMDuplicate,
            this.TSMLogo,
            this.TSMEPG});
            this.TSMTools.Name = "TSMTools";
            this.TSMTools.Size = new System.Drawing.Size(48, 20);
            this.TSMTools.Text = "Tools";
            // 
            // TSMBlacklist
            // 
            this.TSMBlacklist.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMOpenBlacklistEditor,
            this.TSMLoadBlacklist});
            this.TSMBlacklist.Name = "TSMBlacklist";
            this.TSMBlacklist.Size = new System.Drawing.Size(171, 22);
            this.TSMBlacklist.Text = "Blacklist";
            // 
            // TSMOpenBlacklistEditor
            // 
            this.TSMOpenBlacklistEditor.Name = "TSMOpenBlacklistEditor";
            this.TSMOpenBlacklistEditor.Size = new System.Drawing.Size(219, 22);
            this.TSMOpenBlacklistEditor.Text = "Öffne BlacklistEditor";
            this.TSMOpenBlacklistEditor.Click += new System.EventHandler(this.TSMOpenBlacklistEditor_Click);
            // 
            // TSMLoadBlacklist
            // 
            this.TSMLoadBlacklist.Name = "TSMLoadBlacklist";
            this.TSMLoadBlacklist.Size = new System.Drawing.Size(219, 22);
            this.TSMLoadBlacklist.Text = "Lösche Sender von Blacklist";
            this.TSMLoadBlacklist.Click += new System.EventHandler(this.TSMLoadBlacklist_Click);
            // 
            // TSMDuplicate
            // 
            this.TSMDuplicate.Name = "TSMDuplicate";
            this.TSMDuplicate.Size = new System.Drawing.Size(171, 22);
            this.TSMDuplicate.Text = "Entferne Duplikate";
            this.TSMDuplicate.Click += new System.EventHandler(this.TSMDuplicate_Click);
            // 
            // TSMLogo
            // 
            this.TSMLogo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMChangeLogoPath,
            this.TSMLogoUpdate});
            this.TSMLogo.Name = "TSMLogo";
            this.TSMLogo.Size = new System.Drawing.Size(171, 22);
            this.TSMLogo.Text = "Logo";
            // 
            // TSMChangeLogoPath
            // 
            this.TSMChangeLogoPath.Name = "TSMChangeLogoPath";
            this.TSMChangeLogoPath.Size = new System.Drawing.Size(208, 22);
            this.TSMChangeLogoPath.Text = "Logos Verzeichnis ändern";
            this.TSMChangeLogoPath.Click += new System.EventHandler(this.TSMChangeLogoPath_Click);
            // 
            // TSMLogoUpdate
            // 
            this.TSMLogoUpdate.Name = "TSMLogoUpdate";
            this.TSMLogoUpdate.Size = new System.Drawing.Size(208, 22);
            this.TSMLogoUpdate.Text = "Logos Aktualisieren";
            this.TSMLogoUpdate.Click += new System.EventHandler(this.TSMLogoUpdate_Click);
            // 
            // TSMEPG
            // 
            this.TSMEPG.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMLoadEPG,
            this.TSMEpgCheckSimpleIPTV});
            this.TSMEPG.Name = "TSMEPG";
            this.TSMEPG.Size = new System.Drawing.Size(171, 22);
            this.TSMEPG.Text = "EPG";
            // 
            // TSMLoadEPG
            // 
            this.TSMLoadEPG.Name = "TSMLoadEPG";
            this.TSMLoadEPG.Size = new System.Drawing.Size(268, 22);
            this.TSMLoadEPG.Text = "EPG laden";
            this.TSMLoadEPG.Click += new System.EventHandler(this.TSMLoadEPG_Click);
            // 
            // TSMEpgCheckSimpleIPTV
            // 
            this.TSMEpgCheckSimpleIPTV.CheckOnClick = true;
            this.TSMEpgCheckSimpleIPTV.Name = "TSMEpgCheckSimpleIPTV";
            this.TSMEpgCheckSimpleIPTV.Size = new System.Drawing.Size(268, 22);
            this.TSMEpgCheckSimpleIPTV.Text = "Sender für Simple IPTV umbenennen";
            this.TSMEpgCheckSimpleIPTV.Click += new System.EventHandler(this.TSMEpgCheckSimpleIPTV_Click);
            // 
            // TSMSortby
            // 
            this.TSMSortby.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMSortbyName,
            this.TSMSortbyFavourite,
            this.TSMSortbyFile});
            this.TSMSortby.Name = "TSMSortby";
            this.TSMSortby.Size = new System.Drawing.Size(66, 20);
            this.TSMSortby.Text = "Sortieren";
            // 
            // TSMSortbyName
            // 
            this.TSMSortbyName.Name = "TSMSortbyName";
            this.TSMSortbyName.Size = new System.Drawing.Size(280, 22);
            this.TSMSortbyName.Text = "Sortiere nach Name (A-Z)";
            this.TSMSortbyName.Click += new System.EventHandler(this.TSMSortbyName_Click);
            // 
            // TSMSortbyFavourite
            // 
            this.TSMSortbyFavourite.Name = "TSMSortbyFavourite";
            this.TSMSortbyFavourite.Size = new System.Drawing.Size(280, 22);
            this.TSMSortbyFavourite.Text = "Sortiere nach Favorit (A-Z)";
            this.TSMSortbyFavourite.Click += new System.EventHandler(this.TSMSortbyFavourite_Click);
            // 
            // TSMSortbyFile
            // 
            this.TSMSortbyFile.Name = "TSMSortbyFile";
            this.TSMSortbyFile.Size = new System.Drawing.Size(280, 22);
            this.TSMSortbyFile.Text = "Sortiere von einer anderen Datei (.m3u)";
            this.TSMSortbyFile.Click += new System.EventHandler(this.TSMSortbyFile_Click);
            // 
            // TSMOthers
            // 
            this.TSMOthers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMInfo,
            this.TSMLanguage});
            this.TSMOthers.Name = "TSMOthers";
            this.TSMOthers.Size = new System.Drawing.Size(69, 20);
            this.TSMOthers.Text = "Sonstiges";
            // 
            // TSMInfo
            // 
            this.TSMInfo.Name = "TSMInfo";
            this.TSMInfo.Size = new System.Drawing.Size(156, 22);
            this.TSMInfo.Text = "Info";
            this.TSMInfo.Click += new System.EventHandler(this.TSMInfo_Click);
            // 
            // TSMLanguage
            // 
            this.TSMLanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMEng,
            this.TSMIta,
            this.TSMGer});
            this.TSMLanguage.Name = "TSMLanguage";
            this.TSMLanguage.Size = new System.Drawing.Size(156, 22);
            this.TSMLanguage.Text = "Sprache ändern";
            // 
            // TSMEng
            // 
            this.TSMEng.Name = "TSMEng";
            this.TSMEng.Size = new System.Drawing.Size(127, 22);
            this.TSMEng.Text = "Englisch";
            this.TSMEng.Click += new System.EventHandler(this.TSMEng_Click);
            // 
            // TSMIta
            // 
            this.TSMIta.Name = "TSMIta";
            this.TSMIta.Size = new System.Drawing.Size(127, 22);
            this.TSMIta.Text = "Italienisch";
            this.TSMIta.Click += new System.EventHandler(this.TSMIta_Click);
            // 
            // TSMGer
            // 
            this.TSMGer.Name = "TSMGer";
            this.TSMGer.Size = new System.Drawing.Size(127, 22);
            this.TSMGer.Text = "Deutsch";
            this.TSMGer.Click += new System.EventHandler(this.TSMGer_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 540);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(933, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // DGChannel
            // 
            this.DGChannel.AllowDrop = true;
            this.DGChannel.AllowUserToAddRows = false;
            this.DGChannel.AllowUserToDeleteRows = false;
            this.DGChannel.AllowUserToResizeColumns = false;
            this.DGChannel.AllowUserToResizeRows = false;
            this.DGChannel.BackgroundColor = System.Drawing.Color.LightGray;
            this.DGChannel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGChannel.Dock = System.Windows.Forms.DockStyle.Left;
            this.DGChannel.Location = new System.Drawing.Point(0, 24);
            this.DGChannel.Name = "DGChannel";
            this.DGChannel.Size = new System.Drawing.Size(600, 516);
            this.DGChannel.TabIndex = 2;
            this.DGChannel.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGChannel_CellMouseClick);
            this.DGChannel.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.DGChannel_ColumnAdded);
            this.DGChannel.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DGChannel_KeyUp);
            // 
            // grpChange
            // 
            this.grpChange.Controls.Add(this.lblChangeEPGID);
            this.grpChange.Controls.Add(this.txtChangeIDEPG);
            this.grpChange.Controls.Add(this.CBTVRadio);
            this.grpChange.Controls.Add(this.btnDelete);
            this.grpChange.Controls.Add(this.txtChangeEPGShift);
            this.grpChange.Controls.Add(this.btnAddChannel);
            this.grpChange.Controls.Add(this.txtSort);
            this.grpChange.Controls.Add(this.lblSort);
            this.grpChange.Controls.Add(this.lblChangeEPGShift);
            this.grpChange.Controls.Add(this.btnAdd);
            this.grpChange.Controls.Add(this.btnAddClose);
            this.grpChange.Controls.Add(this.btnChangeOK);
            this.grpChange.Controls.Add(this.lblChangeIP);
            this.grpChange.Controls.Add(this.lblChangeLogo);
            this.grpChange.Controls.Add(this.lblChangeGroup);
            this.grpChange.Controls.Add(this.lblChangeNameEPG);
            this.grpChange.Controls.Add(this.lblChangeName);
            this.grpChange.Controls.Add(this.txtChangeLogo);
            this.grpChange.Controls.Add(this.txtChangeIP);
            this.grpChange.Controls.Add(this.txtChangeGroup);
            this.grpChange.Controls.Add(this.txtChangeNameEPG);
            this.grpChange.Controls.Add(this.txtChangeName);
            this.grpChange.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpChange.Enabled = false;
            this.grpChange.Location = new System.Drawing.Point(606, 24);
            this.grpChange.Name = "grpChange";
            this.grpChange.Size = new System.Drawing.Size(327, 516);
            this.grpChange.TabIndex = 5;
            this.grpChange.TabStop = false;
            // 
            // lblChangeEPGID
            // 
            this.lblChangeEPGID.AutoSize = true;
            this.lblChangeEPGID.Location = new System.Drawing.Point(5, 55);
            this.lblChangeEPGID.Name = "lblChangeEPGID";
            this.lblChangeEPGID.Size = new System.Drawing.Size(43, 13);
            this.lblChangeEPGID.TabIndex = 16;
            this.lblChangeEPGID.Text = "EPG-ID";
            // 
            // txtChangeIDEPG
            // 
            this.txtChangeIDEPG.Location = new System.Drawing.Point(6, 71);
            this.txtChangeIDEPG.Name = "txtChangeIDEPG";
            this.txtChangeIDEPG.Size = new System.Drawing.Size(210, 20);
            this.txtChangeIDEPG.TabIndex = 15;
            this.txtChangeIDEPG.TextChanged += new System.EventHandler(this.txtChangeIDEPG_TextChanged);
            // 
            // CBTVRadio
            // 
            this.CBTVRadio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBTVRadio.FormattingEnabled = true;
            this.CBTVRadio.Items.AddRange(new object[] {
            "TV",
            "Radio"});
            this.CBTVRadio.Location = new System.Drawing.Point(232, 31);
            this.CBTVRadio.Name = "CBTVRadio";
            this.CBTVRadio.Size = new System.Drawing.Size(86, 21);
            this.CBTVRadio.TabIndex = 14;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(183, 348);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(133, 31);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Sender entfernen (Entf)";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtChangeEPGShift
            // 
            this.txtChangeEPGShift.Location = new System.Drawing.Point(260, 110);
            this.txtChangeEPGShift.Name = "txtChangeEPGShift";
            this.txtChangeEPGShift.Size = new System.Drawing.Size(55, 20);
            this.txtChangeEPGShift.TabIndex = 2;
            // 
            // btnAddChannel
            // 
            this.btnAddChannel.Location = new System.Drawing.Point(6, 348);
            this.btnAddChannel.Name = "btnAddChannel";
            this.btnAddChannel.Size = new System.Drawing.Size(133, 31);
            this.btnAddChannel.TabIndex = 0;
            this.btnAddChannel.Text = "Sender hinzufügen";
            this.btnAddChannel.UseVisualStyleBackColor = true;
            this.btnAddChannel.Click += new System.EventHandler(this.btnAddChannel_Click);
            // 
            // txtSort
            // 
            this.txtSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSort.Location = new System.Drawing.Point(210, 219);
            this.txtSort.Name = "txtSort";
            this.txtSort.Size = new System.Drawing.Size(108, 31);
            this.txtSort.TabIndex = 6;
            this.txtSort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSort_KeyPress);
            this.txtSort.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSort_KeyUp);
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSort.Location = new System.Drawing.Point(6, 229);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(199, 16);
            this.lblSort.TabIndex = 3;
            this.lblSort.Text = "Geben Sie die neue nummer ein";
            // 
            // lblChangeEPGShift
            // 
            this.lblChangeEPGShift.AutoSize = true;
            this.lblChangeEPGShift.Location = new System.Drawing.Point(257, 94);
            this.lblChangeEPGShift.Name = "lblChangeEPGShift";
            this.lblChangeEPGShift.Size = new System.Drawing.Size(53, 13);
            this.lblChangeEPGShift.TabIndex = 13;
            this.lblChangeEPGShift.Text = "EPG Shift";
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(8, 285);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(133, 37);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Hinzufügen";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAddClose
            // 
            this.btnAddClose.Location = new System.Drawing.Point(183, 285);
            this.btnAddClose.Name = "btnAddClose";
            this.btnAddClose.Size = new System.Drawing.Size(133, 37);
            this.btnAddClose.TabIndex = 12;
            this.btnAddClose.Text = "Schließen";
            this.btnAddClose.UseVisualStyleBackColor = true;
            this.btnAddClose.Click += new System.EventHandler(this.btnAddClose_Click);
            // 
            // btnChangeOK
            // 
            this.btnChangeOK.Location = new System.Drawing.Point(94, 285);
            this.btnChangeOK.Name = "btnChangeOK";
            this.btnChangeOK.Size = new System.Drawing.Size(133, 37);
            this.btnChangeOK.TabIndex = 10;
            this.btnChangeOK.Text = "Ändern";
            this.btnChangeOK.UseVisualStyleBackColor = true;
            this.btnChangeOK.Click += new System.EventHandler(this.btnChangeOK_Click);
            // 
            // lblChangeIP
            // 
            this.lblChangeIP.AutoSize = true;
            this.lblChangeIP.Location = new System.Drawing.Point(5, 172);
            this.lblChangeIP.Name = "lblChangeIP";
            this.lblChangeIP.Size = new System.Drawing.Size(17, 13);
            this.lblChangeIP.TabIndex = 9;
            this.lblChangeIP.Text = "IP";
            // 
            // lblChangeLogo
            // 
            this.lblChangeLogo.AutoSize = true;
            this.lblChangeLogo.Location = new System.Drawing.Point(185, 133);
            this.lblChangeLogo.Name = "lblChangeLogo";
            this.lblChangeLogo.Size = new System.Drawing.Size(31, 13);
            this.lblChangeLogo.TabIndex = 8;
            this.lblChangeLogo.Text = "Logo";
            // 
            // lblChangeGroup
            // 
            this.lblChangeGroup.AutoSize = true;
            this.lblChangeGroup.Location = new System.Drawing.Point(3, 133);
            this.lblChangeGroup.Name = "lblChangeGroup";
            this.lblChangeGroup.Size = new System.Drawing.Size(39, 13);
            this.lblChangeGroup.TabIndex = 7;
            this.lblChangeGroup.Text = "Favorit";
            // 
            // lblChangeNameEPG
            // 
            this.lblChangeNameEPG.AutoSize = true;
            this.lblChangeNameEPG.Location = new System.Drawing.Point(3, 94);
            this.lblChangeNameEPG.Name = "lblChangeNameEPG";
            this.lblChangeNameEPG.Size = new System.Drawing.Size(60, 13);
            this.lblChangeNameEPG.TabIndex = 6;
            this.lblChangeNameEPG.Text = "EPG-Name";
            // 
            // lblChangeName
            // 
            this.lblChangeName.AutoSize = true;
            this.lblChangeName.Location = new System.Drawing.Point(3, 16);
            this.lblChangeName.Name = "lblChangeName";
            this.lblChangeName.Size = new System.Drawing.Size(97, 13);
            this.lblChangeName.TabIndex = 5;
            this.lblChangeName.Text = "Name des Senders";
            // 
            // txtChangeLogo
            // 
            this.txtChangeLogo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtChangeLogo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtChangeLogo.Location = new System.Drawing.Point(185, 149);
            this.txtChangeLogo.Name = "txtChangeLogo";
            this.txtChangeLogo.Size = new System.Drawing.Size(133, 20);
            this.txtChangeLogo.TabIndex = 4;
            this.txtChangeLogo.TextChanged += new System.EventHandler(this.txtChangeLogo_TextChanged);
            // 
            // txtChangeIP
            // 
            this.txtChangeIP.Location = new System.Drawing.Point(8, 188);
            this.txtChangeIP.Name = "txtChangeIP";
            this.txtChangeIP.Size = new System.Drawing.Size(310, 20);
            this.txtChangeIP.TabIndex = 5;
            // 
            // txtChangeGroup
            // 
            this.txtChangeGroup.Location = new System.Drawing.Point(6, 149);
            this.txtChangeGroup.Name = "txtChangeGroup";
            this.txtChangeGroup.Size = new System.Drawing.Size(137, 20);
            this.txtChangeGroup.TabIndex = 3;
            this.txtChangeGroup.TextChanged += new System.EventHandler(this.txtChangeGroup_TextChanged);
            // 
            // txtChangeNameEPG
            // 
            this.txtChangeNameEPG.Location = new System.Drawing.Point(6, 110);
            this.txtChangeNameEPG.Name = "txtChangeNameEPG";
            this.txtChangeNameEPG.Size = new System.Drawing.Size(210, 20);
            this.txtChangeNameEPG.TabIndex = 1;
            this.txtChangeNameEPG.TextChanged += new System.EventHandler(this.txtChangeNameEPG_TextChanged);
            // 
            // txtChangeName
            // 
            this.txtChangeName.Location = new System.Drawing.Point(6, 32);
            this.txtChangeName.Name = "txtChangeName";
            this.txtChangeName.Size = new System.Drawing.Size(210, 20);
            this.txtChangeName.TabIndex = 0;
            // 
            // PbLoad
            // 
            this.PbLoad.Location = new System.Drawing.Point(190, 227);
            this.PbLoad.Name = "PbLoad";
            this.PbLoad.Size = new System.Drawing.Size(202, 23);
            this.PbLoad.TabIndex = 6;
            this.PbLoad.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 562);
            this.Controls.Add(this.PbLoad);
            this.Controls.Add(this.grpChange);
            this.Controls.Add(this.DGChannel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(580, 430);
            this.Name = "Form1";
            this.Text = "IPTVEdit @ tvtools.tk";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGChannel)).EndInit();
            this.grpChange.ResumeLayout(false);
            this.grpChange.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog OFDSort;
        private System.Windows.Forms.OpenFileDialog OFDBlacklist;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog OFDEpg;
        private System.Windows.Forms.FolderBrowserDialog FBDLogo;
        private System.Windows.Forms.ToolStripMenuItem TSMFile;
        private System.Windows.Forms.ToolStripMenuItem TSMNew;
        private System.Windows.Forms.ToolStripMenuItem TSMOpen;
        private System.Windows.Forms.ToolStripMenuItem TSMAddCode;
        private System.Windows.Forms.ToolStripMenuItem TSMSave;
        private System.Windows.Forms.ToolStripMenuItem TSMTools;
        private System.Windows.Forms.ToolStripMenuItem TSMBlacklist;
        private System.Windows.Forms.ToolStripMenuItem TSMOpenBlacklistEditor;
        private System.Windows.Forms.ToolStripMenuItem TSMLoadBlacklist;
        private System.Windows.Forms.ToolStripMenuItem TSMDuplicate;
        private System.Windows.Forms.ToolStripMenuItem TSMLogo;
        private System.Windows.Forms.ToolStripMenuItem TSMChangeLogoPath;
        private System.Windows.Forms.ToolStripMenuItem TSMLogoUpdate;
        private System.Windows.Forms.ToolStripMenuItem TSMEPG;
        private System.Windows.Forms.ToolStripMenuItem TSMLoadEPG;
        private System.Windows.Forms.ToolStripMenuItem TSMEpgCheckSimpleIPTV;
        private System.Windows.Forms.ToolStripMenuItem TSMSortby;
        private System.Windows.Forms.ToolStripMenuItem TSMSortbyName;
        private System.Windows.Forms.ToolStripMenuItem TSMSortbyFavourite;
        private System.Windows.Forms.ToolStripMenuItem TSMSortbyFile;
        private System.Windows.Forms.ToolStripMenuItem TSMOthers;
        private System.Windows.Forms.ToolStripMenuItem TSMInfo;
        private System.Windows.Forms.ToolStripMenuItem TSMLanguage;
        private System.Windows.Forms.ToolStripMenuItem TSMEng;
        private System.Windows.Forms.ToolStripMenuItem TSMIta;
        private System.Windows.Forms.ToolStripMenuItem TSMGer;
        private System.Windows.Forms.DataGridView DGChannel;
        private System.Windows.Forms.GroupBox grpChange;
        private System.Windows.Forms.Label lblChangeEPGID;
        private System.Windows.Forms.TextBox txtChangeIDEPG;
        private System.Windows.Forms.ComboBox CBTVRadio;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtChangeEPGShift;
        private System.Windows.Forms.Button btnAddChannel;
        private System.Windows.Forms.TextBox txtSort;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.Label lblChangeEPGShift;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAddClose;
        private System.Windows.Forms.Button btnChangeOK;
        private System.Windows.Forms.Label lblChangeIP;
        private System.Windows.Forms.Label lblChangeLogo;
        private System.Windows.Forms.Label lblChangeGroup;
        private System.Windows.Forms.Label lblChangeNameEPG;
        private System.Windows.Forms.Label lblChangeName;
        private System.Windows.Forms.TextBox txtChangeLogo;
        private System.Windows.Forms.TextBox txtChangeIP;
        private System.Windows.Forms.TextBox txtChangeGroup;
        private System.Windows.Forms.TextBox txtChangeNameEPG;
        private System.Windows.Forms.TextBox txtChangeName;
        private System.Windows.Forms.ProgressBar PbLoad;
    }
}

