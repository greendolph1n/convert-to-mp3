namespace convertToMp3
{
    partial class PlaylistConverter
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
            this.components = new System.ComponentModel.Container();
            this.DownloadedSong = new System.Windows.Forms.Label();
            this.ConvertProgressBar = new System.Windows.Forms.ProgressBar();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.PlaylistInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ConvertTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // DownloadedSong
            // 
            this.DownloadedSong.AutoSize = true;
            this.DownloadedSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DownloadedSong.Location = new System.Drawing.Point(34, 471);
            this.DownloadedSong.Name = "DownloadedSong";
            this.DownloadedSong.Size = new System.Drawing.Size(0, 39);
            this.DownloadedSong.TabIndex = 9;
            // 
            // ConvertProgressBar
            // 
            this.ConvertProgressBar.Location = new System.Drawing.Point(347, 321);
            this.ConvertProgressBar.Name = "ConvertProgressBar";
            this.ConvertProgressBar.Size = new System.Drawing.Size(1229, 52);
            this.ConvertProgressBar.TabIndex = 8;
            this.ConvertProgressBar.Click += new System.EventHandler(this.ConvertProgressBar_Click);
            // 
            // ConvertButton
            // 
            this.ConvertButton.BackColor = System.Drawing.Color.LightGray;
            this.ConvertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ConvertButton.Location = new System.Drawing.Point(32, 285);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(285, 132);
            this.ConvertButton.TabIndex = 7;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseVisualStyleBackColor = false;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // PlaylistInput
            // 
            this.PlaylistInput.Location = new System.Drawing.Point(32, 182);
            this.PlaylistInput.Name = "PlaylistInput";
            this.PlaylistInput.Size = new System.Drawing.Size(1637, 38);
            this.PlaylistInput.TabIndex = 6;
            this.PlaylistInput.TextChanged += new System.EventHandler(this.PlaylistInput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.label1.Location = new System.Drawing.Point(23, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(712, 48);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter your Youtube Playlist URL here";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // ConvertTimer
            // 
            this.ConvertTimer.Tick += new System.EventHandler(this.ConvertTimer_Tick);
            // 
            // PlaylistConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DownloadedSong);
            this.Controls.Add(this.ConvertProgressBar);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.PlaylistInput);
            this.Controls.Add(this.label1);
            this.Name = "PlaylistConverter";
            this.Size = new System.Drawing.Size(2140, 1240);
            this.Load += new System.EventHandler(this.PlaylistConverter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DownloadedSong;
        private System.Windows.Forms.ProgressBar ConvertProgressBar;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.TextBox PlaylistInput;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer ConvertTimer;
    }
}
