using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trainingProject
{
    public static class Isogram
    {
        public static bool IsIsogram(string word)
        {
            word = word.ToLower();
            for (int i=0; i<word.Length; i++)
            {
                if (word.Substring(i + 1).Contains(word[i]) && char.IsLetter(word[i]))
                    return false;
            }
            return true;

        }
    }
}
