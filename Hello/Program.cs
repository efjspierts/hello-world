using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Add some comments to the project

namespace Hello
{
    class Program
    {
        static void DoesNotMuch()
        {
            // Hello there
            var a = 10;
            var b = a;
            a = b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");
            Console.ReadKey();
        }
    }
}
