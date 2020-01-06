// Deciliterben megadott súlyt bontsunk hektoliter, liter, deciliter egységekre! 

using System;

namespace Exercise10
{
    class Decilter
    {
        static void Main(string[] args)
        {
            int deciliter = 0;
            int hectoliter = 0;
            int liter = 0;
            
            Console.Write("Enter the volume in deciliter: ");
            string userInput = Console.ReadLine();
            try
            {
                deciliter = int.Parse(userInput);
            }
            catch (FormatException)
            {
                Console.WriteLine("That is not a number.");
                System.Environment.Exit(0);
            }

            hectoliter = deciliter / 1000;
            deciliter %= 1000;

            liter = deciliter / 10;
            deciliter %= 10;

            Console.WriteLine();
            Console.WriteLine("{0} hectoliter, {1} liter and {2} deciliter",hectoliter, liter, deciliter);
        }
    }
}
