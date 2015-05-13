namespace IPTVEdit
{
    partial class FormAddCode
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(780, 339);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(193, 358);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(135, 37);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Hinzufügen";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(452, 358);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(132, 37);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormAddCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 407);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.richTextBox1);
            this.Name = "FormAddCode";
            this.Text = "M3U Code";
            this.ResumeLayout(false);

        }
        /*    private void InitializeComponent()
            {
                this.richTextBox1 = new System.Windows.Forms.RichTextBox();
                this.btnCancel = new System.Windows.Forms.Button();
                this.btnAdd = new System.Windows.Forms.Button();
                this.SuspendLayout();
                // 
                // richTextBox1
                // 
                this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Top;
                this.richTextBox1.Location = new System.Drawing.Point(0, 0);
                this.richTextBox1.Name = "richTextBox1";
                this.richTextBox1.Size = new System.Drawing.Size(780, 339);
                this.richTextBox1.TabIndex = 1;
                this.richTextBox1.Text = "";
                // 
                // btnCancel
                // 
                this.btnCancel.Location = new System.Drawing.Point(443, 358);
                this.btnCancel.Name = "btnCancel";
                this.btnCancel.Size = new System.Drawing.Size(132, 37);
                this.btnCancel.TabIndex = 4;
                this.btnCancel.Text = "Abbrechen";
                this.btnCancel.UseVisualStyleBackColor = true;
                // 
                // btnAdd
                // 
                this.btnAdd.Location = new System.Drawing.Point(184, 358);
                this.btnAdd.Name = "btnAdd";
                this.btnAdd.Size = new System.Drawing.Size(135, 37);
                this.btnAdd.TabIndex = 3;
                this.btnAdd.Text = "Hinzufügen";
                this.btnAdd.UseVisualStyleBackColor = true;
                // 
                // FormAddCode
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.ClientSize = new System.Drawing.Size(780, 407);
                this.Controls.Add(this.btnCancel);
                this.Controls.Add(this.btnAdd);
                this.Controls.Add(this.richTextBox1);
                this.Name = "FormAddCode";
                this.Text = "M3U Code";
                this.ResumeLayout(false);

            }*/

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
    }
}