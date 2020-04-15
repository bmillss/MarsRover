using MarsRover;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverTest.UnitTest.RoverTests
{
    [TestClass]
    public class WhenMovingForward
    {
        [TestMethod]
        public void AndFacingNorthThenYIncrementsByOne()
        {
            //arrange 
            var rover = new Rover { Direction = Direction.North };
            //act
            rover.MoveForward();
            //assert
            Assert.AreEqual(1, rover.Y);
        }
        [TestMethod]
        public void AndFacingSouthThenYDecreasesByOne()
        {
            //arrange 
            var rover = new Rover { Direction = Direction.South };
            //act
            rover.MoveForward();
            //assert
            Assert.AreEqual(-1, rover.Y);
        }
        [TestMethod]
        public void AndFacingEastThenXIncrementsByOne()
        {
            //arrange 
            var rover = new Rover { Direction = Direction.East };
            //act
            rover.MoveForward();
            //assert
            Assert.AreEqual(1, rover.X);
        }
        [TestMethod]
        public void AndFacingWestThenXDecreasesByOne()
        {
            //arrange 
            var rover = new Rover { Direction = Direction.West };
            //act
            rover.MoveForward();
            //assert
            Assert.AreEqual(-1, rover.X);
        }

    }
}
