namespace IPTVEdit
{
    partial class FormFavourite
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
            this.lstFav = new System.Windows.Forms.ListBox();
            this.btnChangeName = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblFav = new System.Windows.Forms.Label();
            this.txtNewFav = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNotSave = new System.Windows.Forms.Button();
            this.lblNewGroup = new System.Windows.Forms.Label();
            this.txtFav = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstFav
            // 
            this.lstFav.FormattingEnabled = true;
            this.lstFav.Location = new System.Drawing.Point(12, 28);
            this.lstFav.Name = "lstFav";
            this.lstFav.Size = new System.Drawing.Size(218, 225);
            this.lstFav.TabIndex = 0;
            this.lstFav.SelectedIndexChanged += new System.EventHandler(this.lstFav_SelectedIndexChanged);
            // 
            // btnChangeName
            // 
            this.btnChangeName.Location = new System.Drawing.Point(236, 54);
            this.btnChangeName.Name = "btnChangeName";
            this.btnChangeName.Size = new System.Drawing.Size(111, 32);
            this.btnChangeName.TabIndex = 1;
            this.btnChangeName.Text = "Ändere Name";
            this.btnChangeName.UseVisualStyleBackColor = true;
            this.btnChangeName.Click += new System.EventHandler(this.btnChangeName_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(236, 215);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(209, 35);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "Erstelle neue Favoritgruppe";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(236, 102);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(111, 33);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Favorit löschen";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblFav
            // 
            this.lblFav.AutoSize = true;
            this.lblFav.Location = new System.Drawing.Point(90, 9);
            this.lblFav.Name = "lblFav";
            this.lblFav.Size = new System.Drawing.Size(51, 13);
            this.lblFav.TabIndex = 5;
            this.lblFav.Text = "Favoriten";
            // 
            // txtNewFav
            // 
            this.txtNewFav.Location = new System.Drawing.Point(236, 189);
            this.txtNewFav.Name = "txtNewFav";
            this.txtNewFav.Size = new System.Drawing.Size(209, 20);
            this.txtNewFav.TabIndex = 6;
            this.txtNewFav.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNewFav_KeyPress);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(34, 290);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(142, 41);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Änderungen speichern";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNotSave
            // 
            this.btnNotSave.Location = new System.Drawing.Point(279, 290);
            this.btnNotSave.Name = "btnNotSave";
            this.btnNotSave.Size = new System.Drawing.Size(142, 41);
            this.btnNotSave.TabIndex = 8;
            this.btnNotSave.Text = "Änderungen nicht speichern";
            this.btnNotSave.UseVisualStyleBackColor = true;
            this.btnNotSave.Click += new System.EventHandler(this.btnNotSave_Click);
            // 
            // lblNewGroup
            // 
            this.lblNewGroup.AutoSize = true;
            this.lblNewGroup.Location = new System.Drawing.Point(276, 173);
            this.lblNewGroup.Name = "lblNewGroup";
            this.lblNewGroup.Size = new System.Drawing.Size(112, 13);
            this.lblNewGroup.TabIndex = 9;
            this.lblNewGroup.Text = "Neue Favorit - Gruppe";
            // 
            // txtFav
            // 
            this.txtFav.Location = new System.Drawing.Point(236, 28);
            this.txtFav.Name = "txtFav";
            this.txtFav.Size = new System.Drawing.Size(209, 20);
            this.txtFav.TabIndex = 10;
            this.txtFav.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFav_KeyPress);
            // 
            // FormFavourite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 353);
            this.Controls.Add(this.txtFav);
            this.Controls.Add(this.lblNewGroup);
            this.Controls.Add(this.btnNotSave);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNewFav);
            this.Controls.Add(this.lblFav);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnChangeName);
            this.Controls.Add(this.lstFav);
            this.Name = "FormFavourite";
            this.Text = "Fav - Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstFav;
        private System.Windows.Forms.Button btnChangeName;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblFav;
        private System.Windows.Forms.TextBox txtNewFav;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNotSave;
        private System.Windows.Forms.Label lblNewGroup;
        private System.Windows.Forms.TextBox txtFav;
    }
}