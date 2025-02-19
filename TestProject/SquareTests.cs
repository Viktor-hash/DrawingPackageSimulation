namespace DrawingPackageSimulation.Tests
{
    [TestFixture]
    public class SquareTests
    {
        [Test]
        public void Constructor_ShouldInitializeProperties()
        {
            var square = new Square(15, 25, 35);

            Assert.That(square.PositionX, Is.EqualTo(15));
            Assert.That(square.PositionY, Is.EqualTo(25));
            Assert.That(square.Width, Is.EqualTo(35));
            Assert.That(square.Height, Is.EqualTo(35));
        }

        [Test]
        public void Constructor_ShouldThrowErrorIfSizeNegative()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Square(15, 25, -35));
        }

        [Test]
        public void Draw_ShouldReturnCorrectString()
        {
            var square = new Square(15, 25, 35);
            var result = square.Draw();

            Assert.That(result, Is.EqualTo("Square (15,25) size=35"));
        }
    }
}
