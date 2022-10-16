using P01.Stream_Progress;
using PatternTask.InfoTemplates;

namespace PatternTask.StreamProcesses;

public class StreamProgressInfo : ICurrentPercent
{
    private readonly InfoType _type;

    public StreamProgressInfo(InfoType type)
    {
        _type = type;
    }
    
    public int CalculateCurrentPercent()
    {
        return _type.BytesSent * 100 / _type.Length;
    }
}