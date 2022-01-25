using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExample
{
    class Meeting : IExample
    {
        public void employeeName(string a)
        {
            Console.WriteLine("Employee Name: {0}",a);
        }

        public int employeeSalary(int a)
        {
            Console.WriteLine("Employee Salary: {0}", a);
            return a;
        }

        public int employeeTaxDeducted(int a)
        {
            Console.WriteLine("Employee TaxDeducted: {0}", a);
            return a;
        }
    }
}
