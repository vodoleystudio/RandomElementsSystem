using RandomElementsSystem.Types;

using UnityEngine;

using Random = UnityEngine.Random;

namespace RandomElementsSystem.Examples
{
    public class CompareWithDefaultApproachExample1 : MonoBehaviour
    {
        #region Random int comparation using random elements system property and default approach

        [Header("Example 1. [Min max int] using random elements system property")]

        // Need only one field for configurate min max random int using random elements system property (compact inspector view)
        [SerializeField]
        private MinMaxRandomInt _minMaxRandomIntProperty;

        [Space(10)]
        [Header("Example 1. [Min max int] using default approach")]

        // Need two fields for configurate min max random int using default approach (unneded preparation fields for this simple task)
        [SerializeField]
        private int _minRandomInt;

        [SerializeField]
        private int _maxRandomInt;

        private void RandomInt()
        {
            // Get random int value from range using random elements system property (encapsulated code)
            Debug.Log(_minMaxRandomIntProperty.GetRandomValue());

            // Get random int value from range using default approach
            Debug.Log(Random.Range(_minRandomInt, _maxRandomInt));
        }

        #endregion Random int comparation using random elements system property and default approach
    }
}