using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public abstract class Pizza
    {
        public abstract string Bake();

        public abstract string Cut();

        public abstract string Prepare();

        public abstract string Box();
    }
}
