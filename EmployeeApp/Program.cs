namespace EmployeeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********Fun with Encapsulation******\n");

            Employee emp = new Employee("Marvin", 45, 123, 1000, "111-222-4344", EmployeePayTypeEnum.Salaried);

            emp.GiveBonus(1000);

            emp.DisplayStatus();

            emp.Name = "Marv";

            Console.WriteLine($"Employee is named: {emp.Name}");

            Employee joe = new Employee();

            joe.Age++;

            Console.WriteLine($"Age Joi: {joe.Age}");
        }
    }
}
