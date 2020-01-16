using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputSystem
{
    class BuildQueueCommands : ICommands
    {
        public void Execute(InputHandler inputHandler)
        {
            inputHandler.ACommand = new SharedCommands.EmptyImpulseCommand();
            inputHandler.BCommand = new SharedCommands.EmptyImpulseCommand();
            inputHandler.DPad_Horizontal = new SharedCommands.EmptyDirectionCommand();
            inputHandler.DPad_Vertical = new SharedCommands.EmptyDirectionCommand();
            inputHandler.LeftBumper = new SharedCommands.EmptyImpulseCommand();
            inputHandler.RightBumper = new SharedCommands.EmptyImpulseCommand();
        }
    }
}

