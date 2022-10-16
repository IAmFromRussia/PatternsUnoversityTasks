namespace PatternTask.InfoTemplates;

public abstract class InfoType
{
    public int Length { get; }
    public int BytesSent { get; }

    protected InfoType(int length, int bytesSent)
    {
        Length = length;
        BytesSent = bytesSent;
    }
}