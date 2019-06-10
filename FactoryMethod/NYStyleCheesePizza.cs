using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class NYStyleCheesePizza: Pizza
    {
        public override string Bake()
        {
            return ",bake NYStyleCheesePizza";
        }

        public override string Box()
        {
            return ",box NYStyleCheesePizza";
        }

        public override string Cut()
        {
            return ",cut NYStyleCheesePizza";
        }

        public override string Prepare()
        {
            return ",prepare NYStyleCheesePizza";
        }
    }
}
