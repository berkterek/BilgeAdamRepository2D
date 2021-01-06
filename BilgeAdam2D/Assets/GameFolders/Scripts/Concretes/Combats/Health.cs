using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BilgeAdam2D.Combats
{
    public class Health : MonoBehaviour
    {
        [SerializeField] private int _maxHealth;
        [SerializeField] private int _currentHealth;

        public event System.Action OnDead;
        
        public bool IsDead => _currentHealth <= 0;

        private void Awake()
        {
            _currentHealth = _maxHealth;
        }

        public void TakeHit(Attacker attacker)
        {
            if (IsDead) return;

            _currentHealth -= attacker.Damage;

            if (IsDead)
            {
                StartCoroutine(DieAsync());
            }
        }

        private IEnumerator DieAsync()
        {
            OnDead?.Invoke();
            
            yield return new WaitForSeconds(3);

            Destroy(this.gameObject);
        }
    }
}