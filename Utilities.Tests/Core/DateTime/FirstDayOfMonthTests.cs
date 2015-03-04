using NUnit.Framework;
using System;
using Utilities.Core.DateTime;

namespace Utilities.Tests.Core.DateTime
{
    [TestFixture]
    [Category("DateTime")]
    public class FirstDayOfMonthTests
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
}
