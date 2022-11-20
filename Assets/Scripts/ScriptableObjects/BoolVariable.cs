using UnityEngine;

namespace CarConfigurator.ScriptableObjects
{
    [CreateAssetMenu(menuName = "Variables/Bool")]
    public class BoolVariable : ScriptableObject
    {
        public bool value;

        public void Set() => value = true;
        public void Unset() => value = false;
    }
}