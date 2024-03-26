using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    public class LightCommand : CommandBase
    {
        private Light light;

        public LightCommand(Light light)
        {
            this.light = light;
        }

        public override void ExecuteOn()
        {
            this.light.On();
            this._state = CommandState.On;
        }

        public override void ExecuteOff()
        {
            this.light.Off();
            this._state = CommandState.Off;
        }

        public override void ExecuteUndo()
        {
            if (this._state == CommandState.On)
            {
                this.ExecuteOff();
                this._state = CommandState.Off;
            }
            else
            {
                this.ExecuteOn();
                this._state = CommandState.On;
            }
        }

        public override void ExecuteRedo()
        {
            if (this._state == CommandState.On)
            {
                this.ExecuteOn();
                this._state = CommandState.On;
            }
            else
            {
                this.ExecuteOff();
                this._state = CommandState.Off;
            }
        }
    }
}
