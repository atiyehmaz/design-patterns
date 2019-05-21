using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_Pattern
{
    public class Soy: CondimentDecorator
    {
        Beverage beverage;
        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string getDescription()
        {
            return beverage.getDescription() + " ,Soy";
        }

        public override double Cost()
        {
            return 500 + beverage.Cost();
        }
    }
}
