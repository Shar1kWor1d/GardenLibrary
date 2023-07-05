//Студент Змиев Александр
using System;

namespace GardenLibrary
{
    public class Garden
    {
        public string Address { get; set; }
        public string Owner { get; set; }
        public Flower[] Flowers { get; set; }

        public void ShowAll()
        {
            Console.WriteLine($"Garden Address: {Address}");
            Console.WriteLine($"Owner: {Owner}");
            Console.WriteLine("Flowers:");
            foreach (var flower in Flowers)
            {
                flower.Show();
            }
        }
    }

    public class Flower : IComparable<Flower>
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public void Show()
        {
            Console.WriteLine($"Flower Title: {Title}");
            Console.WriteLine($"Description: {Description}");
        }

        public int CompareTo(Flower other)
        {
            // Реализуйте сравнение двух цветов по вашему выбранному критерию.
            // Например, сравнение по названию цветка (Title).
            return string.Compare(Title, other.Title, StringComparison.InvariantCultureIgnoreCase);
        }
    }
}