// Kérdezzük meg a felhasználót, hogy beszél-e magyarul, angolul, spanyolul (vagy amilyen nyelven tudunk). Ha
// egyikre igennel felel, akkor köszönjük azon a nyelven, ha egyiket sem ismeri, írjuk ki neki egy ♥-et. (unicode:
// 2665) 



using System;

namespace Exercise15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Tudsz magyarul?  ");
            string answerHun = Console.ReadLine();
           
            Console.Write("Do you speak english?  ");
            string answerEng = Console.ReadLine();
            Console.Write("¿Hablas español?  ");
            string answerEsp = Console.ReadLine();
            int knownLanguage = 0;
            char heart = '\u2665';
            if (answerHun.ToLower().Contains("igen"))
            {
                Console.WriteLine("Szia.");
                knownLanguage++; 
            }
            if (answerEng.ToLower().Contains("yes"))
            {
                Console.WriteLine("Hello.");
                knownLanguage++;
            }
            if (answerEsp.ToLower().Contains("si"))
            {
                Console.WriteLine("Ola.");
                knownLanguage++;
            }
            if (knownLanguage == 0)
            {
                Console.WriteLine(heart);
            }
        }
    }
}
