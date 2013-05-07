using System.Utilities.Core.DateTime;
using NUnit.Framework;

namespace System.Utilities.Tests.Utilities.Core.DateTime
{
    [TestFixture]
    public class DateTimeExtensionsTests
    {
        [Test]
        public void DateTime_FirstDayOfWeek_ReturnsDateTime()
        {
            // Arrange
            System.DateTime date = new System.DateTime(2013, 1, 1);

            // Act
            System.DateTime result = date.FirstDayOfWeek();

            // Assert
            Assert.AreEqual(DayOfWeek.Monday, result.DayOfWeek);
            Assert.AreEqual(new System.DateTime(2012, 12, 31), result);
        }

        [Test]
        public void DateTime_FirstDayOfMonth_ReturnsDateTime()
        {
            // Arrange
            System.DateTime date = new System.DateTime(2013, 1, 15);

            // Act
            System.DateTime result = date.FirstDayOfMonth();

            // Assert
            Assert.AreEqual(DayOfWeek.Tuesday, result.DayOfWeek);
            Assert.AreEqual(new System.DateTime(2013, 1, 1), result);
        }
    }
}
