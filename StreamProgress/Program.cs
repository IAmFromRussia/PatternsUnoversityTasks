using PatternTask.StreamProcesses;

namespace P01.Stream_Progress
{
    public class Program
    {
        private static void Main()
        {
            var file = new File("unnamed", 1024);
            var music = new Music("Michael Jackson", "Billie Jean", 2048);

            var processFile = new StreamProgressInfo(file, 3000);
            var processMusic = new StreamProgressInfo(music, 6543);

            Console.WriteLine($"File - {processFile.CalculateCurrentPercent()}");
            Console.WriteLine($"File - {processMusic.CalculateCurrentPercent()}");
        }
    }
}