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
        static void SecondWebinarTasks()
        {
            Console.WriteLine("Second webinar Tasks ##########################################");

            Console.WriteLine("Task 1 \n ------------------------------------------- \n input left top: ");
            Point leftTop = new Point(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            Console.WriteLine("input right bottom: ");
            Point rightBottom = new Point(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            Second_Webinar_Tasks.Task_1.Rectangle r1 = new Second_Webinar_Tasks.Task_1.Rectangle(leftTop, rightBottom);
            Console.WriteLine($"perimeter = {r1.GetPerimeter()} , square = {r1.GetSquare()}");

            Console.WriteLine("Task 2 \n ------------------------------------------- \n input left top: ");
            Point _leftTop = new Point(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            Console.WriteLine("input right bottom: ");
            Point _rightBottom = new Point(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            Second_Webinar_Tasks.Task_2.Rectangle r2 = new Second_Webinar_Tasks.Task_2.Rectangle(_leftTop, _rightBottom);
            Console.WriteLine($"perimeter = {r2.Perimeter} , square = {r2.Square}");

            Console.WriteLine("Task 3 \n ------------------------------------------- \n input radius: ");
            Second_Webinar_Tasks.Task_3.Circle c1 = new Second_Webinar_Tasks.Task_3.Circle();
            int radius = int.Parse(Console.ReadLine());
            Console.WriteLine($"length = {c1.GetLength(radius)} , square = {c1.GetSquare(radius)}");

            Console.WriteLine("Task 4 \n ------------------------------------------- \n input left top: ");
            Point __leftTop = new Point(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            Console.WriteLine("input right bottom: ");
            Point __rightBottom = new Point(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            Console.WriteLine($"perimeter = {Second_Webinar_Tasks.Task_4.Rectangle.GetPerimeter(__leftTop, __rightBottom)} , square = {Second_Webinar_Tasks.Task_4.Rectangle.GetSquare(__leftTop, __rightBottom)}");
            Console.WriteLine("input radius: ");
            int _radius = int.Parse(Console.ReadLine());
            Console.WriteLine($"length = {Second_Webinar_Tasks.Task_4.Circle.GetLength(_radius)} , square = {Second_Webinar_Tasks.Task_4.Circle.GetSquare(_radius)}");

            Console.WriteLine("Task 5 \n ------------------------------------------- \n input real part: ");
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
        }

        static void ThirdWebinarTasks()
        {
            Console.WriteLine("Third webinar Tasks ##########################################");

            Console.WriteLine("Task 1 \n -------------------------------------------");
            Third_Webinar_Tasks.Task_1.Figure f1 = new Third_Webinar_Tasks.Task_1.Rectangle();
            f1.Draw();
            Third_Webinar_Tasks.Task_1.Figure f2 = new Third_Webinar_Tasks.Task_1.Square();
            f2.Draw();

            Console.WriteLine("Task 2 \n ------------------------------------------\n input x , y: ");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            Third_Webinar_Tasks.Task_2.Figure f3 = new Third_Webinar_Tasks.Task_2.Rectangle(x, y);
            Console.WriteLine("input x , y: ");
            int _x = int.Parse(Console.ReadLine());
            int _y = int.Parse(Console.ReadLine());
            Third_Webinar_Tasks.Task_2.Figure f4 = new Third_Webinar_Tasks.Task_2.Square(_x, _y);
            f3.Draw();
            Console.WriteLine($"coordinates: ({f3.X} , {f3.Y})");
            f4.Draw();
            Console.WriteLine($"coordinates: ({f4.X} , {f4.Y})");

            Console.WriteLine("Task 3 \n ------------------------------------------\n input x , y: ");
            int x5 = int.Parse(Console.ReadLine());
            int y5 = int.Parse(Console.ReadLine());
            Third_Webinar_Tasks.Task_3.Figure f5 = new Third_Webinar_Tasks.Task_3.Figure(x5, y5);
            Console.WriteLine("input x , y: ");
            int x6 = int.Parse(Console.ReadLine());
            int y6 = int.Parse(Console.ReadLine());
            Third_Webinar_Tasks.Task_3.Figure f6 = new Third_Webinar_Tasks.Task_3.Rectangle(x6, y6);
            Console.WriteLine("input x , y: ");
            int x7 = int.Parse(Console.ReadLine());
            int y7 = int.Parse(Console.ReadLine());
            Third_Webinar_Tasks.Task_3.Figure f7 = new Third_Webinar_Tasks.Task_3.Square(x7, y7);
            f5.Draw();
            Console.WriteLine($"coordinates: ({f5.X} , {f5.Y})");
            f6.Draw();
            Console.WriteLine($"coordinates: ({f6.X} , {f6.Y})");
            f7.Draw();
            Console.WriteLine($"coordinates: ({f7.X} , {f7.Y})");

            Console.WriteLine("Task 4 \n ------------------------------------------\n input x , y: ");
            int x8 = int.Parse(Console.ReadLine());
            int y8 = int.Parse(Console.ReadLine());
            Third_Webinar_Tasks.Task_4.Figure f8 = new Third_Webinar_Tasks.Task_4.Figure(x8, y8);
            Console.WriteLine("input x , y: ");
            int x9 = int.Parse(Console.ReadLine());
            int y9 = int.Parse(Console.ReadLine());
            Third_Webinar_Tasks.Task_4.Figure f9 = new Third_Webinar_Tasks.Task_4.Rectangle(x9, y9);
            Console.WriteLine("input x , y: ");
            int x10 = int.Parse(Console.ReadLine());
            int y10 = int.Parse(Console.ReadLine());
            Third_Webinar_Tasks.Task_4.Figure f10 = new Third_Webinar_Tasks.Task_4.Square(x10, y10);
            Third_Webinar_Tasks.Task_4.Figure.DrawAll(f8, f9, f10);
            Console.WriteLine($"coordinates:\n({f8.X} , {f8.Y})\n({f9.X} , {f9.Y})\n({f10.X} , {f10.Y})");
        }

        static void ForthWebinarTasks()
        {
            Console.WriteLine("forth webinar Tasks ##########################################");

            Console.WriteLine("Task 1-2 \n -------------------------------------------");
            List<Forth_Webinar_Tasks.Task_1_2.Person> persons = new List<Forth_Webinar_Tasks.Task_1_2.Person>();
            for (int i = 0; i < 6; i++)
            {
                Forth_Webinar_Tasks.Task_1_2.Person p = new Forth_Webinar_Tasks.Task_1_2.Person();
                p.PhoneNumbers = new List<string>();

                Console.WriteLine($"input name of {i + 1} person");
                p.Name = Console.ReadLine();

                Console.WriteLine($"input age of {i + 1} person");
                p.Age = int.Parse(Console.ReadLine());

                Console.WriteLine($"input phone number of {i + 1} person");
                p.PhoneNumbers.Append(Console.ReadLine());

                Console.WriteLine($"input second phone number of {i + 1} person");
                p.PhoneNumbers.Append(Console.ReadLine());

                persons.Add(p);
            }
            foreach (Forth_Webinar_Tasks.Task_1_2.Person pers in persons)
            {
                Console.WriteLine($"name: {pers.Name}\t age: {pers.Age}");
            }
            List<Forth_Webinar_Tasks.Task_1_2.Person> otherpersons = new List<Forth_Webinar_Tasks.Task_1_2.Person>();

            for (int i = 6; i < 9; i++)
            {
                Forth_Webinar_Tasks.Task_1_2.Person p = new Forth_Webinar_Tasks.Task_1_2.Person();
                p.PhoneNumbers = new List<string>();

                Console.WriteLine($"input name of {i + 1} person");
                p.Name = Console.ReadLine();

                Console.WriteLine($"input age of {i + 1} person");
                p.Age = int.Parse(Console.ReadLine());

                Console.WriteLine($"input phone number of {i + 1} person");
                p.PhoneNumbers.Append(Console.ReadLine());

                Console.WriteLine($"input second phone number of {i + 1} person");
                p.PhoneNumbers.Append(Console.ReadLine());
                otherpersons.Add(p);
            }

            persons.AddRange(otherpersons);

            foreach (Forth_Webinar_Tasks.Task_1_2.Person pers in persons)
            {
                Console.WriteLine($"name: {pers.Name}\nphone numbers:");
                foreach (string number in pers.PhoneNumbers)
                {
                    Console.WriteLine(number);
                }
            }

            Console.WriteLine("Task 3 \n -------------------------------------------");
            Forth_Webinar_Tasks.Task_3.ListOfStrings.MakeExample();
            Console.WriteLine("page number wich you want display: ");
            try
            {
                Forth_Webinar_Tasks.Task_3.ListOfStrings.DisplayPage(int.Parse(Console.ReadLine()));
            }
            catch(FormatException)
            {
                Environment.Exit(0);
            }
        }

        static void Main(string[] args)
        {
            int webinarNumber;
            Console.WriteLine("choose webinar(2/3/4): ");
            webinarNumber = int.Parse(Console.ReadLine());
            switch(webinarNumber)
            {
                case 2:
                    SecondWebinarTasks();
                    break;
                case 3:
                    ThirdWebinarTasks();
                    break;
                case 4:
                    ForthWebinarTasks();
                    break;
            }


            Console.Read();
        }
    }
}
