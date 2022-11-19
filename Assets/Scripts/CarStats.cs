using CarConfigurator.ScriptableObjects;
using TMPro;
using UnityEngine;

namespace CarConfigurator
{
    public class CarStats : MonoBehaviour
    {
        public CarList cars;

        [SerializeField]
        private TextMeshProUGUI model;

        [SerializeField]
        private TextMeshProUGUI basePrice;

        private void OnEnable()
        {
            OnCarChanged();
        }

        public void OnCarChanged()
        {
            SetCarData(cars.SelectedCar);
        }

        public void SetCarData(CarData carData)
        {
            model.text = carData.model;
            basePrice.text = $"£{carData.basePrice}";
        }
    }
}
