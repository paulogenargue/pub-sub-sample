using Moq;
using NUnit.Framework;
using SampleApp.NameFormatting.Model;
using SampleApp.NameFormatting.Output;

namespace SampleApp.UnitTests.NameFormatting.Output
{
    [TestFixture]
    public class LastNameFirstOutputTests
    {
        [TestCase("John", "Smith", "Smith, John")]
        [TestCase("John", "", "John")]
        [TestCase("John", null, "John")]
        [TestCase("", "Smith", "Smith")]
        [TestCase(null, "Smith", "Smith")]
        [TestCase("", "", "")]
        [TestCase(null, null, "")]
        public void Write_FirstNameLastNameCombinations(string first, string last, string expectedOutput)
        {
            // Arrange
            var mockStrOut = new Mock<IOutput<string>>();
            var output = new LastNameFirstOutput(mockStrOut.Object);
            var name = new Name
            {
                First = first,
                Last = last
            };

            // Act
            output.Write(name);

            // Assert
            mockStrOut.Verify(o => o.Write(It.Is<string>(output => output == expectedOutput)));
        }
    }
}