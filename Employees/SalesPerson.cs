using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    internal class SalesPerson : Employee
    {
        //number of sales
        public int SalesNumber { get; set; }

        public SalesPerson() { }

        public SalesPerson(string fullName, int age, int empId, float currPay, string ssn, int numOfSales)
            : base(fullName, age, empId, currPay, ssn, EmployeePayTypeEnum.Commision)
        {
            SalesNumber = numOfSales;
        }
    }
}
