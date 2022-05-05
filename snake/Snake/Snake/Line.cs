using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Line
    {
        public void Draw() 
        {
            foreach (Point point in points)
            {
                point.Draw();
            }
        }

        public List<Point> points = new();
    }

    class HorizontalLine : Line
    {
        public HorizontalLine(int startX, int endX, char symbol, int row) 
        {
            for (int i = startX; i < endX; i++)
            {
                points.Add(new Point(i, row, symbol));
            }
        }
    }
    
    class VerticalLine : Line
    {
        public VerticalLine(int startY, int endY, char symbol, int column)
        {
            for (int i = startY; i < endY; i++)
            {
                points.Add(new Point(column, i, symbol));
            }
        }
    }
}
