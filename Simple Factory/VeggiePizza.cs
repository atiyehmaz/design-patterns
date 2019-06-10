using System;
using System.Collections.Generic;
using System.Text;

namespace Simple_Factory
{
    public class VeggiePizza: Pizza
    {
        public override string Bake()
        {
            return ", Bake Veggie pizza";
        }

        public override string Box()
        {
            return ", Box Veggie pizza";

        }

        public override string Cut()
        {
            return ", Cut Veggie pizza";

        }

        public override string Prepare()
        {
            return ", Prepare Veggie pizza";

        }
    }
}
