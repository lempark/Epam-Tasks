using System;

namespace Third_Webinar_Tasks
{
    namespace Task_2
    {
        public abstract class Figure
        {
            public int X { get; }
            public int Y { get; }

            public Figure(int x , int y)
            {
                X = x;
                Y = y;
            }
            public abstract void Draw();
        }


        public class Rectangle : Figure
        {
            public Rectangle(int x , int y) : base(x , y)
            {

            }

            public override void Draw()
            {
                Console.WriteLine("Rectangle");
            }
        }

        public class Square : Figure
        {
            public Square(int x, int y) : base(x, y)
            {

            }

            public override void Draw()
            {
                Console.WriteLine("Square");
            }
        }
    }
}
