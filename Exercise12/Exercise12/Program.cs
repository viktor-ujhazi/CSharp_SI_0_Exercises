// Nem negatív egész számról határozza meg egy program, hogy hány jegyű! 

using System;

namespace Exercise12
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Enter a positive whole number: ");
            string userInput = Console.ReadLine();
            try
            {
                number = int.Parse(userInput);
                if (number < 0)
                {
                    throw new FormatException();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("That is not a positive whole number.");
                System.Environment.Exit(0);
            }

            Console.WriteLine("The {0} number has {1} digits.",userInput, userInput.Length);

        }
    }
}
