using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trainingProject
{
    internal static class LogAnalysis
    {
        // TODO: define the 'SubstringAfter()' extension method on the `string` type

        public static string SubstringAfter(this string str, string del)
            => str.Split(del).Last();

        // TODO: define the 'SubstringBetween()' extension method on the `string` type
        public static string SubstringBetween(this string str, string start, string end)
            => str.Split(start).Last().Split(end).First();
            
            //int leng = str.IndexOf(end) - str.IndexOf(start) - 1;
            //return str.Substring(str.IndexOf(start) + start.Length, leng);
        

        // TODO: define the 'Message()' extension method on the `string` type
        public static string Message(this string str)
            => str.SubstringAfter("]: ");

        // TODO: define the 'LogLevel()' extension method on the `string` type

        public static string LogLevel(this string str)
            => str.SubstringBetween("[","]");
    }
}
