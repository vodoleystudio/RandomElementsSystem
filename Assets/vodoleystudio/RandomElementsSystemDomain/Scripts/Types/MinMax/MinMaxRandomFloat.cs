using System;

using Random = UnityEngine.Random;

namespace RandomElementsSystem.Types
{
    [Serializable]
    public class MinMaxRandomFloat : MinMaxRandomProperty<float>
    {
        /// <summary>
        /// Do not use this default constructor. It is used only for serialization.
        /// </summary>
        public MinMaxRandomFloat()
        {
        }

        /// <summary>
        /// Creates a new instance of the MinMaxRandomFloat class with the specified min and max range.
        /// </summary>
        /// <param name="min">min range of float value (inclusive)</param>
        /// <param name="max">max range of float value (inclusive)</param>
        public MinMaxRandomFloat(float min, float max) : base(min, max)
        {
        }

        protected override float GenerateRandomValue()
        {
            return Random.Range(Min, Max);
        }
    }
}