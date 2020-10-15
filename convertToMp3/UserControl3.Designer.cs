namespace convertToMp3
{
    partial class UserControl3
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.noDirectory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // noDirectory
            // 
            this.noDirectory.AutoSize = true;
            this.noDirectory.BackColor = System.Drawing.Color.Red;
            this.noDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.noDirectory.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.noDirectory.Location = new System.Drawing.Point(82, 86);
            this.noDirectory.Name = "noDirectory";
            this.noDirectory.Size = new System.Drawing.Size(984, 58);
            this.noDirectory.TabIndex = 0;
            this.noDirectory.Text = "ERROR: You have not specified a directory";
            // 
            // UserControl3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.noDirectory);
            this.Name = "UserControl3";
            this.Size = new System.Drawing.Size(2160, 1227);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label noDirectory;
    }
}
