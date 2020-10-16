using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using MediaToolkit;
using MediaToolkit.Model;
using VideoLibrary;


namespace convertToMp3
{
    public partial class PlaylistConverter : UserControl
    {
        static string directory, playlistURL, songName;
        static int status;
        public PlaylistConverter()
        {
            InitializeComponent();
            
        }

        private void PlaylistInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void PlaylistConverter_Load(object sender, EventArgs e)
        {

        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            
            backgroundWorker1.RunWorkerAsync();
            ConvertTimer.Start();
            ConvertProgressBar.Value = 1;
            


        }

        private void ConvertTimer_Tick(object sender, EventArgs e)
        {
            ConvertProgressBar.Increment(status);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            playlistURL = PlaylistInput.Text;
            string[] youtubeURLs = ExtractLinkPlaylist(playlistURL);
            for (int i = 0; i < youtubeURLs.Length; i++)
            {
                status = 1;
                YoutubeConverter yc = new YoutubeConverter();
                yc.convertURL(youtubeURLs[i], directory);
                songName = getYoutubeName(youtubeURLs[i]);
                backgroundWorker1.ReportProgress(0);
                System.Threading.Thread.Sleep(5000);
                Console.WriteLine("waiting....");

            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            status = 100;
         
            DownloadedSong.Text = (songName + " has been successfully downloaded");
            ConvertProgressBar.Value = 0;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ConvertProgressBar.Value = 100;
          //  DownloadedSong.Text = "Completed downloading all songs";
           status = 0;
        }

        private void ConvertProgressBar_Click(object sender, EventArgs e)
        {

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

        public string[] ExtractLinkPlaylist(string html)
        {


            var playlistUrl = html;


            if (playlistUrl.ToLower().Contains("list="))
            {
                var pathPlaylist = playlistUrl
                    .Replace("https", "")
                    .Replace("http", "")
                    .Replace("://", "")
                    .Replace("www.", "")
                    .Replace("youtube.com/", "").Trim();

                var client = new HttpClient();
                client.BaseAddress = new Uri("https://www.youtube.com");
                var result = client.GetAsync(pathPlaylist).Result;

                //entire page source as a string
                var pageSourceStr = result.Content.ReadAsStringAsync().Result;


                //"▶" can be seen as a "flag", only one instance of this character exists in the entire page source, so this is a handy reference point
                int index = pageSourceStr.IndexOf("▶"), index2 = index;
                int total = index;
                List<string> list = new List<string>();
                while (index > -1)
                {
                    index = pageSourceStr.IndexOf(@"""url"":""/watch?v=", total); //this string only appears before the youtube URL
                                                                                  //  Console.WriteLine("index 1 found it is " + index);
                    index2 = pageSourceStr.IndexOf(@"index=", total);//this string only appears after the youtube URL
                                                                     // Console.WriteLine("index 2 found it is " + index2);

                    int difference = index2 - index; //difference between the index reference points is the length of the youtube URL
                    string stringURL = "www.youtube.com" + pageSourceStr.Substring(index + 7, difference - 58);

                    Console.WriteLine("string is " + stringURL + " string length is " + stringURL.Length);
                    if (stringURL.Length > 35) //string URL will only ever be 83 characters long
                    {
                        Console.WriteLine("we are done");
                        break;
                    }

                    list.Add(stringURL);
                    Console.WriteLine("list length is +" + list.Count);
                    total = index2 + 1;
                    if (total > pageSourceStr.Length)
                    {
                        Console.WriteLine("total is too big");
                        break;
                    }
                }
                String[] str = list.ToArray();

                Console.WriteLine("LENGTH OF LIST IS " + str.Length);
                Console.ReadLine();
                return str;
            }
            return null;
        }
    }
}
