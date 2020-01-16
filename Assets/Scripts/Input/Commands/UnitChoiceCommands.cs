using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace InputSystem
{
    class UnitChoiceCommands : ICommands
    {
        public void Execute(InputHandler inputHandler)
        {
            inputHandler.ACommand = new BuildCommand();
            inputHandler.BCommand = new SharedCommands.EmptyImpulseCommand();
            inputHandler.DPad_Horizontal = new SharedCommands.EmptyDirectionCommand();
            inputHandler.DPad_Vertical = new MoveCommand();
            inputHandler.LeftBumper = new SharedCommands.EmptyImpulseCommand();
            inputHandler.RightBumper = new SharedCommands.EmptyImpulseCommand();
        }


        public class MoveCommand : IDirectionCommand
        {
            Application _application;
            public MoveCommand()
            {
                _application = Application.Instance;
            }

            public void Execute(float direction)
            {
                _application.UnitChoice.UpdateSelection((int)direction);     
            }
        }
        public class BuildCommand : IImpulseCommand
        {
            Application _application;
            public BuildCommand()
            {
                _application = Application.Instance;
            }

            public void Execute()
            {
                Debug.Log("bouw");
              var BuildThisUnit = _application.UnitChoice.Build();
            //    _application.BuildQueue.Enqueue(BuildThisUnit,5f);
            }
        }
    }


}
