using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace trainingProject
{
    internal class ScrabbleScore
    {
                 
        private static Dictionary<int, char[]> wordScore = new Dictionary<int, char[]>();

        private static void createDic()
        {
            wordScore.Add(1, ['A', 'E', 'I', 'O', 'U', 'L', 'N', 'R', 'S', 'T']);
            wordScore.Add(2, ['D', 'G']);
            wordScore.Add(3, ['B', 'C', 'M', 'P']);
            wordScore.Add(4, ['F', 'H', 'V', 'W', 'Y']);
            wordScore.Add(5, ['K']);
            wordScore.Add(8, ['J', 'X']);
            wordScore.Add(10, ['Z', 'Q']);
        }


        public static int Score(string input)
        {
            createDic();
            int score= 0;
            input = input.Trim().ToUpper();

            foreach (char c in input)
            {
                foreach (KeyValuePair<int, char[]> entry  in wordScore)
                {
                    if (entry.Value.Contains(c))
                        score += entry.Key;
                }
            }
            return score;
        }
    }
}
