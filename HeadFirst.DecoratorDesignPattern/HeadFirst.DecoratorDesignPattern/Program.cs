using System;

namespace HeadFirst.DecoratorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new DarkRoast();
            beverage = new Mocha(beverage);
            beverage = new Mocha(beverage);
            beverage = new Whip(beverage);

            Console.WriteLine($"Cost:{beverage.cost()} Description:{beverage.getDescription()}");
        }
    }
}
