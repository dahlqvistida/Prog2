using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalLabb
{
    abstract class Animal

    {

        public int NumberOfTeeths { get; set; }

        public String Color { get; set; }


        public abstract void Eat();

        public abstract void Move();

    }
}
