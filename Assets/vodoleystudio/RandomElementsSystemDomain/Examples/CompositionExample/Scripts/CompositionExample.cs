using UnityEngine;

namespace RandomElementsSystem.Examples
{
    public class CompositionExample : MonoBehaviour
    {
        // Composition property (consists from RandomWeightCollection with MinMaxRandom items)
        [SerializeField]
        private SelectiveRandomWeightMinMaxRandomInt _selectiveRandomWeightMinMaxRandomInt;

        private void Start()
        {
            var itterations = 5;

            // Possibility to subscribe to OnGenerated event
            _selectiveRandomWeightMinMaxRandomInt.OnGenerated += value => Debug.Log($"SelectiveRandomWeightMinMaxRandomInt.OnGenerated: {value}");

            for (int i = 0; i < itterations; i++)
            {
                _selectiveRandomWeightMinMaxRandomInt.GetRandomValue();
            }
        }
    }
}