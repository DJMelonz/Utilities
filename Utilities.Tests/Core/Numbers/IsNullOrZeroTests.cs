using NUnit.Framework;
using Utilities.Core.Numbers;

namespace Utilities.Tests.Core.Numbers
{
    [TestFixture]
    [Category("Numbers")]
    [Category("Boolean")]
    public class IsNullOrZeroTests
    {
        [Test]
        public void IsNullOrZero_ZeroInt_ReturnsTrue()
        {
            // Arrange
            int? nullInt = 0;

            // Act
            bool intIsZero = nullInt.IsNullOrZero();

            // Assert
            Assert.IsTrue(intIsZero);
        }

        [Test]
        public void IsNullOrZero_NullInt_ReturnsTrue()
        {
            // Arrange
            int? nullInt = null;

            // Act
            bool intIsNull = nullInt.IsNullOrZero();

            // Assert
            Assert.IsTrue(intIsNull);
        }

        [Test]
        public void IsNullOrZero_IntWithValue_ReturnsFalse()
        {
            // Arrange
            int? nonNullInt = 1;

            // Act
            bool intIsNotNullOrZero = nonNullInt.IsNullOrZero();

            // Assert
            Assert.IsFalse(intIsNotNullOrZero);
        }
    }
}
