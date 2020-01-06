// Olvasson be a billentyűzetről egy számot és mondjuk meg, hogy a szám negatív, vagy pozitív! 


using System;

namespace Exercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            string userInput = Console.ReadLine();
            try
            {
                double number = double.Parse(userInput);
                if (number >= 0)
                {
                    Console.WriteLine("it's a positive number.");
                }
                else
                {
                    Console.WriteLine("It's a negative number.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("That's not a number.");               
            }
           
        }
    }
}
