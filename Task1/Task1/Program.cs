using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя:");
            string name = Console.ReadLine();

            Console.WriteLine("Введите фамилию:");
            string surname = Console.ReadLine();

            Console.WriteLine("Введите возраст:");
            int age;
            while (!int.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine("Возраст должен быть целым числом!");
            }

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

            Console.WriteLine();

            Console.WriteLine("Результат склеиванием: ");
            Console.WriteLine("    " + name + " " + surname + " возраста " + age + " высотой " + height + " см и весом " + weight + " кг");

            Console.WriteLine();

            Console.WriteLine("Результат форматированный: ");
            Console.WriteLine("    {0} {1} возраста {2} высотой {3} см и весом {4} кг", name, surname, age, height, weight);

            Console.WriteLine();

            Console.WriteLine("Результат используя вывод со знаком $: ");
            Console.WriteLine($"    {name} {surname} возраста {age} высотой {height} см и весом {weight} кг");

            Console.ReadLine();
        }
    }
}
