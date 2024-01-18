using System;
using System.Collections.Generic;
using UnityEngine;

namespace RandomElementsSystem.Types
{
    [Serializable]
    public class SelectiveRandomWeightVector2Int : SelectiveRandomWeightPropertyBase<Vector2Int, WeightPropertyVector2Int>
    {
        /// <summary>
        /// Do not use this default constructor. It is used only for serialization.
        /// </summary>
        public SelectiveRandomWeightVector2Int()
        {
        }

        /// <summary>
        /// Creates new instance of SelectiveRandomWeightVector2Int with equal weight for all items.
        /// </summary>
        /// <param name="selectableValues">Vector2Int items</param>
        /// <param name="isUseEachItemOncePerCycle">Set this flag to true if you want to use each item once per cycle. (non-repetitions random during each cycle). More info in _isUseEachItemOncePerCycle comment.</param>
        public SelectiveRandomWeightVector2Int(IEnumerable<Vector2Int> selectableValues, bool isUseEachItemOncePerCycle) : base(selectableValues, isUseEachItemOncePerCycle)
        {
        }

        /// <summary>
        /// Creates new instance of SelectiveRandomWeightVector2Int from collection of Vector2Int values and their weights.
        /// </summary>
        /// <param name="selectableValues">Collection of Vector2Int items as Keys and their weights as Values</param>
        /// <param name="isUseEachItemOncePerCycle">Set this flag to true if you want to use each item once per cycle. (non-repetitions random during each cycle). More info in _isUseEachItemOncePerCycle comment.</param>
        public SelectiveRandomWeightVector2Int(ICollection<KeyValuePair<Vector2Int, float>> selectableValues, bool isUseEachItemOncePerCycle) : base(selectableValues, isUseEachItemOncePerCycle)
        {
        }

        /// <summary>
        /// Creates new instance of SelectiveRandomWeightVector2Int from collection of WeightPropertyVector2Int and their weights.
        /// </summary>
        /// <param name="selectableValues">Collection of WeightPropertyVector2Int items</param>
        /// <param name="isUseEachItemOncePerCycle">Set this flag to true if you want to use each item once per cycle. (non-repetitions random during each cycle). More info in _isUseEachItemOncePerCycle comment.</param>
        /// <param name="isEqualWeightForAllItems">Set this flag to true if you want that all items have equal weight.</param>
        public SelectiveRandomWeightVector2Int(IEnumerable<WeightPropertyVector2Int> selectableValues, bool isUseEachItemOncePerCycle, bool isEqualWeightForAllItems) : base(selectableValues, isUseEachItemOncePerCycle, isEqualWeightForAllItems)
        {
        }
    }
}