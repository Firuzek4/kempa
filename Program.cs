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
            Console.WriteLine("Chuj "+new Program().mama()+" w "+ new Program().dupe());
            Console.ReadKey();
            // bal bla bla
        }
        public string dupe() {
            return "dupe";
        }
        public string mama(){
            return "mama";
        }
    }
}
