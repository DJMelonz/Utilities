using NUnit.Framework;
using Utilities.Core.Text;

namespace Utilities.Tests.Core.Text
{
    [TestFixture]
    [Category("Text")]
    [Category("Boolean")]
    public class IsNotEmptyTests
    {
        [Test]
        public void IsNotEmpty_EmptyString_ReturnsFalse()
        {
            // Arrange
            string emptyString = string.Empty;

            // Act
            bool isEmpty = emptyString.IsNotEmpty();

            // Assert
            Assert.IsFalse(isEmpty);
        }

        [Test]
        public void IsNotEmpty_NonEmptyString_ReturnsTrue()
        {
            // Arrange
            string nonEmptyString = "Test String";

            // Act
            bool isNotEmpty = nonEmptyString.IsNotEmpty();

            // Assert
            Assert.IsTrue(isNotEmpty);
        }
    }
}
