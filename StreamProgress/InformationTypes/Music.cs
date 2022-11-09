using PatternTask.InfoTemplates;

namespace P01.Stream_Progress
{
    public class Music : IFile
    {
        private readonly string _album;
        private readonly string _artist;
        private readonly int _length;

        public Music(string artist, string album, int length)
        {
            _artist = artist;
            _album = album;
            _length = length;
        }

        public int GetLength() => _length;
    }
}