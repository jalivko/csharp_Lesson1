using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите рост в метрах:");
            float height;
            while (!float.TryParse(Console.ReadLine(), out height))
            {
                Console.WriteLine("Рост должен быть целым числом!");
            }

            Console.WriteLine("Введите вес в кг:");
            int weight;
            while (!int.TryParse(Console.ReadLine(), out weight))
            {
                Console.WriteLine("Вес должен быть целым числом!");
            }

            float imt = weight / (height * height);
            Console.WriteLine("Индекс массы тела: {0:F2}", imt);

            Console.ReadLine();
        }
    }
}
