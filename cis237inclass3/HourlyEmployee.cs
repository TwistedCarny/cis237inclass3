using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass3
{
    class HourlyEmployee : Employee
    {
        
        //*****************************
        //Variable / Backing fields
        //*****************************
        private decimal hourlyRate;
        private decimal hoursPerWeek;

        public decimal Salary
        {
            get { return hourlyRate * WEEKS_PER_YEAR * hoursPerWeek; }
        }


        public override string ToString()
        {
            return base.ToString() + " " + Salary.ToString("C");
        }

        public override string GetFormattedSalary()
        {
            return (hoursPerWeek * hourlyRate) + " * " + WEEKS_PER_YEAR.ToString() + " = " + Salary.ToString("C");
        }

        public override object Clone()
        {
            return new HourlyEmployee(FirstName, LastName, hoursPerWeek, hourlyRate);
        }

        //*****************************
        //Constructors
        //*****************************
        public HourlyEmployee(string FirstName, string LastName, 
                              decimal hoursPerWeek, decimal hourlyRate) : base(FirstName, LastName)
        {
            this.hoursPerWeek = hoursPerWeek;
            this.hourlyRate = hourlyRate;
        }
    }
}
