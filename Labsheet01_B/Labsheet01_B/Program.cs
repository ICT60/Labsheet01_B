using System;

namespace Labsheet01_B
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Labsheet01_B";

            var template = new AsciiArtTemplate();
            var asciiArt = new AsciiArt(template);

            asciiArt.Show("IT Rangsit University");
            Console.ReadLine();
        }
    }
}
