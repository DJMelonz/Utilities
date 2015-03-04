using NUnit.Framework;
using Utilities.Core.Text;

namespace Utilities.Tests.Core.Text
{
    [TestFixture]
    [Category("Text")]
    [Category("String")]
    public class TruncateTests
    {
        [Test]
        public void Truncate_EmptyString_ReturnsEmptyString()
        {
            // Arrange
            string emptyString = string.Empty;

            // Act
            string truncated = emptyString.Truncate();

            // Assert
            Assert.AreEqual(string.Empty, truncated);
        }

        [Test]
        public void Truncate_NullString_ReturnsEmptyString()
        {
            // Arrange
            string nullString = null;

            // Act
            string truncated = nullString.Truncate();

            // Assert
            Assert.AreEqual(string.Empty, truncated);
        }

        [Test]
        public void Truncate_NonEmptyString_ReturnsTruncatedString()
        {
            // Arrange
            string stringToTruncate =
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean luctus, massa quis mattis mollis, ligula tellus sollicitudin neque, ut pretium risus neque vitae diam.";

            // Act
            string truncated = stringToTruncate.Truncate();

            // Assert
            Assert.AreEqual("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean luctus, mas ...",
                truncated);
        }

        [Test]
        public void Truncate_StringWithTruncateLength_ReturnsTruncatedString()
        {
            // Arrange
            string stringToTruncate =
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean luctus, massa quis mattis mollis, ligula tellus sollicitudin neque, ut pretium risus neque vitae diam.";

            // Act
            string truncated = stringToTruncate.Truncate(100);

            // Assert
            Assert.AreEqual(
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean luctus, massa quis mattis mollis, li ...",
                truncated);
        }

        [Test]
        public void Truncate_StringWithTruncateLengthLongerThanString_ReturnsString()
        {
            // Arrange
            string stringToTruncate = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";

            // Act
            string truncated = stringToTruncate.Truncate(100);

            // Assert
            Assert.AreEqual("Lorem ipsum dolor sit amet, consectetur adipiscing elit.", truncated);
        }
    }
}
