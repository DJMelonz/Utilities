using NUnit.Framework;
using Utilities.Core.Numbers;

namespace Utilities.Tests.Core.Numbers
{
    [TestFixture]
    [Category("Numbers")]
    [Category("Boolean")]
    public class IsNotNullOrZeroTests
    {
        [Test]
        public void IsNotNullOrZero_ZeroInt_ReturnsFalse()
        {
            // Arrange
            int? nullInt = 0;

            // Act
            bool intIsZero = nullInt.IsNotNullOrZero();

            // Assert
            Assert.IsFalse(intIsZero);
        }

        [Test]
        public void IsNotNullOrZero_NullInt_ReturnsFalse()
        {
            // Arrange
            int? nullInt = null;

            // Act
            bool intIsNull = nullInt.IsNotNullOrZero();

            // Assert
            Assert.IsFalse(intIsNull);
        }

        [Test]
        public void IsNotNullOrZero_IntWithValue_ReturnsTrue()
        {
            // Arrange
            int? nonNullInt = 1;

            // Act
            bool intIsNotNullOrZero = nonNullInt.IsNotNullOrZero();

            // Assert
            Assert.IsTrue(intIsNotNullOrZero);
        }
    }
}
