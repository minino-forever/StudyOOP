using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    internal class Employee
    {
        private string _empName;

        private int _empId;

        private float _currPay;

        public string GetName() => _empName;

        public void SetName(string name)
        {
            if (name.Length > 15)
            {
                Console.WriteLine($"Error! Name lemgth exceeds 15 characters!");
            }
            else
            {
                _empName = name;
            }
        }

        public Employee(){}

        public Employee(string name, int id, float pay)
        {
            _empName = name;

            _empId = id;

            _currPay = pay;
        }

        public void GiveBonus(float amount) => _currPay += amount;

        public void DisplayStatus()
        {
            Console.WriteLine($"Nmae: {_empName}");

            Console.WriteLine($"ID: {_empId}");

            Console.WriteLine($"Pay: {_currPay}");
        }
    }
}
