using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    public class Rover
    {
        public Direction Direction { get; set; }
        
        public int X { get; set; }

        public int Y { get; set; }

        // Default constructor is a constructor that takes 0 parameters
        public Rover()
        {
            X = 0;
            Y = 0;
            Direction = Direction.North;
        }
        public void MoveForward()
        {
            if (Direction == Direction.North)
            {
                Y = Y + 1;
            }
            else if (Direction == Direction.South)
            {
                Y = Y - 1;
            }
            else if (Direction == Direction.East)
            {
                X = X + 1;
            }
            else if (Direction == Direction.West)
            {
                X = X - 1;
            }
        }
        public void MoveBackward()
        {
            if (Direction == Direction.North)
            {
                Y = Y - 1;
            }
            else if (Direction == Direction.South)
            {
                Y = Y + 1;
            }
            else if (Direction == Direction.East)
            {
                X = X - 1;
            }
            else if (Direction == Direction.West)
            {
                X = X + 1;
            }
        }
    }
}

