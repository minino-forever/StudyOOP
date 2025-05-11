using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Employees
{
      abstract partial class Employee
    {
        private string _empName;

        private int _empId;

        private float _currPay;

        private int _empAge;

        private string _empSSN;

        private EmployeePayTypeEnum _payType;

        protected BenefitPackage EmpBenefits = new BenefitPackage();

        public double GetBenefitCost() => EmpBenefits.ComputePayDeduction();

        public BenefitPackage Benefits
        {
            get { return EmpBenefits;}
            set { EmpBenefits = value; }
        }


        public string Name
        {
            get { return _empName; }
            set
            {
                if (value.Length > 15)
                {
                    Console.WriteLine($"Error! Name lemgth exceeds 15 characters!");
                }
                else
                {
                    _empName = value;
                }
            }
        }

        public int Id
        {
            get { return _empId; }
            set { _empId = value; }
        }

        public float Pay
        {
            get { return _currPay; }
            set { _currPay = value; }
        }

        public int Age
        {
            get { return _empAge; }
            set { _empAge = value; }
        }

        public string SSN
        {
            get { return _empSSN; }
            set { _empSSN = value; }
        }

        public EmployeePayTypeEnum PayType
        {
            get => _payType;
            set => _payType = value;
        }

        public Employee(){}

        public Employee(string name, int id, float pay, string ssn) : this (name, 0, id, pay, ssn, EmployeePayTypeEnum.Salaried){ }

        public Employee(string name, int age, int id, float pay, string ssn, EmployeePayTypeEnum payType)
        {
            Name = name;

            Id = id;

            Pay = pay;

            Age = age;

            SSN = ssn;

            PayType = payType;
        }

       /* public void GiveBonus(float amount)
        {
            Pay = this switch
            {
                { PayType: EmployeePayTypeEnum.Commision } => Pay += .10F * amount,
                { PayType: EmployeePayTypeEnum.Hourly } => Pay += 40F * amount / 2080F,
                { PayType: EmployeePayTypeEnum.Salaried } => Pay += amount,
                _ => Pay += 0
            };
        }
       */

        public virtual void GiveBonus(float amount)
        {
            Pay += amount;
        }
        public virtual void DisplayStatus()
        {
            Console.WriteLine($"Name: {Name}");

            Console.WriteLine($"Age: {Age}");

            Console.WriteLine($"ID: {Id}");

            Console.WriteLine($"Pay: {Pay}");

            Console.WriteLine($"SSN: {SSN}");
        }
    }
}
