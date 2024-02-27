using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trainingProject
{
    
    public static class RotationalCipher
    {
        static char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

        public static string Rotate(string text, int shiftKey)
        {
          
            StringBuilder sb = new StringBuilder(text.Length);
            int pos;
            char newChar;
            
            foreach (char c in text)
            {

                pos = Array.IndexOf(alphabet, Char.ToLower(c));

                if (pos >= 0)
                {
                    pos = (pos + shiftKey) % alphabet.Length;

                    newChar = !char.IsUpper(c) ? alphabet[pos] : Char.ToUpper(alphabet[pos]);

                }
                else
                    newChar = c;

                sb.Append(newChar);

            }
            return sb.ToString();
        }
    }
}
