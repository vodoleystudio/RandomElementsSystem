using RandomElementsSystem.Types;

using System;

namespace RandomElementsSystem.Examples
{
    [Serializable]
    public class WeightPropertyMinMaxRandomInt : WeightProperty<MinMaxRandomInt>
    {
        /// <summary>
        /// Do not use this default constructor. It is used only for serialization.
        /// </summary>
        public WeightPropertyMinMaxRandomInt()
        {
        }

        public WeightPropertyMinMaxRandomInt(MinMaxRandomInt value, float weight) : base(value, weight)
        {
        }
    }
}