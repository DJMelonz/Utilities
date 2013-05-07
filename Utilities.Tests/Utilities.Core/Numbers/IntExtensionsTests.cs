using System.Utilities.Core.Numbers;
using NUnit.Framework;

namespace System.Utilities.Tests.Utilities.Core.Numbers
{
    [TestFixture]
    public class IntExtensionsTests
    {
        [Test]
        public void ZeroInt_IsNullOrZero_ReturnsTrue()
        {
            // Arrange
            int? nullInt = 0;

            // Act
            bool intIsZero = nullInt.IsNullOrZero();

            // Assert
            Assert.IsTrue(intIsZero);
        }

        [Test]
        public void NullInt_IsNullOrZero_ReturnsTrue()
        {
            // Arrange
            int? nullInt = null;

            // Act
            bool intIsNull = nullInt.IsNullOrZero();

            // Assert
            Assert.IsTrue(intIsNull);
        }

        [Test]
        public void IntWithValue_IsNullOrZero_ReturnsTrue()
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
