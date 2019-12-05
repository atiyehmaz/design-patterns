using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class Quack : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("duck quacking");
        }
    }
}
