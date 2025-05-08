using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritance
{
    internal class Car
    {
        public readonly int MaxSpeed;

        private int _currSpeed;

        public Car()
        {
            MaxSpeed = 50;
        }

        public Car(int max)
        {
            MaxSpeed = max;
        }

        public int Speed
        {
            get { return _currSpeed; }
            set
            {
                _currSpeed = value;
                if (_currSpeed > MaxSpeed)
                {
                    _currSpeed = MaxSpeed;

                }
            }
        }
    }
}
