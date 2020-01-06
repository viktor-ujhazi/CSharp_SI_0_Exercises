// A téglatest oldalainak ismeretében számítsa ki a lapátlókat, majd határozza meg a testátlót, a felszínt és a
// térfogatot! 

using System;

namespace Exercise08
{
    class Cuboid
    {
        static void Main(string[] args)
        {
            double lenght = 0;
            double width = 0;
            double height = 0;

            Console.Write("Enter the lenght of the cuboid: ");
            string lenghtUserInput = Console.ReadLine();
            Console.Write("Enter the width of the cuboid: ");
            string widthUserInput1 = Console.ReadLine();
            Console.Write("Enter the height of the cuboid: ");
            string heightUserInput1 = Console.ReadLine();

            try
            {
                lenght = double.Parse(lenghtUserInput);
                width = double.Parse(widthUserInput1);
                height = double.Parse(heightUserInput1);
                if (lenght<=0 || width <=0 || height <= 0)
                {
                    throw new FormatException() ;
                }
                
            }
            catch (FormatException)
            {
                Console.WriteLine("These are not valid datas for a cuboid");
                Console.WriteLine("Good bye!");
                System.Environment.Exit(0);
            }
            Console.WriteLine();
            double diagonalLW = Math.Sqrt(Math.Pow(lenght,2)+Math.Pow(width,2));
            Console.WriteLine("Diagonal of the lenght/width side: {0:F3}",diagonalLW);

            double diagonalLH = Math.Sqrt(Math.Pow(lenght, 2) + Math.Pow(height, 2));
            Console.WriteLine("Diagonal of the lenght/height side: {0:F3}",diagonalLH);

            double diagonalWH = Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height, 2));
            Console.WriteLine("Diagonal of the width/height side: {0:F3}",diagonalWH);

            double diagonalCuboid = Math.Sqrt(Math.Pow(lenght, 2) + Math.Pow(width, 2)+ Math.Pow(height,2));
            Console.WriteLine("Diagonal of the cuboid: {0:F3}",diagonalCuboid);

            double surfaceCuboid = 2*(lenght*width + lenght*height + width*height);
            Console.WriteLine("Surface area of the cuboid: {0:F3}",surfaceCuboid);

            double volumeCuboid = lenght*width*height;
            Console.WriteLine("Volume of the cuboid: {0:F3}",volumeCuboid);



        }
    }
}
