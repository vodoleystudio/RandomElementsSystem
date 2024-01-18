using System;
using UnityEngine;

using Random = UnityEngine.Random;

namespace RandomElementsSystem.Types
{
    [Serializable]
    public class MinMaxRandomVector2Int : MinMaxRandomProperty<Vector2Int>
    {
        /// <summary>
        /// Do not use this default constructor. It is used only for serialization.
        /// </summary>
        public MinMaxRandomVector2Int()
        {
        }

        /// <summary>
        /// Creates a new instance of the MinMaxRandomVector2Int class with the specified min and max range.
        /// </summary>
        /// <param name="min">min range of Vector2Int value (inclusive)</param>
        /// <param name="max">max range of Vector2Int value (exclusive)</param>
        public MinMaxRandomVector2Int(Vector2Int min, Vector2Int max) : base(min, max)
        {
        }

        protected override Vector2Int GenerateRandomValue()
        {
            return new Vector2Int(Random.Range(Min.x, Max.x), Random.Range(Min.y, Max.y));
        }
    }
}