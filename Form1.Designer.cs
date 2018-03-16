namespace ExePicker
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.launchButton = new System.Windows.Forms.Button();
            this.stayOpenCheckBox = new System.Windows.Forms.CheckBox();
            this.gameInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.gameListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "title.png";
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(616, 351);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // launchButton
            // 
            this.launchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.launchButton.Location = new System.Drawing.Point(774, 432);
            this.launchButton.Name = "launchButton";
            this.launchButton.Size = new System.Drawing.Size(75, 23);
            this.launchButton.TabIndex = 1;
            this.launchButton.Text = "Launch!";
            this.launchButton.UseVisualStyleBackColor = true;
            // 
            // stayOpenCheckBox
            // 
            this.stayOpenCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.stayOpenCheckBox.AutoSize = true;
            this.stayOpenCheckBox.Location = new System.Drawing.Point(647, 436);
            this.stayOpenCheckBox.Name = "stayOpenCheckBox";
            this.stayOpenCheckBox.Size = new System.Drawing.Size(121, 17);
            this.stayOpenCheckBox.TabIndex = 2;
            this.stayOpenCheckBox.Text = "keep launcher open";
            this.stayOpenCheckBox.UseVisualStyleBackColor = true;
            // 
            // gameInfoGroupBox
            // 
            this.gameInfoGroupBox.Location = new System.Drawing.Point(12, 369);
            this.gameInfoGroupBox.Name = "gameInfoGroupBox";
            this.gameInfoGroupBox.Size = new System.Drawing.Size(616, 86);
            this.gameInfoGroupBox.TabIndex = 4;
            this.gameInfoGroupBox.TabStop = false;
            // 
            // gameListBox
            // 
            this.gameListBox.FormattingEnabled = true;
            this.gameListBox.Location = new System.Drawing.Point(634, 12);
            this.gameListBox.Name = "gameListBox";
            this.gameListBox.Size = new System.Drawing.Size(215, 407);
            this.gameListBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(861, 467);
            this.Controls.Add(this.gameListBox);
            this.Controls.Add(this.gameInfoGroupBox);
            this.Controls.Add(this.stayOpenCheckBox);
            this.Controls.Add(this.launchButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "ExePicker by gekkedev";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button launchButton;
        private System.Windows.Forms.CheckBox stayOpenCheckBox;
        private System.Windows.Forms.ListBox gameListBox;
        private System.Windows.Forms.GroupBox gameInfoGroupBox;
    }
}

