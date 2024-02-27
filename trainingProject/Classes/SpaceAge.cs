using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trainingProject
{
    internal class SpaceAge
    {
        
        private int ageInSeconds;
    
        public SpaceAge(int seconds)
        {
            ageInSeconds = seconds;
        }

        public double OnEarth()
              => Math.Round( 
                  (double) ageInSeconds / 31557600, 2
        );


      
        public double OnMercury()
            => this.OnEarth() / 0.2408467;

        public double OnVenus()
            => this.OnEarth() / 0.61519726;

        public double OnMars()
            => this.OnEarth() / 1.8808158;




        public double OnJupiter()
            => this.OnEarth() / 11.862615;

        public double OnSaturn()
            => this.OnEarth() / 29.447498;

        public double OnUranus()
            => this.OnEarth()/ 84.016846;

        public double OnNeptune()
            => this.OnEarth() / 164.79132;



    }
}
