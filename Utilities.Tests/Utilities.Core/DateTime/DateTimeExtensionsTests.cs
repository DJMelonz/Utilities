using System;
using Utilities.Core.DateTime;
using NUnit.Framework;

namespace Utilities.Tests.Utilities.Core.DateTime
{
    [TestFixture]
    public class DateTimeExtensionsTests
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
