using UnityEngine;

namespace CarConfigurator.ScriptableObjects
{
    [CreateAssetMenu(menuName = "Variables/Cars/List")]
    public class CarList : ScriptableObject
    {
        public CarData[] cars;
        public CarData SelectedCar => cars[selectedCarIndex.value];
        public IntRangeVariable selectedCarIndex;

        private void OnEnable()
        {
            selectedCarIndex.max = cars.Length - 1;
        }
    }
}