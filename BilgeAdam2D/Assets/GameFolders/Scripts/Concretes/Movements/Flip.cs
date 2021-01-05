using System.Collections;
using System.Collections.Generic;
using BilgeAdam2D.Controllers;
using UnityEngine;

namespace BilgeAdam2D.Movements
{
    public class Flip
    {
        private PlayerController _player;

        public Flip(PlayerController player)
        {
            _player = player;
        }

        public void SetDirection(float horizontal)
        {
            if (horizontal == 0f) return;

            horizontal = Mathf.Sign(horizontal);

            _player.transform.localScale = new Vector3(horizontal, 1f, 1f);
        }
    }    
}

