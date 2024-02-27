using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trainingProject
{
    internal class ResistorColor
    {

        private static String[] _colors()
            => new string[] {"Black",
                "Brown",
                "Red",
                "Orange",
                "Yellow",
                "Green",
                "Blue",
                "Violet",
                "Grey",
                "White" };

        public static int ColorCode(string color)
            => Array.IndexOf(_colors(), color);

        public static string[] Colors()
            => _colors();
    }
}
