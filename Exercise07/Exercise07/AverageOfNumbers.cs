// Írjon programot, mely beolvas egy számpárt a billentyűzetről, majd kiírja a két szám számtani közepét!

using System;

namespace Exercise07
{
    class AverageOfNumbers
    {
        static void Main(string[] args)
        {
            double number1 = 0;
            double number2 = 0;

            Console.Write("Enter a number: ");
            string userInput1 = Console.ReadLine();
            Console.Write("Enter another number: ");
            string userInput2 = Console.ReadLine();

            try
            {
                number1 = double.Parse(userInput1);
                number2 = double.Parse(userInput2);
            }
            catch (FormatException)
            {
                Console.WriteLine("Next time try to follow instructions");
                Console.WriteLine("Good bye!");
                System.Environment.Exit(0);
            }

            double numsAverage = (number1 + number2) / 2;
            Console.WriteLine("The average of {0} and {1} is {2}.",number1, number2, numsAverage);

        }
    }
}
