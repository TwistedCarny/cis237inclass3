using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using cis237inclass3;

namespace cis237inclass3UnitTest
{
    [TestClass]
    public class SalaryEmployeeUnitTest
    {
        [TestMethod]
        public void LastNameFirstNameTest()
        {
            //Arrange
            SalaryEmployee salaryEmployee = new SalaryEmployee("David", "Barnes", 150m);
            string expected = "Barnes, David";

            //Act

            string actual = salaryEmployee.GetLastNameFirstName();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetYearlySalaryTest()
        {
            //Arrange
            SalaryEmployee salaryEmployee = new SalaryEmployee("David", "Barnes", 250m);

            string expected = "$13,000.00";


            // Act
            string actual = salaryEmployee.GetFormattedSalary();


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SalaryEmployeeTest()
        {
            // Arrange
            string expectedFirstName = "David";
            string expectedLastName = "Barnes";
            decimal expectedSalary = 250m * 52m;

            // Act
            SalaryEmployee salaryEmployee = new SalaryEmployee("David", "Barnes", 250m);



            //Assert
            Assert.AreEqual(expectedFirstName, salaryEmployee.FirstName);
            Assert.AreEqual(expectedLastName, salaryEmployee.LastName);
            Assert.AreEqual(expectedSalary, salaryEmployee.Salary);
        }
    }

    
}
