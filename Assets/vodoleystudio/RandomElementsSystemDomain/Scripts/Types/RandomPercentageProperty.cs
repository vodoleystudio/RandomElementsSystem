using Newtonsoft.Json;

using System;
using UnityEngine;

using Random = UnityEngine.Random;

namespace RandomElementsSystem.Types
{
    [Serializable]
    public class RandomPercentageProperty : RandomPropertyBase<bool>
    {
        private const float Min = 0f;
        private const float Max = 100f;

        /// <summary>
        /// Expected percentage of success. Value must be in range (0f, 100f)
        /// </summary>
        [Range(Min, Max)]
        [SerializeField]
        [JsonProperty]
        private float _percentage;

        /// <summary>
        /// Expected percentage of success. Value in range (0f, 100f)
        /// </summary>
        [JsonIgnore]
        public float Percentage => _percentage;

        /// <summary>
        /// Do not use this default constructor. It is used only for serialization.
        /// </summary>
        public RandomPercentageProperty()
        {
        }

        /// <summary>
        /// Creates random percentage property with given percentage value.
        /// </summary>
        /// <param name="percentage">Expected percentage of success. Value must be in range (0f, 100f)</param>
        public RandomPercentageProperty(float percentage)
        {
            _percentage = Mathf.Clamp(percentage, Min, Max);
        }

        protected override bool GenerateRandomValue()
        {
            if (Percentage <= Min)
            {
                return false;
            }
            else if (Percentage < Max)
            {
                var randomValue = Random.Range(Min, Max);
                if (randomValue >= Percentage)
                {
                    return false;
                }
            }

            return true;
        }
    }
}