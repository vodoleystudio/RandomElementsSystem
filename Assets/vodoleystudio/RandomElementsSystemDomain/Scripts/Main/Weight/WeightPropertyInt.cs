using System;

namespace RandomElementsSystem.Types
{
    [Serializable]
    public class WeightPropertyInt : WeightProperty<int>
    {
        /// <summary>
        /// Do not use this default constructor. It is used only for serialization.
        /// </summary>
        public WeightPropertyInt()
        {
        }

        /// <summary>
        /// Creates a new instance of WeightPropertyInt.
        /// </summary>
        /// <param name="value">int value</param>
        /// <param name="weight">Weight of value</param>
        public WeightPropertyInt(int value, float weight) : base(value, weight)
        {
        }
    }
}