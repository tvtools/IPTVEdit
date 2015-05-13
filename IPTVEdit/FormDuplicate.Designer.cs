namespace IPTVEdit
{
    partial class FormDuplicate
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
            this.checkName = new System.Windows.Forms.CheckBox();
            this.checkEPGID = new System.Windows.Forms.CheckBox();
            this.checkEPGName = new System.Windows.Forms.CheckBox();
            this.checkFavourite = new System.Windows.Forms.CheckBox();
            this.checkIP = new System.Windows.Forms.CheckBox();
            this.checkLogo = new System.Windows.Forms.CheckBox();
            this.checkTVRadio = new System.Windows.Forms.CheckBox();
            this.checkWrite = new System.Windows.Forms.CheckBox();
            this.checkSpace = new System.Windows.Forms.CheckBox();
            this.checkOneChannel = new System.Windows.Forms.CheckBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.comboOneChannel = new System.Windows.Forms.ComboBox();
            this.grpDeleteby = new System.Windows.Forms.GroupBox();
            this.lblFromTill = new System.Windows.Forms.Label();
            this.lblFromTill2 = new System.Windows.Forms.Label();
            this.comboFrom = new System.Windows.Forms.ComboBox();
            this.comboTill = new System.Windows.Forms.ComboBox();
            this.grpDeleteby.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkName
            // 
            this.checkName.AutoSize = true;
            this.checkName.Checked = true;
            this.checkName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkName.Location = new System.Drawing.Point(21, 19);
            this.checkName.Name = "checkName";
            this.checkName.Size = new System.Drawing.Size(86, 17);
            this.checkName.TabIndex = 0;
            this.checkName.Text = "Sendername";
            this.checkName.UseVisualStyleBackColor = true;
            // 
            // checkEPGID
            // 
            this.checkEPGID.AutoSize = true;
            this.checkEPGID.Location = new System.Drawing.Point(133, 19);
            this.checkEPGID.Name = "checkEPGID";
            this.checkEPGID.Size = new System.Drawing.Size(62, 17);
            this.checkEPGID.TabIndex = 1;
            this.checkEPGID.Text = "EPG-ID";
            this.checkEPGID.UseVisualStyleBackColor = true;
            // 
            // checkEPGName
            // 
            this.checkEPGName.AutoSize = true;
            this.checkEPGName.Location = new System.Drawing.Point(225, 19);
            this.checkEPGName.Name = "checkEPGName";
            this.checkEPGName.Size = new System.Drawing.Size(79, 17);
            this.checkEPGName.TabIndex = 2;
            this.checkEPGName.Text = "EPG-Name";
            this.checkEPGName.UseVisualStyleBackColor = true;
            // 
            // checkFavourite
            // 
            this.checkFavourite.AutoSize = true;
            this.checkFavourite.Location = new System.Drawing.Point(262, 42);
            this.checkFavourite.Name = "checkFavourite";
            this.checkFavourite.Size = new System.Drawing.Size(58, 17);
            this.checkFavourite.TabIndex = 3;
            this.checkFavourite.Text = "Favorit";
            this.checkFavourite.UseVisualStyleBackColor = true;
            // 
            // checkIP
            // 
            this.checkIP.AutoSize = true;
            this.checkIP.Location = new System.Drawing.Point(6, 42);
            this.checkIP.Name = "checkIP";
            this.checkIP.Size = new System.Drawing.Size(36, 17);
            this.checkIP.TabIndex = 4;
            this.checkIP.Text = "IP";
            this.checkIP.UseVisualStyleBackColor = true;
            // 
            // checkLogo
            // 
            this.checkLogo.AutoSize = true;
            this.checkLogo.Location = new System.Drawing.Point(83, 42);
            this.checkLogo.Name = "checkLogo";
            this.checkLogo.Size = new System.Drawing.Size(50, 17);
            this.checkLogo.TabIndex = 5;
            this.checkLogo.Text = "Logo";
            this.checkLogo.UseVisualStyleBackColor = true;
            // 
            // checkTVRadio
            // 
            this.checkTVRadio.AutoSize = true;
            this.checkTVRadio.Location = new System.Drawing.Point(165, 42);
            this.checkTVRadio.Name = "checkTVRadio";
            this.checkTVRadio.Size = new System.Drawing.Size(73, 17);
            this.checkTVRadio.TabIndex = 6;
            this.checkTVRadio.Text = "TV/Radio";
            this.checkTVRadio.UseVisualStyleBackColor = true;
            // 
            // checkWrite
            // 
            this.checkWrite.AutoSize = true;
            this.checkWrite.Location = new System.Drawing.Point(12, 126);
            this.checkWrite.Name = "checkWrite";
            this.checkWrite.Size = new System.Drawing.Size(209, 17);
            this.checkWrite.TabIndex = 7;
            this.checkWrite.Text = "Auf Groß - und Kleinschreibung achten";
            this.checkWrite.UseVisualStyleBackColor = true;
            // 
            // checkSpace
            // 
            this.checkSpace.AutoSize = true;
            this.checkSpace.Location = new System.Drawing.Point(12, 149);
            this.checkSpace.Name = "checkSpace";
            this.checkSpace.Size = new System.Drawing.Size(139, 17);
            this.checkSpace.TabIndex = 9;
            this.checkSpace.Text = "Auf Leerzeichen achten";
            this.checkSpace.UseVisualStyleBackColor = true;
            // 
            // checkOneChannel
            // 
            this.checkOneChannel.AutoSize = true;
            this.checkOneChannel.Location = new System.Drawing.Point(12, 185);
            this.checkOneChannel.Name = "checkOneChannel";
            this.checkOneChannel.Size = new System.Drawing.Size(222, 17);
            this.checkOneChannel.TabIndex = 10;
            this.checkOneChannel.Text = "Duplikate nur von einen Sender löschen :";
            this.checkOneChannel.UseVisualStyleBackColor = true;
            this.checkOneChannel.CheckedChanged += new System.EventHandler(this.checkOneChannel_CheckedChanged);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(12, 261);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(142, 41);
            this.btnApply.TabIndex = 11;
            this.btnApply.Text = "Anwenden";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(200, 261);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(142, 41);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // comboOneChannel
            // 
            this.comboOneChannel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboOneChannel.Enabled = false;
            this.comboOneChannel.FormattingEnabled = true;
            this.comboOneChannel.Location = new System.Drawing.Point(33, 208);
            this.comboOneChannel.Name = "comboOneChannel";
            this.comboOneChannel.Size = new System.Drawing.Size(258, 21);
            this.comboOneChannel.TabIndex = 13;
            // 
            // grpDeleteby
            // 
            this.grpDeleteby.Controls.Add(this.checkTVRadio);
            this.grpDeleteby.Controls.Add(this.checkLogo);
            this.grpDeleteby.Controls.Add(this.checkIP);
            this.grpDeleteby.Controls.Add(this.checkFavourite);
            this.grpDeleteby.Controls.Add(this.checkEPGName);
            this.grpDeleteby.Controls.Add(this.checkEPGID);
            this.grpDeleteby.Controls.Add(this.checkName);
            this.grpDeleteby.Location = new System.Drawing.Point(12, 12);
            this.grpDeleteby.Name = "grpDeleteby";
            this.grpDeleteby.Size = new System.Drawing.Size(326, 73);
            this.grpDeleteby.TabIndex = 14;
            this.grpDeleteby.TabStop = false;
            this.grpDeleteby.Text = "Lösche Sender mit gleichen...";
            // 
            // lblFromTill
            // 
            this.lblFromTill.AutoSize = true;
            this.lblFromTill.Location = new System.Drawing.Point(15, 97);
            this.lblFromTill.Name = "lblFromTill";
            this.lblFromTill.Size = new System.Drawing.Size(116, 13);
            this.lblFromTill.TabIndex = 15;
            this.lblFromTill.Text = "Duplikate löschen von ";
            // 
            // lblFromTill2
            // 
            this.lblFromTill2.AutoSize = true;
            this.lblFromTill2.Location = new System.Drawing.Point(198, 97);
            this.lblFromTill2.Name = "lblFromTill2";
            this.lblFromTill2.Size = new System.Drawing.Size(26, 13);
            this.lblFromTill2.TabIndex = 16;
            this.lblFromTill2.Text = "bis :";
            // 
            // comboFrom
            // 
            this.comboFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFrom.FormattingEnabled = true;
            this.comboFrom.Location = new System.Drawing.Point(133, 94);
            this.comboFrom.Name = "comboFrom";
            this.comboFrom.Size = new System.Drawing.Size(59, 21);
            this.comboFrom.TabIndex = 18;
            this.comboFrom.SelectedIndexChanged += new System.EventHandler(this.comboFrom_SelectedIndexChanged);
            // 
            // comboTill
            // 
            this.comboTill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTill.FormattingEnabled = true;
            this.comboTill.Location = new System.Drawing.Point(223, 94);
            this.comboTill.Name = "comboTill";
            this.comboTill.Size = new System.Drawing.Size(59, 21);
            this.comboTill.TabIndex = 19;
            this.comboTill.SelectedIndexChanged += new System.EventHandler(this.comboTill_SelectedIndexChanged);
            // 
            // FormDuplicate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 314);
            this.Controls.Add(this.comboTill);
            this.Controls.Add(this.comboFrom);
            this.Controls.Add(this.lblFromTill2);
            this.Controls.Add(this.lblFromTill);
            this.Controls.Add(this.grpDeleteby);
            this.Controls.Add(this.comboOneChannel);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.checkOneChannel);
            this.Controls.Add(this.checkSpace);
            this.Controls.Add(this.checkWrite);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDuplicate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDuplicate";
            this.grpDeleteby.ResumeLayout(false);
            this.grpDeleteby.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }
    /*    private void InitializeComponent()
        {
            this.comboTill = new System.Windows.Forms.ComboBox();
            this.comboFrom = new System.Windows.Forms.ComboBox();
            this.lblFromTill2 = new System.Windows.Forms.Label();
            this.lblFromTill = new System.Windows.Forms.Label();
            this.grpDeleteby = new System.Windows.Forms.GroupBox();
            this.checkTVRadio = new System.Windows.Forms.CheckBox();
            this.checkLogo = new System.Windows.Forms.CheckBox();
            this.checkIP = new System.Windows.Forms.CheckBox();
            this.checkFavourite = new System.Windows.Forms.CheckBox();
            this.checkEPGName = new System.Windows.Forms.CheckBox();
            this.checkEPGID = new System.Windows.Forms.CheckBox();
            this.checkName = new System.Windows.Forms.CheckBox();
            this.comboOneChannel = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.checkOneChannel = new System.Windows.Forms.CheckBox();
            this.checkSpace = new System.Windows.Forms.CheckBox();
            this.checkWrite = new System.Windows.Forms.CheckBox();
            this.grpDeleteby.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboTill
            // 
            this.comboTill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTill.FormattingEnabled = true;
            this.comboTill.Location = new System.Drawing.Point(223, 94);
            this.comboTill.Name = "comboTill";
            this.comboTill.Size = new System.Drawing.Size(59, 21);
            this.comboTill.TabIndex = 30;
            // 
            // comboFrom
            // 
            this.comboFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFrom.FormattingEnabled = true;
            this.comboFrom.Location = new System.Drawing.Point(133, 94);
            this.comboFrom.Name = "comboFrom";
            this.comboFrom.Size = new System.Drawing.Size(59, 21);
            this.comboFrom.TabIndex = 29;
            // 
            // lblFromTill2
            // 
            this.lblFromTill2.AutoSize = true;
            this.lblFromTill2.Location = new System.Drawing.Point(198, 97);
            this.lblFromTill2.Name = "lblFromTill2";
            this.lblFromTill2.Size = new System.Drawing.Size(26, 13);
            this.lblFromTill2.TabIndex = 28;
            this.lblFromTill2.Text = "bis :";
            // 
            // lblFromTill
            // 
            this.lblFromTill.AutoSize = true;
            this.lblFromTill.Location = new System.Drawing.Point(15, 97);
            this.lblFromTill.Name = "lblFromTill";
            this.lblFromTill.Size = new System.Drawing.Size(116, 13);
            this.lblFromTill.TabIndex = 27;
            this.lblFromTill.Text = "Duplikate löschen von ";
            // 
            // grpDeleteby
            // 
            this.grpDeleteby.Controls.Add(this.checkTVRadio);
            this.grpDeleteby.Controls.Add(this.checkLogo);
            this.grpDeleteby.Controls.Add(this.checkIP);
            this.grpDeleteby.Controls.Add(this.checkFavourite);
            this.grpDeleteby.Controls.Add(this.checkEPGName);
            this.grpDeleteby.Controls.Add(this.checkEPGID);
            this.grpDeleteby.Controls.Add(this.checkName);
            this.grpDeleteby.Location = new System.Drawing.Point(12, 12);
            this.grpDeleteby.Name = "grpDeleteby";
            this.grpDeleteby.Size = new System.Drawing.Size(326, 73);
            this.grpDeleteby.TabIndex = 26;
            this.grpDeleteby.TabStop = false;
            this.grpDeleteby.Text = "Lösche Sender mit gleichen...";
            // 
            // checkTVRadio
            // 
            this.checkTVRadio.AutoSize = true;
            this.checkTVRadio.Location = new System.Drawing.Point(165, 42);
            this.checkTVRadio.Name = "checkTVRadio";
            this.checkTVRadio.Size = new System.Drawing.Size(73, 17);
            this.checkTVRadio.TabIndex = 6;
            this.checkTVRadio.Text = "TV/Radio";
            this.checkTVRadio.UseVisualStyleBackColor = true;
            // 
            // checkLogo
            // 
            this.checkLogo.AutoSize = true;
            this.checkLogo.Location = new System.Drawing.Point(83, 42);
            this.checkLogo.Name = "checkLogo";
            this.checkLogo.Size = new System.Drawing.Size(50, 17);
            this.checkLogo.TabIndex = 5;
            this.checkLogo.Text = "Logo";
            this.checkLogo.UseVisualStyleBackColor = true;
            // 
            // checkIP
            // 
            this.checkIP.AutoSize = true;
            this.checkIP.Location = new System.Drawing.Point(6, 42);
            this.checkIP.Name = "checkIP";
            this.checkIP.Size = new System.Drawing.Size(36, 17);
            this.checkIP.TabIndex = 4;
            this.checkIP.Text = "IP";
            this.checkIP.UseVisualStyleBackColor = true;
            // 
            // checkFavourite
            // 
            this.checkFavourite.AutoSize = true;
            this.checkFavourite.Location = new System.Drawing.Point(262, 42);
            this.checkFavourite.Name = "checkFavourite";
            this.checkFavourite.Size = new System.Drawing.Size(58, 17);
            this.checkFavourite.TabIndex = 3;
            this.checkFavourite.Text = "Favorit";
            this.checkFavourite.UseVisualStyleBackColor = true;
            // 
            // checkEPGName
            // 
            this.checkEPGName.AutoSize = true;
            this.checkEPGName.Location = new System.Drawing.Point(225, 19);
            this.checkEPGName.Name = "checkEPGName";
            this.checkEPGName.Size = new System.Drawing.Size(79, 17);
            this.checkEPGName.TabIndex = 2;
            this.checkEPGName.Text = "EPG-Name";
            this.checkEPGName.UseVisualStyleBackColor = true;
            // 
            // checkEPGID
            // 
            this.checkEPGID.AutoSize = true;
            this.checkEPGID.Location = new System.Drawing.Point(133, 19);
            this.checkEPGID.Name = "checkEPGID";
            this.checkEPGID.Size = new System.Drawing.Size(62, 17);
            this.checkEPGID.TabIndex = 1;
            this.checkEPGID.Text = "EPG-ID";
            this.checkEPGID.UseVisualStyleBackColor = true;
            // 
            // checkName
            // 
            this.checkName.AutoSize = true;
            this.checkName.Checked = true;
            this.checkName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkName.Location = new System.Drawing.Point(21, 19);
            this.checkName.Name = "checkName";
            this.checkName.Size = new System.Drawing.Size(86, 17);
            this.checkName.TabIndex = 0;
            this.checkName.Text = "Sendername";
            this.checkName.UseVisualStyleBackColor = true;
            // 
            // comboOneChannel
            // 
            this.comboOneChannel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboOneChannel.Enabled = false;
            this.comboOneChannel.FormattingEnabled = true;
            this.comboOneChannel.Location = new System.Drawing.Point(33, 208);
            this.comboOneChannel.Name = "comboOneChannel";
            this.comboOneChannel.Size = new System.Drawing.Size(258, 21);
            this.comboOneChannel.TabIndex = 25;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(200, 261);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(142, 41);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(12, 261);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(142, 41);
            this.btnApply.TabIndex = 23;
            this.btnApply.Text = "Anwenden";
            this.btnApply.UseVisualStyleBackColor = true;
            // 
            // checkOneChannel
            // 
            this.checkOneChannel.AutoSize = true;
            this.checkOneChannel.Location = new System.Drawing.Point(12, 185);
            this.checkOneChannel.Name = "checkOneChannel";
            this.checkOneChannel.Size = new System.Drawing.Size(222, 17);
            this.checkOneChannel.TabIndex = 22;
            this.checkOneChannel.Text = "Duplikate nur von einen Sender löschen :";
            this.checkOneChannel.UseVisualStyleBackColor = true;
            // 
            // checkSpace
            // 
            this.checkSpace.AutoSize = true;
            this.checkSpace.Location = new System.Drawing.Point(12, 149);
            this.checkSpace.Name = "checkSpace";
            this.checkSpace.Size = new System.Drawing.Size(139, 17);
            this.checkSpace.TabIndex = 21;
            this.checkSpace.Text = "Auf Leerzeichen achten";
            this.checkSpace.UseVisualStyleBackColor = true;
            // 
            // checkWrite
            // 
            this.checkWrite.AutoSize = true;
            this.checkWrite.Location = new System.Drawing.Point(12, 126);
            this.checkWrite.Name = "checkWrite";
            this.checkWrite.Size = new System.Drawing.Size(209, 17);
            this.checkWrite.TabIndex = 20;
            this.checkWrite.Text = "Auf Groß - und Kleinschreibung achten";
            this.checkWrite.UseVisualStyleBackColor = true;
            // 
            // FormDuplicate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 314);
            this.Controls.Add(this.comboTill);
            this.Controls.Add(this.comboFrom);
            this.Controls.Add(this.lblFromTill2);
            this.Controls.Add(this.lblFromTill);
            this.Controls.Add(this.grpDeleteby);
            this.Controls.Add(this.comboOneChannel);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.checkOneChannel);
            this.Controls.Add(this.checkSpace);
            this.Controls.Add(this.checkWrite);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDuplicate";
            this.Text = "FormDuplicate";
            this.grpDeleteby.ResumeLayout(false);
            this.grpDeleteby.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }*/

    #endregion

    private System.Windows.Forms.ComboBox comboTill;
        private System.Windows.Forms.ComboBox comboFrom;
        private System.Windows.Forms.Label lblFromTill2;
        private System.Windows.Forms.Label lblFromTill;
        private System.Windows.Forms.GroupBox grpDeleteby;
        private System.Windows.Forms.CheckBox checkTVRadio;
        private System.Windows.Forms.CheckBox checkLogo;
        private System.Windows.Forms.CheckBox checkIP;
        private System.Windows.Forms.CheckBox checkFavourite;
        private System.Windows.Forms.CheckBox checkEPGName;
        private System.Windows.Forms.CheckBox checkEPGID;
        private System.Windows.Forms.CheckBox checkName;
        private System.Windows.Forms.ComboBox comboOneChannel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.CheckBox checkOneChannel;
        private System.Windows.Forms.CheckBox checkSpace;
        private System.Windows.Forms.CheckBox checkWrite;
    }
}