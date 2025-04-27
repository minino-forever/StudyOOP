namespace FunWithRecords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Fun with Records/*****\n");

            Console.WriteLine("Create object with init objects:");
            Car myCar = new Car
            {
                Make = "Honda",
                Model = "Odisey",
                Color = "Red"
            };

            Console.WriteLine("My car: ");

            DisplayCarStats(myCar);

            Console.WriteLine("\nCreate object with special ctor:");

            Car anotherMyCar = new Car("Toyta", "OPA", "Blue");

            Console.WriteLine("Another my car:");

            DisplayCarStats(anotherMyCar);

            Console.WriteLine(anotherMyCar.ToString());

            Console.WriteLine("\n*****RECORDS*****\n");

            Console.WriteLine("Create object of record with init object:");

            CarRecord myCarRrecord = new CarRecord
            {
                Make = "VAZ",
                Model = "2107",
                Color = "yellow"
            };

            Console.WriteLine("My car:");

            DisplayCarREcordStats(myCarRrecord);

            Console.WriteLine("\nCreate object of record with special ctor:");

            CarRecord anotherRecordMyCar = new CarRecord("VAZ", "2107", "yellow");

            Console.WriteLine("Another record my car:");

            DisplayCarREcordStats(anotherRecordMyCar);

            Console.WriteLine(anotherRecordMyCar.ToString());

            Console.WriteLine("\nEqual type class and type record:\n");

            Console.WriteLine($"Cars are the same reference? {ReferenceEquals(myCar, anotherMyCar)}");

            Console.WriteLine($"CarRecords are the same reference? {ReferenceEquals(myCarRrecord, anotherRecordMyCar)}");

            Console.WriteLine($"CarRecord are the same? {myCarRrecord.Equals(anotherRecordMyCar)}");

            Console.WriteLine("\nCopy reference:\n");

            CarRecord carRecordCopy = anotherRecordMyCar;

            Console.WriteLine($"Car record are the same? {carRecordCopy.Equals(anotherRecordMyCar)}");

            Console.WriteLine($"Car record are the reference same? {ReferenceEquals(carRecordCopy, anotherRecordMyCar)}");

            Console.WriteLine("\nCar with 'with':\n");

            CarRecord ourOtherCar = myCarRrecord with { Model = "2105" };

            Console.WriteLine("My copied car:");

            Console.WriteLine(ourOtherCar.ToString());

            Console.WriteLine($"CarRecords are the same? {ourOtherCar.Equals(myCarRrecord)}");

            Console.WriteLine($"CarRecords reference are the same? {ReferenceEquals(ourOtherCar, myCarRrecord)}");
        }

        static void DisplayCarStats(Car car)
        {
            Console.WriteLine($"Car Make: {car.Make}");

            Console.WriteLine($"Car Model: {car.Model}");

            Console.WriteLine($"Car Color: {car.Color}");
        }

        static void DisplayCarREcordStats(CarRecord car)
        {
            Console.WriteLine($"Car Make: {car.Make}");

            Console.WriteLine($"Car Model: {car.Model}");

            Console.WriteLine($"Car Color: {car.Color}");
        }
    }
}
