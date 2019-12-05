using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    public class CheesePizza : Pizza
    {
        public override string Bake()
        {
            return ", Bake cheese pizza";
        }

        public override string Box()
        {
            return ", Box cheese pizza";

        }

        public override string Cut()
        {
            return ", Cut cheese pizza";

        }

        public override string Prepare()
        {
            return ", Prepare cheese pizza";

        }
    }
}
