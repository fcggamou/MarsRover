using MarsRover.Commands;
using Moq;
using NUnit.Framework;

namespace MarsRover.Tests
{
    public class MoveForwardCommandTests
    {
 
        [Test]
        public void TestMoveForwardCommandNorth()
        {
            Mock<IPosition> mockPosition = new Mock<IPosition>();
            mockPosition.Setup(x => x.X).Returns(1);
            mockPosition.Setup(x => x.Y).Returns(2);
            mockPosition.Setup(x => x.Orientation).Returns(Orientation.N);

            var moveCommand = new MoveForwardCommand();
            var newPosition = moveCommand.Execute(mockPosition.Object);

            Assert.AreEqual(1, newPosition.X);
            Assert.AreEqual(3, newPosition.Y);
            Assert.AreEqual(Orientation.N, newPosition.Orientation);
        }

        [Test]
        public void TestMoveForwardCommandEast()
        {
            Mock<IPosition> mockPosition = new Mock<IPosition>();
            mockPosition.Setup(x => x.X).Returns(1);
            mockPosition.Setup(x => x.Y).Returns(2);
            mockPosition.Setup(x => x.Orientation).Returns(Orientation.E);

            var moveCommand = new MoveForwardCommand();
            var newPosition = moveCommand.Execute(mockPosition.Object);

            Assert.AreEqual(2, newPosition.X);
            Assert.AreEqual(2, newPosition.Y);
            Assert.AreEqual(Orientation.E, newPosition.Orientation);
        }

        [Test]
        public void TestMoveForwardCommandWest()
        {
            Mock<IPosition> mockPosition = new Mock<IPosition>();
            mockPosition.Setup(x => x.X).Returns(1);
            mockPosition.Setup(x => x.Y).Returns(2);
            mockPosition.Setup(x => x.Orientation).Returns(Orientation.W);

            var moveCommand = new MoveForwardCommand();
            var newPosition = moveCommand.Execute(mockPosition.Object);

            Assert.AreEqual(0, newPosition.X);
            Assert.AreEqual(2, newPosition.Y);
            Assert.AreEqual(Orientation.W, newPosition.Orientation);
        }

        [Test]
        public void TestMoveForwardCommandSouth()
        {
            Mock<IPosition> mockPosition = new Mock<IPosition>();
            mockPosition.Setup(x => x.X).Returns(1);
            mockPosition.Setup(x => x.Y).Returns(2);
            mockPosition.Setup(x => x.Orientation).Returns(Orientation.S);

            var moveCommand = new MoveForwardCommand();
            var newPosition = moveCommand.Execute(mockPosition.Object);

            Assert.AreEqual(1, newPosition.X);
            Assert.AreEqual(1, newPosition.Y);
            Assert.AreEqual(Orientation.S, newPosition.Orientation);
        }
    }
}