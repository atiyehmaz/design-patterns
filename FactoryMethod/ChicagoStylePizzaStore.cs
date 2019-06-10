using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class ChicagoStylePizzaStore: PizzaStore
    {
        Pizza pizza = null;
        public override Pizza CreatePizza(string type)
        {
            if (type.Equals("cheese"))
            {
                pizza = new ChicagoStyleCheesePizza();
            }
            else if (type.Equals("peperoni"))
            {
                pizza = new ChicagoStylePeperoniPizza();
            }

            return pizza;
        }
    }
}
