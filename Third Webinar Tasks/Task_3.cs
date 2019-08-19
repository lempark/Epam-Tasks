using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_Webinar_Tasks
{
    namespace Task_3
    {
        public class Figure
        {
            public int X { get; }
            public int Y { get; }

            public Figure(int x, int y)
            {
                X = x;
                Y = y;
            }
            public virtual void Draw()
            {
                Console.WriteLine("Some Figure");
            }
        }


        public class Rectangle : Figure
        {
            public Rectangle(int x, int y) : base(x, y)
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
