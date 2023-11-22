using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace trainingProject
{
    public static class Identifier
    {
        private static bool IsGreekLowercase(char c)
            => (c >= 'α' && c <= 'ω');



        public static string Clean(string identifier)
        {
            var strB = new StringBuilder(identifier.Length);
            bool isAfterDash = false;

            foreach (char c in identifier)
            {
                char c1 = isAfterDash ? Char.ToUpper(c) : c;
             


                if (Char.IsControl(c1))
                    strB.Append("Ctrl");
                if (!IsGreekLowercase(c1) && Char.IsLetter(c1))
                    strB.Append(c1) ;
                if (c==' ')
                    strB.Append('_');

                isAfterDash = Char.Equals(c,'-');
            }
            
            return strB.ToString();
        }
    }
}





