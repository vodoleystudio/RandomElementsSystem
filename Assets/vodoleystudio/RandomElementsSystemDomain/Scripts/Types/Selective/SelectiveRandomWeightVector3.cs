using System;
using System.Collections.Generic;
using UnityEngine;

namespace RandomElementsSystem.Types
{
    [Serializable]
    public class SelectiveRandomWeightVector3 : SelectiveRandomWeightPropertyBase<Vector3, WeightPropertyVector3>
    {
        /// <summary>
        /// Do not use this default constructor. It is used only for serialization.
        /// </summary>
        public SelectiveRandomWeightVector3()
        {
        }

        /// <summary>
        /// Creates new instance of SelectiveRandomWeightVector3 with equal weight for all items.
        /// </summary>
        /// <param name="selectableValues">Vector3 items</param>
        /// <param name="isUseEachItemOncePerCycle">Set this flag to true if you want to use each item once per cycle. (non-repetitions random during each cycle). More info in _isUseEachItemOncePerCycle comment.</param>
        public SelectiveRandomWeightVector3(IEnumerable<Vector3> selectableValues, bool isUseEachItemOncePerCycle) : base(selectableValues, isUseEachItemOncePerCycle)
        {
        }

        /// <summary>
        /// Creates new instance of SelectiveRandomWeightVector3 from collection of Vector3 values and their weights.
        /// </summary>
        /// <param name="selectableValues">Collection of Vector3 items as Keys and their weights as Values</param>
        /// <param name="isUseEachItemOncePerCycle">Set this flag to true if you want to use each item once per cycle. (non-repetitions random during each cycle). More info in _isUseEachItemOncePerCycle comment.</param>
        public SelectiveRandomWeightVector3(ICollection<KeyValuePair<Vector3, float>> selectableValues, bool isUseEachItemOncePerCycle) : base(selectableValues, isUseEachItemOncePerCycle)
        {
        }

        /// <summary>
        /// Creates new instance of SelectiveRandomWeightVector3 from collection of WeightPropertyVector3 and their weights.
        /// </summary>
        /// <param name="selectableValues">Collection of WeightPropertyVector3 items</param>
        /// <param name="isUseEachItemOncePerCycle">Set this flag to true if you want to use each item once per cycle. (non-repetitions random during each cycle). More info in _isUseEachItemOncePerCycle comment.</param>
        /// <param name="isEqualWeightForAllItems">Set this flag to true if you want that all items have equal weight.</param>
        public SelectiveRandomWeightVector3(IEnumerable<WeightPropertyVector3> selectableValues, bool isUseEachItemOncePerCycle, bool isEqualWeightForAllItems) : base(selectableValues, isUseEachItemOncePerCycle, isEqualWeightForAllItems)
        {
        }
    }
}