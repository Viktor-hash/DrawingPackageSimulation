using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("TestProject")]
namespace DrawingPackageSimulation
{
    internal sealed class Square : Rectangle
    {
        public Square(int positionX, int positionY, int size) : base(positionX, positionY, size, size)
        {
            if (size < 0) throw new ArgumentOutOfRangeException(nameof(size), "Size cannot be negative");
        }
        public override string Draw()
        {
            return $"Square ({PositionX},{PositionY}) size={Width}";
        }
    }
}
