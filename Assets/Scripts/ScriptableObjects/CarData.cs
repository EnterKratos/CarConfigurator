using System.Collections.Generic;
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
        public List<CarFeature> featureList;

        [SerializeField]
        private List<CarFeature> backupFeatures;

        private void OnEnable()
        {
            backupFeatures = featureList.ToList();
        }

        private void OnDisable()
        {
            featureList = backupFeatures;
        }

        public double Total => basePrice + featureList.Sum(x => x.price);
    }
}