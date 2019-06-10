using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore NYStore =new NYStylePizzaStore();

            Pizza pizza1 = NYStore.OrderPizza("cheese");

            PizzaStore chicagoStore = new ChicagoStylePizzaStore();
            Pizza pizza2 = chicagoStore.OrderPizza("peperoni");

            Console.WriteLine(pizza1.Prepare() + "\n" + pizza1.Bake() +
                              "\n" + pizza1.Cut() + "\n" + pizza1.Box());

            Console.WriteLine("*************************");

            Console.WriteLine(pizza2.Prepare() + "\n" + pizza2.Bake() +
                              "\n" + pizza2.Cut() + "\n" + pizza2.Box());

            Console.ReadKey();
        }
    }
}

