using RandomElementsSystem.Types;

using UnityEngine;

namespace RandomElementsSystem.Examples
{
    public class SelectiveExample : MonoBehaviour
    {
        [SerializeField]
        private SelectiveRandomWeightGameObject _selectiveRandomWeightGameObject;

        private MinMaxRandomVector3 _randomPositions = new MinMaxRandomVector3(-5 * Vector3.one, 5 * Vector3.one);

        private void Start()
        {
            var itterations = 20;

            Debug.Log($"Configurated probabilities are :");
            foreach (var item in _selectiveRandomWeightGameObject.GetValueToProbabilityCollection())
            {
                Debug.Log($"[{item.Key}] Probability is : {item.Value}%");
            }

            Debug.Log($"Start generate :");
            for (var i = 0; i < itterations; i++)
            {
                Generate();
            }
        }

        public void Generate()
        {
            var value = _selectiveRandomWeightGameObject.GetRandomValue();
            var instance = Instantiate(value);
            instance.transform.position = _randomPositions.GetRandomValue();
            Debug.Log($"Created {instance.name}");
        }
    }
}