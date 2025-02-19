using DrawingPackageSimulation;

try
{
    List<IWidget> widgets = new List<IWidget>
        {
            new Rectangle(10, 10, 30, 40),
            new Square(15, 30, 35),
            new Ellipse(100, 150, 300, 200),
            new Circle(1, 1, 300),
            new Textbox(5, 5, 200, 100, "sample text")
        };

    var drawingSimulation = new DrawingSimulation(widgets);
    drawingSimulation.Draw();
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}