using System.Collections;
using System.Collections.Generic;
using System.Timers;
using BilgeAdam2D.Abstracts.Movements;
using BilgeAdam2D.Controllers;
using UnityEngine;

namespace BilgeAdam2D.Movements
{
    public class MoveTransform : IMover
    {
        PlayerController _player;
        
        public MoveTransform(PlayerController player)
        {
            _player = player;
        }
        
        public void MoveAction(float horizontal, float moveSpeed)
        {
            if (horizontal == 0f) return;
            
            _player.transform.Translate(Vector2.right * horizontal * moveSpeed * Time.deltaTime);
        }
    }    
}

