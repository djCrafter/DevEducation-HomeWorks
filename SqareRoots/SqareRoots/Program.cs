using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqareRoots
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ax^2+bx+с");

            Console.Write("Enter a coefficient A: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Enter a coefficient B: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Enter a coefficient C: ");
            double c = double.Parse(Console.ReadLine());

            //D=b^2-4ac
            double D = Math.Pow(b, 2) - 4 * a * c;

            if (D > 0)
            {
                double x1 = (-b - Math.Sqrt(D)) / (2 * a);
                double x2 = (-b + Math.Sqrt(D)) / (2 * a);

                Console.WriteLine("The solution has two roots. X1 = {0}, X2 = {1}", x1, x2);
            }
            else if (D == 0)
            {
                double x = (-b) / (2 * a);

                Console.WriteLine("The solution has one root. X1 = {0}", x);
            }
            else
            {
                Console.WriteLine("The solution has no roots.");
            }

            Console.ReadLine();
        }
    }
}
