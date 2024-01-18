using System;
using UnityEngine;

namespace RandomElementsSystem.Types
{
    [Serializable]
    public class WeightPropertyQuaternion : WeightProperty<Quaternion>
    {
        /// <summary>
        /// Do not use this default constructor. It is used only for serialization.
        /// </summary>
        public WeightPropertyQuaternion()
        {
        }

        /// <summary>
        /// Creates a new instance of WeightPropertyQuaternion.
        /// </summary>
        /// <param name="value">Quaternion value</param>
        /// <param name="weight">Weight of value</param>
        public WeightPropertyQuaternion(Quaternion value, float weight) : base(value, weight)
        {
        }
    }
}