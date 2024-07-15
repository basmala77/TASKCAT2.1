using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static int globalint = 0;    
        static void Main(string[] args)
        {

        }
        static List<int> ii(List<int> list)
        {
            return list.Where(x => x % 2 == 0).ToList();
        }
        public static void IncrementCounter()
        {
            globalint++;
        }
    }
}
