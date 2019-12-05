using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class FlyRocketPowered: IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I’m fl ying with a rocket!");
        }
    }
}
