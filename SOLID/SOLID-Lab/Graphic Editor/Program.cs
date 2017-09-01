using System;

namespace _02.Graphic_Editor
{
    public class Program
    {
        public static void Main()
        {
            var graphicEditor = new GraphicEditor();

            IShape circle = new Circle();
            IShape rectangle = new Rectangle();
            IShape square = new Square();

            graphicEditor.DrawShape(circle);
            graphicEditor.DrawShape(rectangle);
            graphicEditor.DrawShape(square);
        }
    }
}
