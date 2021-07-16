using MarsRover.Commands;
using Moq;
using NUnit.Framework;

namespace MarsRover.Tests
{
    public class RotateRightCommandTests
    { 

        [Test]
        public void RotateRightCommandNorth()
        {
            Mock<IPosition> mockPosition = new Mock<IPosition>();
            mockPosition.Setup(x => x.X).Returns(1);
            mockPosition.Setup(x => x.Y).Returns(2);
            mockPosition.Setup(x => x.Orientation).Returns(Orientation.N);

            var rotateCommand = new RotateRightCommand();
            var newPosition = rotateCommand.Execute(mockPosition.Object);

            Assert.AreEqual(1, newPosition.X);
            Assert.AreEqual(2, newPosition.Y);
            Assert.AreEqual(Orientation.E, newPosition.Orientation);
        }

        [Test]
        public void RotateRightCommandEast()
        {
            Mock<IPosition> mockPosition = new Mock<IPosition>();
            mockPosition.Setup(x => x.X).Returns(1);
            mockPosition.Setup(x => x.Y).Returns(2);
            mockPosition.Setup(x => x.Orientation).Returns(Orientation.E);

            var rotateCommand = new RotateRightCommand();
            var newPosition = rotateCommand.Execute(mockPosition.Object);

            Assert.AreEqual(1, newPosition.X);
            Assert.AreEqual(2, newPosition.Y);
            Assert.AreEqual(Orientation.S, newPosition.Orientation);
        }

        [Test]
        public void RotateRightCommandSouth()
        {
            Mock<IPosition> mockPosition = new Mock<IPosition>();
            mockPosition.Setup(x => x.X).Returns(1);
            mockPosition.Setup(x => x.Y).Returns(2);
            mockPosition.Setup(x => x.Orientation).Returns(Orientation.S);

            var rotateCommand = new RotateRightCommand();
            var newPosition = rotateCommand.Execute(mockPosition.Object);

            Assert.AreEqual(1, newPosition.X);
            Assert.AreEqual(2, newPosition.Y);
            Assert.AreEqual(Orientation.W, newPosition.Orientation);
        }

        [Test]
        public void RotateRightCommandWest()
        {
            Mock<IPosition> mockPosition = new Mock<IPosition>();
            mockPosition.Setup(x => x.X).Returns(1);
            mockPosition.Setup(x => x.Y).Returns(2);
            mockPosition.Setup(x => x.Orientation).Returns(Orientation.W);

            var rotateCommand = new RotateRightCommand();
            var newPosition = rotateCommand.Execute(mockPosition.Object);

            Assert.AreEqual(1, newPosition.X);
            Assert.AreEqual(2, newPosition.Y);
            Assert.AreEqual(Orientation.N, newPosition.Orientation);
        }
    }
}