using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeOOP
{
    class Horizon : Figure
    {


        public Horizon(int xLeft, int xRight, int y, char symb)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            pointList = new List<Point>();

            for (int i = xLeft; i <= xRight; i++)
            {
                Point p = new Point(i, y, symb);
                pointList.Add(p);
            }

        }
    }
}
