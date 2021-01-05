using System.Collections;
using System.Collections.Generic;
using BilgeAdam2D.Controllers;
using UnityEngine;

namespace BilgeAdam2D.Movements
{
    public class JumpRigidbody
    {
        private Rigidbody2D _rigidbody;

        public JumpRigidbody(PlayerController player)
        {
            _rigidbody = player.GetComponent<Rigidbody2D>();
        }

        public void JumpAction(float jumpForce)
        {
            _rigidbody.AddForce(Vector2.up * jumpForce);
        }
    }    
}

