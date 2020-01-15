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
            inputHandler.ACommand = null;
            inputHandler.BCommand = null;
            inputHandler.DPad_Horizontal = null;
            inputHandler.DPad_Vertical = null;
            inputHandler.LeftBumper = null;
            inputHandler.RightBumper = null;
        }
    }
}

