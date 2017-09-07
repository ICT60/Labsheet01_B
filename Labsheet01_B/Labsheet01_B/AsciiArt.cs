using System;

namespace Labsheet01_B
{
    class AsciiArt
    {
        AsciiArtTemplate _currentTemplate;

        
        public AsciiArt(AsciiArtTemplate template)
        {
            _currentTemplate = template;
        }

        public void Show(string text)
        {
            for (int i = 0;  i < _currentTemplate.MaxLine; i++)
            {
                foreach (char character in text.ToCharArray())
                {
                    if (_currentTemplate.Templates.ContainsKey(character))
                    {
                        Console.Write(_currentTemplate.Templates[character][i]);
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
