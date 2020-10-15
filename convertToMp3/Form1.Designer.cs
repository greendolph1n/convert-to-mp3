namespace convertToMp3
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.directoryButton = new System.Windows.Forms.Button();
            this.playlistButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.userControl11 = new convertToMp3.UserControl1();
            this.userControl21 = new convertToMp3.UserControl2();
            this.userControl31 = new convertToMp3.UserControl3();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(600, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(823, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "Youtube to MP3 Converter";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Controls.Add(this.directoryButton);
            this.panel1.Controls.Add(this.playlistButton);
            this.panel1.Controls.Add(this.startButton);
            this.panel1.Location = new System.Drawing.Point(53, 211);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1934, 171);
            this.panel1.TabIndex = 1;
            // 
            // directoryButton
            // 
            this.directoryButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.directoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.directoryButton.Location = new System.Drawing.Point(1476, 3);
            this.directoryButton.Name = "directoryButton";
            this.directoryButton.Size = new System.Drawing.Size(287, 165);
            this.directoryButton.TabIndex = 2;
            this.directoryButton.Text = "Choose Directory";
            this.directoryButton.UseVisualStyleBackColor = false;
            this.directoryButton.Click += new System.EventHandler(this.DirectoryButton_Click);
            // 
            // playlistButton
            // 
            this.playlistButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.playlistButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.playlistButton.Location = new System.Drawing.Point(811, 3);
            this.playlistButton.Name = "playlistButton";
            this.playlistButton.Size = new System.Drawing.Size(271, 165);
            this.playlistButton.TabIndex = 1;
            this.playlistButton.Text = " Convert a Playlist";
            this.playlistButton.UseVisualStyleBackColor = false;
            this.playlistButton.Click += new System.EventHandler(this.PlaylistButton_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.startButton.Location = new System.Drawing.Point(171, 3);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(272, 165);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(-21, 401);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(2170, 1230);
            this.userControl11.TabIndex = 2;
            // 
            // userControl21
            // 
            this.userControl21.Location = new System.Drawing.Point(-33, 437);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(2172, 1194);
            this.userControl21.TabIndex = 3;
            // 
            // userControl31
            // 
            this.userControl31.Location = new System.Drawing.Point(-11, 404);
            this.userControl31.Name = "userControl31";
            this.userControl31.Size = new System.Drawing.Size(2160, 1227);
            this.userControl31.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(2124, 1265);
            this.Controls.Add(this.userControl31);
            this.Controls.Add(this.userControl21);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button directoryButton;
        private System.Windows.Forms.Button playlistButton;
        private System.Windows.Forms.Button startButton;
        private UserControl1 userControl11;
        private UserControl2 userControl21;
        private UserControl3 userControl31;
    }
}

