using NUnit.Framework;
using Utilities.Core.Text;

namespace Utilities.Tests.Core.Text
{
    [TestFixture]
    [Category("Text")]
    [Category("Boolean")]
    public class IsNotEmptyAndEqualToTests
    {
        [Test]
        public void IsNotEmptyAndEqualTo_EmptyStringAndNonEmptyEqualValue_ReturnsFalse()
        {
            // Arrange
            string emptyString = string.Empty;
            string equalValue = "Test String";

            // Act
            bool isEmpty = emptyString.IsNotEmptyAndEqualTo(equalValue);

            // Assert
            Assert.IsFalse(isEmpty);
        }

        [Test]
        public void IsNotEmptyAndEqualTo_EmptyStringAndEmptyEqualValue_ReturnsFalse()
        {
            // Arrange
            string emptyString = string.Empty;
            string equalValue = string.Empty;

            // Act
            bool isEmptyWithNoEqualValue = emptyString.IsNotEmptyAndEqualTo(equalValue);

            // Assert
            Assert.IsFalse(isEmptyWithNoEqualValue);
        }

        [Test]
        public void IsNotEmptyAndEqualTo_EmptyStringAndNullEqualValue_ReturnsFalse()
        {
            // Arrange
            string emptyString = string.Empty;
            string equalValue = null;

            // Act
            bool isEmptyWithNullEqualValue = emptyString.IsNotEmptyAndEqualTo(equalValue);

            // Assert
            Assert.IsFalse(isEmptyWithNullEqualValue);
        }

        [Test]
        public void IsNotEmptyAndEqualTo_NonEmptyStringAndNonEmptyEqualValue_ReturnsTrue()
        {
            // Arrange
            string nonEmptyString = "Test String";
            string equalValue = "Test String";

            // Act
            bool isNotEmpty = nonEmptyString.IsNotEmptyAndEqualTo(equalValue);

            // Assert
            Assert.IsTrue(isNotEmpty);
        }
    }
}
