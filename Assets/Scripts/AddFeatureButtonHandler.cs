using CarConfigurator.ScriptableObjects;
using UnityEngine;

namespace CarConfigurator
{
    public class AddFeatureButtonHandler : MonoBehaviour
    {
        [SerializeField]
        private CarList cars;

        [SerializeField]
        private FeatureList featureList;

        [SerializeField]
        private IntVariable selectedFeatureIndex;

        public void OnClick()
        {
            var currentFeatures = cars.SelectedCar.featureList;
            currentFeatures.Add(featureList.features[selectedFeatureIndex.value]);
        }
    }
}