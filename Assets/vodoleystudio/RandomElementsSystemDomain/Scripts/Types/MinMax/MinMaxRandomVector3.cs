using System;
using UnityEngine;

using Random = UnityEngine.Random;

namespace RandomElementsSystem.Types
{
    [Serializable]
    public class MinMaxRandomVector3 : MinMaxRandomProperty<Vector3>
    {
        /// <summary>
        /// Do not use this default constructor. It is used only for serialization.
        /// </summary>
        public MinMaxRandomVector3()
        {
        }

        /// <summary>
        /// Creates a new instance of the MinMaxRandomVector3 class with the specified min and max range.
        /// </summary>
        /// <param name="min">min range of Vector3 value (inclusive)</param>
        /// <param name="max">max range of Vector3 value (inclusive)</param>
        public MinMaxRandomVector3(Vector3 min, Vector3 max) : base(min, max)
        {
        }

        protected override Vector3 GenerateRandomValue()
        {
            return new Vector3(Random.Range(Min.x, Max.x), Random.Range(Min.y, Max.y), Random.Range(Min.z, Max.z));
        }
    }
}