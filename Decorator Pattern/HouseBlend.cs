using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_Pattern
{
    public class HouseBlend : Beverage
    {
        public override string Description { get;}

        public HouseBlend()
        {
            Description = "House Blend Coffee";
        }

        public override double Cost()
        {
            return 2000;
        }
    }
}
