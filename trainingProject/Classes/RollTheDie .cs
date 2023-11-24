using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trainingProject
{
    public class Player
    {
        private static System.Random rnd = new System.Random();

        public int RollDie()
            =>rnd.Next(1,18);


        public double GenerateSpellStrength()
            => rnd.NextDouble() * 100;
    }
}
