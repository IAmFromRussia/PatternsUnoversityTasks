using LoggerLibrary.Interfaces;

namespace LoggerLibrary;

public class Logger : ILogger
{
    private readonly IAppender[] _appenders;

    public Logger(params IAppender[] appenders)
        => _appenders = appenders;

	public void Error(string date, string message)
	{
		foreach (var appender in _appenders) appender.Append("ERROR:", date, message);
	}

	public void Info(string date, string message)
	{
		foreach (var appender in _appenders) appender.Append("INFO:", date, message);
	}
}