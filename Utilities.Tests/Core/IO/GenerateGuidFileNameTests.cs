using NUnit.Framework;
using Utilities.Core.IO;

namespace Utilities.Tests.Core.IO
{
    [TestFixture]
    [Category("IO")]
    [Category("String")]
    public class GenerateGuidFileNameTests
    {
        [Test]
        public void GenerateGuidFileName_EmptyString_ReturnsEmptyString()
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
