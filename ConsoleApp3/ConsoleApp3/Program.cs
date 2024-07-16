using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //////////////Projection Operation///////////////
            var emp = Repository.LoadEmployees();
            var q1 = emp.Select(e => new { e.FirstName, e.LastName }).ToList();
            q1.Print("print FullName");


            ////////////Sorting Data///////////////

            var q2 = emp.OrderBy(e => e.Salary).ToList();
            q2.Print("print Salary");


            ////////////Quantifiers///////////////
            var q4 = emp.All(e => e.Salary > 150000);
            Console.WriteLine(q4);

            var input1 = "jac";
            var result1 = emp.Any(e => e.FirstName.StartsWith(input1, StringComparison.OrdinalIgnoreCase));
            Console.WriteLine($"find employee with name starts with '{input1}' result: {result1}");


            //////////////Grouping Data///////////////
            var result = emp.GroupBy(x => x.Gender);

            foreach (var item in result)
            {
                string title = $"Employee in '{item.Key}' Gender ,Count: {item.Count()}, Sum of Salary: {item.Sum(s => s.Salary)}, Average Salary: {item.Average(a => a.Salary)}";
                item.Print(title);
            }



            Console.ReadKey();
        }
    }
}
