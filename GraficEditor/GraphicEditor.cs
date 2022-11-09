using System;

namespace P02.Graphic_Editor
{
    public class GraphicEditor
    {
        private readonly IShape _shape;
        public GraphicEditor(IShape shape) 
            => _shape = shape;
        public void DrawShape() 
            => _shape.DrawShape();
    }
}