using System;
using System.Globalization;
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

            var iLikeMovies = true; 

            while (iLikeMovies == true)
            {

                Console.WriteLine("Write the number of one of the movies");
                Console.WriteLine("");
                Console.WriteLine("(1) Hunger Games");
                Console.WriteLine("(2) The Darkest Minds");
                Console.WriteLine("(3) Tangled");
                Console.WriteLine("(4) Dora");

                int movie = Convert.ToInt32(Console.ReadLine());

                switch(movie){

                    case 1:

                        Console.WriteLine("Thats an amazing movie!");
                        Console.WriteLine("You have good taste!");
                        break;

                    case 2:

                        Console.WriteLine("Thats an amazing movie!");
                        Console.WriteLine("You have good taste!");
                        break;

                    case 3:

                        Console.WriteLine("Thats a cute movie!");
                        Console.WriteLine("You have good taste!");
                        break;

                    case 4:

                        Console.WriteLine("Are you sure?");
                        Console.WriteLine("That movie is awful, so is you raste.");

                        iLikeMovies = false;
                        break;
                }

            }

            

            for (int guesses = 5; guesses >= 0; guesses--){
                
                Console.WriteLine("What number between 0 and 10 am i thinking of?");

                int guess = Convert.ToInt32(Console.ReadLine());
                
                int rightNumber = 4;

                if (guess == rightNumber)
                {
                    Console.WriteLine("Yay you are right!");

                    guesses = 0;

                }
                else
                {

                    Console.WriteLine("Make a new guess, you have " + guesses +" guesses left");


                }



            }




            
  
            






        }
    }
}
