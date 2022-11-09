namespace P03.DetailPrinter
{
    public class DetailsPrinter
    {
        private readonly IReport _report;

        public DetailsPrinter(IReport report)
        {
            _report = report;
        }

        public void Print() => _report.GetReport();
    }
}