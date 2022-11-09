namespace P02.Graphic_Editor
{
    internal class Program
    {
        private static void Main()
        {
            var editorRec = new GraphicEditor(new Rectangle());
            var editorCrl = new GraphicEditor(new Circle());
            var editorSqr = new GraphicEditor(new Square());

            editorRec.DrawShape();
            editorCrl.DrawShape();
            editorSqr.DrawShape();
            
            Console.ReadKey();
        }
    }
}