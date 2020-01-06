// A téglatest oldalainak ismeretében határozza meg az oldalélek összegét, majd írassa ki a legrövidebb oldalél
// összeggel rendelkező test adatait, felszínét és térfogatát.

using System;

namespace Exercise09
{
    class Cuboid2
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
                if (lenght <= 0 || width <= 0 || height <= 0)
                {
                    throw new FormatException();
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("These are not valid datas for a cuboid");
                Console.WriteLine("Good bye!");
                System.Environment.Exit(0);
            }

            if(lenght+width<lenght+height && lenght+width< width + height)
            {
                Console.WriteLine("Smallest side is lenght/width.");
                Console.WriteLine("Circumference: {0}",2*(lenght+width));
                Console.WriteLine("Area: {0}",lenght*width);
            }
            else if(lenght+height<lenght+width && lenght+height< width + height)
            {
                Console.WriteLine("Smallest side is lenght/height.");
                Console.WriteLine("Circumference: {0}", 2 * (lenght + height));
                Console.WriteLine("Area: {0}", lenght * height);
            }
            else if(width+height<lenght+height && width + height < lenght + width)
            {
                Console.WriteLine("Smallest side is width/height.");
                Console.WriteLine("Circumference: {0}", 2 * (width + height));
                Console.WriteLine("Area: {0}", width * height);
            }
            else
            {
                Console.WriteLine("It's a cube. All side is equal.");
            }
        }
    }
}
