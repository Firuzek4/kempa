using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Przemo robi loda w "+ new Program().oko());
            Console.ReadKey();
            // bal bla bla
        }
        public string oko() {
            return "oko";
        }
    }
}
