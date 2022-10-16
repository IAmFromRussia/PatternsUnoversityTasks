namespace P01.Stream_Progress
{
    public class Music
    {
        private string album;
        private string artist;

        public Music(string artist, string album, int length, int bytesSent)
        {
            this.artist = artist;
            this.album = album;
            Length = length;
            BytesSent = bytesSent;
        }

        public int Length { get; set; }

        public int BytesSent { get; set; }
    }
}