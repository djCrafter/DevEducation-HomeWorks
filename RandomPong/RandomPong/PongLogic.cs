using System;
using System.Threading;

namespace RandomPong
{
    class PongLogic
    {
        Field field = new Field(20, 30);
        Pong pong;

        char pongSymbol = (char)9608;
        char space = ' ';

        int pongHeight = 2;
        int pongWidth = 3;

        public PongLogic()
        {
            pong = new Pong(pongHeight, pongWidth, field.GetStartPoint());
        }


        //TO DO: Разнести метод...
        public void Start()
        {
            Point temp;

            field.DrawField(ConsoleColor.Green);
      
            pong.vector = pong.RandomizeVector();

            while (true)
            {
                pong.Draw(pongSymbol);
                Thread.Sleep(100);
                pong.Draw(space);

                temp = pong.ChangePosition(pong.currentPoint, pong.vector);

                if (!field.OnTheBorder(temp, pong.Height, pong.Width))
                {
                    pong.currentPoint = temp;
                }
                else
                {
                    Vector tempVector;

                    do
                    {
                        tempVector = pong.RandomizeVector();
                        temp = pong.ChangePosition(pong.currentPoint, tempVector);
                    }
                    while (field.OnTheBorder(temp, pong.Height, pong.Width));
                    pong.currentPoint = temp;
                    pong.vector = tempVector;
                }               
            }
        }    
    }
}
