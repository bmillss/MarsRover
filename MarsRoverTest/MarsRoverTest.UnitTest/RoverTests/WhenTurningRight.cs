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
        public void AndFacingNorthThenRoverFacesEast()
        {
            //arrange
            var rover = new Rover { Direction = Direction.North };
            //act
            rover.TurnRight();
            //assert
            Assert.AreEqual(Direction.East, rover.Direction);
        }

        [TestMethod]
        public void AndFacingEastThenRoverFacesSouth()
        {
            //arrange
            var rover = new Rover { Direction = Direction.East };
            //act
            rover.TurnRight();
            //assert
            Assert.AreEqual(Direction.South, rover.Direction);
        }

        [TestMethod]
        public void AndFacingSouthThenRoverFacesWest()
        {
            //arrange
            var rover = new Rover { Direction = Direction.South };
            //act
            rover.TurnRight();
            //assert
            Assert.AreEqual(Direction.West, rover.Direction);
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
