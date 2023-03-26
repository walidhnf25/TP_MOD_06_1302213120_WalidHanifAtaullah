using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul6_1302213120
{
    class Program
    {
        static void Main(string[] args)
        {
            SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – Walid Hanif Ataullah");
            video.PrintVideoDetails();
        }
    }

    class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        // Constructor
        public SayaTubeVideo(string title)
        {
            this.id = new Random().Next(10000, 99999);
            this.title = title;
            this.playCount = 0;
        }

        // Method to increase play count
        public void IncreasePlayCount(int count)
        {
            this.playCount += count;
        }

        // Method to print video details
        public void PrintVideoDetails()
        {
            Console.WriteLine("Video ID: " + this.id);
            Console.WriteLine("Title: " + this.title);
            Console.WriteLine("Play count: " + this.playCount);
        }
    }
}
