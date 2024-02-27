using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace trainingProject
{
    internal static class Bob
    {

        static readonly String question = "Sure.";
        //This is his response if you ask him a question, such as "How are you?" The convention used for questions is that it ends with a question mark.
        static readonly String yell = "Whoa, chill out!";
        //This is his answer if you YELL AT HIM.The convention used for yelling is ALL CAPITAL LETTERS.
        static readonly String yellQuestion = "Calm down, I know what I'm doing!";
        //This is what he says if you yell a question at him.
        static readonly String silence = "Fine. Be that way!";
        //This is how he responds to silence.The convention used for silence is nothing, or various combinations of whitespace characters.
        static readonly String anythingElse = "Whatever.";
        //This is what he answers to anything else.

        public static string Response(string statement)
        {
            String resp;

            if (isSilence(statement))
            {
                resp = silence;
            }
            else {
                if (isQuestion(statement))
                {
                    resp = isYell(statement) ? yellQuestion : question;
                }
                else
                    resp = isYell(statement) ? yell: anythingElse;
            }
            return resp;

        }


        private static bool isSilence(string text)
            =>string.IsNullOrWhiteSpace(text);
        

        private static bool isQuestion (string text)
            => isSilence(text.Split('?').Last());


        private static bool isYell(string text)
            => text.Any(char.IsLetter) && text.ToUpperInvariant() == text;
               
     
    }
}
