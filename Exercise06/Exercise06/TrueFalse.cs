// Készítsen programot, mely logikai true/false értékeket olvas be a billentyűzetről! True esetén a képernyőre az
// IGAZ szót írja ki a program! 

using System;

namespace Exercise06
{
    class TrueFalse
    {
        static void Main(string[] args)
        {
            Console.Write("Enter true or false: ");
            string userInput = Console.ReadLine();
            if (userInput.ToLower().Equals("true"))
            {
                Console.WriteLine("IGAZ");
            }
        }
    }
}
