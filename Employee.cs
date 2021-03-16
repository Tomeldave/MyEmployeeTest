using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employimg_Test
{
    class Employee
    {
       private string firstName;
       private string lastName;
       private decimal monthlySalary;
       private decimal salaryIncrease;

        public Employee(string first, string last, decimal salary, decimal increase)
        {

            firstName = first;
            lastName = last;
            monthlySalary = salary;
            salaryIncrease = increase;

         }


        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }

        }

        public string LastName
        {
            get
         
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }

        }


        public decimal MonthlySalary
        {
            get
            {
                return monthlySalary;

            }
            set
            {
                if (value >= 0)
                    monthlySalary = value;
                else
                    monthlySalary = 0;

            }
        }
        

         public decimal SalaryIncrease
         {
            get

            {
                return salaryIncrease;
            }
            set
            {
                salaryIncrease = value;
            }

        }


       

    }


}
