using System.IO;
using System;

namespace Labsheet01_B
{
    class Program
    {
        const string TEMPLATE_FILE_NAME = "template.txt";


        static void Main(string[] args)
        {
            var templateDir = Directory.GetCurrentDirectory();
            templateDir += ("\\" + TEMPLATE_FILE_NAME);

            var asciiArt = new AsciiArt();

            if (File.Exists(templateDir))
            {
                asciiArt.LoadTemplate(TEMPLATE_FILE_NAME);
                asciiArt.Show();
            }

            Console.ReadLine();
        }
    }
}
