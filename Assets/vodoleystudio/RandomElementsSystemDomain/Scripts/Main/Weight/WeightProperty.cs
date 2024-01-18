using Newtonsoft.Json;

using System;
using UnityEngine;

namespace RandomElementsSystem.Types
{
    [Serializable]
    public class WeightProperty<T>
    {
        public const float DefaultWeight = 1f;
        public const float MinWeight = 0f;

        [SerializeField]
        [JsonProperty]
        [Min(MinWeight)]
        private float _weight = DefaultWeight;

        [JsonIgnore]
        public float Weight => _weight;

        [SerializeField]
        [JsonProperty]
        private T _value;

        [JsonIgnore]
        public T Value => _value;

        /// <summary>
        /// Do not use this default constructor. It is used only for serialization.
        /// </summary>
        public WeightProperty()
        {
        }

        /// <summary>
        /// Creates a new instance of the WeightProperty class with the specified value and weight.
        /// </summary>
        /// <param name="value">Specified value</param>
        /// <param name="weight">Value weight in range (0f, float.Max), Default value is 1f</param>
        public WeightProperty(T value, float weight)
        {
            _value = value;
            _weight = Mathf.Clamp(weight, MinWeight, float.MaxValue);
        }
    }
}