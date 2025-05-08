namespace RecordInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****Record type inheritance!!****\n");

            Car c = new Car("Honda", "Pilot", "Redd");

            MiniVan m = new MiniVan("Honda", "Pilot", "Redd", 10);

            Console.WriteLine($"Cheking MiniVan is-a Car: {m is Car}");
        }
    }
}
