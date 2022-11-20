using UnityEngine;

namespace CarConfigurator.ScriptableObjects
{
    [CreateAssetMenu(menuName = "Cars/Car Feature")]
    public class CarFeature: ScriptableObject
    {
        public string featureName;
        public double price;
    }
}