namespace P03.DetailPrinter;

public class ManagerReport : EmployeeReport, IReport
{
    private readonly Manager _manager;
    
    public ManagerReport(Manager manager) : base(manager)
    {
        _manager = manager;
    }
    
    public new void GetReport()
    {
        Console.WriteLine(_manager.Name);
        Console.WriteLine(string.Join(Environment.NewLine, _manager.Documents));
    }

}