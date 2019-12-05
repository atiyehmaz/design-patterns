using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class FlyNoWay : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("do nothing - can’t fly!");

        }
    }
}
