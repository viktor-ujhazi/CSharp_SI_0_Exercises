// Írjon programot, mely egy háromszög oldalainak (a, b, c) hosszát olvassa be a billentyűzetről, majd megmondja,
// hogy a háromszög szerkeszthető-e! (A háromszög szerkeszthető, ha az(a+b>c) és(a+c>b) és(b+c>a) feltétel
// teljesül.)

using System;

namespace Exercise03
{
    class Triangle
    {
        static void Main(string[] args)
        {
            int limit = 3;
            int sequence = 1;
            double[] numbers = new double[limit];
            do
            {
                Console.WriteLine("Enter the lenght of the {0}. side of the triangle: ", sequence.ToString());
                string userInput = Console.ReadLine();
                try
                {
                    double number = double.Parse(userInput);
                    if (number > 0)
                    {
                        numbers.SetValue(number, sequence - 1);
                        sequence++;
                    }
                    else
                    {
                        Console.WriteLine("It can't be negative number.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Thats not a number.");
                }



            } while (sequence <= limit);

            double a = numbers[0];
            double b = numbers[1];
            double c = numbers[2];

            if (a + b > c && a+c>b && b+c>a)
            {
                Console.WriteLine("The triangle is valid.");
            }
            else
            {
                Console.WriteLine("The triangle is not valid.");
            }
                       
        }
    }
}
