namespace LoggerLibrary.Interfaces;

public interface ILogger
{
    void Error(string date, string message);
    void Info(string date, string message);
}