using JetBrains.Annotations;
using LAb2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LAb.Tests

{
    [TestClass]
    public class LAbTests
    {
        [TestMethod]
        public void Count_ShouldReturnCorrectNumberOfElements()
        {
            // Arrange
            var set = new Set<int>(new[] { 1, 2, 3, 4, 5 });

            // Act
            int count = set.Count;

            // Assert
            Assert.AreEqual(5, count, "Count method should return the correct number of elements.");
        }

        [TestMethod]
        public void Count_ShouldReturnZeroForEmptySet()
        {
            // Arrange
            var set = new Set<int>();

            // Act
            int count = set.Count;

            // Assert
            Assert.AreEqual(0, count, "Count method should return 0 for an empty set.");
        }

        [TestMethod]
        public void ExplicitConversionToInt_ShouldReturnCorrectCount()
        {
            // Arrange
            var set = new Set<int>(new[] { 1, 2, 3 });

            // Act
            int count = (int)set;

            // Assert
            Assert.AreEqual(3, count, "Explicit conversion to int should return the correct count.");
        }
    }
}