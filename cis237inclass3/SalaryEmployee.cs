using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass3
{
    class SalaryEmployee : Employee
    {
        //*****************************
        //Variable / Backing fields
        //*****************************
        private decimal weeklySalary;

        

        public decimal WeeklySalary
        {
            get { return weeklySalary; }
            set { weeklySalary = value; }
        }


        public override string ToString()
        {
            return base.ToString() + " " + weeklySalary.ToString("C");
        }


        //*****************************
        //Constructors
        //*****************************
        public SalaryEmployee(string FirstName, string LastName, decimal WeeklySalary) : base(FirstName, LastName)
        {
            this.weeklySalary = WeeklySalary;
        }
    }
}
