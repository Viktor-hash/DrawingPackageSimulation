using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("TestProject")]
namespace DrawingPackageSimulation
{
        internal class Rectangle : Widget
    {
        public int Width { get; private set; }
        public int Height { get; private set; }
        public Rectangle(int positionX, int positionY, int width, int height):base(positionX, positionY)
        {
            if (width < 0) throw new ArgumentOutOfRangeException(nameof(width), "Width cannot be negative");
            if (height < 0) throw new ArgumentOutOfRangeException(nameof(height), "Height cannot be negative");

            Width = width;
            Height = height;
        }
        public override string Draw()
        {
            return $"Rectangle ({PositionX},{PositionY}) width={Width} height={Height}";
        }
    }
}
