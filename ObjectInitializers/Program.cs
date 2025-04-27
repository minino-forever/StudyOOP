namespace ObjectInitializers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Fun with object Init Syntax*****\n");

            Console.WriteLine("Syntax std:");

            Point firstPoint = new Point();

            firstPoint.X = 10;

            firstPoint.Y = 10;

            firstPoint.DisplayStats();

            Console.WriteLine("\nSyntax ctor:");

            Point secondPoint = new Point(21, 23);

            secondPoint.DisplayStats();

            Console.WriteLine("\nSyntax init object:");

            Point threePoint = new Point { X = 111, Y = 222 };

            threePoint.DisplayStats();

            Console.WriteLine("\nPoint is gold:");

            Point goldPoint = new Point(PointColorEnum.Gold) { X = 90, Y = 23 };

            goldPoint.DisplayStats();

            Console.WriteLine("\nCreated and initilization object Rectangle:");

            Rectangle myRect = new Rectangle
            {
                Number = 1,
                TopLeft = new Point { X = 10, Y = 10 },
                BottomRight = new Point { X = 222, Y = 333 }
            };

            myRect.DisplayStats();

            Console.WriteLine("\nCreated and initilization object Rectangle and Point:");

            Rectangle myRect2 = new Rectangle();

            Point point = new Point();

            point.X = 22222;

            point.Y = 33333;

            myRect2.TopLeft = point;

            Point point2 = new Point();

            point2.X = 1;

            point2.Y = 2;

            myRect2.BottomRight = point2;

            myRect2.DisplayStats();
        }
    }
}
