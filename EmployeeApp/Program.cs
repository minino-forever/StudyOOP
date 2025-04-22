namespace EmployeeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********Fun with Encapsulation******\n");

            Employee emp = new Employee("Marvin", 456, 30000);

            emp.GiveBonus(1000);

            emp.DisplayStatus();

            emp.SetName("Marv");

            Console.WriteLine($"Employee is named: {emp.GetName()}");
        }
    }
}
