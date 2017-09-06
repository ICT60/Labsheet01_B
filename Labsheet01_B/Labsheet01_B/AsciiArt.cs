using System;
using System.Collections.Generic;
using System.IO;

namespace Labsheet01_B
{
    class AsciiArt
    {
        List<string> _loadedTemplateText;


        public AsciiArt()
        {
            _loadedTemplateText = new List<string>();
        }

        public bool LoadTemplate(string templatePath)
        {
            var isSuccessful = File.Exists(templatePath);

            if (isSuccessful)
            {
                _loadedTemplateText.Clear();

                try
                {
                    using (StreamReader reader = new StreamReader(templatePath))
                    {
                        var text = reader.ReadLine();

                        do
                        {
                            _loadedTemplateText.Add(text);
                            text = reader.ReadLine();

                        } while (text != null);

                    }
                }
                catch (Exception e)
                {
                    isSuccessful = false;
                    Console.WriteLine(e.ToString());
                }
            }

            return isSuccessful;
        }

        public void Show()
        {
            foreach (string text in _loadedTemplateText)
            {
                Console.WriteLine(text);
            }
        }
    }
}
