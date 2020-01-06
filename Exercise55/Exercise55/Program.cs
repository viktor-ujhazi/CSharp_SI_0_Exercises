/*
 * Készítsen osztályt, amely lakóhelyiségek alapterületét, falfelületét és a mennyezet méretét számolja ki a helyiség
 * hossza, szélessége és belmagassága alapján.
 * Az osztály teszteléseként kérje be, hogy hány helyiségben szeretne az illető kövezni és festeni, majd kérje be a
 * helyiségek adatait. Végül addja meg, hogy mennyi kőre és falfestékre lesz szükség (az ajtók és ablakok méretét
 * elhanyagoljuk). */


using System;
using System.Collections.Generic;

namespace Exercise55
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            int numberOfRooms=0;
            double z ;
            List<Room> listOfRooms = new List<Room>(); 
            do
            {
                Console.WriteLine("How many rooms do you want renovate?");
                userInput = Console.ReadLine();
                int.TryParse(userInput, out numberOfRooms);
            } while (numberOfRooms <= 0);
            for (int i=0; i < numberOfRooms; i++)
            {
                listOfRooms.Add(new Room(i));
                Console.WriteLine("Lenght of the {0}. room:",i+1);
                if (double.TryParse(Console.ReadLine(), out z))
                {
                    listOfRooms[i].RoomLenght = z;
                }
                else
                {
                    listOfRooms[i].RoomLenght = 0;
                }
                
                Console.WriteLine("Width of the {0}. room:", i + 1);
                if (double.TryParse(Console.ReadLine(), out z))
                {
                    listOfRooms[i].RoomWidth = z;
                }
                else
                {
                    listOfRooms[i].RoomWidth = 0;
                }
                Console.WriteLine("Height of the {0}. room:", i + 1);
                if (double.TryParse(Console.ReadLine(), out z))
                {
                    listOfRooms[i].RoomHeight = z;
                }
                else
                {
                    listOfRooms[i].RoomHeight = 0;
                }
            }
            double floor = 0;
            double paint = 0;
            for (int i = 0; i < listOfRooms.Count; i++)
            {
                floor += listOfRooms[i].DefineBaseSize(listOfRooms[i].RoomLenght, listOfRooms[i].RoomWidth);
                paint += listOfRooms[i].DefineWallSize(listOfRooms[i].RoomLenght, listOfRooms[i].RoomWidth, listOfRooms[i].RoomHeight);
                paint += listOfRooms[i].DefineCeilingSize(listOfRooms[i].RoomLenght, listOfRooms[i].RoomWidth);
            }
            Console.WriteLine("You need {0} floor and {1} paint.",floor,paint);

        }
    }
}
