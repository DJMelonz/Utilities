using NUnit.Framework;
using Utilities.Core.IO;

namespace Utilities.Tests.Core.IO
{
    [TestFixture]
    [Category("IO")]
    [Category("String")]
    public class GetExtensionTests
    {
        [Test]
        public void GetExtension_EmptyString_ReturnsEmptyString()
        {
            // Arrange
            string emptyString = string.Empty;

            // Act
            string extension = emptyString.GetExtension();

            // Assert
            Assert.AreEqual(string.Empty, extension);
        }

        [Test]
        public void GetExtension_NullString_ReturnsEmptyString()
        {
            // Arrange
            string nullString = null;

            // Act
            string extension = nullString.GetExtension();

            // Assert
            Assert.AreEqual(string.Empty, extension);
        }

        [Test]
        public void GetExtension_FileNameWithNoExtension_ReturnsEmptyString()
        {
            // Arrange
            string invalidFilename = "test-filename.";

            // Act
            string extension = invalidFilename.GetExtension();

            // Assert
            Assert.AreEqual(string.Empty, extension);
        }

        [Test]
        public void GetExtension_ValidFileName_ReturnsExtension()
        {
            // Arrange
            string filename = "test-filename.txt";

            // Act
            string extension = filename.GetExtension();

            // Assert
            Assert.AreEqual("txt", extension);
        }
    }
}
