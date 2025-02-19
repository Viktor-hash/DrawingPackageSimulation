using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("TestProject")]
namespace DrawingPackageSimulation
{
    internal class Ellipse : Widget
    {
        public int HorizontalDiameter { get; private set; }
        public int VerticalDiameter { get; private set; }
        public Ellipse(int positionX, int positionY, int horizontalDiameter, int verticalDiameter) : base(positionX,positionY)
        {
            if (horizontalDiameter < 0) throw new ArgumentOutOfRangeException(nameof(horizontalDiameter), "Horizontal diameter cannot be negative");
            if (verticalDiameter < 0) throw new ArgumentOutOfRangeException(nameof(verticalDiameter), "Vertical diameter cannot be negative");

            HorizontalDiameter = horizontalDiameter;
            VerticalDiameter = verticalDiameter;
        }
        public override string Draw()
        {
            return $"Ellipse ({PositionX},{PositionY}) diameterH = {HorizontalDiameter} diameterV = {VerticalDiameter}";
        }
    }
}
