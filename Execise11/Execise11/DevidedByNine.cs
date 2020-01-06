// Beolvasott egész számról döntsük el, hogy osztható-e kilenccel, a vizsgálatot a számjegyek összegének 9-cel
// való oszthatóságával végezzük, majd ellenőrizzük le maradékos osztással is. 


using System;

namespace Execise11
{
    class DevidedByNine
    {
        static void Main(string[] args)
        {
            int number = 0;
            Console.Write("Enter a positive whole number: ");
            string userInput = Console.ReadLine();
            try
            {
                number = int.Parse(userInput);
            }
            catch (FormatException)
            {
                Console.WriteLine("That is not a positiv whole number.");
                System.Environment.Exit(0);
            }

            int sum = 0;
            for (int i = 0; i < userInput.Length; i++)
            {
                sum += (int)char.GetNumericValue(userInput[i]);
            }
            if ((sum).Equals((sum / 9) * 9))
            {
                Console.WriteLine("{0} is evenly divisible by 9.", number);
            }
            else
            {
                Console.WriteLine("{0} is not evenly divisible by 9.", number);
            }

            
        }
    }
}
