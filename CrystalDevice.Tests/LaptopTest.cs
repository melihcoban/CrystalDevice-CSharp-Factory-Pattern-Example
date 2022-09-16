using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CrystalDevice.BL.Factories;

namespace CrystalDevice.Tests
{
    [TestClass]
    public class LaptopTest
    {
        LaptopFactory laptopProvider = new LaptopFactory();
        [TestMethod]
        public void LaptopNameTest()
        {
            // Arrange

            var laptop = laptopProvider.GetDevice("Laptop");
            var expected = laptop.DeviceName;

            // Act
            var actual = "Crystal Laptop";

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void LaptopWrongNameTest()
        {
            // Arrange
            var laptop = laptopProvider.GetDevice("Computer");
            var expected = laptop.DeviceName;
            Console.Write(expected);

            // Act
            var actual = "Crystal Laptop";     

            // Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
