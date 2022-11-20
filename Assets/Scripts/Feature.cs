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

        [SerializeField]
        [HideInInspector]
        private int index;
        public int Index => index;

        public void Set(int featureIndex, CarFeature feature)
        {
            index = featureIndex;
            name.text = feature.featureName;
            price.text = Helpers.FormatCurrencyValue(feature.price);
        }
    }
}
