namespace ReadOnlyPointAfterCreation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PointReadOnlyPointAfterCreation firstReadOnlyPoint = new PointReadOnlyPointAfterCreation(20, 20);

            firstReadOnlyPoint.DisplayStats();

            Console.WriteLine(Environment.NewLine);

            PointReadOnlyPointAfterCreation secondReadOnlyPoint = new PointReadOnlyPointAfterCreation { X = 11, Y = 22 };

            secondReadOnlyPoint.DisplayStats();
        }
    }
}
