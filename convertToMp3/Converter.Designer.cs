namespace convertToMp3
{
    partial class Converter
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
            this.label1 = new System.Windows.Forms.Label();
            this.URLbox = new System.Windows.Forms.TextBox();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.ConvertProgressBar = new System.Windows.Forms.ProgressBar();
            this.ConvertTimer = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.DownloadedSong = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.label1.Location = new System.Drawing.Point(22, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(566, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your Youtube URL here";
            // 
            // URLbox
            // 
            this.URLbox.Location = new System.Drawing.Point(31, 180);
            this.URLbox.Name = "URLbox";
            this.URLbox.Size = new System.Drawing.Size(1637, 38);
            this.URLbox.TabIndex = 1;
            this.URLbox.TextChanged += new System.EventHandler(this.URLbox_TextChanged);
            // 
            // ConvertButton
            // 
            this.ConvertButton.BackColor = System.Drawing.Color.LightGray;
            this.ConvertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ConvertButton.Location = new System.Drawing.Point(31, 283);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(285, 132);
            this.ConvertButton.TabIndex = 2;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseVisualStyleBackColor = false;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // ConvertProgressBar
            // 
            this.ConvertProgressBar.Location = new System.Drawing.Point(335, 324);
            this.ConvertProgressBar.Name = "ConvertProgressBar";
            this.ConvertProgressBar.Size = new System.Drawing.Size(1229, 52);
            this.ConvertProgressBar.TabIndex = 3;
            this.ConvertProgressBar.Click += new System.EventHandler(this.ConvertProgressBar_Click);
            // 
            // ConvertTimer
            // 
            this.ConvertTimer.Tick += new System.EventHandler(this.ConvertTimer_Tick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // DownloadedSong
            // 
            this.DownloadedSong.AutoSize = true;
            this.DownloadedSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DownloadedSong.Location = new System.Drawing.Point(115, 535);
            this.DownloadedSong.Name = "DownloadedSong";
            this.DownloadedSong.Size = new System.Drawing.Size(0, 39);
            this.DownloadedSong.TabIndex = 4;
            this.DownloadedSong.Click += new System.EventHandler(this.DownloadedSong_Click);
            // 
            // Converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DownloadedSong);
            this.Controls.Add(this.ConvertProgressBar);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.URLbox);
            this.Controls.Add(this.label1);
            this.Name = "Converter";
            this.Size = new System.Drawing.Size(2170, 1230);
            this.Load += new System.EventHandler(this.Converter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox URLbox;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.ProgressBar ConvertProgressBar;
        private System.Windows.Forms.Timer ConvertTimer;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label DownloadedSong;
    }
}
