using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoProps
{
    internal class Car
    {
        public string PetName { get; set; }

        public int Speed { get; set; }

        public string Color { get; set; }

        public void DisplayStatus()
        {
            Console.WriteLine($"Car Name: {PetName}");

            Console.WriteLine($"Car Speed: {Speed}");

            Console.WriteLine($"Car Color: {Color}");
        }
    }
}
