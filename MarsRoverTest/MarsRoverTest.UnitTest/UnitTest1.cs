using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace MarsRoverTest.UnitTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethod1()
        {
            string expected = "F";
            string actual = "f";

            // Arrange

            // Act

            //Assert
//            Assert.AreEqual("f", );
            
        }
        
        [TestMethod]
        public void TestMethod2()
        {
            string expected = "F";
            string actual = "f";

            Assert.AreEqual("F", actual);
            Assert.IsTrue(false, expected);
            Assert.IsFalse(false, "f");
            Assert.IsNull(true, "f");
        }

        [TestMethod]
        public void ThenTheStringRadarIsAPalindrom()
        {
            // Arrange
            const string input = "radar";

            // Act
            var isPalindrome = IsPalindrom(input);

            // Assert
            Assert.IsFalse(isPalindrome);
        }

        private bool IsPalindrom(string a)
        {
            for (var i = 0; i < a.Length; i++)
            {
                if (a[i] != a[a.Length - 1 - i]) return false;
            }
            return true;
        }
    }
    // level = level
    // radar = radar
    // Cameron = noremac
}
