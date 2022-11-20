using UnityEngine;

namespace CarConfigurator.ScriptableObjects
{
    [CreateAssetMenu(menuName = "Variables/Cars/Feature List")]
    public class FeatureList : ScriptableObject
    {
        public CarFeature[] features;
    }
}