using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputSystem
{
        class SharedCommands
        {
            public class EmptyDirectionCommand : IDirectionCommand
            {
                public void Execute(float direction)
                {
                }
            }

            public class EmptyImpulseCommand : IImpulseCommand
            {
                public void Execute()
                {
                }
            }
        }
}
