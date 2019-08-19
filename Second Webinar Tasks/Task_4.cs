using System.Drawing;

namespace Second_Webinar_Tasks
{
    namespace Task_4
    {
        public static class Rectangle
        {  
            public static int GetPerimeter(Point B , Point D)
            {
                return (D.X - B.X) * 2 + (B.Y - D.Y) * 2;
            }

            public static int GetSquare(Point B, Point D)
            {
                return (D.X - B.X) * (B.Y - D.Y);
            }
        }

        public static class Circle
        {
            private const double Pi = 3.14159;

            public static double GetLength(int radius)
            {
                return 2 * Pi * radius;
            }

            public static double GetSquare(int radius)
            {
                return Pi * radius * radius;
            }
        }
    }
}
