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
        public static string Clean(string identifier)
        {

            return Greek(NotLetters(Camel(Control(Spaces(identifier)))));
        }
        private static string Spaces(string id)
            => id.Replace(" ", "_").Trim();


        private static string Control(string id)
            => id.Replace("/0", "CTRL").Trim();

        private static string Camel(string id)
        {
            try
            {
                int index = id.IndexOf("-");
                StringBuilder sb = new StringBuilder(id);
                sb[index + 1] = char.ToUpper(id[index + 1]);
                sb.Remove(index, 1);
                return sb.ToString();
            }
            catch (Exception)
            {
                return id;
            }
        }
        private static string NotLetters(string id)
        {
            Regex rgx = new Regex("[^a-zA-Z]");
            return rgx.Replace(id, "");
        }
        private static string Greek(string id)
        {
            Regex rgx = new Regex("[Α-Ωα-ω]");
            return rgx.Replace(id, "");
        }
    }
}





