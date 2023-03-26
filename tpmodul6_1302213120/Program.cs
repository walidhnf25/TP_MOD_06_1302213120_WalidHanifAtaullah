using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul6_1302213120
{
    class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        // Constructor
        public SayaTubeVideo(string title)
        {
            if (title == null)
            {
                throw new ArgumentNullException("title cannot be null.");
            }
            if (title.Length > 100)
            {
                throw new ArgumentOutOfRangeException("title cannot be longer than 100 characters.");
            }

            this.id = new Random().Next(10000, 99999);
            this.title = title;
            this.playCount = 0;
        }

        // Method to increase play count
        public void IncreasePlayCount(int count)
        {
            if (count < 0)
            {
                throw new ArgumentOutOfRangeException("count cannot be negative.");
            }
            if (count > 10000000)
            {
                throw new ArgumentOutOfRangeException("count cannot be greater than 10,000,000.");
            }

            try
            {
                this.playCount = checked(this.playCount + count);
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Overflow detected: " + e.Message);
            }
        }

        // Method to print video details
        public void PrintVideoDetails()
        {
            Console.WriteLine("Video ID: " + this.id);
            Console.WriteLine("Title: " + this.title);
            Console.WriteLine("Play count: " + this.playCount);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – Walid Hanif Ataullah");
                video.PrintVideoDetails();

                // Test preconditions
                SayaTubeVideo video2 = new SayaTubeVideo(null); // Should throw ArgumentNullException
                SayaTubeVideo video3 = new SayaTubeVideo("This is a video with a really long title that is longer than 100 characters."); // Should throw ArgumentOutOfRangeException
                video.IncreasePlayCount(-100); // Should throw ArgumentOutOfRangeException
                video.IncreasePlayCount(20000000); // Should throw ArgumentOutOfRangeException

                // Test overflow exception
                for (int i = 0; i < 1000000; i++)
                {
                    video.IncreasePlayCount(10);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
            }
        }
    }
}
