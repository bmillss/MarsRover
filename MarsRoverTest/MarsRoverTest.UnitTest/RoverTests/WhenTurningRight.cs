using MarsRover;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverTest.UnitTest.RoverTests
{
    [TestClass]
    public class WhenTurningRight
    {
        [TestMethod]
        public void AndFacingNorth()
        {
            //arrange
            var rover = new Rover { Direction = Direction.North };
            //act
            rover.TurnRight();
            //assert
            Assert.AreEqual(Direction.East, rover.Direction);
        }


    }

    /*
        Turning Right
            - X and Y don't change
            - North -> East
            - East -> South
            - South -> West
            - West -> North
    */
}
