using NUnit.Framework;
using Utilities.Web.Email;

namespace Utilities.Tests.Utilities.Web.Email
{
    [TestFixture]
    public class EmailExtensionsTests
    {
        [Test]
        public void EmptyString_IsValidEmail_ReturnsFalse()
        {
            // Arrange
            string emptyString = "";

            // Act
            bool isValid = emptyString.IsValidEmail();

            // Assert
            Assert.IsFalse(isValid);
        }

        [Test]
        public void NullString_IsValidEmail_ReturnsFalse()
        {
            // Arrange
            string nullString = null;

            // Act
            bool isValid = nullString.IsValidEmail();

            // Assert
            Assert.IsFalse(isValid);
        }

        [Test]
        public void InvalidEmail_IsValidEmail_ReturnsFalse()
        {
            // Arrange
            string invalidEmail1 = "test";
            string invalidEmail2 = "test@";
            string invalidEmail3 = "test@te..";
            string invalidEmail4 = "test@te..xxx";
            string invalidEmail5 = "test.@test.com";
            string invalidEmail6 = "test.@test.com.";

            // Act
            bool isValid1 = invalidEmail1.IsValidEmail();
            bool isValid2 = invalidEmail2.IsValidEmail();
            bool isValid3 = invalidEmail3.IsValidEmail();
            bool isValid4 = invalidEmail4.IsValidEmail();
            bool isValid5 = invalidEmail5.IsValidEmail();
            bool isValid6 = invalidEmail6.IsValidEmail();

            // Assert
            Assert.IsFalse(isValid1);
            Assert.IsFalse(isValid2);
            Assert.IsFalse(isValid3);
            Assert.IsFalse(isValid4);
            Assert.IsFalse(isValid5);
            Assert.IsFalse(isValid6);
        }

        [Test]
        public void ValidEmail_IsValidEmail_ReturnsTrue()
        {
            // Arrange
            string validEmail1 = "test@test.com";
            string validEmail2 = "test+id@test.com";

            // Act
            bool isValid1 = validEmail1.IsValidEmail();
            bool isValid2 = validEmail2.IsValidEmail();

            // Assert
            Assert.IsTrue(isValid1);
            Assert.IsTrue(isValid2);
        }
    }
}
