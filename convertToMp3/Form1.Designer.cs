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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.directoryButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.playlistButton = new System.Windows.Forms.Button();
            this.Info = new System.Windows.Forms.Label();
            this.Converter = new convertToMp3.Converter();
            this.Directory = new convertToMp3.Directory();
            this.playlistConverter1 = new convertToMp3.PlaylistConverter();
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
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.directoryButton);
            this.panel1.Controls.Add(this.startButton);
            this.panel1.Controls.Add(this.playlistButton);
            this.panel1.Location = new System.Drawing.Point(81, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 769);
            this.panel1.TabIndex = 1;
            // 
            // directoryButton
            // 
            this.directoryButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.directoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.directoryButton.Location = new System.Drawing.Point(13, 583);
            this.directoryButton.Name = "directoryButton";
            this.directoryButton.Size = new System.Drawing.Size(279, 156);
            this.directoryButton.TabIndex = 2;
            this.directoryButton.Text = "Choose Directory";
            this.directoryButton.UseVisualStyleBackColor = false;
            this.directoryButton.Click += new System.EventHandler(this.DirectoryButton_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.startButton.Location = new System.Drawing.Point(20, 29);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(272, 165);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Convert a video";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // playlistButton
            // 
            this.playlistButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.playlistButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.playlistButton.Location = new System.Drawing.Point(20, 296);
            this.playlistButton.Name = "playlistButton";
            this.playlistButton.Size = new System.Drawing.Size(271, 165);
            this.playlistButton.TabIndex = 1;
            this.playlistButton.Text = " Convert a Playlist";
            this.playlistButton.UseVisualStyleBackColor = false;
            this.playlistButton.Click += new System.EventHandler(this.PlaylistButton_Click);
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Info.Location = new System.Drawing.Point(421, 196);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(1601, 210);
            this.Info.TabIndex = 4;
            this.Info.Text = resources.GetString("Info.Text");
            // 
            // Converter
            // 
            this.Converter.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Converter.Location = new System.Drawing.Point(405, 419);
            this.Converter.Name = "Converter";
            this.Converter.Size = new System.Drawing.Size(2170, 1230);
            this.Converter.TabIndex = 2;
            this.Converter.Load += new System.EventHandler(this.Converter_Load);
            // 
            // Directory
            // 
            this.Directory.Location = new System.Drawing.Point(415, 389);
            this.Directory.Name = "Directory";
            this.Directory.Size = new System.Drawing.Size(2172, 1194);
            this.Directory.TabIndex = 3;
            // 
            // playlistConverter1
            // 
            this.playlistConverter1.Location = new System.Drawing.Point(405, 409);
            this.playlistConverter1.Name = "playlistConverter1";
            this.playlistConverter1.Size = new System.Drawing.Size(2140, 1240);
            this.playlistConverter1.TabIndex = 5;
            this.playlistConverter1.Load += new System.EventHandler(this.playlistConverter1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(2124, 1265);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Converter);
            this.Controls.Add(this.Directory);
            this.Controls.Add(this.playlistConverter1);
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
        private Converter Converter;
        private Directory Directory;
        private System.Windows.Forms.Label Info;
        private PlaylistConverter playlistConverter1;
    }
}

