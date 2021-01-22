using System;

namespace SOLID_Labb
{
    //Denna klass ger varje djur en färg, sedan skriver den ut vad alla djur gör och ger ägarskap
    class Program
    {
        public string TransferOwnership { get; set; }


        
        static void Main(string[] args)
        {
            //En Lista som; Skapar djur och ger varje djur en färg
            Animal[] animals = {new Dog("Black"),
                            new Hedgehog("Pink"),
                            new Bird("Yellow")};

            Console.WriteLine("###############");
            Console.WriteLine();

            //För varje djur så skriver loopen ut vad de gör, och hur det görs
            foreach (var animal in animals)
            {
                
                //Skriver ut vad de gör och hur det görs
                animal.Eat();
                animal.Sleep();
                animal.Speak();
                animal._color = "Grey";
                Console.WriteLine(animal.GetType().Name + " is " + animal._color);
                Console.WriteLine();

                Console.WriteLine("###############");
                Console.WriteLine();
            }
        }
    }
}
