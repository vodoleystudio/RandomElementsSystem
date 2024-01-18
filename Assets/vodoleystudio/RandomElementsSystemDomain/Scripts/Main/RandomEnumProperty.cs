using System;
using System.Collections.Generic;

using Random = UnityEngine.Random;

namespace RandomElementsSystem.Types
{
    [Serializable]
    public class RandomEnumProperty<T> : RandomPropertyBase<T> where T : Enum
    {
        /// <summary>
        /// Keeps all enum values.
        /// </summary>
        private List<T> _values = new List<T>((T[])Enum.GetValues(typeof(T)));

        protected override T GenerateRandomValue()
        {
            if (_values.Count == 0)
            {
                return default;
            }

            return _values[Random.Range(0, _values.Count)];
        }
    }
}