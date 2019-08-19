

namespace Second_Webinar_Tasks
{
    namespace Task_3
    {
        public class Circle
        {
            private const double Pi = 3.14159;

            public double GetLength(int radius)
            {
                return 2 * Pi * radius;
            }

            public double GetSquare(int radius)
            {
                return Pi * radius * radius;
            }
        }
    }
}
