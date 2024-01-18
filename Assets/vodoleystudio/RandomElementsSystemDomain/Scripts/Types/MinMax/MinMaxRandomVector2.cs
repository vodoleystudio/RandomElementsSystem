using System;
using UnityEngine;

using Random = UnityEngine.Random;

namespace RandomElementsSystem.Types
{
    [Serializable]
    public class MinMaxRandomVector2 : MinMaxRandomProperty<Vector2>
    {
        /// <summary>
        /// Do not use this default constructor. It is used only for serialization.
        /// </summary>
        public MinMaxRandomVector2()
        {
        }

        /// <summary>
        /// Creates a new instance of the MinMaxRandomVector2 class with the specified min and max range.
        /// </summary>
        /// <param name="min">min range of Vector2 value (inclusive)</param>
        /// <param name="max">max range of Vector2 value (inclusive)</param>
        public MinMaxRandomVector2(Vector2 min, Vector2 max) : base(min, max)
        {
        }

        protected override Vector2 GenerateRandomValue()
        {
            return new Vector2(Random.Range(Min.x, Max.x), Random.Range(Min.y, Max.y));
        }
    }
}