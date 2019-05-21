using System;

namespace Decorator_Pattern
{
    class Program
    {
        static void Main(string[] args)
          {
            //    Beverage beverage = new Espresso();

            //    Console.WriteLine(beverage.getDescription() + "$" + beverage.Cost());

            Beverage beverage2 = new HouseBlend();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Soy(beverage2);

            Console.WriteLine(beverage2.getDescription() + "$" + beverage2.Cost());

            Console.ReadKey();
            
        }
    }
}
