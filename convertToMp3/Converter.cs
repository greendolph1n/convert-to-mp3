using System;
using System.ComponentModel;
using System.Windows.Forms;
using VideoLibrary;



namespace convertToMp3
{
    
 
    public partial class Converter : UserControl
    {


        static string directory,url,songName;
        static int status;
        static bool valid;
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
            if (url.Contains("youtube"))
            {
                valid = true;
                songName = getYoutubeName(url);
                backgroundWorker1.RunWorkerAsync();
                ConvertTimer.Start();
                ConvertProgressBar.Value = 15;
            }
            else
            {
                valid = false;
                MessageBox.Show("Please enter a valid URL","Error");
            }

           
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
            while (true)
            {
                try
                {
                    var youtube = YouTube.Default;
                    var vid = youtube.GetVideo(url);
                    string name = vid.FullName;
                    name = name.Remove(name.Length - 4);
                    return name;
                }

                catch (InvalidOperationException)
                {
                    Console.WriteLine("Failed to retrieve video for main thread! trying again...");
                    continue;
                }

            }
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
            DownloadedSong.Text = ("Successfully downloaded:" + "\n\n- " + songName);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (valid)
            {
                ConvertProgressBar.Value = 100;
                //  DownloadedSong.Text = "Completed downloading all songs";
                status = 0;
                MessageBox.Show("The playlist has finished downloading");
            }
            else
            {

            }
        }

        private void DownloadedSong_Click(object sender, EventArgs e)
        {
       
        }
    }
}
