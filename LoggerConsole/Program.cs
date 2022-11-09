// See https://aka.ms/new-console-template for more information

using LoggerLibrary;
using LoggerLibrary.Interfaces;

ILayout isimpleLayout = new SimpleLayout();
IAppender iconsoleAppender = new ConsoleAppender(isimpleLayout);
ILogger ilogger = new Logger(iconsoleAppender); 


ilogger.Error("3/26/2022 2:08:11 PM", "Error parsing JSON.");
ilogger.Info("3/26/2022 2:08:11 PM", "User Ivan successfully registered.");

Console.WriteLine("Press any key for next step...");
Console.ReadKey();

var simpleLayout = new SimpleLayout();

var consoleAppender = new ConsoleAppender(simpleLayout);


var file = new LogFile();

var fileAppender = new FileAppender(simpleLayout, file);


var logger = new Logger(fileAppender, consoleAppender);

logger.Error("3/26/2022 2:08:11 PM", "Error parsing JSON.");

logger.Info("3/26/2022 2:08:11 PM", "User Ivan successfully registered.");

Console.WriteLine("Press any key for exit...");
Console.ReadKey();