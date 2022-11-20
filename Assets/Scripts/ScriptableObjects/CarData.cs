using System.Linq;
using UnityEngine;

namespace CarConfigurator.ScriptableObjects
{
    [CreateAssetMenu(menuName = "Variables/Cars/Car Data")]
    public class CarData: ScriptableObject
    {
        public string model;
        public GameObject modelPrefab;
        public Color colour;
        public double basePrice;
        public CarFeature[] features;

        [SerializeField]
        private CarFeature[] backupFeatures;

        private void OnEnable()
        {
            backupFeatures = features.ToArray();
        }
        
        private void OnDisable()
        {
            features = backupFeatures;
        }

        public double Total => basePrice + features.Sum(x => x.price);
    }
}