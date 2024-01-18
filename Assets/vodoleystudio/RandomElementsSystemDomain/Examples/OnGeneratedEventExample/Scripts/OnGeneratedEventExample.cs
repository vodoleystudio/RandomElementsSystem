using RandomElementsSystem.Types;

using UnityEngine;

namespace RandomElementsSystem.Examples
{
    public class OnGeneratedEventExample : MonoBehaviour
    {
        [SerializeField]
        private RandomStringProperty _randomStringProperty;

        private void OnEnable()
        {
            _randomStringProperty.OnGenerated += OnGenerated;
        }

        private void OnDisable()
        {
            _randomStringProperty.OnGenerated -= OnGenerated;
        }

        private void Start()
        {
            var itterations = 3;
            for (int i = 0; i < itterations; i++)
            {
                _randomStringProperty.GetRandomValue();
            }
        }

        private void OnGenerated(string value)
        {
            Debug.Log($"Generated {value}");
        }
    }
}