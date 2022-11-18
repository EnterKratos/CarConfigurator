using UnityEngine;

namespace CarConfigurator.ScriptableObjects
{
    [CreateAssetMenu(menuName = "Cars/Car Data")]
    public class CarData: ScriptableObject
    {
        public string model;
        public Color colour;
        public double basePrice;
        public CarFeature[] features;
    }
}