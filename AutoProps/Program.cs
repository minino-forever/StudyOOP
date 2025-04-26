namespace AutoProps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******Fun with auto properties****\n");

            Car c = new Car();

            c.PetName = "Frank";

            c.Speed = 55;

            c.Color = "Red";

            Console.WriteLine($"Your car is named {c.PetName}? That's odd..");

            c.DisplayStatus();

            Garage g = new Garage();

            g.MyAuto = c;

            Console.WriteLine($"Number of Cars in garage: {g.NumberOfCars}");

            Console.WriteLine($"Your car is named: {g.MyAuto.PetName}");
        }
    }
}
