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

            

            Console.WriteLine("Write five names, each one on a new line");

            string[] names = new string[5];

            for (int i = 0; i<names.Length; i++)
            {
                names[i] = Console.ReadLine();
            }

            for (int i = 4; i >= 0; i--)
            {

                Console.WriteLine(names[i]);

            }


















        }
    }
}
