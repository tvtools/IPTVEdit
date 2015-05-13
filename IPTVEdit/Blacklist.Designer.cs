namespace IPTVEdit
{
    partial class Blacklist
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
            this.lstBlacklist = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apriBlacklistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creaUnaNuovaBlacklistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvaBlacklistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aggiungiCanaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rimuoviCanaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiaNomeDelCanaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.save = new System.Windows.Forms.SaveFileDialog();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblChannel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstBlacklist
            // 
            this.lstBlacklist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstBlacklist.FormattingEnabled = true;
            this.lstBlacklist.Location = new System.Drawing.Point(0, 24);
            this.lstBlacklist.Name = "lstBlacklist";
            this.lstBlacklist.Size = new System.Drawing.Size(876, 238);
            this.lstBlacklist.TabIndex = 0;
            this.lstBlacklist.DoubleClick += new System.EventHandler(this.lstBlacklist_DoubleClick);
            this.lstBlacklist.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lstBlacklist_KeyUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aggiungiCanaleToolStripMenuItem,
            this.rimuoviCanaleToolStripMenuItem,
            this.cambiaNomeDelCanaleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(876, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apriBlacklistToolStripMenuItem,
            this.creaUnaNuovaBlacklistToolStripMenuItem,
            this.salvaBlacklistToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // apriBlacklistToolStripMenuItem
            // 
            this.apriBlacklistToolStripMenuItem.Name = "apriBlacklistToolStripMenuItem";
            this.apriBlacklistToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.apriBlacklistToolStripMenuItem.Text = "Apri Blacklist";
            this.apriBlacklistToolStripMenuItem.Click += new System.EventHandler(this.apriBlacklistToolStripMenuItem_Click);
            // 
            // creaUnaNuovaBlacklistToolStripMenuItem
            // 
            this.creaUnaNuovaBlacklistToolStripMenuItem.Name = "creaUnaNuovaBlacklistToolStripMenuItem";
            this.creaUnaNuovaBlacklistToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.creaUnaNuovaBlacklistToolStripMenuItem.Text = "Crea una nuova Blacklist";
            this.creaUnaNuovaBlacklistToolStripMenuItem.Click += new System.EventHandler(this.creaUnaNuovaBlacklistToolStripMenuItem_Click);
            // 
            // salvaBlacklistToolStripMenuItem
            // 
            this.salvaBlacklistToolStripMenuItem.Name = "salvaBlacklistToolStripMenuItem";
            this.salvaBlacklistToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.salvaBlacklistToolStripMenuItem.Text = "Salva Blacklist";
            this.salvaBlacklistToolStripMenuItem.Click += new System.EventHandler(this.salvaBlacklistToolStripMenuItem_Click);
            // 
            // aggiungiCanaleToolStripMenuItem
            // 
            this.aggiungiCanaleToolStripMenuItem.Name = "aggiungiCanaleToolStripMenuItem";
            this.aggiungiCanaleToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.aggiungiCanaleToolStripMenuItem.Text = "Aggiungi canale (a)";
            this.aggiungiCanaleToolStripMenuItem.Click += new System.EventHandler(this.aggiungiCanaleToolStripMenuItem_Click);
            // 
            // rimuoviCanaleToolStripMenuItem
            // 
            this.rimuoviCanaleToolStripMenuItem.Name = "rimuoviCanaleToolStripMenuItem";
            this.rimuoviCanaleToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.rimuoviCanaleToolStripMenuItem.Text = "Rimuovi canale (Del)";
            this.rimuoviCanaleToolStripMenuItem.Click += new System.EventHandler(this.rimuoviCanaleToolStripMenuItem_Click);
            // 
            // cambiaNomeDelCanaleToolStripMenuItem
            // 
            this.cambiaNomeDelCanaleToolStripMenuItem.Name = "cambiaNomeDelCanaleToolStripMenuItem";
            this.cambiaNomeDelCanaleToolStripMenuItem.Size = new System.Drawing.Size(167, 20);
            this.cambiaNomeDelCanaleToolStripMenuItem.Text = "Cambia nome del canale (c)";
            this.cambiaNomeDelCanaleToolStripMenuItem.Click += new System.EventHandler(this.cambiaNomeDelCanaleToolStripMenuItem_Click);
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(55, 18);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(288, 20);
            this.txtAdd.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnChange);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.lblChannel);
            this.panel1.Controls.Add(this.txtAdd);
            this.panel1.Location = new System.Drawing.Point(50, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 58);
            this.panel1.TabIndex = 3;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(349, 16);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(71, 23);
            this.btnChange.TabIndex = 5;
            this.btnChange.Text = "Cambia";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(349, 16);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(71, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Aggiungi";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblChannel
            // 
            this.lblChannel.AutoSize = true;
            this.lblChannel.Location = new System.Drawing.Point(3, 21);
            this.lblChannel.Name = "lblChannel";
            this.lblChannel.Size = new System.Drawing.Size(40, 13);
            this.lblChannel.TabIndex = 3;
            this.lblChannel.Text = "Canale";
            // 
            // Blacklist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 262);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lstBlacklist);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Blacklist";
            this.Text = "BlacklistEditor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apriBlacklistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creaUnaNuovaBlacklistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvaBlacklistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aggiungiCanaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rimuoviCanaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiaNomeDelCanaleToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog save;
        private System.Windows.Forms.ListBox lstBlacklist;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblChannel;
        private System.Windows.Forms.TextBox txtAdd;
    }
}