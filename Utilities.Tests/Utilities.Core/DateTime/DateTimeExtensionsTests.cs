using NUnit.Framework;
using System;

namespace Utilities.Core.DateTime.Tests
{
    [TestFixture, Explicit]
    [Category("DateTime Extension Methods")]
    public class DateTimeExtensionsTests
    {
        [TestFixture]
        public class FirstDayOfWeek
        {
            [Test]
            public void FirstDayOfWeek_DateTime_ReturnsDateTime()
            {
                // Arrange
                System.DateTime date = new System.DateTime(2013, 1, 1);

                // Act
                System.DateTime result = date.FirstDayOfWeek();

                // Assert
                Assert.AreEqual(new System.DateTime(2012, 12, 31), result);
            }

            [Test]
            public void FirstDayOfWeek_DateTime_ReturnsCorrectDayOfWeek()
            {
                // Arrange
                System.DateTime date = new System.DateTime(2013, 1, 1);

                // Act
                System.DateTime result = date.FirstDayOfWeek();

                // Assert
                Assert.AreEqual(DayOfWeek.Monday, result.DayOfWeek);
            }
        }

        [TestFixture]
        public class LastDayOfWeek
        {
            [Test]
            public void LastDayOfWeek_DateTime_ReturnsDateTime()
            {
                // Arrange
                System.DateTime date = new System.DateTime(2013, 1, 1);

                // Act
                System.DateTime result = date.LastDayOfWeek();

                // Assert
                Assert.AreEqual(new System.DateTime(2013, 01, 6), result);
            }

            [Test]
            public void LastDayOfWeek_DateTime_ReturnsCorrectDayOfWeek()
            {
                // Arrange
                System.DateTime date = new System.DateTime(2013, 1, 1);

                // Act
                System.DateTime result = date.LastDayOfWeek();

                // Assert
                Assert.AreEqual(DayOfWeek.Sunday, result.DayOfWeek);
            }
        }

        [TestFixture]
        public class FirstDayOfMonth
        {
            [Test]
            public void FirstDayOfMonth_DateTime_ReturnsDateTime()
            {
                // Arrange
                System.DateTime date = new System.DateTime(2013, 1, 15);

                // Act
                System.DateTime result = date.FirstDayOfMonth();

                // Assert
                Assert.AreEqual(new System.DateTime(2013, 1, 1), result);
            }

            [Test]
            public void FirstDayOfMonth_DateTime_ReturnsCorrectDayOfWeek()
            {
                // Arrange
                System.DateTime date = new System.DateTime(2013, 1, 15);

                // Act
                System.DateTime result = date.FirstDayOfMonth();

                // Assert
                Assert.AreEqual(DayOfWeek.Tuesday, result.DayOfWeek);
            }
        }

        [TestFixture]
        public class LastDayOfMonth
        {
            [Test]
            public void LastDayOfMonth_DateTime_ReturnsDateTime()
            {
                // Arrange
                System.DateTime date = new System.DateTime(2013, 1, 15);

                // Act
                System.DateTime result = date.LastDayOfMonth();

                // Assert
                Assert.AreEqual(new System.DateTime(2013, 1, 31), result);
            }

            [Test]
            public void LastDayOfMonth_DateTime_ReturnsCorrectDayOfWeek()
            {
                // Arrange
                System.DateTime date = new System.DateTime(2013, 1, 15);

                // Act
                System.DateTime result = date.LastDayOfMonth();

                // Assert
                Assert.AreEqual(DayOfWeek.Thursday, result.DayOfWeek);
            }
        }

        [TestFixture]
        public class ToIso8601
        {
            [Test]
            public void ToIso8601_DateTime_ReturnsString()
            {
                // Arrange
                System.DateTime date = new System.DateTime(2013, 1, 15, 23, 59, 01);

                // Act
                string iso8601Date = date.ToIso8601();

                // Assert
                Assert.AreEqual("2013-01-15T23:59:01+0", iso8601Date);
            }
        }

        [TestFixture]
        public class BusinessHoursSince
        {
            [Test]
            public void BusinessHoursSince_DateTime_ReturnsTimeSpan()
            {
                // Arrange
                System.DateTime date = System.DateTime.Now.AddHours(-1);

                // Act
                TimeSpan hoursSince = date.BusinessHoursSince();

                // Assert
                Assert.IsNotNull(hoursSince);
            }
        }

        [TestFixture]
        public class BusinessHoursBetween
        {
            [Test]
            public void BusinessHoursBetween_DateTimeOutOfBusinessHours_ReturnsTimeSpanZero()
            {
                // Arrange
                System.DateTime startDate = new System.DateTime(2013, 1, 1, 21, 0, 0);
                System.DateTime endDate = new System.DateTime(2013, 1, 1, 22, 0, 0);

                // Act
                TimeSpan hoursBetween = startDate.BusinessHoursBetween(endDate);

                // Assert
                Assert.AreEqual(TimeSpan.Zero, hoursBetween);
            }

            [Test]
            public void BusinessHoursBetween_StartDateTimeBeforeBusinessHours_ReturnsTimeSpan()
            {
                // Arrange
                System.DateTime startDate = new System.DateTime(2013, 1, 1, 21, 0, 0);
                System.DateTime endDate = new System.DateTime(2013, 1, 2, 09, 0, 0);

                // Act
                TimeSpan hoursBetween = startDate.BusinessHoursBetween(endDate);

                // Assert
                Assert.AreEqual(1, hoursBetween.Hours);
            }

            [Test]
            public void BusinessHoursBetween_EndDateTimeAfterBusinessHours_ReturnsTimeSpan()
            {
                // Arrange
                System.DateTime startDate = new System.DateTime(2013, 1, 1, 17, 0, 0);
                System.DateTime endDate = new System.DateTime(2013, 1, 1, 19, 0, 0);

                // Act
                TimeSpan hoursBetween = startDate.BusinessHoursBetween(endDate);

                // Assert
                Assert.AreEqual(1, hoursBetween.Hours);
            }

            [Test]
            public void BusinessHoursBetween_DateTimeInsideBusinessHours_ReturnsTimeSpan()
            {
                // Arrange
                System.DateTime startDate = new System.DateTime(2013, 1, 1, 09, 0, 0);
                System.DateTime endDate = new System.DateTime(2013, 1, 1, 17, 0, 0);

                // Act
                TimeSpan hoursBetween = startDate.BusinessHoursBetween(endDate);

                // Assert
                Assert.AreEqual(8, hoursBetween.Hours);
            }
        }
    }
}
