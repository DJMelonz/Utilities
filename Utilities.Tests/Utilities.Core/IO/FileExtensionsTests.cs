using System.Utilities.Core.IO;
using NUnit.Framework;

namespace System.Utilities.Tests.Utilities.Core.IO
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
        public void StringWithInvalidFileName_GetExtension_ReturnsEmptyString()
        {
            // Arrange
            string invalidFilename = "test-filename.";

            // Act
            string extension = invalidFilename.GetExtension();

            // Assert
            Assert.AreEqual(string.Empty, extension);
        }
    }
}
