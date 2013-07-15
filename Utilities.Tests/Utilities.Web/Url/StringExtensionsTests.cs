using NUnit.Framework;

namespace Utilities.Web.Url.Tests
{
    [TestFixture, Explicit]
    [Category("String Extension Methods")]
    public class StringExtensionsTests
    {
        [TestFixture]
        public class ToSlug
        {
            [Test]
            public void ToSlug_EmptyString_ReturnsEmptyString()
            {
                // Arrange
                string emptyString = string.Empty;

                // Act
                string result = emptyString.ToSlug();

                // Assert
                Assert.AreEqual(string.Empty, result);
            }

            [Test]
            public void ToSlug_NullString_ReturnsEmptyString()
            {
                // Arrange
                string nullString = null;

                // Act
                string result = nullString.ToSlug();

                // Assert
                Assert.AreEqual(string.Empty, result);
            }

            [Test]
            public void ToSlug_StringWithPunctuation_ReturnsFormattedString()
            {
                // Arrange
                string punctuatedString = "Sphinx of black quartz, judge my vow.";

                // Act
                string result = punctuatedString.ToSlug();

                // Assert
                Assert.AreEqual("sphinx-of-black-quartz-judge-my-vow", result);
            }

            [Test]
            public void ToSlug_StringWithExcessiveDashes_ReturnsFormattedString()
            {
                // Arrange
                string excessivelyDashedString = "Sphinx - of -- black quartz, --- judge my vow.-";

                // Act
                string result = excessivelyDashedString.ToSlug();

                // Assert
                Assert.AreEqual("sphinx-of-black-quartz-judge-my-vow", result);
            }

            [Test]
            public void ToSlug_StringWithPunctuationAndTruncateValue_ReturnsTruncated()
            {
                // Arrange
                string punctuatedString = "Sphinx of black quartz, judge my vow.";

                // Act
                string result = punctuatedString.ToSlug(15);

                // Assert
                Assert.AreEqual(15, result.Length);
            }

            [Test]
            public void ToSlug_StringWithPunctuationAndTruncateValue_ReturnsFormattedString()
            {
                // Arrange
                string punctuatedString = "Sphinx of black quartz, judge my vow.";

                // Act
                string result = punctuatedString.ToSlug(15);

                // Assert
                Assert.AreEqual("sphinx-of-black", result);
            }

            [Test]
            public void ToSlug_StringWithPunctuationAndTruncateValueEndingOnSpace_ReturnsTruncated()
            {
                // Arrange
                string punctuatedString = "Sphinx of black quartz, judge my vow.";

                // Act
                string result = punctuatedString.ToSlug(16);

                // Assert
                Assert.AreEqual(15, result.Length);
            }

            [Test]
            public void ToSlug_StringWithPunctuationAndTruncateValueEndingOnSpace_ReturnsFormattedString()
            {
                // Arrange
                string punctuatedString = "Sphinx of black quartz, judge my vow.";

                // Act
                string result = punctuatedString.ToSlug(16);

                // Assert
                Assert.AreEqual("sphinx-of-black", result);
            }
        }
    }
}
