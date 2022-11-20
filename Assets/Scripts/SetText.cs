using TMPro;
using UnityEngine;

namespace CarConfigurator
{
    public class SetText : MonoBehaviour
    {
        [SerializeField]
        private TextMeshProUGUI model;

        public void Set(string value)
        {
            model.text = value;
        }
    }
}
