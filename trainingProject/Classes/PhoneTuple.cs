using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace trainingProject
{
    public static class PhoneNumber
    {
        public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
        {
            bool IsNewYork = phoneNumber.Substring(0, 3) == "212";
            bool IsFake = phoneNumber.Substring(4, 3) == "555";
            string LocalNumber = phoneNumber.Substring(phoneNumber.Length - 4, 4);

            return (IsNewYork,IsFake,LocalNumber);

        }

        /*
            An indication of whether the number has a New York dialing code ie. 212 as the first 3 digits
            An indication of whether the number is fake having 555 as a prefix code in positions 5 to 7
            (numbering from 1)
            The last 4 digits of the number.
        */



        public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
            => phoneNumberInfo.IsFake;
        
    }
}
