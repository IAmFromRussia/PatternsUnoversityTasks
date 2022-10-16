using PatternTask.InfoTemplates;

namespace P01.Stream_Progress
{
    public class File : InfoType
    {
        private readonly string _name;

        public File(string name, int length, int bytesSent) : base(length ,bytesSent)
        {
            _name = name;
        }
    }
}