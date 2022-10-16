using PatternTask.InfoTemplates;

namespace P01.Stream_Progress
{
    public class Music : InfoType
    {
        private readonly string _album;
        private readonly string _artist;

        public Music(string artist, string album, int length, int bytesSent) : base( length,  bytesSent)
        {
            _artist = artist;
            _album = album;
        }
    }
}