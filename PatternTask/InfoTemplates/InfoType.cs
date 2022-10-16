namespace PatternTask.InfoTemplates;

public abstract class InfoType
{
    public int Length { get; set; }
    public int BytesSent { get; set; }

    public InfoType(int length, int bytesSent)
    {
        Length = length;
        BytesSent = bytesSent;
    }
}