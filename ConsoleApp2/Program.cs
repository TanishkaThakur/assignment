using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using assignment;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employee = new List<Employee>();
            bool x = true;

            Console.WriteLine("========================================");
            Console.WriteLine("\tLITWARE ORGANIZATION");
            Console.WriteLine("========================================");
            Console.WriteLine("\n");
            Console.WriteLine("\t<<Enter The Details>>");
            try
            {
                while (x)
                {


                    Console.WriteLine("Enter Employee Number");
                    int no = Convert.ToInt32(Console.ReadLine());


                    Console.WriteLine("Enter Employee Name");
                    string name = Console.ReadLine();


                    Console.WriteLine("Enter Employee Salary");
                    double sal = Convert.ToDouble(Console.ReadLine());



                    Employee emp = new Employee(no, name, sal);
                    employee.Add(emp);

                    emp.CalculatedSalary();

                    Console.WriteLine("\n");
                    Console.WriteLine("\t==Successfully Registered==");

                    Console.WriteLine("\tEnter 0 to exit");

                    int i = int.Parse(Console.ReadLine());
                    if (i == 0)
                    {
                        x = false;
                    }

                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
