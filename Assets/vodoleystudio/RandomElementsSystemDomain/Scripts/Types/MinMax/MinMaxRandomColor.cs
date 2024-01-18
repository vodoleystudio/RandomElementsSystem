using System;
using UnityEngine;

using Random = UnityEngine.Random;

namespace RandomElementsSystem.Types
{
    [Serializable]
    public class MinMaxRandomColor : MinMaxRandomProperty<Color>
    {
        /// <summary>
        /// Do not use this default constructor. It is used only for serialization.
        /// </summary>
        public MinMaxRandomColor()
        {
        }

        /// <summary>
        /// Creates a new instance of the MinMaxRandomColor class with the specified min and max range.
        /// </summary>
        /// <param name="min">min range of Color value (inclusive)</param>
        /// <param name="max">max range of Color value (inclusive)</param>
        public MinMaxRandomColor(Color min, Color max) : base(min, max)
        {
        }

        protected override Color GenerateRandomValue()
        {
            return new Color(Random.Range(Min.r, Max.r), Random.Range(Min.g, Max.g), Random.Range(Min.b, Max.b), Random.Range(Min.a, Max.a));
        }
    }
}