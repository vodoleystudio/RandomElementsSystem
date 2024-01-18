using System;
using UnityEngine;

using Random = UnityEngine.Random;

namespace RandomElementsSystem.Types
{
    [Serializable]
    public class MinMaxRandomVector3Int : MinMaxRandomProperty<Vector3Int>
    {
        /// <summary>
        /// Do not use this default constructor. It is used only for serialization.
        /// </summary>
        public MinMaxRandomVector3Int()
        {
        }

        /// <summary>
        /// Creates a new instance of the MinMaxRandomVector3Int class with the specified min and max range.
        /// </summary>
        /// <param name="min">min range of Vector3Int value (inclusive)</param>
        /// <param name="max">max range of Vector3Int value (exclusive)</param>
        public MinMaxRandomVector3Int(Vector3Int min, Vector3Int max) : base(min, max)
        {
        }

        protected override Vector3Int GenerateRandomValue()
        {
            return new Vector3Int(Random.Range(Min.x, Max.x), Random.Range(Min.y, Max.y), Random.Range(Min.z, Max.z));
        }
    }
}