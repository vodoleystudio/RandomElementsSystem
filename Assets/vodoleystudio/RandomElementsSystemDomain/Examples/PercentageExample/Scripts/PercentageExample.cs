using RandomElementsSystem.Types;

using UnityEngine;

namespace RandomElementsSystem.Examples
{
    public class PercentageExample : MonoBehaviour
    {
        [SerializeField]
        private RandomPercentageProperty _randomPercentageProperty;

        private void Start()
        {
            var itterations = 100;
            var successCount = 0;
            Debug.Log($"Chance is {_randomPercentageProperty.Percentage} %");
            Debug.Log($"Running {itterations} times");
            for (int i = 0; i < itterations; i++)
            {
                var isSucces = _randomPercentageProperty.GetRandomValue();
                if (isSucces)
                {
                    successCount++;
                }
                Debug.Log($"{i}) IsSuccess : {isSucces}");
            }

            Debug.Log($"Success rate is {((float)successCount / itterations) * 100f} %");
        }
    }
}