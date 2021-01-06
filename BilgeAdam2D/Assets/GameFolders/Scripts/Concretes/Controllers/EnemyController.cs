using System;
using System.Collections;
using System.Collections.Generic;
using BilgeAdam2D.Abstracts.Controllers;
using BilgeAdam2D.Animations;
using BilgeAdam2D.Combats;
using UnityEngine;

namespace BilgeAdam2D.Controllers
{
    public class EnemyController : MonoBehaviour , IEntityController
    {
        private Health _health;
        private CharacterAnimation _animation;

        private void Awake()
        {
            _health = GetComponent<Health>();
            _animation = new CharacterAnimation(this);
        }

        private void OnEnable()
        {
            _health.OnDead += HandleOnDead;
        }

        private void OnDisable()
        {
            _health.OnDead -= HandleOnDead;
        }

        private void HandleOnDead()
        {
            _animation.DeadAnimation();
        }
    }    
}

