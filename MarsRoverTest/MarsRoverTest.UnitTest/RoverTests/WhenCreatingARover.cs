using MarsRover;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverTest.UnitTest.RoverTests
{
    [TestClass]
    public class WhenCreatingARover
    {
        [TestMethod]
        public void ThenTheDirectionShouldBeNorth()
        {
            // Arrange and Act
            var rover = new Rover();

            // Assert
            Assert.AreEqual(Direction.North, rover.Direction);
        }
        [TestMethod]
        public void ThenXShouldBeZero()
        {
            // Arrange
            var rover = new Rover();
            // Act
            // Assert
            Assert.AreEqual(0, rover.X);
        }
        [TestMethod]
        public void ThenYShouldBeZero()
        {
            // Arrange
            var rover = new Rover();
            // Act
            // Assert
            Assert.AreEqual(0, rover.Y);
        }
        // TODO: Write a unit test that verifies that when the rover is created, the X value is 0
        // TODO: Write a unit test that verifies that when the srover is created, the Y value is 0

    }
}
