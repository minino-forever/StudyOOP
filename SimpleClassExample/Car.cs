using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    internal class Car
    {
        public string petName;

        public int currSpeed;

        public Car()
        {
            petName = "Jigul";

            currSpeed = 10;
        }

        public Car(string pn)
        {
            petName = pn;
        }

        public Car(string pn, int cs)
        {
            petName = pn;

            currSpeed = cs;
        }

        public Car(string pn, int cs, out bool inDanger)
        {
            petName = pn;
            
            currSpeed = cs;

            if (cs > 100)
            {
                inDanger = true;
            }
            else
            {
                inDanger = false;
            }
        }

        //The method show current state Car object
        public void PrintState() => Console.WriteLine($"{petName} is going {currSpeed} MPH.");

        //The method increases speed Car object
        public void SpeedUp(int delta) => currSpeed += delta;
    }
}
