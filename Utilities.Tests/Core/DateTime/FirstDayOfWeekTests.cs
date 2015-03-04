using NUnit.Framework;
using System;
using Utilities.Core.DateTime;

namespace Utilities.Tests.Core.DateTime
{
    [TestFixture]
    [Category("DateTime")]
    public class FirstDayOfWeekTests
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
        public void FirstDayOfWeek_DateTimeWithCustomFirstDayOfWeek_ReturnsDateTime()
        {
            // Arrange
            System.DateTime date = new System.DateTime(2013, 1, 1);
            DayOfWeek firstDayOfWeek = DayOfWeek.Sunday;

            // Act
            System.DateTime result = date.FirstDayOfWeek(firstDayOfWeek);

            // Assert
            Assert.AreEqual(new System.DateTime(2012, 12, 30), result);
        }

        [Test]
        public void FirstDayOfWeek_DateTimeWithCustomFirstDayOfWeek_ReturnsCorrectDayOfWeek()
        {
            // Arrange
            System.DateTime date = new System.DateTime(2013, 1, 1);
            DayOfWeek firstDayOfWeek = DayOfWeek.Sunday;

            // Act
            System.DateTime result = date.FirstDayOfWeek(firstDayOfWeek);

            // Assert
            Assert.AreEqual(DayOfWeek.Sunday, result.DayOfWeek);
        }
    }
}
