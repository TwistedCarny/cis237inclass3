﻿using System;
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

        public decimal Salary
        {
            get {return weeklySalary * WEEKS_PER_YEAR; }
        }


        public override string ToString()
        {
            return base.ToString() + " " + Salary.ToString("C");
        }

        public override string GetFormattedSalary()
        {
            return Salary.ToString("C");
        }

        public override object Clone()
        {
            return new SalaryEmployee(FirstName, LastName, weeklySalary);
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
