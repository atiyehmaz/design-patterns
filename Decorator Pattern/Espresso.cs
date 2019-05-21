using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_Pattern
{
   public class Espresso: Beverage
    {
        public override string Description { get; }
        public Espresso()
        {
            Description = "Espresso";
        }

        public override double Cost()
        {
            return 5000;
        }
    }
}
