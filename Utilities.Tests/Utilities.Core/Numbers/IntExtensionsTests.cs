using NUnit.Framework;

namespace Utilities.Core.Numbers.Tests
{
    [TestFixture, Explicit]
    [Category("Integer Extension Methods")]
    public class IntExtensionsTests
    {
        [TestFixture]
        public class IsNullOrZero
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

        [TestFixture]
        public class IsNotNullOrZero
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
}
