//Olvasson be három számot, majd írassa ki őket csökkenő sorrendben. 

using System;
using System.Collections;

namespace Exercise02
{
    class decreasingNumbers
    {
        static void Main(string[] args)
        {
            int limit = 3;
            int sequence = 1;
            double[] numbers = new double[limit]; 
            do
            {
                Console.WriteLine("Enter the {0}. number: ", sequence.ToString());
                string userInput = Console.ReadLine();
                try
                {
                    double number = double.Parse(userInput);
                    numbers.SetValue(number, sequence - 1);
                    sequence++;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Thats not a number.");
                }



            } while (sequence<=limit);
            Array.Sort(numbers);
            Array.Reverse(numbers);
            for (int i = 0; i < limit; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
