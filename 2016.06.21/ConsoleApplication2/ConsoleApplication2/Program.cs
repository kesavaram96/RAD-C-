using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaseChange;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Enter a Upper Case Letter : ");
            char a = char.Parse(Console.ReadLine());
            Console.WriteLine(" Answer is : " + Class1.LowerToUpper(a));
            Console.ReadKey();
        }
    }
}
