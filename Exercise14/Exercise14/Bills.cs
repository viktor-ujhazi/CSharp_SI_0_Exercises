// Kérje be egy cég éves bevételét és kiadását. Állapítsa meg, hogy nyereséges, veszteséges vagy nullszaldós volt-e
// a cég és az eredményt írja ki.

using System;

namespace Exercise14
{
    class Bills
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the yearly income: ");
            string stringIncome = Console.ReadLine();
            double income = CheckInput(stringIncome);

            Console.Write("Enter the yearly expenses: ");
            string stringExpenses = Console.ReadLine();
            double expenses = CheckInput(stringExpenses);

            Console.WriteLine();
            if ((income - expenses) > 0)
            {
                Console.WriteLine("It was a good year. You made {0} profit.",income-expenses);
            }
            else if ((income - expenses) < 0)
            {
                Console.WriteLine("Maybe next year you will be better. You made {0} loss.", expenses-income);
            }
            else
            {
                Console.WriteLine("Not great, not terrible. The income and expenses were equal.");
            }
        }

        public static double CheckInput(string userInput)
        {
            try
            {
                double inputToDouble = double.Parse(userInput);
                return inputToDouble;
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid data.");
                System.Environment.Exit(0);
            }
            return 0;
        }
    }
}
