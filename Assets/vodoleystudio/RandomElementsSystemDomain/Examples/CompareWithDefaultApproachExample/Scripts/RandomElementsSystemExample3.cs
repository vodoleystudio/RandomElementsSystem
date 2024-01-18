using RandomElementsSystem.Types;

using UnityEngine;

namespace RandomElementsSystem.Examples
{
    public class RandomElementsSystemExample3 : MonoBehaviour
    {
        [SerializeField]
        private SelectiveRandomWeightString _weightedDataCollection;

        private void Start()
        {
            // Get random weighted value using random elements system property
            // (compact and incapsulated code with all logic inside)
            Debug.Log(_weightedDataCollection.GetRandomValue());
        }
    }
}