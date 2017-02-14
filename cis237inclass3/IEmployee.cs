using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass3
{
    interface IEmployee : ICloneable
    {
        string GetFormattedSalary();

        string GetLastNameFirstName();

        string FirstName
        {
            get;
            set;
        }

        string LastName
        {
            get;
            set;
        }


    }
}
