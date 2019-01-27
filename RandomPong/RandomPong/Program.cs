using System;

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
