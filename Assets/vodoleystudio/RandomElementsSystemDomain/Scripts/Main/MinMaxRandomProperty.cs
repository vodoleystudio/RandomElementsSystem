using Newtonsoft.Json;

using System;
using UnityEngine;

namespace RandomElementsSystem.Types
{
    [Serializable]
    public abstract class MinMaxRandomProperty<T> : RandomPropertyBase<T>
    {
        [Header("Range")]
        [Tooltip("inclusive")]
        [SerializeField]
        [JsonProperty]
        private T _min;

        [JsonIgnore]
        public T Min => _min;

        [Tooltip("For [int] based types (int/long/VectorInt/etc) : exclusive.\n\nFor [float] based types (float/Color/Vector/etc) : inclusive.")]
        [SerializeField]
        [JsonProperty]
        private T _max;

        [JsonIgnore]
        public T Max => _max;

        /// <summary>
        /// Do not use this default constructor. It is used only for serialization.
        /// </summary>
        public MinMaxRandomProperty()
        {
        }

        /// <summary>
        /// Creates a new instance of the MinMaxRandomProperty class with the specified min and max range and T value.
        /// For [int] based types (int/long/VectorInt/etc) : exclusive.
        /// For [float] based types (float/Color/Vector/etc) : inclusive.
        /// </summary>
        /// <param name="min">min range of T value</param>
        /// <param name="max">max range of T value</param>
        public MinMaxRandomProperty(T min, T max)
        {
            _min = min;
            _max = max;
        }
    }
}