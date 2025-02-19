using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("TestProject")]
namespace DrawingPackageSimulation
{
    internal class DrawingSimulation
    {
        private readonly List<IWidget> _widgets;
        public DrawingSimulation(params List<IWidget> widgets)
        {
            if (widgets == null)
            {
                throw new ArgumentNullException(nameof(widgets), "The widgets parameter cannot be null");
            }

            _widgets = widgets;
        }

        public void Draw()
        {
            WriteSeparator();
            Console.WriteLine("Requested Drawing");
            WriteSeparator();

            foreach (var widget in _widgets)
            {
                Console.WriteLine(widget.Draw());
            }

            WriteSeparator();
        }

        private void WriteSeparator()
        {
            Console.WriteLine("----------------------------------------------------------------");
        }
    }
}
