using NUnit.Framework;
using System;
using Utilities.Core.DateTime;

namespace Utilities.Tests.Core.DateTime
{
    [TestFixture]
    [Category("DateTime")]
    [Category("TimeSpan")]
    public class BusinessHoursBetweenTests
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
