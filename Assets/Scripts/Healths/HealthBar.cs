using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

namespace Healths
{
    public class HealthBar : MonoBehaviour
    {
        [SerializeField] Health health;

        [Header("Fiil Bar Image")]

        [SerializeField] Image healthBarFilImage;

        [Header("Health Bar Canvas GameObject")]

        [SerializeField] GameObject canvasGameObject;

        private const float FILL_DURATION=0.25f;


        public void SetHealthBarRatio() 
         {
            if (healthBarFilImage == null)
            {
                return;
            }
            healthBarFilImage.DOFillAmount(CalculateHealthRatio(), FILL_DURATION);

        }

        private float CalculateHealthRatio()
        {
            return (float)health.CurrentHealth / (float)health.MaxHealth;
        }

        public void CloseCanvas()
        {
            canvasGameObject.SetActive(false);
        }
    }

}
