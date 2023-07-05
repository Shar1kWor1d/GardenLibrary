using System;
using GardenLibrary; // Добавлена ссылка на библиотеку с классами Garden и Flower

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание объекта класса Garden
            Garden garden = new Garden
            {
                Address = "Полярная ул. 23",
                Owner = "Змиев Александр", // Фамилия учащегося
                Flowers = new Flower[]
                {
                    new Flower { Title = "Роза", Description = "Удивительный красный цветок" },
                    new Flower { Title = "Тюльпан", Description = "Красочный весенний цветок" },
                    new Flower { Title = "Подсолнух", Description = "Яркий и жизнерадостный цветок" }
                }
            };

            // Показ содержимого сада
            garden.ShowAll();

            // Пример использования метода CompareTo()
            Flower flower1 = new Flower { Title = "Роза", Description = "Удивительный красный цветок" };
            Flower flower2 = new Flower { Title = "Тюльпан", Description = "Красочный весенний цветок" };

            //Выполнение сравнения двух объектов
            int comparisonResult = flower1.CompareTo(flower2);
            Console.WriteLine($"Результат comparison: {comparisonResult}");

            Console.ReadLine();
        }
    }
}