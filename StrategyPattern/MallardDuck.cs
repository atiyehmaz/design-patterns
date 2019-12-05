using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            quackBehavior = new Quack();
            flyBehavior = new FlyWithWings();
        }

        public override void display()
        {
            throw new NotImplementedException();
        }

        public override void swim()
        {
            throw new NotImplementedException();
        }
    }
}
