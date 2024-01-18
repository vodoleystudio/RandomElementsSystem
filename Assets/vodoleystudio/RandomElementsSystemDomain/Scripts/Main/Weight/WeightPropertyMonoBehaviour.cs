using System;
using UnityEngine;

namespace RandomElementsSystem.Types
{
    [Serializable]
    public class WeightPropertyMonoBehaviour : WeightProperty<MonoBehaviour>
    {
        /// <summary>
        /// Do not use this default constructor. It is used only for serialization.
        /// </summary>
        public WeightPropertyMonoBehaviour()
        {
        }

        /// <summary>
        /// Creates a new instance of WeightPropertyMonoBehaviour.
        /// </summary>
        /// <param name="value">MonoBehaviour value</param>
        /// <param name="weight">Weight of value</param>
        public WeightPropertyMonoBehaviour(MonoBehaviour value, float weight) : base(value, weight)
        {
        }
    }
}