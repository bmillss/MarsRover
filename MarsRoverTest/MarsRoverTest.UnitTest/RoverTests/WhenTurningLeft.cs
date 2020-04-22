using MarsRover;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverTest.UnitTest.RoverTests
{
    [TestClass]
    public class WhenTurningLeft
    {
        [TestMethod]
        public void AndFacingNorthThenRoverFacesWest()
        {
            //arrange
            var rover = new Rover { Direction = Direction.North };
            //act
            rover.TurnLeft();
            //assert
            Assert.AreEqual(Direction.West, rover.Direction);
        }

        [TestMethod]
        public void AndFacingEastThenRoverFacesNorth()
        {
            //arrange
            var rover = new Rover { Direction = Direction.East };
            //act
            rover.TurnLeft();
            //assert
            Assert.AreEqual(Direction.North, rover.Direction);
        }

        [TestMethod]
        public void AndFacingSouthThenRoverFacesEast()
        {
            //arrange
            var rover = new Rover { Direction = Direction.South };
            //act
            rover.TurnLeft();
            //assert
            Assert.AreEqual(Direction.East, rover.Direction);
        }

        [TestMethod]
        public void AndFacingWestThenRoverFacesSouth()
        {
            //arrange
            var rover = new Rover { Direction = Direction.West };
            //act
            rover.TurnLeft();
            //assert
            Assert.AreEqual(Direction.South, rover.Direction);
        }

        [DataTestMethod]
        [DataRow(DisplayName = "AndFacingNorthThenTheRoverFacesEast")]
        [DataRow(DisplayName = "AndFacingEastThenTheRoverFacesSouth")]
        [DataRow(DisplayName = "AndFacingSouthThenRoverFacesWest")]
        [DataRow(DisplayName = "AndFacingWestThenRoverFacesNorth")]
        public void AndRoverFacesInitialDirectionThenRoverFacesFinalDirection(Direction initialDirection, Direction finalDirection)
        {
            //arrange
            var rover = new Rover { Direction = initialDirection };
            //act
            rover.TurnRight();
            //assert
            Assert.AreEqual(finalDirection, rover.Direction);
        }

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
