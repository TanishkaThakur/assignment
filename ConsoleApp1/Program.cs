using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using assignment;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========================================");
            Console.WriteLine("\tLITWARE ORGANIZATION");
            Console.WriteLine("========================================");

            Console.WriteLine("Enter Employee Number");
            int no = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Employee Name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Employee Salary");
            double sal = double.Parse(Console.ReadLine());

            Employee emp = new Employee(no, name, sal);
            emp.CalculatedSalary();
        }
    }
}
