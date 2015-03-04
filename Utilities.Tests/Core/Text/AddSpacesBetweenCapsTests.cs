using NUnit.Framework;
using Utilities.Core.Text;

namespace Utilities.Tests.Core.Text
{
    [TestFixture]
    [Category("Text")]
    [Category("String")]
    public class AddSpacesBetweenCapsTests
    {
        [Test]
        public void AddSpacesBetweenCaps_EmptyString_ReturnsEmptyString()
        {
            // Arrange
            string emptyString = string.Empty;

            // Act
            string result = emptyString.AddSpacesBetweenCaps();

            // Assert
            Assert.AreEqual(string.Empty, result);
        }

        [Test]
        public void AddSpacesBetweenCaps_NullString_ReturnsEmptyString()
        {
            // Arrange
            string nullString = null;

            // Act
            string result = nullString.AddSpacesBetweenCaps();

            // Assert
            Assert.AreEqual(string.Empty, result);
        }

        [Test]
        public void AddSpacesBetweenCaps_AllUppercaseString_ReturnsFormattedString()
        {
            // Arrange
            string allCaps = "LOREMIPSUMDOLOR";

            // Act
            string result = allCaps.AddSpacesBetweenCaps();

            // Assert
            Assert.AreEqual("L O R E M I P S U M D O L O R", result);
        }

        [Test]
        public void AddSpacesBetweenCaps_AllLowercaseString_ReturnsString()
        {
            // Arrange
            string allCaps = "lorem ipsum dolor";

            // Act
            string result = allCaps.AddSpacesBetweenCaps();

            // Assert
            Assert.AreEqual("lorem ipsum dolor", result);
        }

        [Test]
        public void AddSpacesBetweenCaps_StringWithSpaces_ReturnsFormattedStringWithExtraSpaces()
        {
            // Arrange
            string allCaps = "Lorem Ipsum Dolor";

            // Act
            string result = allCaps.AddSpacesBetweenCaps();

            // Assert
            Assert.AreEqual("Lorem  Ipsum  Dolor", result);
        }

        [Test]
        public void AddSpacesBetweenCaps_StringWithSpaces_ReturnsFormattedString()
        {
            // Arrange
            string allCaps = "LoremIpsumDolor";

            // Act
            string result = allCaps.AddSpacesBetweenCaps();

            // Assert
            Assert.AreEqual("Lorem Ipsum Dolor", result);
        }
    }
}
