using UnityEngine;
using UnityEngine.Events;

namespace Healths
{
    public class Health : MonoBehaviour
    {
        public int health;

        [Header("Events")]

        public UnityEvent OnBorn;

        public UnityEvent OnDead;

        public UnityEvent OnTakeDamage;

        public UnityEvent OnHealing;



        private int maxHealth;
        public int MaxHealth { get => maxHealth; }

        private int currentHealth;

        public int CurrentHealth { get => currentHealth; }

        private void Start()
        {
            maxHealth = health;
            currentHealth = health;

            OnBorn?.Invoke();

        }

        public void TakeDamage(int damage)
        {
            currentHealth -= damage;

            OnTakeDamage?.Invoke();

            if (currentHealth < 0)
            {
                OnDead?.Invoke();
            }
        }

        public void Healing(int healingAmount)
        {
            currentHealth += healingAmount;
            currentHealth = Mathf.Clamp(currentHealth, 0, MaxHealth);
            OnHealing?.Invoke();
        }
    }
}
