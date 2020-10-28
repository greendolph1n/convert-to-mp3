using System;
using System.IO;
using MediaToolkit.Model;
using MediaToolkit;
using VideoLibrary;


namespace convertToMp3
{
     class YoutubeConverter
    {
      


        public void convertURL(string link, string dir)
        {
            {

                Console.WriteLine("the link is " + link );
                string source = dir;
                var youtube = YouTube.Default;
                 
                while (true) {
                    try
                    {
                        Console.WriteLine("attempting to download...");
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
                        Console.WriteLine("successfully downloaded video");
                        break;
                    }

                    catch  (InvalidOperationException){
                        Console.WriteLine("Failed to retrieve video (invalid operation)! trying again...");
                        System.Threading.Thread.Sleep(5000);
                        continue;
                    }
                    catch (ArgumentNullException)
                    {
                        Console.WriteLine("Failed to retrieve video for main thread (null exception)! trying again...");
                        continue;
                    }
                }
               
               

            }


        }


   
    }
}
