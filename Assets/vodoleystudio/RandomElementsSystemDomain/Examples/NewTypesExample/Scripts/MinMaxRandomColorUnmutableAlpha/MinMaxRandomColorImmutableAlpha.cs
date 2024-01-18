using Newtonsoft.Json;
using RandomElementsSystem.Types;

using System;
using UnityEngine;

using Random = UnityEngine.Random;

namespace RandomElementsSystem.Examples
{
    [Serializable]
    public class MinMaxRandomColorImmutableAlpha : MinMaxRandomColor
    {
        [SerializeField]
        [JsonProperty]
        [Range(0f, 1f)]
        private float _alpha = 1f;

        /// <summary>
        /// Do not use this default constructor. It is used only for serialization.
        /// </summary>
        public MinMaxRandomColorImmutableAlpha()
        {
        }

        public MinMaxRandomColorImmutableAlpha(Color min, Color max, float alpha) : base(min, max)
        {
            _alpha = alpha;
        }

        protected override Color GenerateRandomValue()
        {
            return new Color(Random.Range(Min.r, Max.r), Random.Range(Min.g, Max.g), Random.Range(Min.b, Max.b), _alpha);
        }
    }
}