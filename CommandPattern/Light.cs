using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class Light
    {
        public virtual void On() 
        {
            Console.WriteLine("light is on");
        }

        public virtual void Off()
        {
            Console.WriteLine("light is off");
        }

    }
}
