using NUnit.Framework;
using Utilities.Web.Email;

namespace Utilities.Tests.Web.Email
{
    [TestFixture]
    [Category("Email")]
    [Category("Boolean")]
    public class IsValidEmail
    {
        [Test]
        public void IsValidEmail_EmptyString_ReturnsFalse()
        {
            // Arrange
            string emptyString = string.Empty;

            // Act
            bool isValid = emptyString.IsValidEmail();

            // Assert
            Assert.IsFalse(isValid);
        }

        [Test]
        public void IsValidEmail_NullString_ReturnsFalse()
        {
            // Arrange
            string nullString = null;

            // Act
            bool isValid = nullString.IsValidEmail();

            // Assert
            Assert.IsFalse(isValid);
        }

        [Test]
        public void IsValidEmail_InvalidEmails_ReturnsFalse()
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
        public void IsValidEmail_ValidEmails_ReturnsTrue()
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
