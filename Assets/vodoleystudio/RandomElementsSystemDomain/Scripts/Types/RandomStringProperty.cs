using Newtonsoft.Json;

using System;
using UnityEngine;

using static RandomElementsSystem.Types.RandomString;

namespace RandomElementsSystem.Types
{
    [Serializable]
    public class RandomStringProperty : RandomPropertyBase<string>
    {
        /// <summary>
        /// Configurate content of the returned string (numbers only/specific characters/etc)
        /// </summary>
        [JsonProperty]
        [SerializeField]
        private RandomStringType _randomStringType;

        /// <summary>
        /// Configurate min max length of generated string
        /// </summary>
        [JsonProperty]
        [SerializeField]
        private MinMaxRandomInt _minMaxRandomInt;

        /// <summary>
        /// Do not use this default constructor. It is used only for serialization.
        /// </summary>
        public RandomStringProperty()
        {
        }

        /// <summary>
        /// Creates a RandomStringProperty property with a random string of a given length.
        /// </summary>
        /// <param name="minSize">min possible size of generated string</param>
        /// <param name="maxSize">max possible size of generated string (exclusive)</param>
        /// <param name="randomStringType">Flag for configurate content of the returned string (numbers only/specific characters/etc)</param>
        public RandomStringProperty(int minSize, int maxSize, RandomStringType randomStringType)
        {
            _minMaxRandomInt = new MinMaxRandomInt(minSize, maxSize);
            _randomStringType = randomStringType;
        }

        protected override string GenerateRandomValue()
        {
            return Next(_minMaxRandomInt.GetRandomValue(), _randomStringType);
        }
    }
}