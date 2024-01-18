using System;
using System.Collections.Generic;

namespace RandomElementsSystem.Types
{
    [Serializable]
    public class SelectiveRandomWeightInt : SelectiveRandomWeightPropertyBase<int, WeightPropertyInt>
    {
        /// <summary>
        /// Do not use this default constructor. It is used only for serialization.
        /// </summary>
        public SelectiveRandomWeightInt()
        {
        }

        /// <summary>
        /// Creates new instance of SelectiveRandomWeightInt with equal weight for all items.
        /// </summary>
        /// <param name="selectableValues">int items</param>
        /// <param name="isUseEachItemOncePerCycle">Set this flag to true if you want to use each item once per cycle. (non-repetitions random during each cycle). More info in _isUseEachItemOncePerCycle comment.</param>
        public SelectiveRandomWeightInt(IEnumerable<int> selectableValues, bool isUseEachItemOncePerCycle) : base(selectableValues, isUseEachItemOncePerCycle)
        {
        }

        /// <summary>
        /// Creates new instance of SelectiveRandomWeightInt from collection of int values and their weights.
        /// </summary>
        /// <param name="selectableValues">Collection of int items as Keys and their weights as Values</param>
        /// <param name="isUseEachItemOncePerCycle">Set this flag to true if you want to use each item once per cycle. (non-repetitions random during each cycle). More info in _isUseEachItemOncePerCycle comment.</param>
        public SelectiveRandomWeightInt(ICollection<KeyValuePair<int, float>> selectableValues, bool isUseEachItemOncePerCycle) : base(selectableValues, isUseEachItemOncePerCycle)
        {
        }

        /// <summary>
        /// Creates new instance of SelectiveRandomWeightInt from collection of WeightPropertyInt and their weights.
        /// </summary>
        /// <param name="selectableValues">Collection of WeightPropertyInt items</param>
        /// <param name="isUseEachItemOncePerCycle">Set this flag to true if you want to use each item once per cycle. (non-repetitions random during each cycle). More info in _isUseEachItemOncePerCycle comment.</param>
        /// <param name="isEqualWeightForAllItems">Set this flag to true if you want that all items have equal weight.</param>
        public SelectiveRandomWeightInt(IEnumerable<WeightPropertyInt> selectableValues, bool isUseEachItemOncePerCycle, bool isEqualWeightForAllItems) : base(selectableValues, isUseEachItemOncePerCycle, isEqualWeightForAllItems)
        {
        }
    }
}