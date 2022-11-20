using CarConfigurator.ScriptableObjects;
using TMPro;
using UnityEngine;

namespace CarConfigurator
{
    public class Feature : MonoBehaviour
    {
        public float offset = 0;

        [SerializeField]
        private new TextMeshProUGUI name;

        [SerializeField]
        private TextMeshProUGUI price;

        public void Set(CarFeature feature)
        {
            name.text = feature.featureName;
            price.text = $"£{feature.price}";
        }
    }
}
