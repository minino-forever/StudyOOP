namespace StaticDataAndMembers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******Fun with Static Data*\n");

            SavingAccount s1 = new SavingAccount(50);

            SavingAccount s2 = new SavingAccount(100);

            Console.WriteLine($"Interest Rate is: {SavingAccount.GetInterestRate()}");

            SavingAccount.SetInterestRate(0.08);

            SavingAccount s3 = new SavingAccount(10000.75);

            Console.WriteLine($"Interest Rate is: {SavingAccount.GetInterestRate()}");

            Console.WriteLine("\n*****Fun with static Class*****\n");

            TimeUtilClass.PrintDate();

            TimeUtilClass.PrintTime();
        }
    }
}
