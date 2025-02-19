namespace DrawingPackageSimulation.Tests
{
    [TestFixture]
    public class RectangleTests
    {
        [Test]
        public void Constructor_ShouldInitializeProperties()
        {
            var rectangle = new Rectangle(10, 20, 30, 40);

            Assert.That(rectangle.PositionX, Is.EqualTo(10));
            Assert.That(rectangle.PositionY, Is.EqualTo(20));
            Assert.That(rectangle.Width, Is.EqualTo(30));
            Assert.That(rectangle.Height, Is.EqualTo(40));
        }

        [Test]
        public void Draw_ShouldReturnCorrectString()
        {
            var rectangle = new Rectangle(10, 20, 30, 40);
            var result = rectangle.Draw();

            Assert.That(result, Is.EqualTo("Rectangle (10,20) width=30 height=40"));
        }
    }
}
