using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Epam_Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("task 1 \n ------------------------------------------- \n input left top: ");
            Point leftTop = new Point(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            Console.WriteLine("input right bottom: ");
            Point rightBottom = new Point(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            Second_Webinar_Tasks.Task_1.Rectangle r1 = new Second_Webinar_Tasks.Task_1.Rectangle(leftTop, rightBottom);
            Console.WriteLine($"perimeter = {r1.GetPerimeter()} , square = {r1.GetSquare()}");

            Console.WriteLine("task 2 \n ------------------------------------------- \n input left top: ");
            Point _leftTop = new Point(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            Console.WriteLine("input right bottom: ");
            Point _rightBottom = new Point(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            Second_Webinar_Tasks.Task_2.Rectangle r2 = new Second_Webinar_Tasks.Task_2.Rectangle(_leftTop, _rightBottom);
            Console.WriteLine($"perimeter = {r2.Perimeter} , square = {r2.Square}");

            Console.WriteLine("task 3 \n ------------------------------------------- \n input radius: ");
            Second_Webinar_Tasks.Task_3.Circle c1 = new Second_Webinar_Tasks.Task_3.Circle();
            int radius = int.Parse(Console.ReadLine());
            Console.WriteLine($"length = {c1.GetLength(radius)} , square = {c1.GetSquare(radius)}");

            Console.WriteLine("task 4 \n ------------------------------------------- \n input left top: ");
            Point __leftTop = new Point(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            Console.WriteLine("input right bottom: ");
            Point __rightBottom = new Point(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            Console.WriteLine($"perimeter = {Second_Webinar_Tasks.Task_4.Rectangle.GetPerimeter(__leftTop , __rightBottom)} , square = {Second_Webinar_Tasks.Task_4.Rectangle.GetSquare(__leftTop , __rightBottom)}");
            Console.WriteLine("input radius: ");
            int _radius = int.Parse(Console.ReadLine());
            Console.WriteLine($"length = {Second_Webinar_Tasks.Task_4.Circle.GetLength(_radius)} , square = {Second_Webinar_Tasks.Task_4.Circle.GetSquare(_radius)}");

            Console.WriteLine("task 5 \n ------------------------------------------- \n input real part: ");
            int real = int.Parse(Console.ReadLine());
            Console.WriteLine("input imaginary part: ");
            int imaginary = int.Parse(Console.ReadLine());
            Second_Webinar_Tasks.Task_5.ComplexNumber cn1 = new Second_Webinar_Tasks.Task_5.ComplexNumber(real, imaginary);
            Console.WriteLine("input real part: ");
            int _real = int.Parse(Console.ReadLine());
            Console.WriteLine("input imaginary part: ");
            int _imaginary = int.Parse(Console.ReadLine());
            Second_Webinar_Tasks.Task_5.ComplexNumber cn2 = new Second_Webinar_Tasks.Task_5.ComplexNumber(real, imaginary);
            Second_Webinar_Tasks.Task_5.ComplexNumber cn3 = cn1 * cn2;
            Second_Webinar_Tasks.Task_5.ComplexNumber cn4 = cn1 / cn2;
            Console.WriteLine($"result of multiply = ({cn3.Real} , {cn3.Imaginary}) \n result of division = ({cn4.Real} , {cn4.Imaginary}) ");

            Console.Read();
        }
    }
}
