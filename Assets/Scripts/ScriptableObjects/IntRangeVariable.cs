using UnityEngine;

namespace CarConfigurator.ScriptableObjects
{
    [CreateAssetMenu(menuName = "Variables/Int (Range)")]
    public class IntRangeVariable : ScriptableObject
    {
        public int defaultValue = 0;
        public int min;
        public int max;
        public bool loopRange = false;
        public int value;

        public void Increment()
        {
            if (loopRange)
            {
                if (value + 1 > max)
                {
                    value = min;
                    return;
                }
            }

            if (value < max)
            {
                value++;
            }
        }

        public void Decrement()
        {
            if (loopRange)
            {
                if (value - 1 < min)
                {
                    value = max;
                    return;
                }
            }

            if (value > min)
            {
                value--;
            }
        }

        private void OnEnable()
        {
            value = defaultValue;
        }
    }
}