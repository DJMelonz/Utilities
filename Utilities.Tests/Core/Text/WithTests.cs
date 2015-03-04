using NUnit.Framework;
using System;
using Utilities.Core.Text;

namespace Utilities.Tests.Core.Text
{
    [TestFixture]
    [Category("Text")]
    [Category("String")]
    public class WithTests
    {
        [Test]
        public void With_EmptyStringPassingEmptyString_ReturnsEmptyString()
        {
            // Arrange
            string emptyString = string.Empty;
            string[] withValues = new[] { string.Empty };

            // Act
            string result = emptyString.With(withValues);

            // Assert
            Assert.AreEqual(string.Empty, result);
        }

        [Test]
        public void With_NullStringPassingNonEmptyString_ThrowsArgumentNullException()
        {
            // Arrange
            string nullString = null;
            string[] withValues = new[] { "value1", "value2" };

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => nullString.With(withValues));
        }

        [Test]
        public void With_StringPassingNullString_ThrowsArgumentNullException()
        {
            // Arrange
            string validString = "Sphinx of black {0}, judge my {1}.";
            string[] withValues = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => validString.With(withValues));
        }

        [Test]
        public void With_EmptyStringPassingArguments_ReturnsEmptyString()
        {
            // Arrange
            string emptyString = string.Empty;
            string[] withValues = new[] { "value1", "value2" };

            // Act
            string result = emptyString.With(withValues);

            // Assert
            Assert.AreEqual(string.Empty, result);
        }

        [Test]
        public void With_StringPassingNoArguments_ThrowsFormatException()
        {
            // Arrange
            string validString = "Sphinx of black {0}, judge my {1}.";

            // Act & Assert
            Assert.Throws<FormatException>(() => validString.With());
        }

        [Test]
        public void With_StringPassingIncorrectNumberOfArguments_ThrowsFormatException()
        {
            // Arrange
            string validString = "Sphinx of black {0}, judge my {1}.";
            string[] withValues = new[] { "quartz" };

            // Act & Assert
            Assert.Throws<FormatException>(() => validString.With(withValues));
        }

        [Test]
        public void With_StringPassingCorrectNumberOfArguments_ReturnsString()
        {
            // Arrange
            string validString = "Sphinx of black {0}, judge my {1}.";
            string[] withValues = new[] { "quartz", "vow" };

            // Act
            string result = validString.With(withValues);

            // Assert
            Assert.AreEqual("Sphinx of black quartz, judge my vow.", result);
        }
    }
}
