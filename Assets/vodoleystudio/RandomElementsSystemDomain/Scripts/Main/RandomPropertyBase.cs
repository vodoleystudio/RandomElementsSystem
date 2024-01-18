using System;

namespace RandomElementsSystem.Types
{
    /// <summary>
    /// Main base class for all random properties.
    /// </summary>
    /// <typeparam name="T">Specific type</typeparam>
    [Serializable]
    public abstract class RandomPropertyBase<T>
    {
        /// <summary>
        /// Event that is invoked when random value is generated.
        /// </summary>
        public event Action<T> OnGenerated;

        /// <summary>
        /// Generates random value of type T.
        /// </summary>
        /// <returns>T type value</returns>
        public T GetRandomValue()
        {
            var value = GenerateRandomValue();
            OnGenerated?.Invoke(value);
            return value;
        }

        /// <summary>
        /// Generates random value of type T.
        /// Inner overridable method.
        /// </summary>
        /// <returns>T type value</returns>
        protected abstract T GenerateRandomValue();
    }
}