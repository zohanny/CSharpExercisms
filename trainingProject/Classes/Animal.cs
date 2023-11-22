using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trainingProject
{
    abstract class Animal
    {
        public abstract void MakeAnimalSound();

        public virtual void sleep()
        {
            Console.WriteLine("ZzzZzzzzZzzZ");
        }

    }

    class Pig : Animal
    {
        public override void MakeAnimalSound()
        {
            Console.WriteLine("The pig makes Oink!");
        }
        public override void sleep()
        {
            Console.WriteLine("The pig slepping makes zZZzzOinkzzzZzz");
        }
    }

    class Dog : Animal
    {
        public override void MakeAnimalSound()
        {
            Console.WriteLine("The dog makes Au Au!");
        }
    }

    class Cat : Animal
    {
        public override void MakeAnimalSound()
        {
            Console.WriteLine("The cat makes Meow!");
            
        }
    }
}
