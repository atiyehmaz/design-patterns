using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class MuteQuack : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("do nothing - can’t quack!");
        }
    }
}
