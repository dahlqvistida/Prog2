using System;
using System.Collections.Generic;

namespace AnimalLabb
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            var dog = new Dog();
            dog.Color = "Black";

            var duck = new Duck();
            duck.Color = "Yellow";

            animals.Add(dog);
            animals.Add(duck);

            foreach (var animal in animals)
            {
                animal.Eat();
                animal.Move();

            }

        }
    }
}
