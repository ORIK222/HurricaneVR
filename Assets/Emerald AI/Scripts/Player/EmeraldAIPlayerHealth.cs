using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using EmeraldAI.CharacterController;
using Main.Scripts;

namespace EmeraldAI.Example
{
    /// <summary>
    /// An example health script that the EmeraldAIPlayerDamage script calls.
    /// Various events can be created and used to cause damage to a 3rd party character controllers via the inspector.
    /// You can also edit the EmeraldAIPlayerDamage script directly and add custom functions.
    /// </summary>
    public class EmeraldAIPlayerHealth : MonoBehaviour
    {
        [SerializeField] private HealthBar _healthBar;

        public int CurrentHealth = 100; [Space]
        public UnityEvent DamageEvent;
        public UnityEvent DeathEvent;

        [HideInInspector]
        public int StartingHealth;

        private void Start()
        {
            StartingHealth = CurrentHealth;
            
            _healthBar.SetMaxHealth(StartingHealth);
            _healthBar.SetCurrentHealth(CurrentHealth);
        }

        public void DamagePlayer (int DamageAmount)
        {
            CurrentHealth -= DamageAmount;
            DamageEvent.Invoke();

            if (CurrentHealth <= 0)
            {
                PlayerDeath();
            }

            _healthBar.SetCurrentHealth(CurrentHealth);
        }

        public void PlayerDeath ()
        {
            DeathEvent.Invoke();
        }
    }
}
