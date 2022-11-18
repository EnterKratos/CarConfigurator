using CarConfigurator.ScriptableObjects;
using TMPro;
using UnityEngine;

namespace CarConfigurator
{
    public class CarStats : MonoBehaviour
    {
        [SerializeField]
        private TextMeshProUGUI BasePrice;

        public CarData CarData;

        // TODO: Add event to receive which car to display

        private void Update()
        {
            BasePrice.text = $"£{CarData.BasePrice}";
        }

        public void SetCarData(CarData carData)
        {
            CarData = carData;
        }
    }
}
