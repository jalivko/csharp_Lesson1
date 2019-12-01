using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            int a;
            while (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Допустимы только целые числа!");
                Console.Write("a = ");
            }

            Console.Write("b = ");
            int b;
            while (!int.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Допустимы только целые числа!");
                Console.Write("b = ");
            }

            Console.WriteLine("Замена...");
            (a, b) = (b, a);

            Console.WriteLine($"a = {a}; b = {b}");
            Console.ReadKey();
        }
    }
}
