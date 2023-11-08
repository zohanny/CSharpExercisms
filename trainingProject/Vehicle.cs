using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trainingProject
{
    class Vehicle
    {
        public void soundHorn()
        {
            Console.WriteLine("Oink!");
        }
    }

    class Car : Vehicle
    {
        string brand;
        string year;

        public string Brand { get => brand; set => brand = value; }
        public string Year { get => year; set => year = value; }

        public Car()
        {
            Brand = "Ford";
            year = "1969";
        }

        public Car(string brand, string year)
        {
            this.brand = brand;
            this.year = year;
        }
    }
}
