using System;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.SymbolStore;
using System.Xml.Schema;

namespace Homework_methods
{
    class Program
    { 

        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");

            int[] addNumbers = { 5, 7, 10, 2, 8 };

            string[] words = { "You", "Are", "Special" };

            int[] listOfNumbers = { 7, 5, 9, 2, 4 };



            Console.WriteLine(Add(addNumbers));

            BackwardsWords(words);

            Console.WriteLine("Biggest number:" + smallestVsBiggestNumber(listOfNumbers));

        }
        static int Add(int[] addNumbers)
        {

            int total = 1;

            for (int i = 4; i >= 0; i--)
            {
               total = total + addNumbers[i];


            }
                
            return total;
        }

        static void BackwardsWords(string [] words)
        {
            for (int i = 2; i >= 0; i--)
            {
                Console.WriteLine(words[i]);

            }
        }

        static int smallestVsBiggestNumber(int[] listOfNumbers)
        {
            int smallestNumber;
            int biggestNumber;

            for (int i = 4; i >= 0; i--)
            {
                int j = i;

                if (j >= listOfNumbers[0] && j >= listOfNumbers[1] && j >= listOfNumbers[2] && j >= listOfNumbers[3] && j >= listOfNumbers[4])
                {

                    biggestNumber = j;

                    
                }
                else if (j <= listOfNumbers[0] && j <= listOfNumbers[1] && j <= listOfNumbers[2] && j <= listOfNumbers[3] && j <= listOfNumbers[4])
                {

                    smallestNumber = j;

                }

            }

            return biggestNumber;
            
        }
    }
}
