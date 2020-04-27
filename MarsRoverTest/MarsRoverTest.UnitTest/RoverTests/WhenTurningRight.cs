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

        [DataTestMethod]
        [DataRow(Direction.North, Direction.East, DisplayName = "AndFacingNorthThenTheRoverFacesEast")]
        [DataRow(Direction.East, Direction.South, DisplayName = "AndFacingEastThenTheRoverFacesSouth")]
        [DataRow(Direction.South, Direction.West, DisplayName = "AndFacingSouthThenRoverFacesWest")]
        [DataRow(Direction.West, Direction.North, DisplayName = "AndFacingWestThenRoverFacesNorth")]
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