using Newtonsoft.Json;
using System;
using UnityEngine;

namespace RandomElementsSystem.Examples
{
    [Serializable]
    public class MyNewClassType
    {
        [SerializeField]
        [JsonProperty]
        private string _name;

        public string Name => _name;

        [SerializeField]
        [JsonProperty]
        private int _age;

        public int Age => _age;
    }
}