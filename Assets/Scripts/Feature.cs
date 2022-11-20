using CarConfigurator.ScriptableObjects;
using TMPro;
using UnityEngine;

namespace CarConfigurator
{
    public class Feature : MonoBehaviour
    {
        [SerializeField]
        private new TextMeshProUGUI name;

        [SerializeField]
        private TextMeshProUGUI price;

        public void Set(CarFeature feature)
        {
            name.text = feature.featureName;
            price.text = Helpers.FormatCurrencyValue(feature.price);
        }
    }
}
