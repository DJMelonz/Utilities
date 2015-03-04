using NUnit.Framework;
using System;
using Utilities.Core.DateTime;

namespace Utilities.Tests.Core.DateTime
{
    [TestFixture]
    [Category("DateTime")]
    public class LastDayOfWeekTests
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

        [Test]
        public void LastDayOfWeek_DateTimeWithCustomFirstDayOfWeek_ReturnsDateTime()
        {
            // Arrange
            System.DateTime date = new System.DateTime(2013, 1, 1);
            DayOfWeek firstDayOfWeek = DayOfWeek.Sunday;

            // Act
            System.DateTime result = date.LastDayOfWeek(firstDayOfWeek);

            // Assert
            Assert.AreEqual(new System.DateTime(2013, 01, 5), result);
        }

        [Test]
        public void LastDayOfWeek_DateTimeWithCustomFirstDayOfWeek_ReturnsCorrectDayOfWeek()
        {
            // Arrange
            System.DateTime date = new System.DateTime(2013, 1, 1);
            DayOfWeek firstDayOfWeek = DayOfWeek.Sunday;

            // Act
            System.DateTime result = date.LastDayOfWeek(firstDayOfWeek);

            // Assert
            Assert.AreEqual(DayOfWeek.Saturday, result.DayOfWeek);
        }
    }
}
