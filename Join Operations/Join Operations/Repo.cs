using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Join_Operations
{
    public class Repo
    {
       public static IEnumerable<Student> LoadSTD()
        {
            return new List<Student>
            {
                new Student {Id = 1, Name = "Basmala"},
                new Student { Id = 2,Name="Mariem"},
                new Student { Id = 3,Name="Farida"}
            };
        }
        public static IEnumerable<Enrollment> LoadENR()
        {
            return new List<Enrollment>
            {
                new Enrollment {StudentId = 1, Course = "LINQ"},
                new Enrollment { StudentId = 2,Course="SQL"},
                new Enrollment { StudentId = 3,Course="EF"}
            };
        }
    }
}
