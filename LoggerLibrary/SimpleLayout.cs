using System.Text;
using LoggerLibrary.Interfaces;

namespace LoggerLibrary;

public class SimpleLayout : ILayout
{
	public string SetLayout(params string[] messages)
	{
		var builder = new StringBuilder();
		var last = messages.Last();

		foreach (var message in messages)
		{
			builder.Append(message + "\n");

			if (Equals(last, message))
				builder.Append('\n');
		}

		return builder.ToString();
	}
}