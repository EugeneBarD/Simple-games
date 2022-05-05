using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Line
    {
        Direction direction;

        public Snake(Point tail, int length, Direction direction) 
        {
            this.direction = direction;

            for (int i = 0; i < length; i++)
            {
                Point point = new Point(tail);
                point.Move(i, direction);
                points.Add(point);
            }
        }

        public void Handling(ConsoleKeyInfo key) 
        {
            direction = key.Key switch
            {
                ConsoleKey.LeftArrow => Direction.Left,
                ConsoleKey.RightArrow => Direction.Right,
                ConsoleKey.UpArrow => Direction.Up,
                ConsoleKey.DownArrow => Direction.Down,
                _ => throw new ArgumentException()
            };
        }

        internal void Move()
        {
            Point tail = points.First();
            points.Remove(tail);

            Point head = GetNextPosition();
            points.Add(head);

            tail.Clear();
            head.Draw();
        }

        private Point GetNextPosition() 
        {
            Point nextPoint = new Point(points.Last());
            nextPoint.Move(1, direction);
            return nextPoint;
        }
    }
}
