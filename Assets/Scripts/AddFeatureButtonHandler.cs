using System.Linq;
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
            var currentFeatures = cars.SelectedCar.features;
            var tmpFeatures = currentFeatures.ToList();
            tmpFeatures.Add(featureList.features[selectedFeatureIndex.value]);
            cars.SelectedCar.features = tmpFeatures.ToArray();
        }
    }
}