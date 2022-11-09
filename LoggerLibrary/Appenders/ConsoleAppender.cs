using LoggerLibrary.Interfaces;

namespace LoggerLibrary;

public class ConsoleAppender : IAppender
{
    private readonly ILayout _layout;

    public ConsoleAppender(ILayout layout)
        => _layout = layout;

	public void Append(params string[] messages)
		=> Console.Write(_layout.SetLayout(messages));
}