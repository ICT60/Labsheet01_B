using System;
using System.Collections.Generic;

namespace Labsheet01_B
{
    class AsciiArtTemplate
    {
        protected int _maxLine;
        protected Dictionary<char, List<string>> _templates;


        public int MaxLine {  get { return _maxLine;  } }
        public Dictionary<char, List<string>> Templates { get { return _templates; } }


        public AsciiArtTemplate()
        {
            _maxLine = 0;
            _templates = new Dictionary<char, List<string>>();
            _GenerateTemplate();
        }

        void _GenerateTemplate()
        {
            _maxLine = 7;

            _templates.Add(' ', new List<string>());
            _templates[' '].Add("    ");
            _templates[' '].Add("    ");
            _templates[' '].Add("    ");
            _templates[' '].Add("    ");
            _templates[' '].Add("    ");
            _templates[' '].Add("    ");
            _templates[' '].Add("    ");

            _templates.Add('A', new List<string>());
            _templates['A'].Add("  ____ ");
            _templates['A'].Add(" /    |");
            _templates['A'].Add("|  o  |");
            _templates['A'].Add("|     |");
            _templates['A'].Add("|  _  |");
            _templates['A'].Add("|  |  |");
            _templates['A'].Add("|__|__|");

            _templates.Add('E', new List<string>());
            _templates['E'].Add("   ___ ");
            _templates['E'].Add("  /  _]");
            _templates['E'].Add(" /  [_ ");
            _templates['E'].Add("|    _]");
            _templates['E'].Add("|   [_ ");
            _templates['E'].Add("|     |");
            _templates['E'].Add("|_____|");

            _templates.Add('G', new List<string>());
            _templates['G'].Add("  ____ ");
            _templates['G'].Add(" /    |");
            _templates['G'].Add("|   __|");
            _templates['G'].Add("|  |  |");
            _templates['G'].Add("|  |_ |");
            _templates['G'].Add("|     |");
            _templates['G'].Add("|___,_|");

            _templates.Add('I', new List<string>());
            _templates['I'].Add(" ____ ");
            _templates['I'].Add("|    |");
            _templates['I'].Add(" |  | ");
            _templates['I'].Add(" |  | ");
            _templates['I'].Add(" |  | ");
            _templates['I'].Add(" |  | ");
            _templates['I'].Add("|____|");

            _templates.Add('N', new List<string>());
            _templates['N'].Add(" ____  ");
            _templates['N'].Add("|    \\ ");
            _templates['N'].Add("|  _  |");
            _templates['N'].Add("|  |  |");
            _templates['N'].Add("|  |  |");
            _templates['N'].Add("|  |  |");
            _templates['N'].Add("|__|__|");

            _templates.Add('R', new List<string>());
            _templates['R'].Add(" ____  ");
            _templates['R'].Add("|    \\ ");
            _templates['R'].Add("|  D  )");
            _templates['R'].Add("|    / ");
            _templates['R'].Add("|    \\ ");
            _templates['R'].Add("|  .  \\");
            _templates['R'].Add("|__|\\_|");

            _templates.Add('S', new List<string>());
            _templates['S'].Add(" _____");
            _templates['S'].Add("/ ___/");
            _templates['S'].Add("(  \\_ ");
            _templates['S'].Add("\\__  |");
            _templates['S'].Add("/  \\ |");
            _templates['S'].Add("\\    |");
            _templates['S'].Add(" \\___|");

            _templates.Add('T', new List<string>());
            _templates['T'].Add(" ______ ");
            _templates['T'].Add("|      |");
            _templates['T'].Add("|      |");
            _templates['T'].Add("|_|  |_|");
            _templates['T'].Add("  |  |  ");
            _templates['T'].Add("  |  |  ");
            _templates['T'].Add("  |__|  ");

            _templates.Add('U', new List<string>());
            _templates['U'].Add(" __ __ ");
            _templates['U'].Add("|  |  |");
            _templates['U'].Add("|  |  |");
            _templates['U'].Add("|  |  |");
            _templates['U'].Add("|  :  |");
            _templates['U'].Add("|     |");
            _templates['U'].Add(" \\__,_|");

            _templates.Add('V', new List<string>());
            _templates['V'].Add(" __ __ ");
            _templates['V'].Add("|  |  |");
            _templates['V'].Add("|  |  |");
            _templates['V'].Add("|  |  |");
            _templates['V'].Add("|  :  |");
            _templates['V'].Add(" \\   / ");
            _templates['V'].Add("  \\_/  ");

            _templates.Add('Y', new List<string>());
            _templates['Y'].Add(" __ __ ");
            _templates['Y'].Add("|  |  |");
            _templates['Y'].Add("|  |  |");
            _templates['Y'].Add("|  ~  |");
            _templates['Y'].Add("|___, |");
            _templates['Y'].Add("|     |");
            _templates['Y'].Add("|____/ ");


            _templates.Add('a', _templates['A']);
            _templates.Add('e', _templates['E']);
            _templates.Add('g', _templates['G']);
            _templates.Add('i', _templates['I']);
            _templates.Add('n', _templates['N']);
            _templates.Add('r', _templates['R']);
            _templates.Add('s', _templates['S']);
            _templates.Add('t', _templates['T']);
            _templates.Add('u', _templates['U']);
            _templates.Add('v', _templates['V']);
            _templates.Add('y', _templates['Y']);
        }
    }
}
