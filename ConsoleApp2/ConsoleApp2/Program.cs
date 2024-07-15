using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    static class Program
    {
        static void Main(string[] args)
        {
            var emp = new List<Employee>
            {
                new Employee {FName = "Basmala", LName = "Mohamed", Salary=15.000m},
                new Employee {FName = "sara", LName = "Ahmed", Salary =20.000m}
            };
            var re = emp.EmployeeFilter();
            foreach (var r in re)
            {
                Console.WriteLine(r);
            }
            Console.ReadLine();

        }
        public static IEnumerable<string> EmployeeFilter(this IEnumerable<Employee> emp)
        {
            return emp.
                Where(e => e.Salary > 15.000m).Select(e => $"{e.FName} {e.LName}");
        }
    }
    class Employee
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public decimal Salary { get; set; }
    }
}
