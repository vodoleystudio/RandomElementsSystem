using System;
using UnityEngine;

namespace RandomElementsSystem.Types
{
    [Serializable]
    public class WeightPropertyColor : WeightProperty<Color>
    {
        /// <summary>
        /// Do not use this default constructor. It is used only for serialization.
        /// </summary>
        public WeightPropertyColor()
        {
        }

        /// <summary>
        /// Creates a new instance of WeightPropertyColor.
        /// </summary>
        /// <param name="value">Color value</param>
        /// <param name="weight">Weight of value</param>
        public WeightPropertyColor(Color value, float weight) : base(value, weight)
        {
        }
    }
}