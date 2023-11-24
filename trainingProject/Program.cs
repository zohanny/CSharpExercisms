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
            var list = Languages.GetExistingLanguages();

            string vegetable = null;
            

            //Languages.ReverseList(list).ForEach(p => Console.WriteLine(p));

            Console.WriteLine(vegetable ?? "banana");



            /*var value = "helαα56lo- wo rld/0 e arredores";
            Console.WriteLine(Identifier.Clean(value));



            /*
             * long value = 15;
            Console.WriteLine(value);
            //Console.WriteLine(ASCIIEncoding.Unicode.GetByteCount(value));
            var a = TelemetryBuffer.ToBuffer(value);
            //BirdCount = 0;
            Console.WriteLine("Rhis is the byte array");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }

            Console.WriteLine($"The nuber was: {TelemetryBuffer.FromBuffer(a)}");


            /*
            var wiz = new Wizard();

            Console.WriteLine(wiz);

            Console.WriteLine(wiz.Vulnerable());
            wiz.PrepareSpell();
            Console.WriteLine(wiz.Vulnerable());
            */


            /*int speed = 9;
            int batteryDrain = 50;
            var car = new RemoteControlCar(speed, batteryDrain);
            car.Drive();
            car.Drive();
            car.Drive();
            Console.WriteLine($"batt: {car.BatteryCharge}  // dist: {car.DistanceDriven()}");
            */


            /*Console.WriteLine(SavingsAccount.InterestRate(balance: 200.75m));
            Console.WriteLine(SavingsAccount.Interest(balance: 200.75m));
            Console.WriteLine(SavingsAccount.AnnualBalanceUpdate(balance: 200.75m));
            Console.WriteLine(SavingsAccount.YearsBeforeDesiredBalance(balance: 200.75m, targetBalance: 220m));
            */
            /*
            Console.WriteLine(Identifier.Clean("My/0Id"));

            /*
             * RemoteControlCar car = RemoteControlCar.Buy();
            car.BatteryDisplay();
            car.DistanceDisplay();
            // hello

            for (int i=0; i<110; i++)
                car.Drive();
                
            Console.WriteLine(car.BatteryDisplay());
            Console.WriteLine(car.DistanceDisplay());
            */
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
