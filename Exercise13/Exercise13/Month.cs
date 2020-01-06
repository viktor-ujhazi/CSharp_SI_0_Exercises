// Olvassa be egy hónap nevét, majd írja ki, hogy melyik évszakban van az adott hónap. 

using System;
using System.Linq;

namespace Exercise13
{
    class Month
    {
        static void Main(string[] args)
        {
            string[] winter = {"december", "january", "february"};
            string[] spring = {"march", "april", "may"};
            string[] summer = {"june", "july", "august"};
            string[] autumn = {"september", "october", "november"};

            Console.Write ("Enter a month: ");
            string month = Console.ReadLine();
            Console.WriteLine();
            if (winter.Contains(month.ToLower())){
                Console.WriteLine("It's in winter.");
            }
            else if (spring.Contains(month.ToLower()))
            {
                Console.WriteLine("It's in spring.");
            }
            else if (summer.Contains(month.ToLower()))
            {
                Console.WriteLine("It's in summer.");
            }
            else if (autumn.Contains(month.ToLower()))
            {
                Console.WriteLine("It's in autumn.");
            }
            else
            {
                Console.WriteLine("There is no month like that.");
            }
        }
    }
}
