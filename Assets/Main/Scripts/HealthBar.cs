using UnityEngine;
using UnityEngine.UI;

namespace Main.Scripts
{
    public class HealthBar : MonoBehaviour
    {
        private Slider _slider;

        private void Awake() => _slider = GetComponent<Slider>();

        public void SetMaxHealth(int maxHealth) => _slider.maxValue = maxHealth;
        public void SetCurrentHealth(int health) => _slider.value = health;
    }
}