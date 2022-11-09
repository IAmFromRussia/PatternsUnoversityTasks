namespace P03.DetailPrinter;

public class EmployeeReport : IReport
{
    private readonly Employee _employee;

    public EmployeeReport(Employee employee)
    {
        _employee = employee;
    }

    public void GetReport() => Console.WriteLine(_employee.Name);
}