using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("TestProject")]
namespace DrawingPackageSimulation
{
    internal abstract class Widget : IWidget
    {
        public abstract string Draw();
        public int PositionX { get; private set; }
        public int PositionY { get; private set; }

        public Widget(int positionX, int positionY)
        {
            PositionX = positionX;
            PositionY = positionY;
        }

    }
}
