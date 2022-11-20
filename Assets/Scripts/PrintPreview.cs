using CarConfigurator.ScriptableObjects;
using UnityEngine;

namespace CarConfigurator
{
    public class PrintPreview : MonoBehaviour
    {
        [SerializeField]
        private CarList carList;

        [SerializeField]
        private RectTransform contentOrigin;

        [SerializeField]
        private GameObject dataRowPrefab;

        [SerializeField]
        private GameObject featureRowPrefab;

        private void OnEnable()
        {
            foreach (Transform child in contentOrigin)
            {
                Destroy(child.gameObject);
            }

            foreach (var carData in carList.cars)
            {
                CreateDataRowUI(contentOrigin, carData);
            }
        }

        private void CreateDataRowUI(RectTransform origin, CarData carData)
        {
            var dataRowInstance = Instantiate(dataRowPrefab, Vector3.zero, Quaternion.identity, origin);

            var dataRow = dataRowInstance.GetComponent<PrintPreviewDataRow>();
            dataRow.Set(carData);

            foreach (var carFeature in carData.featureList)
            {
                CreateFeatureRowsUI(carFeature, dataRow.featureOrigin);
            }
        }

        private void CreateFeatureRowsUI(CarFeature feature, RectTransform origin)
        {
            var featureRowInstance = Instantiate(featureRowPrefab, Vector3.zero, Quaternion.identity, origin);

            var featureRow = featureRowInstance.GetComponent<PrintPreviewFeatureRow>();
            featureRow.Set(feature);
        }
    }
}