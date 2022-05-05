using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Point
    {
        public void DrawSymbol()
        {
            Console.SetCursorPosition(X, Y);
            Console.WriteLine(Symbol);
        }

        public Point(int x, int y, char symbol) 
        {
            X = x;
            Y = y;
            Symbol = symbol;
        }

        private int X { get; set; }
        private int Y { get; set; }
        private char Symbol { get; set; }
    }
}
