using System.Collections;
using System.Collections.Generic;
using BilgeAdam2D.Abstracts.Controllers;
using BilgeAdam2D.Controllers;
using UnityEngine;

namespace BilgeAdam2D.Animations
{
    public class CharacterAnimation
    {
        private Animator _animator;

        public CharacterAnimation(IEntityController entity)
        {
            _animator = entity.transform.GetComponent<Animator>();
        }

        public void MoveAnimation(float moveSpeed)
        {
            if (moveSpeed == _animator.GetFloat("moveSpeed")) return;
            
            _animator.SetFloat("moveSpeed",moveSpeed);
        }

        public void AttackAnimation()
        {
            _animator.SetTrigger("attack");
        }

        public void DeadAnimation()
        {
            _animator.SetTrigger("die");
        }
    }    
}

