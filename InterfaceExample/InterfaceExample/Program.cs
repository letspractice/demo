using System;

namespace InterfaceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Meeting meeting = new Meeting();
            meeting.employeeName("Brown");
            int Salary=meeting.employeeSalary(150000);
            int Tax=meeting.employeeTaxDeducted(1200);
            Console.WriteLine("Salary after Tax: {0}",Salary-Tax);
        }
    }
}
