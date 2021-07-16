using MarsRover.Commands;
using Moq;
using NUnit.Framework;

namespace MarsRover.Tests
{
    public class CommandFactoryTests
    {
      
        [Test]
        public void TestTryGetMoveForwardCommand()
        {
            Assert.IsTrue(CommandFactory.TryGetCommand('A', out IMoveCommand moveCommand));
            Assert.IsInstanceOf<MoveForwardCommand>(moveCommand);
        }

        [Test]
        public void TestTryGetRotateLeftCommand()
        {
            Assert.IsTrue(CommandFactory.TryGetCommand('L', out IMoveCommand moveCommand));
            Assert.IsInstanceOf<RotateLeftCommand>(moveCommand);
        }
        [Test]
        public void TestTryGetRotateRightCommand()
        {
            Assert.IsTrue(CommandFactory.TryGetCommand('R', out IMoveCommand moveCommand));
            Assert.IsInstanceOf<RotateRightCommand>(moveCommand);
        }

        [Test]
        public void TestTryGetInvalidCommand()
        {
            Assert.IsFalse(CommandFactory.TryGetCommand('Z', out IMoveCommand moveCommand));
            Assert.IsNull(moveCommand);
        }
    }
}