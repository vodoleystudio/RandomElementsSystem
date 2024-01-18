using System;
using System.Collections.Generic;

namespace RandomElementsSystem.Types
{
    [Serializable]
    public class SelectiveRandomWeightString : SelectiveRandomWeightPropertyBase<string, WeightPropertyString>
    {
        /// <summary>
        /// Do not use this default constructor. It is used only for serialization.
        /// </summary>
        public SelectiveRandomWeightString()
        {
        }

        /// <summary>
        /// Creates new instance of SelectiveRandomWeightString with equal weight for all items.
        /// </summary>
        /// <param name="selectableValues">string items</param>
        /// <param name="isUseEachItemOncePerCycle">Set this flag to true if you want to use each item once per cycle. (non-repetitions random during each cycle). More info in _isUseEachItemOncePerCycle comment.</param>
        public SelectiveRandomWeightString(IEnumerable<string> selectableValues, bool isUseEachItemOncePerCycle) : base(selectableValues, isUseEachItemOncePerCycle)
        {
        }

        /// <summary>
        /// Creates new instance of SelectiveRandomWeightString from collection of string values and their weights.
        /// </summary>
        /// <param name="selectableValues">Collection of string items as Keys and their weights as Values</param>
        /// <param name="isUseEachItemOncePerCycle">Set this flag to true if you want to use each item once per cycle. (non-repetitions random during each cycle). More info in _isUseEachItemOncePerCycle comment.</param>
        public SelectiveRandomWeightString(ICollection<KeyValuePair<string, float>> selectableValues, bool isUseEachItemOncePerCycle) : base(selectableValues, isUseEachItemOncePerCycle)
        {
        }

        /// <summary>
        /// Creates new instance of SelectiveRandomWeightString from collection of WeightPropertyString and their weights.
        /// </summary>
        /// <param name="selectableValues">Collection of WeightPropertyString items</param>
        /// <param name="isUseEachItemOncePerCycle">Set this flag to true if you want to use each item once per cycle. (non-repetitions random during each cycle). More info in _isUseEachItemOncePerCycle comment.</param>
        /// <param name="isEqualWeightForAllItems">Set this flag to true if you want that all items have equal weight.</param>
        public SelectiveRandomWeightString(IEnumerable<WeightPropertyString> selectableValues, bool isUseEachItemOncePerCycle, bool isEqualWeightForAllItems) : base(selectableValues, isUseEachItemOncePerCycle, isEqualWeightForAllItems)
        {
        }
    }
}