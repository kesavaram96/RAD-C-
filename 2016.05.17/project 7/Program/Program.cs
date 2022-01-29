using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The sum of two digits is: {0}", Class1.sum(2, 3));
            Console.ReadKey();
        }
    }
}
