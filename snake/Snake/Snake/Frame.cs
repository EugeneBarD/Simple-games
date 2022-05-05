using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Frame
    {
        public Frame(Point sPoint, Point ePoint, char symbol)
        {
            horizontalLines.Add(new HorizontalLine(sPoint.X + 1, ePoint.X * 2 + 1, symbol, sPoint.Y));
            horizontalLines.Add(new HorizontalLine(sPoint.X, ePoint.X * 2, symbol, ePoint.Y));
            verticalLines.Add(new VerticalLine(sPoint.Y, ePoint.Y, symbol, sPoint.X));
            verticalLines.Add(new VerticalLine(sPoint.Y + 1, ePoint.Y + 1, symbol, ePoint.X * 2));
        }

        public void Draw() 
        {
            foreach (HorizontalLine horizontalLine in horizontalLines)
            {
                horizontalLine.Draw();
            }

            foreach (VerticalLine verticalLine in verticalLines)
            {
                verticalLine.Draw();
            }
        }

        private List<HorizontalLine> horizontalLines = new();
        private List<VerticalLine> verticalLines = new();
    }
}
