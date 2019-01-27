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
            while (true)
            {
                Console.Write("\n\n1) Binary\n2) DEC\n3) HEX\nChoose a number system: ");

                int choose = int.Parse(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        BinaryTable();
                        break;
                    case 2:
                        HexOrDecTable("");
                        break;
                    case 3:
                        HexOrDecTable("X2");
                        break;
                    default:
                        Console.WriteLine("Incorrect choice!!!");
                        break;
                }
            }
        }

        public static string ToBinary(int myValue)
        {
            string binVal = Convert.ToString(myValue, 2);
            int bits = 0;
            int bitblock = 8;

            for (int i = 0; i < binVal.Length; i = i + bitblock)
            { bits += bitblock; }

            return binVal.PadLeft(bits, '0');
        }

        public static void HexOrDecTable(string format)
        {
            Console.Write("\n     ");

            for (int i = 2; i < 10; ++i)
                Console.Write(i + "  ");

            Console.WriteLine("\n  " + new string('-', 25));

            for (int i = 2; i < 10; ++i)
            {
                Console.Write(i + " |");
                for (int j = 2; j < 10; ++j)
                {
                    Console.Write("{0,3}", (i * j).ToString(format));
                }
                Console.WriteLine();
            }
        }

        public static void BinaryTable()
        {
            Console.Write("\n\t  ");

            for (int i = 2; i < 10; ++i)
                Console.Write(i + "         ");
             
            Console.WriteLine("\n  " + new string('-', 80));

            for (int i = 2; i < 10; ++i)
            {
                Console.Write(i + " |");
                for (int j = 2; j < 10; ++j)
                {
                    Console.Write(ToBinary(i * j) + "  ");
                }
                Console.WriteLine();
            }
        }

    
    }
}
