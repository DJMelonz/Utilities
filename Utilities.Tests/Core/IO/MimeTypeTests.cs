using NUnit.Framework;
using Utilities.Core.IO;

namespace Utilities.Tests.Core.IO
{
    [TestFixture]
    [Category("IO")]
    [Category("String")]
    public class MimeTypeTests
    {
        [Test]
        public void MimeType_EmptyString_ReturnsUnknownMimeType()
        {
            // Arrange
            string emptyString = string.Empty;

            // Act
            string mimeType = emptyString.MimeType();

            // Assert
            Assert.AreEqual("unknown/unknown", mimeType);
        }

        [Test]
        public void MimeType_NullString_ReturnsUnknownMimeType()
        {
            // Arrange
            string nullString = null;

            // Act
            string mimeType = nullString.MimeType();

            // Assert
            Assert.AreEqual("unknown/unknown", mimeType);
        }

        [Test]
        public void MimeType_StringWithInvalidFileName_ReturnsUnknownMimeType()
        {
            // Arrange
            string invalidFilename = "test-filename.";

            // Act
            string mimeType = invalidFilename.MimeType();

            // Assert
            Assert.AreEqual("unknown/unknown", mimeType);
        }

        [Test]
        public void MimeType_StringWithValidFileName_ReturnsMimeType()
        {
            // Arrange
            string filename = "test-filename.txt";

            // Act
            string mimeType = filename.MimeType();

            // Assert
            Assert.AreEqual("text/plain", mimeType);
        }
    }
}
