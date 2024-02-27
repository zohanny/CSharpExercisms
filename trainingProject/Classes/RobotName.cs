using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trainingProject
{
    public class Robot
    {
        
        private static HashSet<String> allNames = new HashSet<string>();
        public string Name { get; private set; }

        public Robot() : base()
        {
            Reset();
        }
              

        public void Reset()
        {
            SetUniqueName();
        }

        private void SetUniqueName()
        {
            string testName;
            do
            {
                testName = GenerateName();
            }
            while (!allNames.Add(testName));
            Name = testName;
        }

        private String GenerateName()
        {
            var letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var numbers = "0123456789";

            var nameChars = new char[5];
            var random = new Random();

            for (int i = 0; i < 2; i++)
            {
                nameChars[i] = letters[random.Next(letters.Length)];
            }

            for (int i = 2; i < nameChars.Length; i++)
            {
                nameChars[i] = numbers[random.Next(numbers.Length)];
            }

            return new String(nameChars);
        }
    }
}
