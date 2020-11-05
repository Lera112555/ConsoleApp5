using System;

namespace ConsoleApp5
{
    class Program
    {

        static void Main(string[] args)
        {
            Cat cat = new Cat("Kit", new DateTime(2005, 8, 7));

            Console.WriteLine($"Коту по имени {cat.Name} уже {cat.GetAge()} лет");

            cat.HungryStatus = 150;

            Console.ReadLine();

        }


    }
}
