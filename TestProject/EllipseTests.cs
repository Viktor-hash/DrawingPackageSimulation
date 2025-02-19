namespace DrawingPackageSimulation.Tests
{
    [TestFixture]
    public class EllipseTests
    {
        [Test]
        public void Constructor_ShouldInitializeProperties()
        {
            var ellipse = new Ellipse(100, 150, 300, 200);

            Assert.That(ellipse.PositionX, Is.EqualTo(100));
            Assert.That(ellipse.PositionY, Is.EqualTo(150));
            Assert.That(ellipse.HorizontalDiameter, Is.EqualTo(300));
            Assert.That(ellipse.VerticalDiameter, Is.EqualTo(200));
        }

        [Test]
        public void Constructor_ShouldThrowErrorIfDiameterHNegative()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Ellipse(1, 1, -300, 200));
        }

        [Test]
        public void Constructor_ShouldThrowErrorIfDiameterVNegative()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Ellipse(1, 1, 300, -200));
        }

        [Test]
        public void Draw_ShouldReturnCorrectString()
        {
            var ellipse = new Ellipse(100, 150, 300, 200);
            var result = ellipse.Draw();

            Assert.That(result, Is.EqualTo("Ellipse (100,150) diameterH = 300 diameterV = 200"));
        }
    }
}
