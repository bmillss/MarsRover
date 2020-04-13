using System;

namespace MarsRover
{
    public static class Program
    {
        public static void Main(String[] args)
        {
            Direction startingDirection = Direction.North;
            Console.WriteLine("Hello! Please input a direction for movement, options are:\n F for forward, B for backward, L for turn left, R for turn right");

            string userInput = Console.ReadLine();

            Console.WriteLine("You inputed: " + userInput);

            String direction;
            direction = userInput.ToUpper();
            switch (direction)
            {
                case "F":
                    Console.WriteLine("Moving Forward...");
                    break;
                case "B":
                    Console.WriteLine("Moving Backward...");
                    break;
                case "L":
                    Console.WriteLine("Moving Left...");
                    break;
                case "R":
                    Console.WriteLine("Moving Right...");
                    break;
            }
        }
    }
}
