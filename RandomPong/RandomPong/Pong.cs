using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomPong
{
    enum Vector
    {
      Up, UpRight, Right, DownRigh, Down, DownLeft, Left, UpLeft
    }

    struct Point
    {
        public int PointX { get; set; }
        public int PointY { get; set; }
    }

    class Pong
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public Point currentPoint { get; set; }
        public Vector vector { get; set; }
             
        int correct = 1;

        public Pong(int height, int width, Point startPoint)
        {
            Height = height;
            Width = width;
            currentPoint = startPoint;
            vector = RandomizeVector();
        }
        
        public void Draw(char symbol)
        {
            Console.SetCursorPosition(currentPoint.PointX + correct, currentPoint.PointY + correct);

            for(int i = 0; i < Height; ++i)
            {
                for(int j = 0; j < Width; ++j)
                {
                    Console.Write(symbol);
                }          
                Console.WriteLine();
                Console.CursorLeft = currentPoint.PointX + correct;
            }
        }

        public Vector RandomizeVector()
        {
            Random random = new Random();

            return (Vector)random.Next(0, 8);
        } 

        public Point ChangePosition(Point point, Vector _vector)
        {
            switch (_vector)
            {
                case Vector.Up:
                    point.PointY--;
                    break;
                case Vector.UpRight:
                    point.PointX++;
                    point.PointY--;
                    break;
                case Vector.Right:
                    point.PointX++;
                    break;
                case Vector.DownRigh:
                    point.PointX++;
                    point.PointY++;
                    break;
                case Vector.Down:
                    point.PointY++;
                    break;
                case Vector.DownLeft:
                    point.PointY++;
                    point.PointX--;
                    break;
                case Vector.Left:
                    point.PointX--;
                    break;
                case Vector.UpLeft:
                    point.PointX--;
                    point.PointY--;
                    break;
            }

            return point;
        }

    
    }
}
