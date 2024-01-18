using System;

using Random = UnityEngine.Random;

namespace RandomElementsSystem.Types
{
    [Serializable]
    public class MinMaxRandomInt : MinMaxRandomProperty<int>
    {
        /// <summary>
        /// Do not use this default constructor. It is used only for serialization.
        /// </summary>
        public MinMaxRandomInt()
        {
        }

        /// <summary>
        /// Creates a new instance of the MinMaxRandomInt class with the specified min and max range.
        /// </summary>
        /// <param name="min">min range of int value (inclusive)</param>
        /// <param name="max">max range of int value (exclusive)</param>
        public MinMaxRandomInt(int min, int max) : base(min, max)
        {
        }

        protected override int GenerateRandomValue()
        {
            return Random.Range(Min, Max);
        }
    }
}