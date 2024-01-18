using System;
using System.Collections.Generic;

using Object = UnityEngine.Object;

namespace RandomElementsSystem.Types
{
    [Serializable]
    public class SelectiveRandomWeightUnityObject : SelectiveRandomWeightPropertyBase<Object, WeightPropertyUnityObject>
    {
        /// <summary>
        /// Do not use this default constructor. It is used only for serialization.
        /// </summary>
        public SelectiveRandomWeightUnityObject()
        {
        }

        /// <summary>
        /// Creates new instance of SelectiveRandomWeightUnityObject with equal weight for all items.
        /// </summary>
        /// <param name="selectableValues">UnityEngine.Object items</param>
        /// <param name="isUseEachItemOncePerCycle">Set this flag to true if you want to use each item once per cycle. (non-repetitions random during each cycle). More info in _isUseEachItemOncePerCycle comment.</param>
        public SelectiveRandomWeightUnityObject(IEnumerable<Object> selectableValues, bool isUseEachItemOncePerCycle) : base(selectableValues, isUseEachItemOncePerCycle)
        {
        }

        /// <summary>
        /// Creates new instance of SelectiveRandomWeightUnityObject from collection of UnityEngine.Object values and their weights.
        /// </summary>
        /// <param name="selectableValues">Collection of UnityEngine.Object items as Keys and their weights as Values</param>
        /// <param name="isUseEachItemOncePerCycle">Set this flag to true if you want to use each item once per cycle. (non-repetitions random during each cycle). More info in _isUseEachItemOncePerCycle comment.</param>
        public SelectiveRandomWeightUnityObject(ICollection<KeyValuePair<Object, float>> selectableValues, bool isUseEachItemOncePerCycle) : base(selectableValues, isUseEachItemOncePerCycle)
        {
        }

        /// <summary>
        /// Creates new instance of SelectiveRandomWeightUnityObject from collection of WeightPropertyUnityObject and their weights.
        /// </summary>
        /// <param name="selectableValues">Collection of WeightPropertyUnityObject items</param>
        /// <param name="isUseEachItemOncePerCycle">Set this flag to true if you want to use each item once per cycle. (non-repetitions random during each cycle). More info in _isUseEachItemOncePerCycle comment.</param>
        /// <param name="isEqualWeightForAllItems">Set this flag to true if you want that all items have equal weight.</param>
        public SelectiveRandomWeightUnityObject(IEnumerable<WeightPropertyUnityObject> selectableValues, bool isUseEachItemOncePerCycle, bool isEqualWeightForAllItems) : base(selectableValues, isUseEachItemOncePerCycle, isEqualWeightForAllItems)
        {
        }
    }
}