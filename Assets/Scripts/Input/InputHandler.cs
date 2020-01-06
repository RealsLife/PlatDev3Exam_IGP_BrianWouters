using UnityEngine;
using UnityInput = UnityEngine.Input;

namespace Input
{
    public class InputHandler : MonoBehaviour
    {
        public IImpulseCommand ACommand;
        public IImpulseCommand BCommand;
        public IImpulseCommand RightBumper;
        public IImpulseCommand LeftBumper;
        public IVerticalDirectionCommand DPad_Horizontal;

        public void Update()
        {

            if (UnityInput.GetButtonDown("A"))
            {
                Debug.Log("test A");
                //ACommand.Execute();
            }

            if (UnityInput.GetButtonDown("B"))
            {
                Debug.Log("test B");
            }

            if (UnityInput.GetButtonDown("RightBumper"))
            {
                Debug.Log("test right");
                //RightBumper.Execute();
            }

            if (UnityInput.GetButtonDown("LeftBumper"))
            {
                Debug.Log("test left");
                //RightBumper.Execute();
            }

            //if()


            //float D-Pad
            //Vector2 directionRight = new Vector2(UnityInput.GetAxis("D-Pad_Horizontal"), UnityInput.GetAxis("D-Pad_Vertical"));

            //RightJoyStickCommand.Execute(directionRight);
        }
    }
}
