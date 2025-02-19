namespace DrawingPackageSimulation.Tests
{
    [TestFixture]
    public class CircleTests
    {
        [Test]
        public void Constructor_ShouldInitializeProperties()
        {
            var circle = new Circle(1, 1, 300);

            Assert.That(circle.PositionX, Is.EqualTo(1));
            Assert.That(circle.PositionY, Is.EqualTo(1));
            Assert.That(circle.HorizontalDiameter, Is.EqualTo(300));
            Assert.That(circle.VerticalDiameter, Is.EqualTo(300));
        }

        [Test]
        public void Constructor_ShouldThrowErrorIfDiameterNegative()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(1, 1, -300));
        }

        [Test]
        public void Draw_ShouldReturnCorrectString()
        {
            var circle = new Circle(1, 1, 300);
            var result = circle.Draw();

            Assert.That(result, Is.EqualTo("Circle (1,1) size=300"));
        }
    }
}
