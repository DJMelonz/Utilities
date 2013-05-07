using System.Utilities.Core.Text;
using NUnit.Framework;

namespace System.Utilities.Tests.Utilities.Core.Text
{
    [TestFixture]
    public class StringExtensionsTests
    {
        [Test]
        public void EmptyString_IsEmpty_ReturnsTrue()
        {
            // Arrange
            string emptyString = "";

            // Act
            bool isEmpty = emptyString.IsEmpty();

            // Assert
            Assert.IsTrue(isEmpty, "String was empty.");
        }

        [Test]
        public void NonEmptyString_IsEmpty_ReturnsFalse()
        {
            // Arrange
            string nonEmptyString = "Test String";

            // Act
            bool isNotEmpty = nonEmptyString.IsEmpty();

            // Assert
            Assert.IsFalse(isNotEmpty, "String was not empty.");
        }

        [Test]
        public void EmptyString_IsNotEmpty_ReturnsFalse()
        {
            // Arrange
            string emptyString = "";

            // Act
            bool isEmpty = emptyString.IsNotEmpty();

            // Assert
            Assert.IsFalse(isEmpty, "String was empty.");
        }

        [Test]
        public void NonEmptyString_IsNotEmpty_ReturnsTrue()
        {
            // Arrange
            string nonEmptyString = "Test String";

            // Act
            bool isNotEmpty = nonEmptyString.IsNotEmpty();

            // Assert
            Assert.IsTrue(isNotEmpty, "String was not empty.");
        }

        [Test]
        public void EmptyString_IsNotEmptyAndEqualTo_ReturnsFalse()
        {
            // Arrange
            string emptyString = "";

            // Act
            bool isEmpty = emptyString.IsNotEmptyAndEqualTo("Test String");
            bool isEmptyWithNoEqualValue = emptyString.IsNotEmptyAndEqualTo("");
            bool isEmptyWithNullEqualValue = emptyString.IsNotEmptyAndEqualTo(null);

            // Assert
            Assert.IsFalse(isEmpty, "String was empty and not equal to \"Test String\".");
            Assert.IsFalse(isEmptyWithNoEqualValue, "String was empty and not equal to empty string.");
            Assert.IsFalse(isEmptyWithNullEqualValue, "String was empty.");
        }

        [Test]
        public void EmptyString_IsNotEmptyAndEqualTo_ReturnsTrue()
        {
            // Arrange
            string nonEmptyString = "Test String";

            // Act
            bool isNotEmpty = nonEmptyString.IsNotEmptyAndEqualTo("Test String");

            // Assert
            Assert.IsTrue(isNotEmpty, "String was not empty and equal to \"Test String\".");
        }

        [Test]
        public void EmptyString_IsNotEmptyOrEqualTo_ReturnsFalse()
        {
            // Arrange
            string emptyString = "";

            // Act
            bool isEmpty = emptyString.IsNotEmptyOrEqualTo("Test String");
            bool isEmptyWithNoEqualValue = emptyString.IsNotEmptyOrEqualTo("");
            bool isEmptyWithNullEqualValue = emptyString.IsNotEmptyOrEqualTo(null);

            // Assert
            Assert.IsFalse(isEmpty, "String was empty and not equal to \"Test String\".");
            Assert.IsFalse(isEmptyWithNoEqualValue, "String was empty and not equal to empty string.");
            Assert.IsFalse(isEmptyWithNullEqualValue, "String was empty.");
        }

        [Test]
        public void EmptyString_IsNotEmptyOrEqualTo_ReturnsTrue()
        {
            // Arrange
            string nonEmptyString = "Test String";

            // Act
            bool isNotEmptyWithMatchingValue = nonEmptyString.IsNotEmptyOrEqualTo("Test String");
            bool isNotEmptyWithNonMatchingValue = nonEmptyString.IsNotEmptyOrEqualTo("Non Matching Test String");

            // Assert
            Assert.IsFalse(isNotEmptyWithMatchingValue, "String was not empty and equal to \"Test String\".");
            Assert.IsTrue(isNotEmptyWithNonMatchingValue, "String was not empty and not equal to \"Test String\".");
        }
    }
}
