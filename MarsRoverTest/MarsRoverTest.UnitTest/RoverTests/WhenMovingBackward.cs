using MarsRover;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRoverTest.UnitTest.RoverTests
{
    [TestClass]
    public class WhenMovingBackward
    {
        [TestMethod]
        public void AndFacingNorthThenYDecreasesByOne()
        {
            //arrange 
            var rover = new Rover { Direction = Direction.North };
            //act
            rover.MoveBackward();
            //assert
            Assert.AreEqual(-1, rover.Y);
        }
        [TestMethod]
        public void AndFacingSouthThenYIncreasesByOne()
        {
            //arrange 
            var rover = new Rover { Direction = Direction.South };
            //act
            rover.MoveBackward();
            //assert
            Assert.AreEqual(1, rover.Y);
        }
        [TestMethod]
        public void AndFacingEastThenXDecreasesByOne()
        {
            //arrange 
            var rover = new Rover { Direction = Direction.East };
            //act
            rover.MoveBackward();
            //assert
            Assert.AreEqual(-1, rover.X);
        }
        [TestMethod]
        public void AndFacingWestThenXIncreasesByOne()
        {
            //arrange 
            var rover = new Rover { Direction = Direction.West };
            //act
            rover.MoveBackward();
            //assert
            Assert.AreEqual(1, rover.X);
        }
    }
}