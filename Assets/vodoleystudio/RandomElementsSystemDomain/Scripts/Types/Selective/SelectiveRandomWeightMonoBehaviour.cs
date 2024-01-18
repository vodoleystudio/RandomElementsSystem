using System;
using System.Collections.Generic;
using UnityEngine;

namespace RandomElementsSystem.Types
{
    [Serializable]
    public class SelectiveRandomWeightMonoBehaviour : SelectiveRandomWeightPropertyBase<MonoBehaviour, WeightPropertyMonoBehaviour>
    {
        /// <summary>
        /// Do not use this default constructor. It is used only for serialization.
        /// </summary>
        public SelectiveRandomWeightMonoBehaviour()
        {
        }

        /// <summary>
        /// Creates new instance of SelectiveRandomWeightMonoBehaviour with equal weight for all items.
        /// </summary>
        /// <param name="selectableValues">MonoBehaviour items</param>
        /// <param name="isUseEachItemOncePerCycle">Set this flag to true if you want to use each item once per cycle. (non-repetitions random during each cycle). More info in _isUseEachItemOncePerCycle comment.</param>
        public SelectiveRandomWeightMonoBehaviour(IEnumerable<MonoBehaviour> selectableValues, bool isUseEachItemOncePerCycle) : base(selectableValues, isUseEachItemOncePerCycle)
        {
        }

        /// <summary>
        /// Creates new instance of SelectiveRandomWeightMonoBehaviour from collection of MonoBehaviour values and their weights.
        /// </summary>
        /// <param name="selectableValues">Collection of MonoBehaviour items as Keys and their weights as Values</param>
        /// <param name="isUseEachItemOncePerCycle">Set this flag to true if you want to use each item once per cycle. (non-repetitions random during each cycle). More info in _isUseEachItemOncePerCycle comment.</param>
        public SelectiveRandomWeightMonoBehaviour(ICollection<KeyValuePair<MonoBehaviour, float>> selectableValues, bool isUseEachItemOncePerCycle) : base(selectableValues, isUseEachItemOncePerCycle)
        {
        }

        /// <summary>
        /// Creates new instance of SelectiveRandomWeightInt from collection of WeightPropertyInt and their weights.
        /// </summary>
        /// <param name="selectableValues">Collection of WeightPropertyInt items</param>
        /// <param name="isUseEachItemOncePerCycle">Set this flag to true if you want to use each item once per cycle. (non-repetitions random during each cycle). More info in _isUseEachItemOncePerCycle comment.</param>
        /// <param name="isEqualWeightForAllItems">Set this flag to true if you want that all items have equal weight.</param>
        public SelectiveRandomWeightMonoBehaviour(IEnumerable<WeightPropertyMonoBehaviour> selectableValues, bool isUseEachItemOncePerCycle, bool isEqualWeightForAllItems) : base(selectableValues, isUseEachItemOncePerCycle, isEqualWeightForAllItems)
        {
        }
    }
}