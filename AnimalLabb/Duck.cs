using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalLabb
{
    class Duck : Animal
    {
        public Duck()
        {
            NumberOfTeeths = 0;
          

        }

        public override void Eat()
        {
            Console.WriteLine("The duck is nomnoming its green beans");
        }

        public override void Move()
        {
            Console.WriteLine("The duck is wabbling around");
        }
    }
}
