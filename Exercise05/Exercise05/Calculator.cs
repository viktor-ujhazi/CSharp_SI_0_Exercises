// Kérjen be a billentyűzetről két számot, majd írja ki azok összegét, különbségét, szorzatát és hányadosát a
// képernyőre! 

using System;

namespace Exercise05
{
    class Calculator
    {
        static void Main(string[] args)
        {

            double number1 = 0 ;
            double number2 = 0 ;

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
                Console.WriteLine("I only asked 2 numbers. Why don't you follow instructions?");
                Console.WriteLine("Good bye!");
                System.Environment.Exit(0);
            }

            double amount = number1 + number2 ;
            Console.WriteLine("{0} + {1} = {2}",number1, number2, amount);
            
            double difference = number1 - number2;
            Console.WriteLine("{0} - {1} = {2}", number1, number2, difference);
            double multiplication = number1 * number2;
            Console.WriteLine("{0} * {1} = {2}", number1, number2, multiplication);
            if (number2.Equals(0))
            {
                Console.WriteLine("{0} / {1} =   Not allowed to divide by zero", number1, number2);
            }
            else
            {
                double ratio = number1/number2 ;
                Console.WriteLine("{0} / {1} = {2}", number1, number2, ratio);
            }
            

        }
    }
}
