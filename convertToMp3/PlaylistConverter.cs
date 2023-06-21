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
        static bool valid;
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
                ConvertProgressBar.Value = 10;
                status = 0;

            }

        }

        private void ConvertTimer_Tick(object sender, EventArgs e)
        {
            ConvertProgressBar.Increment(status);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            playlistURL = PlaylistInput.Text;
            if (playlistURL.Contains("youtube"))
            {
                valid = true;

                if (playlistURL.Contains("list="))
                    //link is playlist
                {
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
            if (valid)
            {
                ConvertProgressBar.Value = 100;
                //  DownloadedSong.Text = "Completed downloading all songs";
                status = 0;
                MessageBox.Show("The playlist has finished downloading", "Task Completed");
                valid = false;
            }
            else
            {

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
                        Console.WriteLine("Finished Extracting");
                        break;
                    }

                    list.Add(stringURL);
                    Console.WriteLine("list length is +" + list.Count);
                    total = index2 + 1;
                    if (total > pageSourceStr.Length)
                    {
                        /// Console.WriteLine("total is too big");
                        break;
                    }
                }
                String[] str = list.ToArray();

                // Console.WriteLine("LENGTH OF LIST IS " + str.Length);

                return str;
            }
            return null;
        }
    }
}
