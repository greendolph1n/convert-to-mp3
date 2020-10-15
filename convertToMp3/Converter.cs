using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoLibrary;



namespace convertToMp3
{
    
 
    public partial class Converter : UserControl
    {


        static string directory,url,songName;
        static int status;
        public Converter()
        {
            InitializeComponent();
        }

        private void Converter_Load(object sender, EventArgs e)
        {

        }



        private void ConvertButton_Click(object sender, EventArgs e)
        {

            url = URLbox.Text;
           songName= getYoutubeName(url);
            backgroundWorker1.RunWorkerAsync();
            status = 1;
            ConvertTimer.Start();
            ConvertProgressBar.Value = 0;

           
        }

        private void ConvertTimer_Tick(object sender, EventArgs e)
        {

            ConvertProgressBar.Increment(status);

        }

        public void getDir(string dir)
        {
             directory = dir.ToString();
        }

        public string getYoutubeName(string url)

        {
            var youtube = YouTube.Default;
            var vid = youtube.GetVideo(url);
            string name = vid.FullName;
            name = name.Remove(name.Length - 4);
            return name;
        }

    
    
        private void URLbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConvertProgressBar_Click(object sender, EventArgs e)
        {

        }





    //BACKGROUND WORKER 


        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
             
            YoutubeConverter converter = new YoutubeConverter();
            this.ConvertTimer.Start();
            converter.convertURL(url, directory);
           // DownloadedSong.Text = songName;
           backgroundWorker1.ReportProgress(0);

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            status = 50;
            DownloadedSong.Text = (songName+" has been successfully downloaded");
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
           //MessageBox.Show("Success");
            ConvertProgressBar.Value = 100;
            
            status = 0;
        }

        private void DownloadedSong_Click(object sender, EventArgs e)
        {
       
        }
    }
}
