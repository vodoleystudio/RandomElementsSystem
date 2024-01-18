using System;

namespace RandomElementsSystem.Types
{
    [Serializable]
    public class WeightPropertyChar : WeightProperty<char>
    {
        /// <summary>
        /// Do not use this default constructor. It is used only for serialization.
        /// </summary>
        public WeightPropertyChar()
        {
        }

        /// <summary>
        /// Creates a new instance of WeightPropertyChar.
        /// </summary>
        /// <param name="value">char value</param>
        /// <param name="weight">Weight of value</param>
        public WeightPropertyChar(char value, float weight) : base(value, weight)
        {
        }
    }
}