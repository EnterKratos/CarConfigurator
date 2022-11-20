using CarConfigurator.ScriptableObjects;
using UnityEngine;

namespace CarConfigurator
{
    public class PrintPreviewFeatureRow : MonoBehaviour
    {
        [SerializeField]
        private SetText feature;

        [SerializeField]
        private SetText price;

        public void Set(CarFeature carFeature)
        {
            feature.Set(carFeature.featureName);
            price.Set(Helpers.FormatCurrencyValue(carFeature.price));
        }
    }
}