using System;

namespace Labsheet01_B
{
    class Program
    {
        static void _SetUpTerminal()
        {
            Console.Title = "Labsheet01_B : 6002526";
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight / 2);
        }

        static void Main(string[] args)
        {
            _SetUpTerminal();

            var template = new AsciiArtTemplate();
            var asciiArt = new AsciiArt(template);

            asciiArt.Show("IT Rangsit University");
            Console.ReadLine();
        }
    }
}
