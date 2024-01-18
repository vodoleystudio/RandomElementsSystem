using System;
using System.Collections.Generic;
using UnityEngine;

namespace RandomElementsSystem.Types
{
    [Serializable]
    public class SelectiveRandomWeightVector3Int : SelectiveRandomWeightPropertyBase<Vector3Int, WeightPropertyVector3Int>
    {
        /// <summary>
        /// Do not use this default constructor. It is used only for serialization.
        /// </summary>
        public SelectiveRandomWeightVector3Int()
        {
        }

        /// <summary>
        /// Creates new instance of SelectiveRandomWeightVector3Int with equal weight for all items.
        /// </summary>
        /// <param name="selectableValues">Vector3Int items</param>
        /// <param name="isUseEachItemOncePerCycle">Set this flag to true if you want to use each item once per cycle. (non-repetitions random during each cycle). More info in _isUseEachItemOncePerCycle comment.</param>
        public SelectiveRandomWeightVector3Int(IEnumerable<Vector3Int> selectableValues, bool isUseEachItemOncePerCycle) : base(selectableValues, isUseEachItemOncePerCycle)
        {
        }

        /// <summary>
        /// Creates new instance of SelectiveRandomWeightVector3Int from collection of Vector3Int values and their weights.
        /// </summary>
        /// <param name="selectableValues">Collection of Vector3Int items as Keys and their weights as Values</param>
        /// <param name="isUseEachItemOncePerCycle">Set this flag to true if you want to use each item once per cycle. (non-repetitions random during each cycle). More info in _isUseEachItemOncePerCycle comment.</param>
        public SelectiveRandomWeightVector3Int(ICollection<KeyValuePair<Vector3Int, float>> selectableValues, bool isUseEachItemOncePerCycle) : base(selectableValues, isUseEachItemOncePerCycle)
        {
        }

        /// <summary>
        /// Creates new instance of SelectiveRandomWeightVector3Int from collection of WeightPropertyVector3Int and their weights.
        /// </summary>
        /// <param name="selectableValues">Collection of WeightPropertyVector3Int items</param>
        /// <param name="isUseEachItemOncePerCycle">Set this flag to true if you want to use each item once per cycle. (non-repetitions random during each cycle). More info in _isUseEachItemOncePerCycle comment.</param>
        /// <param name="isEqualWeightForAllItems">Set this flag to true if you want that all items have equal weight.</param>
        public SelectiveRandomWeightVector3Int(IEnumerable<WeightPropertyVector3Int> selectableValues, bool isUseEachItemOncePerCycle, bool isEqualWeightForAllItems) : base(selectableValues, isUseEachItemOncePerCycle, isEqualWeightForAllItems)
        {
        }
    }
}