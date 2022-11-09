namespace P03.DetailPrinter
{
    internal class Program
    {
        private static void Main()
        {
            var documents = new[] { "one", "two", "three" };
            
            var managerRt = new ManagerReport(new Manager("Danila", documents));
            var employeeRt = new EmployeeReport(new Employee("Oleg"));

            var managerPrt = new DetailsPrinter(managerRt);
            var employeePrt = new DetailsPrinter(employeeRt);
            
            managerPrt.Print();
            employeePrt.Print();

            Console.ReadKey();
        }
    }
}