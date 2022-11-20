using CarConfigurator.ScriptableObjects;
using UnityEngine;

namespace CarConfigurator
{
    public class PrintPreviewDataRow : MonoBehaviour
    {
        public RectTransform featureOrigin;

        [SerializeField]
        private SetText model;

        [SerializeField]
        private SetText totalPrice;

        public void Set(CarData carData)
        {
            model.Set(carData.model);
            totalPrice.Set(Helpers.FormatCurrencyValue(carData.Total));
        }
    }
}