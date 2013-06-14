using System;
using Utilities.Core.Text;
using NUnit.Framework;

namespace Utilities.Tests.Utilities.Core.Text
{
    [TestFixture]
    public class StringExtensionsTests
    {
        [Test]
        public void EmptyString_IsEmpty_ReturnsTrue()
        {
            // Arrange
            string emptyString = "";

            // Act
            bool isEmpty = emptyString.IsEmpty();

            // Assert
            Assert.IsTrue(isEmpty);
        }

        [Test]
        public void NullString_IsEmpty_ReturnsTrue()
        {
            // Arrange
            string nullString = null;

            // Act
            bool nullStringIsEmpty = nullString.IsEmpty();

            // Assert
            Assert.IsTrue(nullStringIsEmpty);
        }

        [Test]
        public void NonEmptyString_IsEmpty_ReturnsFalse()
        {
            // Arrange
            string nonEmptyString = "Test String";

            // Act
            bool isNotEmpty = nonEmptyString.IsEmpty();

            // Assert
            Assert.IsFalse(isNotEmpty);
        }

        [Test]
        public void EmptyString_IsNotEmpty_ReturnsFalse()
        {
            // Arrange
            string emptyString = "";

            // Act
            bool isEmpty = emptyString.IsNotEmpty();

            // Assert
            Assert.IsFalse(isEmpty);
        }

        [Test]
        public void NonEmptyString_IsNotEmpty_ReturnsTrue()
        {
            // Arrange
            string nonEmptyString = "Test String";

            // Act
            bool isNotEmpty = nonEmptyString.IsNotEmpty();

            // Assert
            Assert.IsTrue(isNotEmpty);
        }

        [Test]
        public void EmptyString_IsNotEmptyAndEqualTo_ReturnsFalse()
        {
            // Arrange
            string emptyString = "";

            // Act
            bool isEmpty = emptyString.IsNotEmptyAndEqualTo("Test String");
            bool isEmptyWithNoEqualValue = emptyString.IsNotEmptyAndEqualTo("");
            bool isEmptyWithNullEqualValue = emptyString.IsNotEmptyAndEqualTo(null);

            // Assert
            Assert.IsFalse(isEmpty);
            Assert.IsFalse(isEmptyWithNoEqualValue);
            Assert.IsFalse(isEmptyWithNullEqualValue);
        }

        [Test]
        public void NonEmptyString_IsNotEmptyAndEqualTo_ReturnsTrue()
        {
            // Arrange
            string nonEmptyString = "Test String";

            // Act
            bool isNotEmpty = nonEmptyString.IsNotEmptyAndEqualTo("Test String");

            // Assert
            Assert.IsTrue(isNotEmpty);
        }

        [Test]
        public void EmptyString_IsNotEmptyOrEqualTo_ReturnsFalse()
        {
            // Arrange
            string emptyString = "";

            // Act
            bool isEmpty = emptyString.IsNotEmptyOrEqualTo("Test String");
            bool isEmptyWithNoEqualValue = emptyString.IsNotEmptyOrEqualTo("");
            bool isEmptyWithNullEqualValue = emptyString.IsNotEmptyOrEqualTo(null);

            // Assert
            Assert.IsFalse(isEmpty);
            Assert.IsFalse(isEmptyWithNoEqualValue);
            Assert.IsFalse(isEmptyWithNullEqualValue);
        }

        [Test]
        public void NonEmptyString_IsNotEmptyOrEqualTo_ReturnsTrue()
        {
            // Arrange
            string nonEmptyString = "Test String";

            // Act
            bool isNotEmptyWithMatchingValue = nonEmptyString.IsNotEmptyOrEqualTo("Test String");
            bool isNotEmptyWithNonMatchingValue = nonEmptyString.IsNotEmptyOrEqualTo("Non Matching Test String");

            // Assert
            Assert.IsFalse(isNotEmptyWithMatchingValue);
            Assert.IsTrue(isNotEmptyWithNonMatchingValue);
        }

        [Test]
        public void EmptyString_Truncate_ReturnsEmptyString()
        {
            // Arrange
            string emptyString = "";

            // Act
            string truncated = emptyString.Truncate();

            // Assert
            Assert.AreEqual("", truncated);
        }

        [Test]
        public void NullString_Truncate_ReturnsEmptyString()
        {
            // Arrange
            string nullString = null;

            // Act
            string truncated = nullString.Truncate();

            // Assert
            Assert.AreEqual("", truncated);
        }

