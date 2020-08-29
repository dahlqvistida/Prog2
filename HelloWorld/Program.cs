using System;
using System.Linq.Expressions;

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

            Console.WriteLine("Are you alive? (yes or no)");

            bool alive = true;
            String answer = Console.ReadLine().ToLower();
            
            Console.WriteLine("Hello! " + Name);

            if (answer == "yes"){

                Console.WriteLine("Status update Alive: " + alive.ToString());
                Console.WriteLine("Good to hear that you are alive and " + age + " years");
                Console.WriteLine("Have a great day!");

                    }
            
            else
            {
                alive = false;
                Console.WriteLine("Status update Alive: " + alive.ToString());

                Console.WriteLine("Oh.. sad to hear, still " + age + " years in the mind huh?");
                Console.WriteLine("Say hi to the dead for me.");
            }

            
  
            






        }
    }
}
