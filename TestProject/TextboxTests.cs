namespace DrawingPackageSimulation.Tests
{
    [TestFixture]
    public class TextboxTests
    {
        [Test]
        public void Constructor_ShouldInitializeProperties()
        {
            var textbox = new Textbox(5, 5, 200, 100, "sample text");

            Assert.That(textbox.PositionX, Is.EqualTo(5));
            Assert.That(textbox.PositionY, Is.EqualTo(5));
            Assert.That(textbox.Width, Is.EqualTo(200));
            Assert.That(textbox.Height, Is.EqualTo(100));
            Assert.That(textbox.Text, Is.EqualTo("sample text"));
        }

        [Test]
        public void Draw_ShouldReturnCorrectString()
        {
            var textbox = new Textbox(5, 5, 200, 100, "sample text");
            var result = textbox.Draw();

            Assert.That(result, Is.EqualTo("Textbox (5,5) width=200 height=100 Text=\"sample text\""));
        }
    }
}
