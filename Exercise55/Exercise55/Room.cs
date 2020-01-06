using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise55
{
    class Room
    {
        public int Identifier { get; set; }
        public double RoomLenght { get; set; } = 0;
        public double RoomWidth { get; set; } = 0;
        public double RoomHeight { get; set; } = 0;


        public Room(int identifier)
        {
            Identifier = identifier;
        }

        public Room(int identifier, double roomLenght, double roomWidth, double roomHeight)
        {
            Identifier = identifier;
            RoomLenght = roomLenght;
            RoomWidth = roomWidth;
            RoomHeight = roomHeight;
        }
        
        public double DefineBaseSize(double RoomLenght, double RoomWidth)
        {
            return RoomLenght * RoomWidth;
        }
        public double DefineWallSize(double RoomLenght, double RoomWidth, double RoomHeight)
        {
            return 2*(RoomLenght * RoomHeight + RoomWidth * RoomHeight);
        }
        public double DefineCeilingSize(double RoomLenght, double RoomWidth)
        {
            return RoomLenght * RoomWidth;
        }


    }
}
