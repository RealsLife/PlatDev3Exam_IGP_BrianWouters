using UnityEngine;
using UnityInput = UnityEngine.Input;

namespace Input
{
    public class InputHandler
    {
        public IImpulseCommand ACommand;
        public IImpulseCommand BCommand;
        public IImpulseCommand RightBumper;
        public IImpulseCommand LeftBumper;
        public IDirectionCommand DPad_Vertical;
        public IDirectionCommand DPad_Horizontal;
        public void Update()
        {

            if (UnityInput.GetButtonDown("A"))
            {
                ACommand.Execute();
            }

            if (UnityInput.GetButtonDown("B"))
            {
                BCommand.Execute();
            }

            if (UnityInput.GetButtonDown("RightBumper"))
            {
                RightBumper.Execute();
            }

            if (UnityInput.GetButtonDown("LeftBumper"))
            {
                RightBumper.Execute();
            }

            DPad_Vertical.Execute(UnityInput.GetAxisRaw("D-Pad_Horizontal"));
            DPad_Horizontal.Execute(UnityInput.GetAxisRaw("D-Pad_Vertical"));
        }
    }
}
