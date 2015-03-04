using NUnit.Framework;
using Utilities.Core.Text;

namespace Utilities.Tests.Core.Text
{
    [TestFixture]
    [Category("Text")]
    [Category("Boolean")]
    public class IsNotEmptyOrEqualToTests
    {
        [Test]
        public void IsNotEmptyOrEqualTo_EmptyStringAndNonEmptyEqualValue_ReturnsFalse()
        {
            // Arrange
            string emptyString = string.Empty;
            string equalValue = "Test String";

            // Act
            bool isEmpty = emptyString.IsNotEmptyOrEqualTo(equalValue);

            // Assert
            Assert.IsFalse(isEmpty);
        }

        [Test]
        public void IsNotEmptyOrEqualTo_EmptyStringAndEmptyEqualValue_ReturnsFalse()
        {
            // Arrange
            string emptyString = string.Empty;
            string equalValue = string.Empty;

            // Act
            bool isEmptyWithNoEqualValue = emptyString.IsNotEmptyOrEqualTo(equalValue);

            // Assert
            Assert.IsFalse(isEmptyWithNoEqualValue);
        }

        [Test]
        public void IsNotEmptyOrEqualTo_EmptyStringAndNullEqualValue_ReturnsFalse()
        {
            // Arrange
            string emptyString = string.Empty;
            string equalValue = null;

            // Act
            bool isEmpty = emptyString.IsNotEmptyOrEqualTo(equalValue);

            // Assert
            Assert.IsFalse(isEmpty);
        }

        [Test]
        public void IsNotEmptyOrEqualTo_NonEmptyStringAndNonEmptyMatchingEqualValue_ReturnsFalse()
        {
            // Arrange
            string nonEmptyString = "Test String";
            string equalValue = "Test String";

            // Act
            bool isNotEmptyWithMatchingValue = nonEmptyString.IsNotEmptyOrEqualTo(equalValue);

            // Assert
            Assert.IsFalse(isNotEmptyWithMatchingValue);
        }

        [Test]
        public void IsNotEmptyOrEqualTo_NonEmptyStringAndNonEmptyNonMatchingEqualValue_ReturnsTrue()
        {
            // Arrange
            string nonEmptyString = "Test String";
            string equalValue = "Non Matching Test String";

            // Act
            bool isNotEmptyWithNonMatchingValue = nonEmptyString.IsNotEmptyOrEqualTo(equalValue);

            // Assert
            Assert.IsTrue(isNotEmptyWithNonMatchingValue);
        }
    }
}
