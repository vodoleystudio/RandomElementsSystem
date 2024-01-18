using System;

using Object = UnityEngine.Object;

namespace RandomElementsSystem.Types
{
    [Serializable]
    public class WeightPropertyUnityObject : WeightProperty<Object>
    {
        /// <summary>
        /// Do not use this default constructor. It is used only for serialization.
        /// </summary>
        public WeightPropertyUnityObject()
        {
        }

        /// <summary>
        /// Creates a new instance of WeightPropertyUnityObject.
        /// </summary>
        /// <param name="value">UnityEngine.Object value</param>
        /// <param name="weight">Weight of value</param>
        public WeightPropertyUnityObject(Object value, float weight) : base(value, weight)
        {
        }
    }
}