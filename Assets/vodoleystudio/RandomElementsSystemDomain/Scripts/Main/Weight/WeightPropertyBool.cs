using System;

namespace RandomElementsSystem.Types
{
    [Serializable]
    public class WeightPropertyBool : WeightProperty<bool>
    {
        /// <summary>
        /// Do not use this default constructor. It is used only for serialization.
        /// </summary>
        public WeightPropertyBool()
        {
        }

        /// <summary>
        /// Creates a new instance of WeightPropertyBool.
        /// </summary>
        /// <param name="value">True/False value</param>
        /// <param name="weight">Weight of value</param>
        public WeightPropertyBool(bool value, float weight) : base(value, weight)
        {
        }
    }
}