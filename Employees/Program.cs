namespace Employees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********The Employee Class Hierarchy*****\n");

            SalesPerson fred = new SalesPerson
            {
                Age =31, Name = "Fred", SalesNumber = 50
            };

            Manager chucky = new Manager("Chucky", 50, 92, 100000, "12-4-53-24", 9000);

            double cost = chucky.GetBenefitCost();
            
            Console.WriteLine($"\nBenefit: {cost}\n");

            chucky.GiveBonus(300);

            chucky.DisplayStatus();

            SalesPerson fran = new SalesPerson("Fran", 43, 93, 3000, "213-2131-123", 31);

            fran.GiveBonus(200);

            fran.DisplayStatus();

            Console.WriteLine("\nCasting Examples\n");

            CastingExamples();
        }


        static void CastingExamples()
        {
            object frank = new Manager("Frank Zappa", 9, 3000, 40000, "23-42-35", 5);

            Employee mooUnit = new Manager("MoonUnit Zappa", 2, 3001, 20000, "123-35-6546", 1);

            SalesPerson jill = new PtSalesPerson("Jill", 834, 3002, 100000, "12131-242-24", 90);

            GivePromotion(mooUnit);

            GivePromotion(jill);
        }

        static void GivePromotion(Employee emp)
        {
            Console.WriteLine($"{emp.Name}");
        }
    }
}
