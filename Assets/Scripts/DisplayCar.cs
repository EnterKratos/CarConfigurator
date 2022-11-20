using CarConfigurator.ScriptableObjects;
using UnityEngine;

namespace CarConfigurator
{
    public class DisplayCar : MonoBehaviour
    {
        [SerializeField]
        private CarList cars;

        [SerializeField]
        private Vector3 spawnPosition = Vector3.zero;

        [SerializeField]
        private Vector3 spawnScale = Vector3.one;

        private void OnEnable()
        {
            OnCarChanged();
        }

        public void OnCarChanged()
        {
            UpdateCar(cars.SelectedCar);
        }

        private void UpdateCar(CarData carData)
        {
            foreach (Transform child in transform)
            {
                Destroy(child.gameObject);
            }

            var car = Instantiate(carData.modelPrefab, spawnPosition, Quaternion.identity, transform);
            car.transform.localScale = spawnScale;
        }
    }
}
