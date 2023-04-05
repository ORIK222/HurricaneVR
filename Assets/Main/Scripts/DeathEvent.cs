using System.Collections;
using HurricaneVR.Framework.Core.Player;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Main.Scripts
{
    public class DeathEvent : MonoBehaviour
    {
        [SerializeField] private CharacterController _characterController;
        [SerializeField] private HVRScreenFade _screenFade;

        public void OnDeath()
        {
            _characterController.enabled = false;
            StartCoroutine(nameof(PlayerReset));
        }

        public void ScreenFadeDamage() => StartCoroutine(nameof(GotHit));

        private IEnumerator GotHit()
        {
            _screenFade.Fade(.6f, 2f);
            yield return new WaitForSeconds(.5f);
            _screenFade.Fade(0, 2f);
        }

        private IEnumerator PlayerReset()
        {
            StopCoroutine(nameof(GotHit));
            _screenFade.Fade(1, 1);
            yield return new WaitForSeconds(3f);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}