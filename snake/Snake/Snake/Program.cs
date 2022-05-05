using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            const int size = 40;

            for (int i = 1; i < size * 2; i += 2)
            {
                if (i == 1 || i == size * 2 - 1)
                {
                    for (int j = 1; j <= size; j++)
                    {
                        new Point(i, j, '*').DrawSymbol();
                    }
                }
                else
                {
                    new Point(i, 1, '*').DrawSymbol();
                    new Point(i, size, '*').DrawSymbol();
                }
            }

            Console.ReadLine();
        }
    }
}
