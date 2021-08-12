using System;

namespace Metoder_opgave_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name");
            string name = Console.ReadLine();
            Console.WriteLine("Age");
            int age = Convert.ToInt32(Console.ReadLine());
            AgeChecker(name, age);
        }
        public static void AgeChecker(string name, int age)
        {
            if (age < 3)
                Console.WriteLine(name + ", you're allowed to wear a diaper");
            else if (age < 15)
                Console.WriteLine(name + ", you're not allowed to do anything");
            else if (age < 18)
                Console.WriteLine(name + ", you're allowed to drink");
            else
                Console.WriteLine(name + ", you're allowed to vote and drive a car");
        }
    }
}
