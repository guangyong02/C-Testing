using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance3
{
    internal class VideoPost :Post
    {
        //member Fields
        protected bool isPlaying = false;
        protected int currDuration = 0;
        Timer timer;

        //properties
        public string VideoURL { get; set; }
        public double Length { get; set; }

        public VideoPost (string title, bool isPublic, string sendByUsername, string videoURL, double length) : base (title, isPublic, sendByUsername)
        {
            VideoURL = videoURL;
            Length = length;
        }

        public void Play()
        {
            if (!isPlaying)
            {
                isPlaying = true;
                Console.WriteLine("Playing");
                timer = new Timer(TimerCallback, null, currDuration, 1000);
            }       
        }

        private void TimerCallback(Object o)
        {
            if ( currDuration<Length)
            {
                currDuration++;
                Console.WriteLine("Video at {0}s ",currDuration);
                GC.Collect();
            }
            else
            {
                currDuration = 0;
                Stop();
            }
        }

        public void Stop()
        {
            if (isPlaying)
            {
                isPlaying= false;
                Console.WriteLine("Video Stop! ");
                timer.Dispose();
            }
            
        }



        public override string ToString()
        {
            return base.ToString() + " " + VideoURL +" " +Length;
        }
    }
}
