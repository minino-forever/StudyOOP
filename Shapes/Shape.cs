﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    abstract internal class Shape
    {
        public string PetName { get; set; }

        protected Shape(string name = "NoName") => PetName = name; 

        public abstract void Draw();
    }
}
