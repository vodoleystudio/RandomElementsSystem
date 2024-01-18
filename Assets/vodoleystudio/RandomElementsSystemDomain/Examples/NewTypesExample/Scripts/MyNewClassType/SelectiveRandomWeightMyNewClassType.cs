using RandomElementsSystem.Types;

using System;
using System.Collections.Generic;

namespace RandomElementsSystem.Examples
{
    [Serializable]
    public class SelectiveRandomWeightMyNewClassType : SelectiveRandomWeightPropertyBase<MyNewClassType, WeightPropertyMyNewClassType>
    {
        /// <summary>
        /// Do not use this default constructor. It is used only for serialization.
        /// </summary>
        public SelectiveRandomWeightMyNewClassType()
        {
        }

        public SelectiveRandomWeightMyNewClassType(IEnumerable<MyNewClassType> selectableValues, bool isUseEachItemOncePerCycle) : base(selectableValues, isUseEachItemOncePerCycle)
        {
        }

        public SelectiveRandomWeightMyNewClassType(ICollection<KeyValuePair<MyNewClassType, float>> selectableValues, bool isUseEachItemOncePerCycle) : base(selectableValues, isUseEachItemOncePerCycle)
        {
        }

        public SelectiveRandomWeightMyNewClassType(IEnumerable<WeightPropertyMyNewClassType> selectableValues, bool isUseEachItemOncePerCycle, bool isEqualWeightForAllItems) : base(selectableValues, isUseEachItemOncePerCycle, isEqualWeightForAllItems)
        {
        }
    }
}