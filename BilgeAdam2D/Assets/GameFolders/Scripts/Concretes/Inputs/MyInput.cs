using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace BilgeAdam2D.Inputs
{
    public class MyInput
    {
        DefaultControl _defaultInput;

        public float Horizontal { get; private set; }

        public MyInput(DefaultControl input)
        {
            _defaultInput = input;
            
            _defaultInput.PlayerOnFoot.Move.performed += MoveOnperformed; 
            
            _defaultInput.Enable();
        }

        private void MoveOnperformed(InputAction.CallbackContext context)
        {
            Horizontal = context.ReadValue<float>();
        }
    }    
}
