using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_Pattern
{
    public class Mocha: CondimentDecorator
    {
        Beverage beverage;

        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string getDescription()
        {
            return beverage.getDescription()+ " ,Mocha";
        }

        public override double Cost()
        {
            return 1000 + beverage.Cost();
        }

        
    }
}
