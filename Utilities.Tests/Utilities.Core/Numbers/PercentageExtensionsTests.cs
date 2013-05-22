using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Utilities.Core.Numbers;

namespace Utilities.Tests.Utilities.Core.Numbers
{
    [TestFixture]
    public class PercentageExtensionsTests
    {
        [Test]
        public void NullListOfInts_AsPercentages_ReturnsEmptyList()
        {
            // Arrange
            List<int> nullList = null;

            // Act
            IEnumerable<double> percentages = nullList.AsPercentages();

            // Assert
            Assert.AreEqual(0, percentages.Count());
        }

        [Test]
        public void EmptyListOfInts_AsPercentages_ReturnsEmptyList()
        {
            // Arrange
            List<int> emptyList = new List<int>(0);

            // Act
            IEnumerable<double> percentages = emptyList.AsPercentages();

            // Assert
            Assert.AreEqual(0, percentages.Count());
        }

        [Test]
        public void ListOfIntsWithZero_AsPercentages_ReturnsEmptyList()
        {
            // Arrange
            List<int> listWithZero = new List<int> { 0 };

            // Act
            IEnumerable<double> percentages = listWithZero.AsPercentages();

            // Assert
            Assert.AreEqual(0, percentages.Count());
        }

        [Test]
        public void ListOfIntsWithZeros_AsPercentages_ReturnsEmptyList()
        {
            // Arrange
            List<int> listWithZeros = new List<int> { 0, 0, 0 };

            // Act
            IEnumerable<double> percentages = listWithZeros.AsPercentages();

            // Assert
            Assert.AreEqual(0, percentages.Count());
        }

        [Test]
        public void ListOfIntsContainingZero_AsPercentages_ReturnsList()
        {
            // Arrange
            List<int> listContainingZero = new List<int> { 0, 2, 2 };

            // Act
            IEnumerable<double> percentages = listContainingZero.AsPercentages();

            // Assert
            Assert.AreEqual(new List<double> { 0.0D, 0.5D, 0.5D }, percentages.ToList());
        }

        [Test]
        public void ListOfInts_AsPercentages_ReturnsList()
        {
            // Arrange
            List<int> list1 = new List<int> { 1, 2, 3, 4 };
            List<int> list2 = new List<int> { 20, 40, 60, 80 };

            // Act
            IEnumerable<double> percentages1 = list1.AsPercentages();
            IEnumerable<double> percentages2 = list2.AsPercentages();

            // Assert
            Assert.AreEqual(new List<double> { 0.1D, 0.2D, 0.3D, 0.4D }, percentages1.ToList());
            Assert.AreEqual(new List<double> { 0.1D, 0.2D, 0.3D, 0.4D }, percentages2.ToList());
        }


        [Test]
        public void NullListOfLongs_AsPercentages_ReturnsEmptyList()
        {
            // Arrange
            List<long> nullList = null;

            // Act
            IEnumerable<double> percentages = nullList.AsPercentages();

            // Assert
            Assert.AreEqual(0, percentages.Count());
        }

        [Test]
        public void EmptyListOfLongs_AsPercentages_ReturnsEmptyList()
        {
            // Arrange
            List<long> emptyList = new List<long>(0);

            // Act
            IEnumerable<double> percentages = emptyList.AsPercentages();

            // Assert
            Assert.AreEqual(0, percentages.Count());
        }

        [Test]
        public void ListOfLongsWithZero_AsPercentages_ReturnsEmptyList()
        {
            // Arrange
            List<long> listWithZero = new List<long> { 0L };

            // Act
            IEnumerable<double> percentages = listWithZero.AsPercentages();

            // Assert
            Assert.AreEqual(0, percentages.Count());
        }

        [Test]
        public void ListOfLongsWithZeros_AsPercentages_ReturnsEmptyList()
        {
            // Arrange
            List<long> listWithZeros = new List<long> { 0L, 0L, 0L };

            // Act
            IEnumerable<double> percentages = listWithZeros.AsPercentages();

            // Assert
            Assert.AreEqual(0, percentages.Count());
        }

        [Test]
        public void ListOfLongsContainingZero_AsPercentages_ReturnsList()
        {
            // Arrange
            List<long> listContainingZero = new List<long> { 0L, 2L, 2L };

            // Act
            IEnumerable<double> percentages = listContainingZero.AsPercentages();

            // Assert
            Assert.AreEqual(new List<double> { 0.0D, 0.5D, 0.5D }, percentages.ToList());
        }

        [Test]
        public void ListOfLongs_AsPercentages_ReturnsList()
        {
            // Arrange
            List<long> list1 = new List<long> { 1L, 2L, 3L, 4L };
            List<long> list2 = new List<long> { 20L, 40L, 60L, 80L };

            // Act
            IEnumerable<double> percentages1 = list1.AsPercentages();
            IEnumerable<double> percentages2 = list2.AsPercentages();

            // Assert
            Assert.AreEqual(new List<double> { 0.1D, 0.2D, 0.3D, 0.4D }, percentages1.ToList());
            Assert.AreEqual(new List<double> { 0.1D, 0.2D, 0.3D, 0.4D }, percentages2.ToList());
        }


        [Test]
        public void NullListOfDoubles_AsPercentages_ReturnsEmptyList()
        {
            // Arrange
            List<double> nullList = null;

            // Act
            IEnumerable<double> percentages = nullList.AsPercentages();

            // Assert
            Assert.AreEqual(0, percentages.Count());
        }

        [Test]
        public void EmptyListOfDoubles_AsPercentages_ReturnsEmptyList()
        {
            // Arrange
            List<double> emptyList = new List<double>(0);

            // Act
            IEnumerable<double> percentages = emptyList.AsPercentages();

            // Assert
            Assert.AreEqual(0, percentages.Count());
        }

        [Test]
        public void ListOfDoublesWithZero_AsPercentages_ReturnsEmptyList()
        {
            // Arrange
            List<double> listWithZero = new List<double> { 0D };

            // Act
            IEnumerable<double> percentages = listWithZero.AsPercentages();

            // Assert
            Assert.AreEqual(0, percentages.Count());
        }

        [Test]
        public void ListOfDoublesWithZeros_AsPercentages_ReturnsEmptyList()
        {
            // Arrange
            List<double> listWithZeros = new List<double> { 0D, 0D, 0D };

            // Act
            IEnumerable<double> percentages = listWithZeros.AsPercentages();

            // Assert
            Assert.AreEqual(0, percentages.Count());
        }

        [Test]
        public void ListOfDoublesContainingZero_AsPercentages_ReturnsList()
        {
            // Arrange
            List<double> listContainingZero = new List<double> { 0D, 2D, 2D };

            // Act
            IEnumerable<double> percentages = listContainingZero.AsPercentages();

            // Assert
            Assert.AreEqual(new List<double> { 0.0D, 0.5D, 0.5D }, percentages.ToList());
        }

        [Test]
        public void ListOfDoubles_AsPercentages_ReturnsList()
        {
            // Arrange
            List<double> list1 = new List<double> { 1D, 2D, 3D, 4D };
            List<double> list2 = new List<double> { 20D, 40D, 60D, 80D };

            // Act
            IEnumerable<double> percentages1 = list1.AsPercentages();
            IEnumerable<double> percentages2 = list2.AsPercentages();

            // Assert
            Assert.AreEqual(new List<double> { 0.1D, 0.2D, 0.3D, 0.4D }, percentages1.ToList());
            Assert.AreEqual(new List<double> { 0.1D, 0.2D, 0.3D, 0.4D }, percentages2.ToList());
        }
    }
}
