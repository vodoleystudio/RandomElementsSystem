using System;

namespace RandomElementsSystem.Types
{
    [Serializable]
    public class WeightPropertyFloat : WeightProperty<float>
    {
        /// <summary>
        /// Do not use this default constructor. It is used only for serialization.
        /// </summary>
        public WeightPropertyFloat()
        {
        }

        /// <summary>
        /// Creates a new instance of WeightPropertyFloat.
        /// </summary>
        /// <param name="value">float value</param>
        /// <param name="weight">Weight of value</param>
        public WeightPropertyFloat(float value, float weight) : base(value, weight)
        {
        }
    }
}