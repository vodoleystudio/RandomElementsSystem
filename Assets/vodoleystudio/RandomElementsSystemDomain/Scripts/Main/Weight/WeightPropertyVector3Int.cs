using System;
using UnityEngine;

namespace RandomElementsSystem.Types
{
    [Serializable]
    public class WeightPropertyVector3Int : WeightProperty<Vector3Int>
    {
        /// <summary>
        /// Do not use this default constructor. It is used only for serialization.
        /// </summary>
        public WeightPropertyVector3Int()
        {
        }

        /// <summary>
        /// Creates a new instance of WeightPropertyVector3Int.
        /// </summary>
        /// <param name="value">Vector3Int value</param>
        /// <param name="weight">Weight of value</param>
        public WeightPropertyVector3Int(Vector3Int value, float weight) : base(value, weight)
        {
        }
    }
}