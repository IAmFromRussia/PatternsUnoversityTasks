using P01.Stream_Progress;

namespace PatternTask.StreamProcesses;

public class StreamProgressInfo : IStream
{
    private readonly IFile _file;
    private readonly int _bytesSent;

    public StreamProgressInfo(IFile file, int bytesSent)
    {
        _file = file;
        _bytesSent = bytesSent;
    }
    
    public int CalculateCurrentPercent()
    {
        return _bytesSent * 100 / _file.GetLength();
    }

    public int GetBytesSent() => _bytesSent;
}