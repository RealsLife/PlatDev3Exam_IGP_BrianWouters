using UnityEngine;
using UnityInput = UnityEngine.Input;
using System.Collections.Generic;
using InputSystem;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitChoiceSystem;
using UnityEngine;

namespace InputSystem
{
    public class InputHandler
    {
        public IImpulseCommand ACommand;
        public IImpulseCommand BCommand;
        public IImpulseCommand RightBumper;
        public IImpulseCommand LeftBumper;
        public IDirectionCommand DPad_Vertical;
        public IDirectionCommand DPad_Horizontal;
        float _delay = 0;
        float _timer = 0.2f;
        public void Update()
        {
            _delay -= Time.deltaTime;

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
           
            if(_delay <= 0)
            {
                if(UnityInput.GetAxisRaw("DPad_Vertical") > 0 || UnityInput.GetAxisRaw("DPad_Vertical") < 0)
                {
                   
                    DPad_Vertical.Execute(UnityInput.GetAxisRaw("DPad_Vertical"));
                    _delay = _timer;
                }
                
                if(UnityInput.GetAxisRaw("DPad_Horizontal") > 0 || UnityInput.GetAxisRaw("DPad_Horizontal") < 0)
                {
                    DPad_Horizontal.Execute(UnityInput.GetAxisRaw("DPad_Horizontal"));
                    _delay = _timer;
                }
                
            }   
        }


    }
}
