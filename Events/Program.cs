using System;

namespace Events
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var video = new Video("nasVideo.mp4");
            video.ImeSePromenilo += Video_ImeSePromenilo;
            video.ImeSePromenilo += Video_ImeSePromenilo1;
            Console.ReadLine();
            video.Ime = "njihovVideo.mp4";
            Console.ReadLine();
            video.Ime = "events.mp4";
        }

        private static void Video_ImeSePromenilo1(object sender, VideoEventArgs e)
        {
            Console.WriteLine("#2 Ime se upravo promenilo " + e.StaroIme + " -> " + e.NovoIme);
        }

        private static void Video_ImeSePromenilo(object sender, VideoEventArgs e)
        {
            Console.WriteLine("#1 Ime se upravo promenilo " + e.StaroIme + " -> " + e.NovoIme);
        }
    }
}