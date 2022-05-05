using System;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BufferHeight = 30;

            new Frame(new Point(2, 1, '*'), new Point(59, 28, '*'), '*').Draw();

            Point startPos = new Point(6, 6, 'o');

            Snake snake = new Snake(startPos, 4, Direction.Right);
            snake.Draw();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();

                    snake.Handling(key);
                }

                Thread.Sleep(100);
                snake.Move();
            }
        }
    }
}
