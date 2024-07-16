using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chunk
{
    public class Repo
    {
        public static IEnumerable<Person> LoadEmployees()
        {
            return new List<Person>
        {
            new Person { Name = "Basmala", Age = 20 },
            new Person { Name = "Ahmed", Age = 30 },
            new Person { Name = "Farida", Age = 10 }
       
        };
        }

    }
}
