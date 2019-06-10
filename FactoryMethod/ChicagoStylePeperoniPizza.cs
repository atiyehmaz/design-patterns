using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class ChicagoStylePeperoniPizza: Pizza
    {
        public override string Bake()
        {
            return ",bake ChicagoPeperoniPizza";

        }

        public override string Box()
        {
            return ",bake ChicagoPeperoniPizza";

        }

        public override string Cut()
        {
            return ",bake ChicagoPeperoniPizza";

        }

        public override string Prepare()
        {
            return ",bake ChicagoPeperoniPizza";

        }
    }
}
