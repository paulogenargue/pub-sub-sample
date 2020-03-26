using System.Collections;
using System.Collections.Generic;
using Moq;
using NUnit.Framework;
using SampleApp.NameFormatting.Input;
using SampleApp.NameFormatting.Output;

namespace SampleApp.UnitTests.NameFormatting.Input
{
    [TestFixture]
    public class NameInputTests
    {
        [TestCase("John", "Smith")]
        [TestCase("John", "")]
        [TestCase("John", null)]
        [TestCase("", "Smith")]
        [TestCase(null, "Smith")]
        public void Read_AtLeastFirstNameOrLastNameIsAvailable_ReturnName(string first, string last)
        {
            // Arrange
            var strInput = new Mock<IInput<string>>();
            var strOutput = new Mock<IOutput<string>>();
            var input = new NameInput(strInput.Object, strOutput.Object);

            // Simulate the order of read
            Queue<string> queue = new Queue<string>();
            queue.Enqueue(first);
            queue.Enqueue(last);

            strInput
                .Setup(i => i.Read())
                .Returns(() => queue.Dequeue());

            // Act
            var name = input.Read();

            // Assert
            Assert.IsNotNull(name);
            Assert.AreEqual(first, name.First);
            Assert.AreEqual(last, name.Last);
        }

        [TestCase("", "")]
        [TestCase(null, null)]
        public void Read_BothFirstNameAndLastNameAreNotAvailable_ReturnNull(string first, string last)
        {
            // Arrange
            var strInput = new Mock<IInput<string>>();
            var strOutput = new Mock<IOutput<string>>();
            var input = new NameInput(strInput.Object, strOutput.Object);

            // Simulate the order of read
            Queue<string> queue = new Queue<string>();
            queue.Enqueue(first);
            queue.Enqueue(last);

            strInput
                .Setup(i => i.Read())
                .Returns(() => queue.Dequeue());

            // Act
            var name = input.Read();

            // Assert
            Assert.IsNull(name);
        }

    }
}