        [Test]
        public void NonEmptyString_Truncate_ReturnsEmptyString()
        {
            // Arrange
            string stringToTruncate = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean luctus, massa quis mattis mollis, ligula tellus sollicitudin neque, ut pretium risus neque vitae diam.";

            // Act
            string truncated = stringToTruncate.Truncate();

            // Assert
            Assert.AreEqual("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean luctus, mas ...", truncated);
            Assert.AreEqual(79, truncated.Length);
        }

        [Test]
        public void NonEmptyString_TruncateWithLength_ReturnsEmptyString()
        {
            // Arrange
            string stringToTruncate = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean luctus, massa quis mattis mollis, ligula tellus sollicitudin neque, ut pretium risus neque vitae diam.";

            // Act
            string truncated = stringToTruncate.Truncate(100);

            // Assert
            Assert.AreEqual("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean luctus, massa quis mattis mollis, li ...", truncated);
            Assert.AreEqual(104, truncated.Length);
        }

        [Test]
        public void EmptyStringPassingEmptyString_With_ReturnsEmptyString()
        {
            // Arrange
            string emptyString = "";

            // Act
            string result = emptyString.With("");

            // Assert
            Assert.AreEqual("", result);
        }

        [Test]
        public void NullStringPassingNonEmptyString_With_ThrowsArgumentNullException()
        {
            // Arrange
            string nullString = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => nullString.With("value1", "value2"));
        }

        [Test]
        public void StringPassingNullString_With_ThrowsArgumentNullException()
        {
            // Arrange
            string validString = "Sphinx of black {0}, judge my {1}.";

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => validString.With(null));
        }

        [Test]
        public void EmptyStringPassingArguments_With_ReturnsEmptyString()
        {
            // Arrange
            string emptyString = "";

            // Act
            string result = emptyString.With("value1", "value2");

            // Assert
            Assert.AreEqual("", result);
        }

        [Test]
        public void StringPassingNoArguments_With_ThrowsFormatException()
        {
            // Arrange
            string validString = "Sphinx of black {0}, judge my {1}.";

            // Act & Assert
            Assert.Throws<FormatException>(() => validString.With());
        }

        [Test]
        public void StringPassingIncorrectNumberOfArguments_With_ThrowsFormatException()
        {
            // Arrange
            string validString = "Sphinx of black {0}, judge my {1}.";

            // Act & Assert
            Assert.Throws<FormatException>(() => validString.With("quartz"));
        }

        [Test]
        public void StringPassingCorrectNumberOfArguments_With_ReturnsString()
        {
            // Arrange
            string validString = "Sphinx of black {0}, judge my {1}.";

            // Act
            string result = validString.With("quartz", "vow");

            // Assert
            Assert.AreEqual("Sphinx of black quartz, judge my vow.", result);
        }

        [Test]
        public void EmptyString_ToSlug_ReturnsEmptyString()
        {
            // Arrange
            string emptyString = "";

            // Act
            string result = emptyString.ToSlug();

            // Assert
            Assert.AreEqual("", result);
        }

        [Test]
        public void NullString_ToSlug_ReturnsEmptyString()
        {
            // Arrange
            string nullString = null;

            // Act
            string result = nullString.ToSlug();

            // Assert
            Assert.AreEqual("", result);
        }

        [Test]
        public void StringWithPunctuation_ToSlug_ReturnsFormattedString()
        {
            // Arrange
            string punctuatedString = "Sphinx of black quartz, judge my vow.";

            // Act
            string result = punctuatedString.ToSlug();

            // Assert
            Assert.AreEqual("sphinx-of-black-quartz-judge-my-vow", result);
        }

        [Test]
        public void StringWithExcessiveDashes_ToSlug_ReturnsFormattedString()
        {
            // Arrange
            string excessivelyDashedString = "Sphinx - of -- black quartz, --- judge my vow.-";

            // Act
            string result = excessivelyDashedString.ToSlug();

            // Assert
            Assert.AreEqual("sphinx-of-black-quartz-judge-my-vow", result);
        }

        [Test]
        public void StringWithPunctuationAndTruncateValue_ToSlug_ReturnsTruncatedFormattedString()
        {
            // Arrange
            string punctuatedString = "Sphinx of black quartz, judge my vow.";

            // Act
            string result = punctuatedString.ToSlug(15);

            // Assert
            Assert.AreEqual("sphinx-of-black", result);
            Assert.AreEqual(15, result.Length);
        }

        [Test]
        public void StringWithPunctuationAndTruncateValueEndingOnDash_ToSlug_ReturnsTruncatedFormattedString()
        {
            // Arrange
            string punctuatedString = "Sphinx of black quartz, judge my vow.";

            // Act
            string result = punctuatedString.ToSlug(16);

            // Assert
            Assert.AreEqual("sphinx-of-black", result);
            Assert.AreEqual(15, result.Length);
        }
    }
}
