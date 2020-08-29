using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");

            Console.WriteLine("Whats your name?");

            string Name = Console.ReadLine();

            Console.WriteLine("How old are you?");

            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello! " + Name);
            Console.WriteLine("You are " + age + " so you know.");

            Console.WriteLine("Have a great day!");






        }
    }
}
