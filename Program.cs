using System;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal zebra = new Zebra() { Type="Zebra", Age=6, Gender="Male", Height=1.5, Weight=400};
            zebra.DisplayInfo();

            Console.WriteLine("=============");

            Animal lion = new Lion() { Type = "Lion", Age = 8, Gender = "Male", Height = 1.2, Weight = 190 };
            lion.DisplayInfo();

            Console.WriteLine("=============");

            Animal monkey = new Monkey() { Type = "Monkey", Age = 15, Gender = "Female", Height = 0.8, Weight = 7.7 };
            monkey.DisplayInfo();

        }
    }
}
