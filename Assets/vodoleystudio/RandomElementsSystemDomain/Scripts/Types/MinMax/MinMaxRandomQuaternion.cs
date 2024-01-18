using System;
using UnityEngine;

using Random = UnityEngine.Random;

namespace RandomElementsSystem.Types
{
    [Serializable]
    public class MinMaxRandomQuaternion : MinMaxRandomProperty<Quaternion>
    {
        /// <summary>
        /// Do not use this default constructor. It is used only for serialization.
        /// </summary>
        public MinMaxRandomQuaternion()
        {
        }

        /// <summary>
        /// Creates a new instance of the MinMaxRandomQuaternion class with the specified min and max range.
        /// </summary>
        /// <param name="min">min range of Quaternion value (inclusive)</param>
        /// <param name="max">max range of Quaternion value (inclusive)</param>
        public MinMaxRandomQuaternion(Quaternion min, Quaternion max) : base(min, max)
        {
        }

        protected override Quaternion GenerateRandomValue()
        {
            return new Quaternion(Random.Range(Min.x, Max.x), Random.Range(Min.y, Max.y), Random.Range(Min.z, Max.z), Random.Range(Min.w, Max.w));
        }
    }
}