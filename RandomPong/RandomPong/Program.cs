using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomPong
{
    class Program
    {      
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            PongLogic logic = new PongLogic();

            logic.Start();
   
            Console.ReadLine();
        }
    }
}
