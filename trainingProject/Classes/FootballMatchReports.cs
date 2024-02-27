using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trainingProject
{
    public static class PlayAnalyzer
    {
        public static string AnalyzeOnFieldOld(int shirtNum)
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
                    pos = "midfielder";
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

        public static string AnalyzeOnField(int shirtNum)
            => players.TryGetValue(shirtNum, out string value) ? value : throw new ArgumentOutOfRangeException();

        public static string AnalyzeOffField(object report)
            => report switch
            {
                int supporters => $"There are {supporters} supporters at the match.",
                string announcement => announcement,
                Injury inc => $"Oh no! {inc.GetDescription()} Medics are on the field.",
                Incident inc => inc.GetDescription(),
                Manager2 manager => manager.Club is not null ? $"{manager.Name} ({manager.Club})" : $"{manager.Name}",
                _ => throw new ArgumentException()
            };

        #region Fixed Values
        private static Dictionary<int, string> players = new Dictionary<int, string>
        {
            {1, "goalie"},
            {2, "left back"},
            {3, "Center back"},
            {4, "Center back"},
            {5, "right back" },
            {6, "midfielder" },
            {7, "midfielder" },
            {8, "midfielder" },
            {9, "left wing"},
            {10, "striker"},
            {11, "right wing"}
        };
        
        #endregion
    }
}

    
