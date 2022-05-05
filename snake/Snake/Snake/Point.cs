using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Point
    {
        public void Draw()
        {
            Console.SetCursorPosition(X, Y);
            Console.WriteLine(Symbol);
        }

        public void Move(int shift, Direction direction) 
        {
            if (direction == Direction.Up)
            {
                Y -= shift;
            }
            
            if (direction == Direction.Down)
            {
                Y += shift;
            } 
            
            if (direction == Direction.Right)
            {
                X += shift;
            }
            
            if (direction == Direction.Left)
            {
                X -= shift;
            }
        }

        internal void Clear()
        {
            Symbol = ' ';
            Draw();
        }

        public Point(int x, int y, char symbol) 
        {
            X = x;
            Y = y;
            Symbol = symbol;
        }

        public Point(Point point) 
        {
            X = point.X;
            Y = point.Y;
            Symbol = point.Symbol;
        }


        public int X { get; private set; }
        public int Y { get; private set; }
        private char Symbol { get; set; }
    }
}
