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
            Y = Y + 1;
        }

        //TODO: Bonus points
        // Research on how to write a default constructor
        //that would explicitly set X, Y, and Direction
    }
}

