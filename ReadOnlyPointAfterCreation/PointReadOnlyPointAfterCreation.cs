using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnlyPointAfterCreation
{
    internal class PointReadOnlyPointAfterCreation
    {
        public int X { get; init; }

        public int Y { get; init; }

        public void DisplayStats()
        {
            Console.WriteLine($"InitOnlySetter: [{X}, {Y}]");
        }

        public PointReadOnlyPointAfterCreation() { }

        public PointReadOnlyPointAfterCreation(int xVal, int yVal)
        {
            X = xVal;

            Y = yVal;
        }
    }
}
