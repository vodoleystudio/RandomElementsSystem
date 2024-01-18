using System;
using UnityEngine;

namespace RandomElementsSystem.Types
{
    [Serializable]
    public class WeightPropertyGameObject : WeightProperty<GameObject>
    {
        /// <summary>
        /// Do not use this default constructor. It is used only for serialization.
        /// </summary>
        public WeightPropertyGameObject()
        {
        }

        public WeightPropertyGameObject(GameObject value, float weight) : base(value, weight)
        {
        }
    }
}