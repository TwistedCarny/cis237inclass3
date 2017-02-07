using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass3
{
    class Employee
    {

        // Const for weeks per year
        protected const decimal WEEKS_PER_YEAR = 52;

        private string firstName;
        private string lastName;

        //*****************************
        //Properties
        //*****************************
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        //******************************
        //Public Methods
        //******************************
        public string FirstAndLastName()
        {
            return firstName + " " + lastName;
        }


        public override string ToString()
        {
            return FirstAndLastName();
        }

        public Employee(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

    }
}
