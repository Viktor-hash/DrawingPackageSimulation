
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("TestProject")]
namespace DrawingPackageSimulation
{
    internal sealed class Circle : Ellipse
    {
        public Circle(int positionX, int positionY, int diameter) : base(positionX, positionY, diameter, diameter)
        {
            if (diameter < 0) throw new ArgumentOutOfRangeException(nameof(diameter), "Diameter cannot be negative");
        }
        public override string Draw()
        {
            return $"Circle ({PositionX},{PositionY}) size={HorizontalDiameter}";
        }
    }
}
