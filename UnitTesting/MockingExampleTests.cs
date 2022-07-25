using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTesting
{
    public class MockingExampleTests
    {
        [Fact]
        public void MockingExample_TestMeMethodWithMockedData_ReturnsContent()
        {
            // Arrange
            var mock = new Mock<IFileWriter>();
            var mockingExample = new MockingExample(mock.Object);

            // Act
            var content = mockingExample.TestMeMethod("test");

            // Assert
            Assert.Equal("test", content);
        }
    }
}
