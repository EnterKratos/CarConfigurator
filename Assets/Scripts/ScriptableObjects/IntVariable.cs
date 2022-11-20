using UnityEngine;

namespace CarConfigurator.ScriptableObjects
{
    [CreateAssetMenu(menuName = "Variables/Int")]
    public class IntVariable : ScriptableObject
    {
        public int value;

        public void Set(int input) => value = input;
    }
}