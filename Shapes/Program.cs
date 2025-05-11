namespace Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******Fun with Polymorphism*****\n");

            Hexagon hex = new Hexagon("Beth");

            hex.Draw();

            Circle cir = new Circle("Cindy");

            cir.Draw();

            Console.WriteLine("\nArrays is Shape\n");

            Shape[] myShapes = {new Hexagon(), new Circle(), new Hexagon("Mick"),
            new Circle("Beth"), new Hexagon("Linda")};

            foreach (Shape shape in myShapes)
            {
                shape.Draw();
            }

            Console.WriteLine("\nThree 3D!\n");

            ThreeDCircle threeD = new ThreeDCircle();

            threeD.Draw();

            ((Circle)threeD).Draw();
        }
    }
}
