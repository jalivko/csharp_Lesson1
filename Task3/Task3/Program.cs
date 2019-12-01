using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x1: ");
            double x1;
            while (!double.TryParse(Console.ReadLine(), out x1))
            {
                Console.WriteLine("Нужно число!");
                Console.Write("x1: ");
            }

            Console.Write("y1: ");
            double y1;
            while (!double.TryParse(Console.ReadLine(), out y1))
            {
                Console.WriteLine("Нужно число!");
                Console.Write("y1: ");
            }

            Console.Write("x2: ");
            double x2;
            while (!double.TryParse(Console.ReadLine(), out x2))
            {
                Console.WriteLine("Нужно число!");
                Console.Write("x2: ");
            }

            Console.Write("y2: ");
            double y2;
            while (!double.TryParse(Console.ReadLine(), out y2))
            {
                Console.WriteLine("Нужно число!");
                Console.Write("y2: ");
            }

            Console.Write("Расстояние = {0:F2}", GetDistance(x1, y1, x2, y2));
            Console.ReadLine();
        }


        static double GetDistance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}
