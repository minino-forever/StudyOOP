using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    internal sealed class PtSalesPerson : SalesPerson
    {
        public PtSalesPerson() { }

        public PtSalesPerson(string name, int age, int id, float currPay, string ssn, int numOfSales)
            : base(name, age, id, currPay, ssn, numOfSales)
        {

        }
    }
}
