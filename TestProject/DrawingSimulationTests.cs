namespace DrawingPackageSimulation.Tests
{
    [TestFixture]
    public class DrawingSimulationTests
    {
        [Test]
        public void Constructor_ShouldInitializeWidgets()
        {
            var widgets = new List<IWidget>
            {
                new Rectangle(10, 10, 30, 40),
                new Square(15, 30, 35),
                new Ellipse(100, 150, 300, 200),
                new Circle(1, 1, 300),
                new Textbox(5, 5, 200, 100, "sample text")
            };

            var drawingSimulation = new DrawingSimulation(widgets);

            Assert.That(drawingSimulation, Is.Not.Null);
        }

        [Test]
        public void Draw_ShouldPrintCorrectOutput()
        {
            var widgets = new List<IWidget>
            {
                new Rectangle(10, 10, 30, 40),
                new Square(15, 30, 35),
                new Ellipse(100, 150, 300, 200),
                new Circle(1, 1, 300),
                new Textbox(5, 5, 200, 100, "sample text")
            };

            var drawingSimulation = new DrawingSimulation(widgets);

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                drawingSimulation.Draw();

                var result = sw.ToString().Trim();
                var expectedOutput = string.Join(Environment.NewLine, new[]
                {
                    "----------------------------------------------------------------",
                    "Requested Drawing",
                    "----------------------------------------------------------------",
                    "Rectangle (10,10) width=30 height=40",
                    "Square (15,30) size=35",
                    "Ellipse (100,150) diameterH = 300 diameterV = 200",
                    "Circle (1,1) size=300",
                    "Textbox (5,5) width=200 height=100 Text=\"sample text\"",
                    "----------------------------------------------------------------"
                });

                Assert.That(result, Is.EqualTo(expectedOutput));
            }
        }
    }
}
