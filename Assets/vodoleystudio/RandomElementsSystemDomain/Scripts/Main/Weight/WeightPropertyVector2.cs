using System;
using UnityEngine;

namespace RandomElementsSystem.Types
{
    [Serializable]
    public class WeightPropertyVector2 : WeightProperty<Vector2>
    {
        /// <summary>
        /// Do not use this default constructor. It is used only for serialization.
        /// </summary>
        public WeightPropertyVector2()
        {
        }

        /// <summary>
        /// Creates a new instance of WeightPropertyVector2.
        /// </summary>
        /// <param name="value">Vector2 value</param>
        /// <param name="weight">Weight of value</param>
        public WeightPropertyVector2(Vector2 value, float weight) : base(value, weight)
        {
        }
    }
}