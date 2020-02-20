using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            exception e = new exception();
            e.division(25, 0);
            Console.ReadKey();
        }
    }
}
