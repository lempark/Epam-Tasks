using System;


namespace Third_Webinar_Tasks
{
    namespace Task_1
    {
        public abstract class Figure
        {
            public abstract void Draw();
        }


        public class Rectangle : Figure
        {
            public override void Draw()
            {
                Console.WriteLine("Rectangle");
            }
        }

        public class Square : Figure
        {
            public override void Draw()
            {
                Console.WriteLine("Square");
            }
        }
    }
}
