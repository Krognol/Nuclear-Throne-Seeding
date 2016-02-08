namespace NT_Seeding
{
    partial class Form1
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
            this.seedTextBox = new System.Windows.Forms.TextBox();
            this.applySeed = new System.Windows.Forms.Button();
            this.deleteFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // seedTextBox
            // 
            this.seedTextBox.Location = new System.Drawing.Point(13, 13);
            this.seedTextBox.Name = "seedTextBox";
            this.seedTextBox.Size = new System.Drawing.Size(416, 20);
            this.seedTextBox.TabIndex = 0;
            // 
            // applySeed
            // 
            this.applySeed.Location = new System.Drawing.Point(77, 55);
            this.applySeed.Name = "applySeed";
            this.applySeed.Size = new System.Drawing.Size(75, 23);
            this.applySeed.TabIndex = 1;
            this.applySeed.Text = "Set seed";
            this.applySeed.UseVisualStyleBackColor = true;
            this.applySeed.Click += new System.EventHandler(this.applySeed_Click);
            // 
            // deleteFile
            // 
            this.deleteFile.Location = new System.Drawing.Point(249, 55);
            this.deleteFile.Name = "deleteFile";
            this.deleteFile.Size = new System.Drawing.Size(107, 23);
            this.deleteFile.TabIndex = 2;
            this.deleteFile.Text = "Delete Seed File";
            this.deleteFile.UseVisualStyleBackColor = true;
            this.deleteFile.Click += new System.EventHandler(this.deleteFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 90);
            this.Controls.Add(this.deleteFile);
            this.Controls.Add(this.applySeed);
            this.Controls.Add(this.seedTextBox);
            this.Name = "Form1";
            this.Text = "Nuclear Throne Seeding";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox seedTextBox;
        private System.Windows.Forms.Button applySeed;
        private System.Windows.Forms.Button deleteFile;
    }
}

