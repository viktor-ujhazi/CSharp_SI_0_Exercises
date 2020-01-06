using System;

namespace Exercise01
{
    class Circle
    {
        static void Main(string[] args)
        {
            double radius = 0;
            do
            {
                Console.WriteLine("Enter the value of radius: ");
                string userInput = Console.ReadLine();
                try
                {
                    radius = double.Parse(userInput);

                }
                catch (FormatException)
                {
                    Console.WriteLine("That's not a number");
                    radius = 0;
                }
                
            } while (radius <= 0);
                       
            double circumference = 2 * Math.PI * radius; 
            double area = Math.PI * Math.Pow(radius, 2);
            double sphereVolume = (4 / 3) * Math.PI * Math.Pow(radius, 3);
            double sphereArea = 4 * Math.PI * Math.Pow(radius, 2);

            Console.WriteLine("Circumference of circle: " + circumference.ToString("F"));
            Console.WriteLine("Area of circle: " + area.ToString("F"));
            Console.WriteLine("Volume of sphere: " + sphereVolume.ToString("F"));
            Console.WriteLine("Surface area of sphere: " + sphereArea.ToString("F"));

        }
    }
}
