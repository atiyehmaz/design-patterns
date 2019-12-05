using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class ModelDuck: Duck
    {
        public ModelDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new Quack();
        }
        public override void display()
        {
            Console.WriteLine("I’m a model duck");
        }       

        public override void swim()
        {
            throw new NotImplementedException();
        }
    }
}
