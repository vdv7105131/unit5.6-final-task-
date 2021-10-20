using System;

namespace unit5._6
{
    class Program
    {
        static void Main(string[] args)
        {
            UserWorksheet();
        }

        static (string name, string lastName, int age, string animal, int animalCount, int countColor) UserWorksheet()
        {
            (string name,       // имя
             string lastName,   // фамилия
             int age,           // возраст
             string animal,     // наличие питомца
             int animalCount,   // количество питомцев
             int countColor     // количество любимых цветов
             ) user;

            Console.WriteLine("Как Вас зовут?");
            user.name = Console.ReadLine();

            Console.WriteLine("Назовите фамилию");
            user.lastName = Console.ReadLine();

            Console.WriteLine("Сколько Вам лет?");
            user.age = int.Parse(Console.ReadLine());   // ввод числа
            user.age = TryParse(user.age);              // проверка на ноль

            Console.WriteLine("Есть ли у Вас питомцы? да/нет");
            user.animal = Console.ReadLine();
            if (user.animal == "да")
            {
                Console.WriteLine("Сколько питомцев?");
                user.animalCount = int.Parse(Console.ReadLine());   // ввод числа
                user.animalCount = TryParse(user.animalCount);      // проверка на ноль
                Count(user.animalCount); // вывод массива любимых цветов
            }
            else user.animalCount = 0;

            Console.WriteLine("Введите кол-во любимых цветов");
            user.countColor = int.Parse(Console.ReadLine());    // ввод числа
            user.countColor = TryParse(user.countColor);        // проверка на ноль
            Console.WriteLine("Какие Ваши любимые цвета?");
            Count(user.countColor); // вывод массива любимых цветов

            PrintSheet(user.name, user.lastName, user.age, user.animal, user.animalCount, user.countColor);

            return user;
        }
        // возрат массива значений
        static string[] Count(int count)
        {
            string[] iCount = new string[count];
            for (int i = 0; i < iCount.Length; i++)
            {
                iCount[i] = Console.ReadLine();
            }
            Console.WriteLine("Вывод указанных значений:");
            for (int i = 0; i < iCount.Length; i++)
            {
                Console.WriteLine(iCount[i] + " ");
            }

            return iCount;
        }
        // проверка на ноль
        static int TryParse(int i)
        {
            if (i == 0)
            {
                Console.WriteLine("Вводимое число должно быть больше нулю, введите число повторно:");
                i = int.Parse(Console.ReadLine());
                TryParse(i);
            }
            else if (i < 0)
            {
                Console.WriteLine("Вводимое число должно быть больше нулю, введите число повторно:");
                i = int.Parse(Console.ReadLine());
                TryParse(i);
            }
            return i;
        }

        // вывод на экран
        static void PrintSheet(string name, string lastName, int age, string animal, int animalCount, int countColor)
        {
            Console.WriteLine($"имя: {name}");
            Console.WriteLine($"фамилия: {lastName}");
            Console.WriteLine($"возраст: {age}");
            Console.WriteLine($"наличие животных: {animal}");
            Console.WriteLine($"кол-во животных: {animalCount}");
            Console.WriteLine($"кол-во любимых цветов: {countColor}");
        }

    }

}
