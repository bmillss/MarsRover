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

        [DataTestMethod]
        [DataRow(Direction.North, Direction.West, DisplayName = "AndFacingNorthThenTheRoverFacesWest")]
        [DataRow(Direction.East, Direction.North, DisplayName = "AndFacingEastThenTheRoverFacesNorth")]
        [DataRow(Direction.South, Direction.East, DisplayName = "AndFacingSouthThenRoverFacesEast")]
        [DataRow(Direction.West, Direction.South, DisplayName = "AndFacingWestThenRoverFacesSouth")]
        public void AndRoverFacesInitialDirectionThenRoverFacesFinalDirection(Direction initialDirection, Direction finalDirection)
        {
            //arrange
            var rover = new Rover { Direction = initialDirection };
            //act
            rover.TurnLeft();
            //assert
            Assert.AreEqual(finalDirection, rover.Direction);
        }

    }
}