using System;

namespace RandomElementsSystem.Types
{
    [Serializable]
    public class WeightPropertyString : WeightProperty<string>
    {
        /// <summary>
        /// Do not use this default constructor. It is used only for serialization.
        /// </summary>
        public WeightPropertyString()
        {
        }

        /// <summary>
        /// Creates a new instance of WeightPropertyString.
        /// </summary>
        /// <param name="value">string value</param>
        /// <param name="weight">Weight of value</param>
        public WeightPropertyString(string value, float weight) : base(value, weight)
        {
        }
    }
}