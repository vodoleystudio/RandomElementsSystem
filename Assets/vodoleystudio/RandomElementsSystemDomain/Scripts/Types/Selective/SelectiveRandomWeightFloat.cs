using System;
using System.Collections.Generic;

namespace RandomElementsSystem.Types
{
    [Serializable]
    public class SelectiveRandomWeightFloat : SelectiveRandomWeightPropertyBase<float, WeightPropertyFloat>
    {
        /// <summary>
        /// Do not use this default constructor. It is used only for serialization.
        /// </summary>
        public SelectiveRandomWeightFloat()
        {
        }

        /// <summary>
        /// Creates new instance of SelectiveRandomWeightFloat with equal weight for all items.
        /// </summary>
        /// <param name="selectableValues">float items</param>
        /// <param name="isUseEachItemOncePerCycle">Set this flag to true if you want to use each item once per cycle. (non-repetitions random during each cycle). More info in _isUseEachItemOncePerCycle comment.</param>
        public SelectiveRandomWeightFloat(IEnumerable<float> selectableValues, bool isUseEachItemOncePerCycle) : base(selectableValues, isUseEachItemOncePerCycle)
        {
        }

        /// <summary>
        /// Creates new instance of SelectiveRandomWeightFloat from collection of float values and their weights.
        /// </summary>
        /// <param name="selectableValues">Collection of float items as Keys and their weights as Values</param>
        /// <param name="isUseEachItemOncePerCycle">Set this flag to true if you want to use each item once per cycle. (non-repetitions random during each cycle). More info in _isUseEachItemOncePerCycle comment.</param>
        public SelectiveRandomWeightFloat(ICollection<KeyValuePair<float, float>> selectableValues, bool isUseEachItemOncePerCycle) : base(selectableValues, isUseEachItemOncePerCycle)
        {
        }

        /// <summary>
        /// Creates new instance of SelectiveRandomWeightFloat from collection of WeightPropertyFloat and their weights.
        /// </summary>
        /// <param name="selectableValues">Collection of WeightPropertyFloat items</param>
        /// <param name="isUseEachItemOncePerCycle">Set this flag to true if you want to use each item once per cycle. (non-repetitions random during each cycle). More info in _isUseEachItemOncePerCycle comment.</param>
        /// <param name="isEqualWeightForAllItems">Set this flag to true if you want that all items have equal weight.</param>
        public SelectiveRandomWeightFloat(IEnumerable<WeightPropertyFloat> selectableValues, bool isUseEachItemOncePerCycle, bool isEqualWeightForAllItems) : base(selectableValues, isUseEachItemOncePerCycle, isEqualWeightForAllItems)
        {
        }
    }
}