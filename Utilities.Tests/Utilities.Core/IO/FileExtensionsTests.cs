using Utilities.Core.IO;
using NUnit.Framework;

namespace Utilities.Tests.Utilities.Core.IO
{
    [TestFixture]
    public class FileExtensionsTests
    {
        [Test]
        public void EmptyString_GetExtension_ReturnsEmptyString()
        {
            // Arrange
            string emptyString = "";

            // Act
            string extension = emptyString.GetExtension();

            // Assert
            Assert.AreEqual(string.Empty, extension);
        }

        [Test]
        public void NullString_GetExtension_ReturnsEmptyString()
        {
            // Arrange
            string nullString = null;

            // Act
            string extension = nullString.GetExtension();

            // Assert
            Assert.AreEqual(string.Empty, extension);
        }

        [Test]
        public void StringWithInvalidFileName_GetExtension_ReturnsEmptyString()
        {
            // Arrange
            string invalidFilename = "test-filename.";

            // Act
            string extension = invalidFilename.GetExtension();

            // Assert
            Assert.AreEqual(string.Empty, extension);
        }

        [Test]
        public void StringWithValidFileName_GetExtension_ReturnsExtension()
        {
            // Arrange
            string filename = "test-filename.txt";

            // Act
            string extension = filename.GetExtension();

            // Assert
            Assert.AreEqual("txt", extension);
        }

        [Test]
        public void EmptyString_MimeType_ReturnsUnknownMimeType()
        {
            // Arrange
            string emptyString = "";

            // Act
            string mimeType = emptyString.MimeType();

            // Assert
            Assert.AreEqual("unknown/unknown", mimeType);
        }

        [Test]
        public void NullString_MimeType_ReturnsUnknownMimeType()
        {
            // Arrange
            string nullString = null;

            // Act
            string mimeType = nullString.MimeType();

            // Assert
            Assert.AreEqual("unknown/unknown", mimeType);
        }

        [Test]
        public void StringWithInvalidFileName_MimeType_ReturnsUnknownMimeType()
        {
            // Arrange
            string invalidFilename = "test-filename.";

            // Act
            string mimeType = invalidFilename.MimeType();

            // Assert
            Assert.AreEqual("unknown/unknown", mimeType);
        }

        [Test]
        public void StringWithValidFileName_MimeType_ReturnsMimeType()
        {
            // Arrange
            string filename = "test-filename.txt";

            // Act
            string mimeType = filename.MimeType();

            // Assert
            Assert.AreEqual("text/plain", mimeType);
        }

        [Test]
        public void EmptyString_GenerateGuidFileName_ReturnsEmptyString()
        {
            // Arrange
            string emptyString = "";

            // Act
            string fileName = emptyString.GenerateGuidFileName();

            // Assert
            Assert.AreEqual(string.Empty, fileName);
        }

        [Test]
        public void NullString_GenerateGuidFileName_ReturnsEmptyString()
        {
            // Arrange
            string nullString = null;

            // Act
            string fileName = nullString.GenerateGuidFileName();

            // Assert
            Assert.AreEqual(string.Empty, fileName);
        }

        [Test]
        public void StringWithInvalidFileName_GenerateGuidFileName_ReturnsEmptyString()
        {
            // Arrange
            string invalidFilename = "test-filename.";

            // Act
            string fileName = invalidFilename.GenerateGuidFileName();

            // Assert
            Assert.AreEqual(string.Empty, fileName);
        }

        [Test]
        public void StringWithValidFileName_GenerateGuidFileName_ReturnsFileName()
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
