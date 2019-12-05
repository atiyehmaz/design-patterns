using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class SimpleRemoteControl
    {
        Command slot;

        public SimpleRemoteControl()
        {

        }

        public void SetCommand(Command command )
        {
            slot = command;
        }

        public void buttonWasPressed()
        {
            slot.Execute();
        }
    }
}
