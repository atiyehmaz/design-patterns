using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class ChicagoStyleCheesePizza : Pizza
    {
        public override string Bake()
        {
            return ",bake ChicagoCheesePizza";

        }

        public override string Box()
        {
            return ",bake ChicagoCheesePizza";

        }

        public override string Cut()
        {
            return ",bake ChicagoCheesePizza";

        }

        public override string Prepare()
        {
            return ",bake ChicagoCheesePizza";

        }
    }
}
