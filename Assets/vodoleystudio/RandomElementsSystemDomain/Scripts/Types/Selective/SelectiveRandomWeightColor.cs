using System;
using System.Collections.Generic;
using UnityEngine;

namespace RandomElementsSystem.Types
{
    [Serializable]
    public class SelectiveRandomWeightColor : SelectiveRandomWeightPropertyBase<Color, WeightPropertyColor>
    {
        /// <summary>
        /// Do not use this default constructor. It is used only for serialization.
        /// </summary>
        public SelectiveRandomWeightColor()
        {
        }

        /// <summary>
        /// Creates new instance of SelectiveRandomWeightColor with equal weight for all items.
        /// </summary>
        /// <param name="selectableValues">Color items</param>
        /// <param name="isUseEachItemOncePerCycle">Set this flag to true if you want to use each item once per cycle. (non-repetitions random during each cycle). More info in _isUseEachItemOncePerCycle comment.</param>
        public SelectiveRandomWeightColor(IEnumerable<Color> selectableValues, bool isUseEachItemOncePerCycle) : base(selectableValues, isUseEachItemOncePerCycle)
        {
        }

        /// <summary>
        /// Creates new instance of SelectiveRandomWeightColor from collection of Color values and their weights.
        /// </summary>
        /// <param name="selectableValues">Collection of Color items as Keys and their weights as Values</param>
        /// <param name="isUseEachItemOncePerCycle">Set this flag to true if you want to use each item once per cycle. (non-repetitions random during each cycle). More info in _isUseEachItemOncePerCycle comment.</param>
        public SelectiveRandomWeightColor(ICollection<KeyValuePair<Color, float>> selectableValues, bool isUseEachItemOncePerCycle) : base(selectableValues, isUseEachItemOncePerCycle)
        {
        }

        /// <summary>
        /// Creates new instance of SelectiveRandomWeightColor from collection of WeightPropertyColor and their weights.
        /// </summary>
        /// <param name="selectableValues">Collection of WeightPropertyColor items</param>
        /// <param name="isUseEachItemOncePerCycle">Set this flag to true if you want to use each item once per cycle. (non-repetitions random during each cycle). More info in _isUseEachItemOncePerCycle comment.</param>
        /// <param name="isEqualWeightForAllItems">Set this flag to true if you want that all items have equal weight.</param>
        public SelectiveRandomWeightColor(IEnumerable<WeightPropertyColor> selectableValues, bool isUseEachItemOncePerCycle, bool isEqualWeightForAllItems) : base(selectableValues, isUseEachItemOncePerCycle, isEqualWeightForAllItems)
        {
        }
    }
}