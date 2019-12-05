using System;
using System.Linq;

namespace SimpleFactory
{
    class Program
    {

        static void Main(string[] args)
        {
            SimplePizzaFactory factory = new SimplePizzaFactory();
            PizzaStore pizzaStore = new PizzaStore(factory);
            Pizza pizza = pizzaStore.OrderPizza("cheese");


            Console.WriteLine(pizza.Prepare() + "\n" + pizza.Bake() + "\n" + pizza.Cut() + "\n" + pizza.Box());


            Console.ReadKey();
        }
    }
}
