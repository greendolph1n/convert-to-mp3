namespace convertToMp3
{
    partial class UserControl5
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
            this.directoryInput = new System.Windows.Forms.TextBox();
            this.selectButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(101, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1559, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the directory of where you want your video to be downloaded to";
            // 
            // directoryInput
            // 
            this.directoryInput.Location = new System.Drawing.Point(131, 219);
            this.directoryInput.Name = "directoryInput";
            this.directoryInput.Size = new System.Drawing.Size(1419, 38);
            this.directoryInput.TabIndex = 1;
            this.directoryInput.TextChanged += new System.EventHandler(this.directoryInput_TextChanged);
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(1612, 195);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(221, 85);
            this.selectButton.TabIndex = 2;
            this.selectButton.Text = "Browse";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(150, 341);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(1399, 143);
            this.confirmButton.TabIndex = 3;
            this.confirmButton.Text = "CONFIRM";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // UserControl5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.directoryInput);
            this.Controls.Add(this.label1);
            this.Name = "UserControl5";
            this.Size = new System.Drawing.Size(2221, 1210);
            this.Load += new System.EventHandler(this.UserControl5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox directoryInput;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Button confirmButton;
    }
}
