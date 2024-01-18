using System;
using UnityEngine;

namespace RandomElementsSystem.Types
{
    [Serializable]
    public class WeightPropertyScriptableObject : WeightProperty<ScriptableObject>
    {
        /// <summary>
        /// Do not use this default constructor. It is used only for serialization.
        /// </summary>
        public WeightPropertyScriptableObject()
        {
        }

        /// <summary>
        /// Creates a new instance of WeightPropertyScriptableObject.
        /// </summary>
        /// <param name="value">ScriptableObject value</param>
        /// <param name="weight">Weight of value</param>
        public WeightPropertyScriptableObject(ScriptableObject value, float weight) : base(value, weight)
        {
        }
    }
}