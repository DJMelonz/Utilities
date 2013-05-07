using System.Utilities.Core.Text;
using NUnit.Framework;

namespace System.Utilities.Tests.Utilities.Core.Text
{
    [TestFixture]
    public class StringExtensionsTests
    {
        [Test]
        public void EmptyString_IsEmpty_ReturnsFalse()
        {
            // Arrange
            string emptyString = "";

            // Act
            bool isEmpty = emptyString.IsEmpty();

            // Assert
            Assert.IsTrue(isEmpty, "String was empty");
        }

        [Test]
        public void NonEmptyString_IsEmpty_ReturnsFalse()
        {
            // Arrange
            string nonEmptyString = "Test String";

            // Act
            bool isNotEmpty = nonEmptyString.IsEmpty();

            // Assert
            Assert.IsFalse(isNotEmpty, "String was not empty");
        }
    }
}
