using PatternTask.StreamProcesses;

namespace P01.Stream_Progress
{
    public class Program
    {
        private static void Main()
        {
            var file = new File("unnamed", 1024, 3000);
            var music = new Music("Michael Jackson", "Billie Jean", 2048, 6023);

            var processFile = new StreamProgressInfo(file);
            var processMusic = new StreamProgressInfo(music);

            Console.WriteLine($"File - {processFile.CalculateCurrentPercent()}");
            Console.WriteLine($"File - {processMusic.CalculateCurrentPercent()}");
        }
    }
}