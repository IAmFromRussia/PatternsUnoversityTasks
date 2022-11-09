namespace LoggerLibrary.Interfaces;

public interface IAppender
{
    void Append(params string[] messages);
}