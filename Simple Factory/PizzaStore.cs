using System;
using System.Collections.Generic;
using System.Text;

namespace Simple_Factory
{
    public class PizzaStore
    {
        SimplePizzaFactory factory;
        public PizzaStore(SimplePizzaFactory factory)
        {
            this.factory = factory;
        }

        public Pizza OrderPizza(string type)
        {
            Pizza pizza;
            pizza = factory.CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

           string ss= pizza.Prepare();
            return pizza;
        }
    }
}
