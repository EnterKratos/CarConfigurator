using System.Linq;
using CarConfigurator.ScriptableObjects;
using TMPro;
using UnityEngine;

namespace CarConfigurator
{
    public class FeatureListBinding : MonoBehaviour
    {
        [SerializeField]
        private FeatureList featureList;

        [SerializeField]
        private TMP_Dropdown dropdown;

        private void OnEnable()
        {
            dropdown.ClearOptions();

            dropdown.AddOptions(featureList.features.Select(x =>
                $"{x.featureName} (+ {Helpers.FormatCurrencyValue(x.price)})"
            ).ToList());
        }
    }
}