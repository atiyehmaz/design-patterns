using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class NYStylePizzaStore : PizzaStore
    {
        Pizza pizza = null;
        public override Pizza CreatePizza(string type)
        {
            if (type.Equals("cheese"))
            {
                pizza = new NYStyleCheesePizza();
            }
            else if(type.Equals("peperoni"))
            {
                pizza = new NYStylePeperoniPizza();
            }

            return pizza;
        }
    }
}
