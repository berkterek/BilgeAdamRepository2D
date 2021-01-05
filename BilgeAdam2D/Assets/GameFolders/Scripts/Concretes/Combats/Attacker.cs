using System;
using System.Collections;
using System.Collections.Generic;
using BilgeAdam2D.Animations;
using UnityEngine;

namespace BilgeAdam2D.Combats
{
    public class Attacker : MonoBehaviour
    {
        [SerializeField] private int _damage;
        [SerializeField] private Transform _attackDirection;
        [SerializeField] private float _radius;

        public int Damage => _damage;

        private Collider2D[] _colliders;

        private void Awake()
        {
            _colliders = new Collider2D[10];
        }

        private void OnEnable()
        {
            GetComponent<AnimationInpactWatcher>().OnImpact += HandleOnImpact;
        }

        private void OnDisable()
        {
            GetComponent<AnimationInpactWatcher>().OnImpact -= HandleOnImpact;
        }

        private void OnDrawGizmos()
        {
            OnDrawGizmosSelected();
        }

        private void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(_attackDirection.position,_radius);
        }
        
        private void Attack(Health health)
        {
            health.TakeHit(this);
        }
        
        private void HandleOnImpact()
        {
            int count = Physics2D.OverlapCircleNonAlloc(_attackDirection.position, _radius, _colliders);

            for (int i = 0; i < count; i++)
            {
                Health health = _colliders[i].GetComponent<Health>();

                if (health != null)
                {
                    Attack(health);
                }
            }
        }
    }    
}

