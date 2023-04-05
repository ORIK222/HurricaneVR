using System;
using EmeraldAI.Example;
using UnityEngine;
using UnityEngine.UI;

namespace Main.Scripts
{
    public class HealthBar : MonoBehaviour
    {
        [SerializeField] private EmeraldAIPlayerHealth _emeraldAIPlayerHealth;
        
        private Slider _slider;

        private float _currentHealth;

        private void Awake() => _slider = GetComponent<Slider>();

        private void Start()
        {
            _slider.maxValue = _emeraldAIPlayerHealth.CurrentHealth;
            // _slider.value = _emeraldAIPlayerHealth.CurrentHealth;
        }

        private void Update()
        {
            _slider.value = _emeraldAIPlayerHealth.CurrentHealth;
        }
    }
}
