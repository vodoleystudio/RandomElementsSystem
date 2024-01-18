using System;

using Random = UnityEngine.Random;

namespace RandomElementsSystem.Types
{
    [Serializable]
    public class RandomBoolProperty : RandomPropertyBase<bool>
    {
        protected override bool GenerateRandomValue()
        {
            return Convert.ToBoolean(Random.Range(0, 2));
        }
    }
}