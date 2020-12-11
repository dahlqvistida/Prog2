using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalLabb
{
    class Dog : Animal
    {
        public Dog() 
        {
            NumberOfTeeths = 42;
           
        }

        public override void Eat()
        {
            Console.WriteLine("The dog is eating with a big appetite");
        }

        public override void Move()
        {
            Console.WriteLine("The dog is running as fast as the wind");
        }
    }
}
