using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    public abstract class CommandBase
    {
        public enum CommandState
        {
            On,
            Off
        }

        protected CommandState _state = CommandState.Off;

        public abstract void ExecuteOn();
        public abstract void ExecuteOff();
        public abstract void ExecuteUndo();
        public abstract void ExecuteRedo();
    }
}
