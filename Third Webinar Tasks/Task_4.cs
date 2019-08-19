using System;


namespace Third_Webinar_Tasks
{
    namespace Task_4
    {
        public interface IDrawable
        {
            void Draw();
        }

        public class Figure : IDrawable
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

            public static void DrawAll(params IDrawable[] figures)
            {
                foreach (Figure figure in figures)
                {
                    figure.Draw();
                }
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
