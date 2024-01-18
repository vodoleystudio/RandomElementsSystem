using RandomElementsSystem.Types;

using System;

namespace RandomElementsSystem.Examples
{
    [Serializable]
    public class WeightPropertyMyNewClassType : WeightProperty<MyNewClassType>
    {
        /// <summary>
        /// Do not use this default constructor. It is used only for serialization.
        /// </summary>
        public WeightPropertyMyNewClassType()
        {
        }

        public WeightPropertyMyNewClassType(MyNewClassType value, float weight) : base(value, weight)
        {
        }
    }
}