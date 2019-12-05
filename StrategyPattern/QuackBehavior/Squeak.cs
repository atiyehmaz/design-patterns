using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class Squeak : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("rubber duckie squeak");
        }
    }
}
