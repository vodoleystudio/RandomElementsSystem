using System;
using UnityEngine;

namespace RandomElementsSystem.Types
{
    [Serializable]
    public class WeightPropertyVector3 : WeightProperty<Vector3>
    {
        /// <summary>
        /// Do not use this default constructor. It is used only for serialization.
        /// </summary>
        public WeightPropertyVector3()
        {
        }

        /// <summary>
        /// Creates a new instance of WeightPropertyVector3.
        /// </summary>
        /// <param name="value">Vector3 value</param>
        /// <param name="weight">Weight of value</param>
        public WeightPropertyVector3(Vector3 value, float weight) : base(value, weight)
        {
        }
    }
}