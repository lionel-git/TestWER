using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWER
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Core File...");
            throw new Exception("Some uncatched exception ...");
        }
    }
}
