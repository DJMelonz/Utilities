using NUnit.Framework;
using Utilities.Core.DateTime;

namespace Utilities.Tests.Core.DateTime
{
    [TestFixture]
    [Category("DateTime")]
    [Category("String")]
    public class ToIso8601Tests
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
}
