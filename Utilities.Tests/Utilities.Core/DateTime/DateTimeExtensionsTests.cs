using System.Utilities.Core.DateTime;
using NUnit.Framework;

namespace System.Utilities.Tests.Utilities.Core.DateTime
{
    [TestFixture]
    public class DateTimeExtensionsTests
    {
        [Test]
        public void Date_FirstDayOfWeek_ReturnsDateTime()
        {
            // Arrange
            System.DateTime date = new System.DateTime(2013, 1, 1);

            // Act
            System.DateTime result = date.FirstDayOfWeek();

            // Assert
            Assert.AreEqual(DayOfWeek.Monday, result.DayOfWeek);
            Assert.AreEqual(new System.DateTime(2012, 12, 31), result);
        }
    }
}
