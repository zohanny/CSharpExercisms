using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trainingProject
{
    class Program
    {

        static void Main(string[] args)
        {

            RemoteControlCar car = RemoteControlCar.Buy();
            car.BatteryDisplay();
            car.DistanceDisplay();

            for (int i=0; i<110; i++)
                car.Drive();
                
            Console.WriteLine(car.BatteryDisplay());
            Console.WriteLine(car.DistanceDisplay());

            /*
            double res = AssemblyLine.WorkingItemsPerMinute(6);
            Console.WriteLine(res);
            */


            /*
             * 
             * Annalyn Quest
            var knightIsAwake = true;
            var archerIsAwake = false;
            var prisonerIsAwake = false;
            var petDogIsPresent = true;

            Console.WriteLine(QuestLogic.CanFastAttack(knightIsAwake));

            Console.WriteLine(QuestLogic.CanSpy(knightIsAwake, archerIsAwake, prisonerIsAwake));

            Console.WriteLine(QuestLogic.CanSignalPrisoner(archerIsAwake, prisonerIsAwake));

            Console.WriteLine(QuestLogic.CanFreePrisoner(knightIsAwake, archerIsAwake, prisonerIsAwake, petDogIsPresent));
            
            // => false
            */

            /*
            * LogLine
            string test = "[WARNING]:   \tTimezone not set  \r\n";
            Console.WriteLine(LogLine.Message(test));
            Console.WriteLine(LogLine.LogLevel(test));
            Console.WriteLine(LogLine.Reformat(test));
            */

            /*Car mustang = new Car();
            Car opel = new Car("Opel", "2020");

            Console.WriteLine(mustang.Brand + " " + mustang.Year);
            Console.WriteLine(opel.Brand + " " + opel.Year);

            mustang.soundHorn();
            */

            /*
            Animal dog = new Dog();
            Animal cat = new Cat();
            Animal pig = new Pig();

            dog.MakeAnimalSound();
            cat.MakeAnimalSound();
            pig.MakeAnimalSound();
            cat.sleep();
            pig.sleep();

            string firstName = "John";
            string lastName = "Doe";
            string name = $"My full name is: {firstName} {lastName}.";

            Console.WriteLine(name);
            string myString = "Hello";
            Console.WriteLine(myString.Length);*/


        }
    }
}
