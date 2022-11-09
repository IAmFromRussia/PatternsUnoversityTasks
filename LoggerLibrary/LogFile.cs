namespace LoggerLibrary;

public class LogFile
{
    private readonly string _path;
    private readonly string _name;

    public LogFile()
    {
        _path = "C:/TestFolder/";
        _name = "LogFile";
    }

    public LogFile(string name, string path)
    {
        _path = path;
        _name = name;
    }
	
	public string Name => _name;
	public string Path => _path;
}