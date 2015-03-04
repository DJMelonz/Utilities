using NUnit.Framework;
using System;
using Utilities.Core.DateTime;

namespace Utilities.Tests.Core.DateTime
{
    [TestFixture]
    [Category("DateTime")]
    public class LastDayOfMonthTests
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
}
