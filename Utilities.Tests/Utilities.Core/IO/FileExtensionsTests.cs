using Utilities.Core.IO;
using NUnit.Framework;

namespace Utilities.Tests.Utilities.Core.IO
{
    [TestFixture]
    public class FileExtensionsTests
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

        [Test]
        public void GenerateGuidFileNameEmptyString__ReturnsEmptyString()
        {
            // Arrange
            string emptyString = string.Empty;

            // Act
            string fileName = emptyString.GenerateGuidFileName();

            // Assert
            Assert.AreEqual(string.Empty, fileName);
        }

        [Test]
        public void GenerateGuidFileName_NullString_ReturnsEmptyString()
        {
            // Arrange
            string nullString = null;

            // Act
            string fileName = nullString.GenerateGuidFileName();

            // Assert
            Assert.AreEqual(string.Empty, fileName);
        }

        [Test]
        public void GenerateGuidFileName_StringWithInvalidFileName_ReturnsEmptyString()
        {
            // Arrange
            string invalidFilename = "test-filename.";

            // Act
            string fileName = invalidFilename.GenerateGuidFileName();

            // Assert
            Assert.AreEqual(string.Empty, fileName);
        }

        [Test]
        public void GenerateGuidFileName_StringWithValidFileName_ReturnsFileName()
        {
            // Arrange
            string filename = "test-filename.txt";

            // Act
            string generatedFileName = filename.GenerateGuidFileName();

            // Assert
            Assert.IsNotNullOrEmpty(generatedFileName);
            Assert.IsFalse(generatedFileName.Contains(filename));
        }
    }
}
