using System;
using System.Collections.Generic;
using UnityEngine;

namespace RandomElementsSystem.Types
{
    [Serializable]
    public class SelectiveRandomWeightVector2 : SelectiveRandomWeightPropertyBase<Vector2, WeightPropertyVector2>
    {
        /// <summary>
        /// Do not use this default constructor. It is used only for serialization.
        /// </summary>
        public SelectiveRandomWeightVector2()
        {
        }

        /// <summary>
        /// Creates new instance of SelectiveRandomWeightVector2 with equal weight for all items.
        /// </summary>
        /// <param name="selectableValues">Vector2 items</param>
        /// <param name="isUseEachItemOncePerCycle">Set this flag to true if you want to use each item once per cycle. (non-repetitions random during each cycle). More info in _isUseEachItemOncePerCycle comment.</param>
        public SelectiveRandomWeightVector2(IEnumerable<Vector2> selectableValues, bool isUseEachItemOncePerCycle) : base(selectableValues, isUseEachItemOncePerCycle)
        {
        }

        /// <summary>
        /// Creates new instance of SelectiveRandomWeightVector2 from collection of Vector2 values and their weights.
        /// </summary>
        /// <param name="selectableValues">Collection of Vector2 items as Keys and their weights as Values</param>
        /// <param name="isUseEachItemOncePerCycle">Set this flag to true if you want to use each item once per cycle. (non-repetitions random during each cycle). More info in _isUseEachItemOncePerCycle comment.</param>
        public SelectiveRandomWeightVector2(ICollection<KeyValuePair<Vector2, float>> selectableValues, bool isUseEachItemOncePerCycle) : base(selectableValues, isUseEachItemOncePerCycle)
        {
        }

        /// <summary>
        /// Creates new instance of SelectiveRandomWeightVector2 from collection of WeightPropertyVector2 and their weights.
        /// </summary>
        /// <param name="selectableValues">Collection of WeightPropertyVector2 items</param>
        /// <param name="isUseEachItemOncePerCycle">Set this flag to true if you want to use each item once per cycle. (non-repetitions random during each cycle). More info in _isUseEachItemOncePerCycle comment.</param>
        /// <param name="isEqualWeightForAllItems">Set this flag to true if you want that all items have equal weight.</param>
        public SelectiveRandomWeightVector2(IEnumerable<WeightPropertyVector2> selectableValues, bool isUseEachItemOncePerCycle, bool isEqualWeightForAllItems) : base(selectableValues, isUseEachItemOncePerCycle, isEqualWeightForAllItems)
        {
        }
    }
}