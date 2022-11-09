namespace P01.Stream_Progress
{
    public class File : IFile
    {
        private readonly string _name;
        private readonly int _length;

        public File(string name, int length)
        {
            _name = name;
            _length = length;
        }

        public int GetLength() => _length;
    }
}