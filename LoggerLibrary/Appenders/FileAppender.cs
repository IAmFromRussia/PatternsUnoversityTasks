using LoggerLibrary.Interfaces;

namespace LoggerLibrary;

public class FileAppender : IAppender
{
    private readonly ILayout _layout;
    private readonly LogFile _file;

	public FileAppender(ILayout layout, LogFile file)
	{
		_layout = layout;
		_file = file;
	}

	public void Append(params string[] messages)
	{
		using StreamWriter file = new(_file.Path + _file.Name, append: true);
		file.WriteLineAsync(_layout.SetLayout(messages));
	}
}