using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDelegat
{
    internal class Car
    {
        public string Make { get; set; }

        public string Model { get; set; }

        Wheels wheels = new Wheels();

        public void GetWheel() => wheels.ComleteWheels();
    }
}
