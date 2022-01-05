using System;
using System.Collections.Generic;
using System.Threading;

namespace SnakeOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(10, 10, '*');
            Point p2 = new Point(11, 10, '*');

            HorizontalLine hLine = new HorizontalLine(10, 14, 5, 'O');
            //hLine.Draw();
            VerticalLine vLine = new VerticalLine(6, 16, 10, '💼');
            //vLine.Draw();

            //game field frame
            HorizontalLine top = new HorizontalLine(0, 80, 0, 'O');
            top.Draw();
            VerticalLine left = new VerticalLine(0, 25, 0, 'O');
            left.Draw();
            HorizontalLine bottom = new HorizontalLine(0, 80, 25, 'O');
            bottom.Draw();
            VerticalLine right = new VerticalLine(0, 25, 80, 'O');
            right.Draw();

            Point snakeTail = new Point(15, 15, '@');
            Snake snake = new Snake(snakeTail, 5, Direction.RIGHT);
            snake.Draw();

            FoodGenerator foodGenerator = new FoodGenerator(80, 25, '@');
            Point food = foodGenerator.GenerateFood();
            food.Draw();

            while (true)
            {
                if (snake.Eat(food))
                {
                    food = foodGenerator.GenerateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKeys(key.Key);
                }

                Thread.Sleep(300);
                //snake.Move();
            
            }


            Console.ReadLine();
        }


    }
}