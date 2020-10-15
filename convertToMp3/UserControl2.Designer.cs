namespace convertToMp3
{
    partial class UserControl2
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ChooseDir = new System.Windows.Forms.Button();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(111, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1142, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select the directory you want the MP3 file to be saved into";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(130, 189);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1330, 38);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ChooseDir
            // 
            this.ChooseDir.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ChooseDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ChooseDir.Location = new System.Drawing.Point(1487, 158);
            this.ChooseDir.Name = "ChooseDir";
            this.ChooseDir.Size = new System.Drawing.Size(205, 96);
            this.ChooseDir.TabIndex = 2;
            this.ChooseDir.Text = "Browse";
            this.ChooseDir.UseVisualStyleBackColor = false;
            this.ChooseDir.Click += new System.EventHandler(this.ChooseDir_Click);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ConfirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ConfirmButton.Location = new System.Drawing.Point(141, 351);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(1346, 150);
            this.ConfirmButton.TabIndex = 3;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = false;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.ChooseDir);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(2172, 1194);
            this.Load += new System.EventHandler(this.UserControl2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ChooseDir;
        private System.Windows.Forms.Button ConfirmButton;
    }
}
