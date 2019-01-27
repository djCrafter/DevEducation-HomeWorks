using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pythagorean_table
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Pythagorean table:\n\n     ");
            
            for (int i = 2; i < 10; ++i)
                Console.Write(i + "  ");

            Console.WriteLine("\n  " + new string('-', 25));

            for(int i = 2; i < 10; ++i)
            {
                Console.Write(i + " |");
                for(int j = 2; j < 10; ++j)
                {               
                    Console.Write("{0,3}", i * j);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
