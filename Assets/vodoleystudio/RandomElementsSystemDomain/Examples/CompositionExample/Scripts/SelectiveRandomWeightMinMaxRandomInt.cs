using RandomElementsSystem.Types;

using System;
using System.Collections.Generic;

namespace RandomElementsSystem.Examples
{
    [Serializable]
    public class SelectiveRandomWeightMinMaxRandomInt : SelectiveRandomWeightPropertyBase<MinMaxRandomInt, WeightPropertyMinMaxRandomInt>
    {
        public new event Action<int> OnGenerated;

        /// <summary>
        /// Do not use this default constructor. It is used only for serialization.
        /// </summary>
        public SelectiveRandomWeightMinMaxRandomInt()
        {
        }

        public SelectiveRandomWeightMinMaxRandomInt(IEnumerable<MinMaxRandomInt> selectableValues, bool isUseEachItemOncePerCycle) : base(selectableValues, isUseEachItemOncePerCycle)
        {
        }

        public SelectiveRandomWeightMinMaxRandomInt(ICollection<KeyValuePair<MinMaxRandomInt, float>> selectableValues, bool isUseEachItemOncePerCycle) : base(selectableValues, isUseEachItemOncePerCycle)
        {
        }

        public SelectiveRandomWeightMinMaxRandomInt(IEnumerable<WeightPropertyMinMaxRandomInt> selectableValues, bool isUseEachItemOncePerCycle, bool isEqualWeightForAllItems) : base(selectableValues, isUseEachItemOncePerCycle, isEqualWeightForAllItems)
        {
        }

        public new int GetRandomValue()
        {
            var value = base.GetRandomValue().GetRandomValue();
            OnGenerated?.Invoke(value);
            return value;
        }
    }
}