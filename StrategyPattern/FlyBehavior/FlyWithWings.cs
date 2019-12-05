using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class FlyWithWings : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("implements duck flying");
        }
    }
}
