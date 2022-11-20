using CarConfigurator.ScriptableObjects;
using UnityEngine;

namespace CarConfigurator
{
    public class RemoveFeatureButtonHandler : MonoBehaviour
    {
        [SerializeField]
        private CarList cars;
        
        [SerializeField]
        private Feature feature;

        public void OnClick()
        {
            var currentFeatures = cars.SelectedCar.featureList;
            currentFeatures.RemoveAt(feature.Index);
        }
    }
}