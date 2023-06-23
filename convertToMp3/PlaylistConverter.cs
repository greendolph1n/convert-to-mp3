using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Net.Http;
using VideoLibrary;


namespace convertToMp3
{
    public partial class PlaylistConverter : UserControl
    {
        static string directory, playlistURL, songName;
        static int status;
        static bool valid, playlist;
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
            if (!valid)
            {
                backgroundWorker1.RunWorkerAsync();
                ConvertTimer.Start();
                ConvertProgressBar.Value = 0;
                status = 0;

            }

        }

        private void ConvertTimer_Tick(object sender, EventArgs e)
        {   
            if(ConvertProgressBar.Value < 95) {
                ConvertProgressBar.Increment(status);

            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            playlistURL = PlaylistInput.Text;
            if (playlistURL.Contains("youtube"))
            {
                valid = true;

                if (playlistURL.Contains("list=")) {
                    //link is playlist
                    playlist = true;
                
                    string[] youtubeURLs = ExtractLinkPlaylist(playlistURL);
                    for (int i = 0; i < youtubeURLs.Length; i++)
                    {

                        status = 1;
                        YoutubeConverter yc = new YoutubeConverter();
                        yc.convertURL(youtubeURLs[i], directory);
                        songName = getYoutubeName(youtubeURLs[i]);
                        backgroundWorker1.ReportProgress(0);
                    }
                }
                else
                {
                    //link is a single video
                    status = 1;
                    YoutubeConverter yc = new YoutubeConverter();
                    yc.convertURL(playlistURL, directory);
                    songName = getYoutubeName(playlistURL);
                    backgroundWorker1.ReportProgress(0);

                }

            }
            else
            {
                MessageBox.Show("Please enter a valid playlist URL", "Error");
                valid = false;
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            status = 100;

            DownloadedSong.Text = ("Successfully downloaded:" + "\n\n- " + songName);
            ConvertProgressBar.Value = 0;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ConvertProgressBar.Value = 100;
            status = 0;
            valid = false;

            if (valid && playlist)
            {
                MessageBox.Show("The playlist has finished downloading", "Task Completed");
            }
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
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Failed to retrieve video for main thread! trying again...");
                    continue;
                }

            }
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
                int begin = pageSourceStr.IndexOf("▶");
                int end = begin;
                List<string> list = new List<string>();
                while (begin > -1)
                {
                    //this string only appears before the youtube URL
                    begin = pageSourceStr.IndexOf(@"""url"":""/watch?v=", end);
                    //this string only appears after the youtube URL
                    end = pageSourceStr.IndexOf(@"index=", begin);

                    //difference between the index reference points is the length of the youtube URL
                    int difference = end-begin; 

                    //Console.WriteLine("begin is " + begin + " end is " + end);
                    string stringURL = "www.youtube.com" + pageSourceStr.Substring(begin+7,difference);

                    //Console.WriteLine("string is " + stringURL + " string length is " + stringURL.Length);

                    //find breakpoint
                    int breakpoint = pageSourceStr.IndexOf("pp=", end);
                    String breakCode = pageSourceStr.Substring(breakpoint+3, 4);

                    //Console.WriteLine("break code is "+ breakCode);
                    if (!breakCode.Contains("iAQ")){
                        //reached end of playlist
                        break;
                    }
       

                    list.Add(stringURL);
                    //Console.WriteLine("list length is +" + list.Count);
                    begin = end;
                }
                String[] str = list.ToArray();

                // Console.WriteLine("LENGTH OF LIST IS " + str.Length);

                return str;
            }
            return null;
        }
    }
}
