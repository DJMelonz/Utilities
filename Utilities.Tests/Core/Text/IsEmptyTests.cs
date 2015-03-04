using NUnit.Framework;
using Utilities.Core.Text;

namespace Utilities.Tests.Core.Text
{
    [TestFixture]
    [Category("Text")]
    [Category("Boolean")]
    public class IsEmptyTests
    {
        [Test]
        public void IsEmpty_WithEmptyString_ReturnsTrue()
        {
            // Arrange
            string emptyString = string.Empty;

            // Act
            bool isEmpty = emptyString.IsEmpty();

            // Assert
            Assert.IsTrue(isEmpty);
        }

        [Test]
        public void IsEmpty_NullString_ReturnsTrue()
        {
            // Arrange
            string nullString = null;

            // Act
            bool nullStringIsEmpty = nullString.IsEmpty();

            // Assert
            Assert.IsTrue(nullStringIsEmpty);
        }

        [Test]
        public void IsEmpty_NonEmptyString_ReturnsFalse()
        {
            // Arrange
            string nonEmptyString = "Test String";

            // Act
            bool isNotEmpty = nonEmptyString.IsEmpty();

            // Assert
            Assert.IsFalse(isNotEmpty);
        }
    }
}
