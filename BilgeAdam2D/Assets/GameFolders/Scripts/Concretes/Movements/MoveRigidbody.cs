using System.Collections;
using System.Collections.Generic;
using BilgeAdam2D.Abstracts.Movements;
using BilgeAdam2D.Controllers;
using UnityEngine;

namespace BilgeAdam2D.Movements
{
    public class MoveRigidbody : IMover
    {
         Rigidbody2D _rigidbody;

         public MoveRigidbody(PlayerController player)
         {
             _rigidbody = player.GetComponent<Rigidbody2D>();
         }

         public void MoveAction(float horizontal, float moveSpeed)
         {
             if (horizontal != 0f || _rigidbody.velocity != Vector2.zero)
             {
                 _rigidbody.velocity = new Vector2(horizontal * moveSpeed * Time.deltaTime, _rigidbody.velocity.y);
             }
         }
    }    
}

