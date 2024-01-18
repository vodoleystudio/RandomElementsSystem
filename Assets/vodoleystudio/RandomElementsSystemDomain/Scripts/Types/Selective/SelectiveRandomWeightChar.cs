using System;
using System.Collections.Generic;

namespace RandomElementsSystem.Types
{
    [Serializable]
    public class SelectiveRandomWeightChar : SelectiveRandomWeightPropertyBase<char, WeightPropertyChar>
    {
        /// <summary>
        /// Do not use this default constructor. It is used only for serialization.
        /// </summary>
        public SelectiveRandomWeightChar()
        {
        }

        /// <summary>
        /// Creates new instance of SelectiveRandomWeightChar with equal weight for all items.
        /// </summary>
        /// <param name="selectableValues">char items</param>
        /// <param name="isUseEachItemOncePerCycle">Set this flag to true if you want to use each item once per cycle. (non-repetitions random during each cycle). More info in _isUseEachItemOncePerCycle comment.</param>
        public SelectiveRandomWeightChar(IEnumerable<char> selectableValues, bool isUseEachItemOncePerCycle) : base(selectableValues, isUseEachItemOncePerCycle)
        {
        }

        /// <summary>
        /// Creates new instance of SelectiveRandomWeightChar from collection of char values and their weights.
        /// </summary>
        /// <param name="selectableValues">Collection of char items as Keys and their weights as Values</param>
        /// <param name="isUseEachItemOncePerCycle">Set this flag to true if you want to use each item once per cycle. (non-repetitions random during each cycle). More info in _isUseEachItemOncePerCycle comment.</param>
        public SelectiveRandomWeightChar(ICollection<KeyValuePair<char, float>> selectableValues, bool isUseEachItemOncePerCycle) : base(selectableValues, isUseEachItemOncePerCycle)
        {
        }

        /// <summary>
        /// Creates new instance of SelectiveRandomWeightChar from collection of WeightPropertyChar and their weights.
        /// </summary>
        /// <param name="selectableValues">Collection of WeightPropertyChar items</param>
        /// <param name="isUseEachItemOncePerCycle">Set this flag to true if you want to use each item once per cycle. (non-repetitions random during each cycle). More info in _isUseEachItemOncePerCycle comment.</param>
        /// <param name="isEqualWeightForAllItems">Set this flag to true if you want that all items have equal weight.</param>
        public SelectiveRandomWeightChar(IEnumerable<WeightPropertyChar> selectableValues, bool isUseEachItemOncePerCycle, bool isEqualWeightForAllItems) : base(selectableValues, isUseEachItemOncePerCycle, isEqualWeightForAllItems)
        {
        }
    }
}