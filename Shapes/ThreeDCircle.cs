﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class ThreeDCircle : Circle
    {
        public new string PetName { get; set; }

        public new void Draw()
        {
            Console.WriteLine("Draiwing a 3D Circle!");
        }
    }
}
