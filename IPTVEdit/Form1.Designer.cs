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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TSMFile = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMNew = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMOpenM3U = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMM3UfromFile = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMM3UfromURL = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMM3UfromCode = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMFTP = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMFTPConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMFTPUpload = new System.Windows.Forms.ToolStripMenuItem();
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
            this.TSMOpenEPG = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMOpenEPGFromFile = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMOpenEPGFromInternet = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMEpgCheckSimpleIPTV = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIP = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMRenameIPEndToM3U8 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.TSMCheckUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.OFDSort = new System.Windows.Forms.OpenFileDialog();
            this.OFDBlacklist = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.OFDEpg = new System.Windows.Forms.OpenFileDialog();
            this.FBDLogo = new System.Windows.Forms.FolderBrowserDialog();
            this.DGChannel = new System.Windows.Forms.DataGridView();
            this.grpChange = new System.Windows.Forms.GroupBox();
            this.btnFavourite = new System.Windows.Forms.Button();
            this.CBChangeGroup = new System.Windows.Forms.ComboBox();
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
            this.txtChangeNameEPG = new System.Windows.Forms.TextBox();
            this.txtChangeName = new System.Windows.Forms.TextBox();
            this.PbLoad = new System.Windows.Forms.ProgressBar();
            this.grpURL = new System.Windows.Forms.GroupBox();
            this.btnURLCANCEL = new System.Windows.Forms.Button();
            this.lblURL = new System.Windows.Forms.Label();
            this.btnURL = new System.Windows.Forms.Button();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.grpFTP = new System.Windows.Forms.GroupBox();
            this.rbSFTP = new System.Windows.Forms.RadioButton();
            this.rbFTP = new System.Windows.Forms.RadioButton();
            this.txtFTPDir = new System.Windows.Forms.TextBox();
            this.lblFTPDir = new System.Windows.Forms.Label();
            this.txtFTPIP = new System.Windows.Forms.TextBox();
            this.txtFTPPw = new System.Windows.Forms.TextBox();
            this.txtFTPUser = new System.Windows.Forms.TextBox();
            this.btnFTPCancel = new System.Windows.Forms.Button();
            this.btnFTPSave = new System.Windows.Forms.Button();
            this.lblFTPServerIP = new System.Windows.Forms.Label();
            this.lblFTPPassword = new System.Windows.Forms.Label();
            this.lblFTPUser = new System.Windows.Forms.Label();
            this.lblFTPFilename = new System.Windows.Forms.Label();
            this.txtFTPFilename = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGChannel)).BeginInit();
            this.grpChange.SuspendLayout();
            this.grpURL.SuspendLayout();
            this.grpFTP.SuspendLayout();
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
            this.TSMOpenM3U,
            this.TSMFTP,
            this.TSMSave});
            this.TSMFile.Name = "TSMFile";
            this.TSMFile.Size = new System.Drawing.Size(46, 20);
            this.TSMFile.Text = "Datei";
            // 
            // TSMNew
            // 
            this.TSMNew.Name = "TSMNew";
            this.TSMNew.Size = new System.Drawing.Size(195, 22);
            this.TSMNew.Text = "Erstelle eine neue Datei";
            this.TSMNew.Click += new System.EventHandler(this.TSMNew_Click);
            // 
            // TSMOpenM3U
            // 
            this.TSMOpenM3U.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMM3UfromFile,
            this.TSMM3UfromURL,
            this.TSMM3UfromCode});
            this.TSMOpenM3U.Name = "TSMOpenM3U";
            this.TSMOpenM3U.Size = new System.Drawing.Size(195, 22);
            this.TSMOpenM3U.Text = "M3U-Datei hinzufügen";
            // 
            // TSMM3UfromFile
            // 
            this.TSMM3UfromFile.Name = "TSMM3UfromFile";
            this.TSMM3UfromFile.Size = new System.Drawing.Size(214, 22);
            this.TSMM3UfromFile.Text = "M3U - Datei öffnen";
            this.TSMM3UfromFile.Click += new System.EventHandler(this.TSMM3UfromFile_Click);
            // 
            // TSMM3UfromURL
            // 
            this.TSMM3UfromURL.Name = "TSMM3UfromURL";
            this.TSMM3UfromURL.Size = new System.Drawing.Size(214, 22);
            this.TSMM3UfromURL.Text = "M3U - Datei herunterladen";
            this.TSMM3UfromURL.Click += new System.EventHandler(this.TSMM3UfromURL_Click);
            // 
            // TSMM3UfromCode
            // 
            this.TSMM3UfromCode.Name = "TSMM3UfromCode";
            this.TSMM3UfromCode.Size = new System.Drawing.Size(214, 22);
            this.TSMM3UfromCode.Text = "M3U - Code einfügen";
            this.TSMM3UfromCode.Click += new System.EventHandler(this.TSMM3UfromCode_Click);
            // 
            // TSMFTP
            // 
            this.TSMFTP.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMFTPConfig,
            this.TSMFTPUpload});
            this.TSMFTP.Name = "TSMFTP";
            this.TSMFTP.Size = new System.Drawing.Size(195, 22);
            this.TSMFTP.Text = "FTP - Server";
            // 
            // TSMFTPConfig
            // 
            this.TSMFTPConfig.Name = "TSMFTPConfig";
            this.TSMFTPConfig.Size = new System.Drawing.Size(267, 22);
            this.TSMFTPConfig.Text = "Einstellungen";
            this.TSMFTPConfig.Click += new System.EventHandler(this.TSMFTPConfig_Click);
            // 
            // TSMFTPUpload
            // 
            this.TSMFTPUpload.Name = "TSMFTPUpload";
            this.TSMFTPUpload.Size = new System.Drawing.Size(267, 22);
            this.TSMFTPUpload.Text = "M3U-Liste auf FTP-Server hochladen";
            this.TSMFTPUpload.Click += new System.EventHandler(this.TSMFTPUpload_Click);
            // 
            // TSMSave
            // 
            this.TSMSave.Name = "TSMSave";
            this.TSMSave.Size = new System.Drawing.Size(195, 22);
            this.TSMSave.Text = "Speichern unter...";
            this.TSMSave.Click += new System.EventHandler(this.TSMSave_Click);
            // 
            // TSMTools
            // 
            this.TSMTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMBlacklist,
            this.TSMDuplicate,
            this.TSMLogo,
            this.TSMEPG,
            this.TSMIP});
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
            this.TSMOpenEPG,
            this.TSMEpgCheckSimpleIPTV});
            this.TSMEPG.Name = "TSMEPG";
            this.TSMEPG.Size = new System.Drawing.Size(171, 22);
            this.TSMEPG.Text = "EPG";
            // 
            // TSMOpenEPG
            // 
            this.TSMOpenEPG.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMOpenEPGFromFile,
            this.TSMOpenEPGFromInternet});
            this.TSMOpenEPG.Name = "TSMOpenEPG";
            this.TSMOpenEPG.Size = new System.Drawing.Size(268, 22);
            this.TSMOpenEPG.Text = "EPG-Datei öffnen";
            // 
            // TSMOpenEPGFromFile
            // 
            this.TSMOpenEPGFromFile.Name = "TSMOpenEPGFromFile";
            this.TSMOpenEPGFromFile.Size = new System.Drawing.Size(212, 22);
            this.TSMOpenEPGFromFile.Text = "Öffne EPG vom Computer";
            this.TSMOpenEPGFromFile.Click += new System.EventHandler(this.TSMOpenEPGFromFile_Click);
            // 
            // TSMOpenEPGFromInternet
            // 
            this.TSMOpenEPGFromInternet.Name = "TSMOpenEPGFromInternet";
            this.TSMOpenEPGFromInternet.Size = new System.Drawing.Size(212, 22);
            this.TSMOpenEPGFromInternet.Text = "Öffne EPG vom Internet";
            this.TSMOpenEPGFromInternet.Click += new System.EventHandler(this.TSMOpenEPGFromInternet_Click);
            // 
            // TSMEpgCheckSimpleIPTV
            // 
            this.TSMEpgCheckSimpleIPTV.CheckOnClick = true;
            this.TSMEpgCheckSimpleIPTV.Name = "TSMEpgCheckSimpleIPTV";
            this.TSMEpgCheckSimpleIPTV.Size = new System.Drawing.Size(268, 22);
            this.TSMEpgCheckSimpleIPTV.Text = "Sender für Simple IPTV umbenennen";
            this.TSMEpgCheckSimpleIPTV.Click += new System.EventHandler(this.TSMEpgCheckSimpleIPTV_Click);
            // 
            // TSMIP
            // 
            this.TSMIP.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMRenameIPEndToM3U8});
            this.TSMIP.Name = "TSMIP";
            this.TSMIP.Size = new System.Drawing.Size(171, 22);
            this.TSMIP.Text = "IP";
            // 
            // TSMRenameIPEndToM3U8
            // 
            this.TSMRenameIPEndToM3U8.Name = "TSMRenameIPEndToM3U8";
            this.TSMRenameIPEndToM3U8.Size = new System.Drawing.Size(209, 22);
            this.TSMRenameIPEndToM3U8.Text = ".ts in .m3u8 umbenennen";
            this.TSMRenameIPEndToM3U8.Click += new System.EventHandler(this.TSMRenameIPEndToM3U8_Click);
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
            this.TSMLanguage,
            this.TSMCheckUpdate});
            this.TSMOthers.Name = "TSMOthers";
            this.TSMOthers.Size = new System.Drawing.Size(69, 20);
            this.TSMOthers.Text = "Sonstiges";
            // 
            // TSMInfo
            // 
            this.TSMInfo.Name = "TSMInfo";
            this.TSMInfo.Size = new System.Drawing.Size(186, 22);
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
            this.TSMLanguage.Size = new System.Drawing.Size(186, 22);
            this.TSMLanguage.Text = "Sprache ändern";
            // 
            // TSMEng
            // 
            this.TSMEng.Name = "TSMEng";
            this.TSMEng.Size = new System.Drawing.Size(152, 22);
            this.TSMEng.Text = "English";
            this.TSMEng.Click += new System.EventHandler(this.TSMEng_Click);
            // 
            // TSMIta
            // 
            this.TSMIta.Name = "TSMIta";
            this.TSMIta.Size = new System.Drawing.Size(152, 22);
            this.TSMIta.Text = "Italiano";
            this.TSMIta.Click += new System.EventHandler(this.TSMIta_Click);
            // 
            // TSMGer
            // 
            this.TSMGer.Name = "TSMGer";
            this.TSMGer.Size = new System.Drawing.Size(152, 22);
            this.TSMGer.Text = "Deutsch";
            this.TSMGer.Click += new System.EventHandler(this.TSMGer_Click);
            // 
            // TSMCheckUpdate
            // 
            this.TSMCheckUpdate.Name = "TSMCheckUpdate";
            this.TSMCheckUpdate.Size = new System.Drawing.Size(186, 22);
            this.TSMCheckUpdate.Text = "Nach Updates prüfen";
            this.TSMCheckUpdate.Click += new System.EventHandler(this.TSMCheckUpdate_Click);
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
            this.DGChannel.SelectionChanged += new System.EventHandler(this.DGChannel_SelectionChanged);
            this.DGChannel.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DGChannel_KeyUp);
            // 
            // grpChange
            // 
            this.grpChange.Controls.Add(this.btnFavourite);
            this.grpChange.Controls.Add(this.CBChangeGroup);
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
            // btnFavourite
            // 
            this.btnFavourite.Location = new System.Drawing.Point(6, 410);
            this.btnFavourite.Name = "btnFavourite";
            this.btnFavourite.Size = new System.Drawing.Size(133, 34);
            this.btnFavourite.TabIndex = 18;
            this.btnFavourite.Text = "Favoriten bearbeiten";
            this.btnFavourite.UseVisualStyleBackColor = true;
            this.btnFavourite.Click += new System.EventHandler(this.btnFavourite_Click);
            // 
            // CBChangeGroup
            // 
            this.CBChangeGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBChangeGroup.FormattingEnabled = true;
            this.CBChangeGroup.Location = new System.Drawing.Point(6, 148);
            this.CBChangeGroup.Name = "CBChangeGroup";
            this.CBChangeGroup.Size = new System.Drawing.Size(173, 21);
            this.CBChangeGroup.TabIndex = 17;
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
            this.txtChangeIDEPG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChangeIDEPG_KeyPress);
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
            this.txtChangeEPGShift.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChangeEPGShift_KeyPress_1);
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
            this.txtChangeLogo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChangeLogo_KeyPress);
            // 
            // txtChangeIP
            // 
            this.txtChangeIP.Location = new System.Drawing.Point(8, 188);
            this.txtChangeIP.Name = "txtChangeIP";
            this.txtChangeIP.Size = new System.Drawing.Size(310, 20);
            this.txtChangeIP.TabIndex = 5;
            this.txtChangeIP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChangeIP_KeyPress);
            // 
            // txtChangeNameEPG
            // 
            this.txtChangeNameEPG.Location = new System.Drawing.Point(6, 110);
            this.txtChangeNameEPG.Name = "txtChangeNameEPG";
            this.txtChangeNameEPG.Size = new System.Drawing.Size(210, 20);
            this.txtChangeNameEPG.TabIndex = 1;
            this.txtChangeNameEPG.TextChanged += new System.EventHandler(this.txtChangeNameEPG_TextChanged);
            this.txtChangeNameEPG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChangeNameEPG_KeyPress);
            // 
            // txtChangeName
            // 
            this.txtChangeName.Location = new System.Drawing.Point(6, 32);
            this.txtChangeName.Name = "txtChangeName";
            this.txtChangeName.Size = new System.Drawing.Size(210, 20);
            this.txtChangeName.TabIndex = 0;
            this.txtChangeName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChangeName_KeyPress);
            // 
            // PbLoad
            // 
            this.PbLoad.Location = new System.Drawing.Point(190, 227);
            this.PbLoad.Name = "PbLoad";
            this.PbLoad.Size = new System.Drawing.Size(202, 23);
            this.PbLoad.TabIndex = 6;
            this.PbLoad.Visible = false;
            // 
            // grpURL
            // 
            this.grpURL.Controls.Add(this.btnURLCANCEL);
            this.grpURL.Controls.Add(this.lblURL);
            this.grpURL.Controls.Add(this.btnURL);
            this.grpURL.Controls.Add(this.txtURL);
            this.grpURL.Location = new System.Drawing.Point(66, 24);
            this.grpURL.Name = "grpURL";
            this.grpURL.Size = new System.Drawing.Size(582, 72);
            this.grpURL.TabIndex = 7;
            this.grpURL.TabStop = false;
            this.grpURL.Visible = false;
            // 
            // btnURLCANCEL
            // 
            this.btnURLCANCEL.Location = new System.Drawing.Point(509, 29);
            this.btnURLCANCEL.Name = "btnURLCANCEL";
            this.btnURLCANCEL.Size = new System.Drawing.Size(67, 23);
            this.btnURLCANCEL.TabIndex = 3;
            this.btnURLCANCEL.Text = "Cancel";
            this.btnURLCANCEL.UseVisualStyleBackColor = true;
            this.btnURLCANCEL.Click += new System.EventHandler(this.btnURLCANCEL_Click);
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(6, 13);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(29, 13);
            this.lblURL.TabIndex = 2;
            this.lblURL.Text = "URL";
            // 
            // btnURL
            // 
            this.btnURL.Location = new System.Drawing.Point(430, 29);
            this.btnURL.Name = "btnURL";
            this.btnURL.Size = new System.Drawing.Size(67, 23);
            this.btnURL.TabIndex = 1;
            this.btnURL.Text = "OK";
            this.btnURL.UseVisualStyleBackColor = true;
            this.btnURL.Click += new System.EventHandler(this.btnURL_Click);
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(6, 29);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(418, 20);
            this.txtURL.TabIndex = 0;
            this.txtURL.Text = "http://";
            // 
            // grpFTP
            // 
            this.grpFTP.BackColor = System.Drawing.Color.DodgerBlue;
            this.grpFTP.Controls.Add(this.txtFTPFilename);
            this.grpFTP.Controls.Add(this.lblFTPFilename);
            this.grpFTP.Controls.Add(this.rbSFTP);
            this.grpFTP.Controls.Add(this.rbFTP);
            this.grpFTP.Controls.Add(this.txtFTPDir);
            this.grpFTP.Controls.Add(this.lblFTPDir);
            this.grpFTP.Controls.Add(this.txtFTPIP);
            this.grpFTP.Controls.Add(this.txtFTPPw);
            this.grpFTP.Controls.Add(this.txtFTPUser);
            this.grpFTP.Controls.Add(this.btnFTPCancel);
            this.grpFTP.Controls.Add(this.btnFTPSave);
            this.grpFTP.Controls.Add(this.lblFTPServerIP);
            this.grpFTP.Controls.Add(this.lblFTPPassword);
            this.grpFTP.Controls.Add(this.lblFTPUser);
            this.grpFTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpFTP.Location = new System.Drawing.Point(245, 276);
            this.grpFTP.Name = "grpFTP";
            this.grpFTP.Size = new System.Drawing.Size(335, 237);
            this.grpFTP.TabIndex = 8;
            this.grpFTP.TabStop = false;
            this.grpFTP.Text = "FTP";
            this.grpFTP.Visible = false;
            // 
            // rbSFTP
            // 
            this.rbSFTP.AutoSize = true;
            this.rbSFTP.Location = new System.Drawing.Point(172, 19);
            this.rbSFTP.Name = "rbSFTP";
            this.rbSFTP.Size = new System.Drawing.Size(52, 17);
            this.rbSFTP.TabIndex = 12;
            this.rbSFTP.Text = "SFTP";
            this.rbSFTP.UseVisualStyleBackColor = true;
            // 
            // rbFTP
            // 
            this.rbFTP.AutoSize = true;
            this.rbFTP.Location = new System.Drawing.Point(90, 19);
            this.rbFTP.Name = "rbFTP";
            this.rbFTP.Size = new System.Drawing.Size(45, 17);
            this.rbFTP.TabIndex = 11;
            this.rbFTP.Text = "FTP";
            this.rbFTP.UseVisualStyleBackColor = true;
            // 
            // txtFTPDir
            // 
            this.txtFTPDir.Location = new System.Drawing.Point(90, 126);
            this.txtFTPDir.Name = "txtFTPDir";
            this.txtFTPDir.Size = new System.Drawing.Size(228, 20);
            this.txtFTPDir.TabIndex = 10;
            this.txtFTPDir.Text = "/";
            // 
            // lblFTPDir
            // 
            this.lblFTPDir.AutoSize = true;
            this.lblFTPDir.Location = new System.Drawing.Point(35, 129);
            this.lblFTPDir.Name = "lblFTPDir";
            this.lblFTPDir.Size = new System.Drawing.Size(49, 13);
            this.lblFTPDir.TabIndex = 9;
            this.lblFTPDir.Text = "Directory";
            // 
            // txtFTPIP
            // 
            this.txtFTPIP.Location = new System.Drawing.Point(90, 103);
            this.txtFTPIP.Name = "txtFTPIP";
            this.txtFTPIP.Size = new System.Drawing.Size(228, 20);
            this.txtFTPIP.TabIndex = 8;
            // 
            // txtFTPPw
            // 
            this.txtFTPPw.Location = new System.Drawing.Point(90, 78);
            this.txtFTPPw.Name = "txtFTPPw";
            this.txtFTPPw.Size = new System.Drawing.Size(228, 20);
            this.txtFTPPw.TabIndex = 7;
            // 
            // txtFTPUser
            // 
            this.txtFTPUser.Location = new System.Drawing.Point(90, 54);
            this.txtFTPUser.Name = "txtFTPUser";
            this.txtFTPUser.Size = new System.Drawing.Size(228, 20);
            this.txtFTPUser.TabIndex = 6;
            // 
            // btnFTPCancel
            // 
            this.btnFTPCancel.Location = new System.Drawing.Point(243, 198);
            this.btnFTPCancel.Name = "btnFTPCancel";
            this.btnFTPCancel.Size = new System.Drawing.Size(75, 23);
            this.btnFTPCancel.TabIndex = 5;
            this.btnFTPCancel.Text = "Cancel";
            this.btnFTPCancel.UseVisualStyleBackColor = true;
            this.btnFTPCancel.Click += new System.EventHandler(this.btnFTPCancel_Click);
            // 
            // btnFTPSave
            // 
            this.btnFTPSave.Location = new System.Drawing.Point(90, 198);
            this.btnFTPSave.Name = "btnFTPSave";
            this.btnFTPSave.Size = new System.Drawing.Size(75, 23);
            this.btnFTPSave.TabIndex = 4;
            this.btnFTPSave.Text = "Save";
            this.btnFTPSave.UseVisualStyleBackColor = true;
            this.btnFTPSave.Click += new System.EventHandler(this.btnFTPSave_Click);
            // 
            // lblFTPServerIP
            // 
            this.lblFTPServerIP.AutoSize = true;
            this.lblFTPServerIP.Location = new System.Drawing.Point(8, 106);
            this.lblFTPServerIP.Name = "lblFTPServerIP";
            this.lblFTPServerIP.Size = new System.Drawing.Size(76, 13);
            this.lblFTPServerIP.TabIndex = 2;
            this.lblFTPServerIP.Text = "Hostname / IP";
            // 
            // lblFTPPassword
            // 
            this.lblFTPPassword.AutoSize = true;
            this.lblFTPPassword.Location = new System.Drawing.Point(31, 81);
            this.lblFTPPassword.Name = "lblFTPPassword";
            this.lblFTPPassword.Size = new System.Drawing.Size(53, 13);
            this.lblFTPPassword.TabIndex = 1;
            this.lblFTPPassword.Text = "Password";
            // 
            // lblFTPUser
            // 
            this.lblFTPUser.AutoSize = true;
            this.lblFTPUser.Location = new System.Drawing.Point(29, 57);
            this.lblFTPUser.Name = "lblFTPUser";
            this.lblFTPUser.Size = new System.Drawing.Size(55, 13);
            this.lblFTPUser.TabIndex = 0;
            this.lblFTPUser.Text = "Username";
            // 
            // lblFTPFilename
            // 
            this.lblFTPFilename.AutoSize = true;
            this.lblFTPFilename.Location = new System.Drawing.Point(35, 154);
            this.lblFTPFilename.Name = "lblFTPFilename";
            this.lblFTPFilename.Size = new System.Drawing.Size(49, 13);
            this.lblFTPFilename.TabIndex = 13;
            this.lblFTPFilename.Text = "Filename";
            // 
            // txtFTPFilename
            // 
            this.txtFTPFilename.Location = new System.Drawing.Point(90, 151);
            this.txtFTPFilename.Name = "txtFTPFilename";
            this.txtFTPFilename.Size = new System.Drawing.Size(228, 20);
            this.txtFTPFilename.TabIndex = 14;
            this.txtFTPFilename.Text = "List.m3u";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 562);
            this.Controls.Add(this.grpFTP);
            this.Controls.Add(this.grpURL);
            this.Controls.Add(this.PbLoad);
            this.Controls.Add(this.grpChange);
            this.Controls.Add(this.DGChannel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
            this.grpURL.ResumeLayout(false);
            this.grpURL.PerformLayout();
            this.grpFTP.ResumeLayout(false);
            this.grpFTP.PerformLayout();
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
        private System.Windows.Forms.TextBox txtChangeNameEPG;
        private System.Windows.Forms.TextBox txtChangeName;
        private System.Windows.Forms.ProgressBar PbLoad;
        private System.Windows.Forms.ComboBox CBChangeGroup;
        private System.Windows.Forms.Button btnFavourite;
        private System.Windows.Forms.ToolStripMenuItem TSMCheckUpdate;
        private System.Windows.Forms.ToolStripMenuItem TSMIP;
        private System.Windows.Forms.ToolStripMenuItem TSMRenameIPEndToM3U8;
        private System.Windows.Forms.ToolStripMenuItem TSMOpenEPG;
        private System.Windows.Forms.ToolStripMenuItem TSMOpenEPGFromFile;
        private System.Windows.Forms.ToolStripMenuItem TSMOpenEPGFromInternet;
        private System.Windows.Forms.GroupBox grpURL;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.Button btnURL;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Button btnURLCANCEL;
        private System.Windows.Forms.ToolStripMenuItem TSMOpenM3U;
        private System.Windows.Forms.ToolStripMenuItem TSMM3UfromFile;
        private System.Windows.Forms.ToolStripMenuItem TSMM3UfromURL;
        private System.Windows.Forms.ToolStripMenuItem TSMM3UfromCode;
        private System.Windows.Forms.ToolStripMenuItem TSMFTP;
        private System.Windows.Forms.ToolStripMenuItem TSMFTPConfig;
        private System.Windows.Forms.ToolStripMenuItem TSMFTPUpload;
        private System.Windows.Forms.GroupBox grpFTP;
        private System.Windows.Forms.TextBox txtFTPIP;
        private System.Windows.Forms.TextBox txtFTPPw;
        private System.Windows.Forms.TextBox txtFTPUser;
        private System.Windows.Forms.Button btnFTPCancel;
        private System.Windows.Forms.Button btnFTPSave;
        private System.Windows.Forms.Label lblFTPServerIP;
        private System.Windows.Forms.Label lblFTPPassword;
        private System.Windows.Forms.Label lblFTPUser;
        private System.Windows.Forms.TextBox txtFTPDir;
        private System.Windows.Forms.Label lblFTPDir;
        private System.Windows.Forms.RadioButton rbSFTP;
        private System.Windows.Forms.RadioButton rbFTP;
        private System.Windows.Forms.TextBox txtFTPFilename;
        private System.Windows.Forms.Label lblFTPFilename;
    }
}

