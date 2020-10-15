using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using FFmpeg.Native;
using MediaToolkit.Model;
using MediaToolkit;
using VideoLibrary;
using System.Windows.Forms;

namespace convertToMp3
{
     class YoutubeConverter
    {
      


        public void convertURL(string link, string dir)
        {
            {

                Converter conv = new Converter();
             
                string source = dir;
                var youtube = YouTube.Default;
                var vid = youtube.GetVideo(link);
                string videopath = Path.Combine(source, vid.FullName);
                string name = vid.FullName;
                name = name.Remove(name.Length - 4);
                File.WriteAllBytes(videopath, vid.GetBytes());

                var inputFile = new MediaFile { Filename = Path.Combine(source, vid.FullName) };
                var outputFile = new MediaFile { Filename = Path.Combine(source, $"{name}.mp3") };

                using (var engine = new Engine())
                {
                    engine.GetMetadata(inputFile);


                    engine.Convert(inputFile, outputFile);
                }
              



                File.Delete(Path.Combine(source, vid.FullName));
               // MessageBox.Show(name + " has been downloaded!", "Success");

            }


        }


   
    }
}
