using System;

namespace Variables2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();

            Console.WriteLine("What city do you live in?");
            var cityName = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            var colorName = Console.ReadLine();

            Console.WriteLine("What kind of car do you drive");
            string carName = Console.ReadLine();

            Console.WriteLine("What is your favorite thing to do?");
            string favThingTodo = Console.ReadLine();

            Console.WriteLine("How do you feel");
            string yourMood = Console.ReadLine();

            Console.WriteLine($"There used to be a guy named {yourName}.  He liked to go to {cityName} when he was {yourMood}.");

            Console.WriteLine($"{yourName} liked to {favThingTodo} his {colorName} {carName} to {cityName} when he was {yourMood}.");

            Console.WriteLine($"{yourName} turns {colorName} and {favThingTodo} his {cityName} {carName} when he is {yourMood}");
        }
    }
}
