using UnityEngine;

namespace RandomElementsSystem.Examples
{
    public class NewTypesExample : MonoBehaviour
    {
        [SerializeField]
        private SelectiveRandomWeightMyNewClassType _selectiveRandomWeightMyNewType;

        [SerializeField]
        private MinMaxRandomColorImmutableAlpha _minMaxRandomColorUnmutableAlpha;

        private void Start()
        {
            Debug.Log("SelectiveRandomWeightMyNewType :");
            for (int i = 0; i < 5; i++)
            {
                Debug.Log(_selectiveRandomWeightMyNewType.GetRandomValue().Name);
            }

            Debug.Log("MinMaxRandomColorUnmutableAlpha :");
            for (int i = 0; i < 5; i++)
            {
                Debug.Log(_minMaxRandomColorUnmutableAlpha.GetRandomValue());
            }

            Debug.Log("RandomMyNewEnumType :");
            var randomMyNewEnumType = new RandomMyNewEnumType();
            for (int i = 0; i < 5; i++)
            {
                Debug.Log(randomMyNewEnumType.GetRandomValue());
            }
        }
    }
}