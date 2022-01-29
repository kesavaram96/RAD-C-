using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    struct Point
    {
        public int x, y;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point P1 = new Point();
            Point P2 = new Point();
            Point P3 = new Point();

            Console.WriteLine("\n Enter a Point : ");
            P1.x = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("\n Enter a Point : ");
            P1.y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n Enter a Point : ");
            P2.x = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("\n Enter a Point : ");
            P2.y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n Enter a Point : ");
            P3.x = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("\n Enter a Point : ");
            P3.y = Convert.ToInt32(Console.ReadLine());

            double m1 = (double)(P2.y - P1.y) / (double)(P2.x - P1.x);
            double m2 = (double)(P3.y - P1.y) / (double)(P3.x - P1.x);
            double m3 = (double)(P3.y - P2.y) / (double)(P3.x - P2.x);

            if (m1==m2 && m1==m3 && m2==m3)
            {
                Console.WriteLine(" Points are on same line ");
            }
            else
            {
                Console.WriteLine(" Points are not on same line ");
            }

            Console.ReadKey();
        }
    }
}
