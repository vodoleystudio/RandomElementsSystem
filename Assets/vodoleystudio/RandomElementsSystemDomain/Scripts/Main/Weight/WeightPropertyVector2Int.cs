using System;
using UnityEngine;

namespace RandomElementsSystem.Types
{
    [Serializable]
    public class WeightPropertyVector2Int : WeightProperty<Vector2Int>
    {
        /// <summary>
        /// Do not use this default constructor. It is used only for serialization.
        /// </summary>
        public WeightPropertyVector2Int()
        {
        }

        /// <summary>
        /// Creates a new instance of WeightPropertyVector2Int.
        /// </summary>
        /// <param name="value">Vector2Int value</param>
        /// <param name="weight">Weight of value</param>
        public WeightPropertyVector2Int(Vector2Int value, float weight) : base(value, weight)
        {
        }
    }
}