using NUnit.Framework;

namespace MarsRover.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_Position_Initialization()
        {
            Position p = new Position(0, 0, Orientation.N);
            Assert.AreEqual(0, p.X);
            Assert.AreEqual(0, p.Y);
            Assert.AreEqual(Orientation.N, p.Orientation);
        }

        [Test]
        public void Test_Position_MoveForwardNorth()
        {
            Position p = new Position(0, 0, Orientation.N);
            
            p.MoveForward();
            Assert.AreEqual(0, p.X);
            Assert.AreEqual(1, p.Y);
            Assert.AreEqual(Orientation.N, p.Orientation);
            
            p.MoveForward();
            Assert.AreEqual(0, p.X);
            Assert.AreEqual(2, p.Y);
            Assert.AreEqual(Orientation.N, p.Orientation);
        }

        [Test]
        public void Test_Position_MoveForwardEast()
        {
            Position p = new Position(0, 0, Orientation.E);

            p.MoveForward();
            Assert.AreEqual(1, p.X);
            Assert.AreEqual(0, p.Y);
            Assert.AreEqual(Orientation.E, p.Orientation);

            p.MoveForward();
            Assert.AreEqual(2, p.X);
            Assert.AreEqual(0, p.Y);
            Assert.AreEqual(Orientation.E, p.Orientation);
        }

        [Test]
        public void Test_Position_MoveForwardSouth()
        {
            Position p = new Position(0, 0, Orientation.S);

            p.MoveForward();
            Assert.AreEqual(0, p.X);
            Assert.AreEqual(-1, p.Y);
            Assert.AreEqual(Orientation.S, p.Orientation);

            p.MoveForward();
            Assert.AreEqual(0, p.X);
            Assert.AreEqual(-2, p.Y);
            Assert.AreEqual(Orientation.S, p.Orientation);
        }

        [Test]
        public void Test_Position_MoveForwardWest()
        {
            Position p = new Position(0, 0, Orientation.W);

            p.MoveForward();
            Assert.AreEqual(-1, p.X);
            Assert.AreEqual(0, p.Y);
            Assert.AreEqual(Orientation.W, p.Orientation);

            p.MoveForward();
            Assert.AreEqual(-2, p.X);
            Assert.AreEqual(0, p.Y);
            Assert.AreEqual(Orientation.W, p.Orientation);
        }
    }
}