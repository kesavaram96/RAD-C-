using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Summation of two numbers : {0}", Class1.sum(55, 6));
            Console.WriteLine("Subraction of two numbers : {0}", Class1.sub(55, 6));
            Console.ReadKey();
        }
    }
}
