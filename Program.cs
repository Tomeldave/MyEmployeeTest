using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employimg_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee( "Oladayo", "John", 3000.00M, 36000.00M);
            
            Employee employee2 = new Employee( "Tomiseen", "Emmanuel", 2000.00M, 24000.00M);

            decimal yearlySalary1 = 3000.00M * 12;
            decimal yearlySalary2 = 2000.00M * 12;
            decimal salaryIncrease1 = yearlySalary1 + (yearlySalary1 * 0.1M);
            decimal salaryIncrease2 = yearlySalary2 + (yearlySalary2 * 0.1M);

            Console.WriteLine("Employee1 = Oladayo ");
            Console.WriteLine();
            Console.WriteLine("Oladayo's yearly salary is = " + yearlySalary1);
            Console.WriteLine();
            Console.WriteLine("Employee2 = Tomiseen");
            Console.WriteLine();
            Console.WriteLine("Tomiseen's yearly salary is = " + yearlySalary2);
            Console.WriteLine();
            Console.WriteLine("Employee1 = Oladayo ");
            Console.WriteLine();
            Console.WriteLine("Oladayo's salary increase is = " + salaryIncrease1);
            Console.WriteLine();
            Console.WriteLine("Employee2 = Tomiseen ");
            Console.WriteLine();
            Console.WriteLine("Tomiseen's salary increase is = " + salaryIncrease2);




          Console.ReadLine();
        }

    
    }

}
