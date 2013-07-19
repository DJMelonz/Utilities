using NUnit.Framework;
using System;
using Utilities.Core.Text;

namespace Utilities.Core.Text.Tests
{
    [TestFixture, Explicit]
    [Category("String Extension Methods")]
    public class StringExtensionsTests
    {
        [TestFixture]
        public class IsEmpty
        {
            [Test]
            public void IsEmpty_WithEmptyString_ReturnsTrue()
            {
                // Arrange
                string emptyString = string.Empty;

                // Act
                bool isEmpty = emptyString.IsEmpty();

                // Assert
                Assert.IsTrue(isEmpty);
            }

            [Test]
            public void IsEmpty_NullString_ReturnsTrue()
            {
                // Arrange
                string nullString = null;

                // Act
                bool nullStringIsEmpty = nullString.IsEmpty();

                // Assert
                Assert.IsTrue(nullStringIsEmpty);
            }

            [Test]
            public void IsEmpty_NonEmptyString_ReturnsFalse()
            {
                // Arrange
                string nonEmptyString = "Test String";

                // Act
                bool isNotEmpty = nonEmptyString.IsEmpty();

                // Assert
                Assert.IsFalse(isNotEmpty);
            }
        }

        [TestFixture]
        public class IsNotEmpty
        {
            [Test]
            public void IsNotEmpty_EmptyString_ReturnsFalse()
            {
                // Arrange
                string emptyString = string.Empty;

                // Act
                bool isEmpty = emptyString.IsNotEmpty();

                // Assert
                Assert.IsFalse(isEmpty);
            }

            [Test]
            public void IsNotEmpty_NonEmptyString_ReturnsTrue()
            {
                // Arrange
                string nonEmptyString = "Test String";

                // Act
                bool isNotEmpty = nonEmptyString.IsNotEmpty();

                // Assert
                Assert.IsTrue(isNotEmpty);
            }
        }

        [TestFixture]
        public class IsNotEmptyAndEqualTo
        {
            [Test]
            public void IsNotEmptyAndEqualTo_EmptyStringAndNonEmptyEqualValue_ReturnsFalse()
            {
                // Arrange
                string emptyString = string.Empty;
                string equalValue = "Test String";

                // Act
                bool isEmpty = emptyString.IsNotEmptyAndEqualTo(equalValue);

                // Assert
                Assert.IsFalse(isEmpty);
            }

            [Test]
            public void IsNotEmptyAndEqualTo_EmptyStringAndEmptyEqualValue_ReturnsFalse()
            {
                // Arrange
                string emptyString = string.Empty;
                string equalValue = string.Empty;

                // Act
                bool isEmptyWithNoEqualValue = emptyString.IsNotEmptyAndEqualTo(equalValue);

                // Assert
                Assert.IsFalse(isEmptyWithNoEqualValue);
            }

            [Test]
            public void IsNotEmptyAndEqualTo_EmptyStringAndNullEqualValue_ReturnsFalse()
            {
                // Arrange
                string emptyString = string.Empty;
                string equalValue = null;

                // Act
                bool isEmptyWithNullEqualValue = emptyString.IsNotEmptyAndEqualTo(equalValue);

                // Assert
                Assert.IsFalse(isEmptyWithNullEqualValue);
            }

            [Test]
            public void IsNotEmptyAndEqualTo_NonEmptyStringAndNonEmptyEqualValue_ReturnsTrue()
            {
                // Arrange
                string nonEmptyString = "Test String";
                string equalValue = "Test String";

                // Act
                bool isNotEmpty = nonEmptyString.IsNotEmptyAndEqualTo(equalValue);

                // Assert
                Assert.IsTrue(isNotEmpty);
            }
        }

        [TestFixture]
        public class IsNotEmptyOrEqualTo
        {
            [Test]
            public void IsNotEmptyOrEqualTo_EmptyStringAndNonEmptyEqualValue_ReturnsFalse()
            {
                // Arrange
                string emptyString = string.Empty;
                string equalValue = "Test String";

                // Act
                bool isEmpty = emptyString.IsNotEmptyOrEqualTo(equalValue);

                // Assert
                Assert.IsFalse(isEmpty);
            }

            [Test]
            public void IsNotEmptyOrEqualTo_EmptyStringAndEmptyEqualValue_ReturnsFalse()
            {
                // Arrange
                string emptyString = string.Empty;
                string equalValue = string.Empty;

                // Act
                bool isEmptyWithNoEqualValue = emptyString.IsNotEmptyOrEqualTo(equalValue);

                // Assert
                Assert.IsFalse(isEmptyWithNoEqualValue);
            }

            [Test]
            public void IsNotEmptyOrEqualTo_EmptyStringAndNullEqualValue_ReturnsFalse()
            {
                // Arrange
                string emptyString = string.Empty;
                string equalValue = null;

                // Act
                bool isEmpty = emptyString.IsNotEmptyOrEqualTo(equalValue);

                // Assert
                Assert.IsFalse(isEmpty);
            }

            [Test]
            public void IsNotEmptyOrEqualTo_NonEmptyStringAndNonEmptyMatchingEqualValue_ReturnsFalse()
            {
                // Arrange
                string nonEmptyString = "Test String";
                string equalValue = "Test String";

                // Act
                bool isNotEmptyWithMatchingValue = nonEmptyString.IsNotEmptyOrEqualTo(equalValue);

                // Assert
                Assert.IsFalse(isNotEmptyWithMatchingValue);
            }

            [Test]
            public void IsNotEmptyOrEqualTo_NonEmptyStringAndNonEmptyNonMatchingEqualValue_ReturnsTrue()
            {
                // Arrange
                string nonEmptyString = "Test String";
                string equalValue = "Non Matching Test String";

                // Act
                bool isNotEmptyWithNonMatchingValue = nonEmptyString.IsNotEmptyOrEqualTo(equalValue);

                // Assert
                Assert.IsTrue(isNotEmptyWithNonMatchingValue);
            }
        }

        [TestFixture]
        public class Truncate
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

        [TestFixture]
        public class With
        {
            [Test]
            public void With_EmptyStringPassingEmptyString_ReturnsEmptyString()
            {
                // Arrange
                string emptyString = string.Empty;
                string[] withValues = new[] {string.Empty};

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
                string[] withValues = new[] {"value1", "value2"};

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
                string[] withValues = new[] {"value1", "value2"};

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
                string[] withValues = new[] {"quartz"};

                // Act & Assert
                Assert.Throws<FormatException>(() => validString.With(withValues));
            }

            [Test]
            public void With_StringPassingCorrectNumberOfArguments_ReturnsString()
            {
                // Arrange
                string validString = "Sphinx of black {0}, judge my {1}.";
                string[] withValues = new[] {"quartz", "vow"};

                // Act
                string result = validString.With(withValues);

                // Assert
                Assert.AreEqual("Sphinx of black quartz, judge my vow.", result);
            }
        }

        [TestFixture]
        public class AddSpacesBetweenCaps
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
}
