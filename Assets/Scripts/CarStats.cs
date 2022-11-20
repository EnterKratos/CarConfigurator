using CarConfigurator.ScriptableObjects;
using UnityEngine;

namespace CarConfigurator
{
    public class CarStats : MonoBehaviour
    {
        public CarList cars;

        [SerializeField]
        private SetText model;

        [SerializeField]
        private SetText basePrice;

        [SerializeField]
        private SetText total;

        [SerializeField]
        private RectTransform featuresListOrigin;

        [SerializeField]
        private GameObject featurePrefab;

        private void OnEnable()
        {
            OnCarChanged();
        }

        public void OnCarChanged()
        {
            SetCarData(cars.SelectedCar);
        }

        public void SetCarData(CarData carData)
        {
            model.Set(carData.model);
            basePrice.Set(Helpers.FormatCurrencyValue(carData.basePrice));

            foreach (Transform child in featuresListOrigin.transform)
            {
                Destroy(child.gameObject);
            }

            var featureHeight = 0.0F;
            var featureCount = cars.SelectedCar.featureList.Count;
            for (var i = 0; i < featureCount; i++)
            {
                featureHeight = CreateFeatureUI(featurePrefab, featuresListOrigin, i);
            }

            UpdateOriginHeight(featuresListOrigin, featureCount, featureHeight);

            total.Set(Helpers.FormatCurrencyValue(carData.Total));
        }

        private void UpdateOriginHeight(RectTransform originRectTransform, int featureCount, float featureHeight)
        {
            var sizeDelta = originRectTransform.sizeDelta;
            sizeDelta.y = featureCount * featureHeight;
            originRectTransform.sizeDelta = sizeDelta;
        }

        private float CreateFeatureUI(GameObject prefab, RectTransform listOrigin, int index)
        {
            var featureInstance = Instantiate(prefab, Vector3.zero, Quaternion.identity, listOrigin);
            var rectTransform = featureInstance.GetComponent<RectTransform>();
            rectTransform.SetLocalPositionAndRotation(new Vector3(0, -rectTransform.rect.height * index + 1, 0), Quaternion.identity);

            var feature = featureInstance.GetComponent<Feature>();
            feature.Set(cars.SelectedCar.featureList[index]);

            return rectTransform.rect.height;
        }
    }
}
