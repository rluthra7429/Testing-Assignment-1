using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 0, width = 0, choice;
            do
            {
                Console.WriteLine("Enter the Length of the Rectangle:");
                length = Convert.ToInt32(Console.ReadLine());
            } while (length <= 0);

            do
            {
                Console.WriteLine("Enter the Width of the Rectangle:");
                width = Convert.ToInt32(Console.ReadLine());
            } while (width <= 0);

            Rectangle obj = new Rectangle(length, width);
            obj.SetLength(length);
            obj.SetWidth(width);
            string ch = "y";

            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Get Rectangle Length");
                Console.WriteLine("2.Change Rectangle Length");
                Console.WriteLine("3.Get Rectangle Width");
                Console.WriteLine("4.Change Rectangle Width");
                Console.WriteLine("5.Get Rectangle Perimeter");
                Console.WriteLine("6.Get Rectangle Area");
                Console.WriteLine("7.Exit");

                Console.WriteLine("Enter your Choice:");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine(obj.GetLength() + " Units");
                        break;
                    case 2:
                        {
                            do
                            {
                                Console.WriteLine("Enter the Length of the Rectangle:");
                                length = Convert.ToInt32(Console.ReadLine());
                            } while (length <= 0);
                            Console.WriteLine(obj.SetLength(length));
                            break;
                        }
                    case 3:
                        Console.WriteLine(obj.GetWidth() + " Units");
                        break;
                    case 4:
                        {
                            do
                            {
                                Console.WriteLine("Enter the Width of the Rectangle:");
                                width = Convert.ToInt32(Console.ReadLine());
                            } while (width <= 0);
                            Console.WriteLine(obj.SetWidth(width));
                            break;
                        }
                    case 5:
                        Console.WriteLine(obj.GetPerimeter() + " Units");
                        break;
                    case 6:
                        Console.WriteLine(obj.GetArea() + " Sqr Units");
                        break;
                    default: break;

                }
                if (choice == 7)
                {
                    break;
                    ch = "n";
                }

            } while (ch == "y" || ch == "Y");

        }
    }
}
