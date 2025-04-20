namespace SimpleClassExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Fun with Class Types*****\n");

            Car myCar = new Car();

            Car jigul = new Car();

            Car uaz = new Car("UAZ");

            Car niva = new Car("Niva", 75);

            Motorcycle mc = new Motorcycle();

            mc.PopAWheely();

            uaz.PrintState();

            niva.PrintState();

            Console.Write("\nMy super car ");

            jigul.PrintState();

            Console.WriteLine(Environment.NewLine);

            myCar.petName = "SuperCar";

            myCar.PrintState();

            myCar.currSpeed = 10;

            for (int i = 0; i <= 10; i++)
            {
                myCar.SpeedUp(5);

                myCar.PrintState();
            }
        }
    }
}
