using System;
using System.Collections.Generic;
using UnityEngine;

namespace RandomElementsSystem.Types
{
    [Serializable]
    public class SelectiveRandomWeightScriptableObject : SelectiveRandomWeightPropertyBase<ScriptableObject, WeightPropertyScriptableObject>
    {
        /// <summary>
        /// Do not use this default constructor. It is used only for serialization.
        /// </summary>
        public SelectiveRandomWeightScriptableObject()
        {
        }

        /// <summary>
        /// Creates new instance of SelectiveRandomWeightScriptableObject with equal weight for all items.
        /// </summary>
        /// <param name="selectableValues">ScriptableObject items</param>
        /// <param name="isUseEachItemOncePerCycle">Set this flag to true if you want to use each item once per cycle. (non-repetitions random during each cycle). More info in _isUseEachItemOncePerCycle comment.</param>
        public SelectiveRandomWeightScriptableObject(IEnumerable<ScriptableObject> selectableValues, bool isUseEachItemOncePerCycle) : base(selectableValues, isUseEachItemOncePerCycle)
        {
        }

        /// <summary>
        /// Creates new instance of SelectiveRandomWeightScriptableObject from collection of ScriptableObject values and their weights.
        /// </summary>
        /// <param name="selectableValues">Collection of ScriptableObject items as Keys and their weights as Values</param>
        /// <param name="isUseEachItemOncePerCycle">Set this flag to true if you want to use each item once per cycle. (non-repetitions random during each cycle). More info in _isUseEachItemOncePerCycle comment.</param>
        public SelectiveRandomWeightScriptableObject(ICollection<KeyValuePair<ScriptableObject, float>> selectableValues, bool isUseEachItemOncePerCycle) : base(selectableValues, isUseEachItemOncePerCycle)
        {
        }

        /// <summary>
        /// Creates new instance of SelectiveRandomWeightScriptableObject from collection of WeightPropertyScriptableObject and their weights.
        /// </summary>
        /// <param name="selectableValues">Collection of WeightPropertyScriptableObject items</param>
        /// <param name="isUseEachItemOncePerCycle">Set this flag to true if you want to use each item once per cycle. (non-repetitions random during each cycle). More info in _isUseEachItemOncePerCycle comment.</param>
        /// <param name="isEqualWeightForAllItems">Set this flag to true if you want that all items have equal weight.</param>
        public SelectiveRandomWeightScriptableObject(IEnumerable<WeightPropertyScriptableObject> selectableValues, bool isUseEachItemOncePerCycle, bool isEqualWeightForAllItems) : base(selectableValues, isUseEachItemOncePerCycle, isEqualWeightForAllItems)
        {
        }
    }
}