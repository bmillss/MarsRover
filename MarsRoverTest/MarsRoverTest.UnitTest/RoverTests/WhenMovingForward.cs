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
            var rover = new Rover();
            rover.Direction = Direction.North;
            //act
            rover.MoveForward();
            //assert
            Assert.AreEqual(1, rover.Y);
        }

    }
}
