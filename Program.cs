using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
      
            string RKelly = "I believe I Can Fly!";
            string Favorite = "Apples!";
            Console.WriteLine(RKelly);
            Console.WriteLine(Favorite);
            Console.ReadKey();

            int num1 = 21;
            int num2 = 4;
            int num3 = 2;
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
            Console.ReadKey();

            
            float myAge = 16.25F;
            Console.WriteLine(myAge);
            Console.ReadKey();
                        
            double dog = 16.34D;
            Console.WriteLine(dog);
            Console.ReadKey();

            bool D = true;
            Console.WriteLine(D);
            Console.ReadKey();

            Console.WriteLine("There are {0} kids trying to pick {1} {2} off the tree!", num2, num1, Favorite);
            Console.ReadKey();

            Console.Write("Please Say Hi!:");
            string name = Console.ReadLine();
            Console.WriteLine(name);
            Console.ReadKey();

            
            Console.WriteLine(12 < 80);
            Console.WriteLine("Happy" != "Sad");
            Console.WriteLine(-6 > 0);
            Console.WriteLine(1 > 2);
            Console.WriteLine("Kevin" == "Gates");
            Console.WriteLine(!true);
            Console.WriteLine("Askarrii" != "Jeff");
            Console.WriteLine(!false);
            Console.ReadKey();

        }
    }
}
