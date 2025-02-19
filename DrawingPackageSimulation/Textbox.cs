using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("TestProject")]
namespace DrawingPackageSimulation
{
    internal sealed class Textbox : Rectangle
    {
        public string Text { get; private set; }

        public Textbox(int positionX, int positionY, int width, int height, string text) : base(positionX, positionY, width, height)
        {
            if (text == null) throw new ArgumentNullException(nameof(text),"Text cannot be null");
            Text = text;
        }

        public override string Draw()
        {
            return $"Textbox ({PositionX},{PositionY}) width={Width} height={Height} Text=\"{Text}\"";
        }
    }
}
