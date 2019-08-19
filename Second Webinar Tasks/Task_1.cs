using System.Drawing;


namespace Second_Webinar_Tasks
{
    namespace Task_1
    {
        public class Rectangle
        {
            private Point B ,D;

            public Rectangle(Point B, Point D)
            {
                this.B = B;
                this.D = D;
            }

            public int GetPerimeter()
            {
                return (D.X - B.X) * 2 + (B.Y - D.Y) * 2;
            }

            public int GetSquare()
            {
                return (D.X - B.X) * (B.Y - D.Y);
            }
        }
    }
}
