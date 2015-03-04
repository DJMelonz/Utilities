using NUnit.Framework;
using System;
using Utilities.Core.DateTime;

namespace Utilities.Tests.Core.DateTime
{
    [TestFixture]
    [Category("DateTime")]
    [Category("TimeSpan")]
    public class BusinessHoursSinceTests
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
}
