using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trainingProject
{
    public static class PlayAnalyzer
    {
        public static string AnalyzeOnField(int shirtNum)
        {
            string pos;
            switch (shirtNum)
            {
                case 1:
                    pos = "goalie";
                    break;
                case 2:
                    pos = "left back";
                    break;
                case 3 or 4:
                    pos = "center back";
                    break;
                case 5:
                    pos = "right back";
                    break;
                case 6 or 7 or 8:
                    pos= "midfielder";
                    break;
                case 9:
                    pos = "left wing";
                    break;
                case 10:
                    pos = "striker";
                    break;
                case 11:
                    pos = "right wing";
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
                    
            }
            return pos;

        }

        public static string AnalyzeOffField(object report)
        {
            string desc;
            switch (report)
            {
                case int:
                    desc = $"There are {report} supporters at the match.";
                    break;
                case string:
                    desc = report.ToString(); 
                    break;
                default:
                    throw new System.ArgumentException();

            }
            return desc;

            /*
            PlayAnalyzer.AnalyzeOffField(new Foul());
            // => "The referee deemed a foul."

            PlayAnalyzer.AnalyzeOffField(new Injury(8));
            // => "Oh no! Player 8 is injured. Medics are on the field.
            */
        }
    }

}
