using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trainingProject.Classes;

namespace trainingProject
{
    class Program
    {

        static void Main(string[] args)

        {

            var spm = new SecurityPassMaker();
            string ans1 = spm.GetDisplayName(new Security());
            // => "Too Important for a Security Pass"
            string ans2 = spm.GetDisplayName(new SecurityJunior());
            // => "The Physio"

            Console.WriteLine(ans1 + " /n || " + ans2);
        }
    }
}

