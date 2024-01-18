using RandomElementsSystem.Types;

using UnityEngine;

namespace RandomElementsSystem.Examples
{
    public class MinMaxExample : MonoBehaviour
    {
        [SerializeField]
        private MinMaxRandomVector2 _minMaxRandomVector2;

        private void Start()
        {
            var itterations = 5;

            for (var i = 0; i < itterations; i++)
            {
                var value = _minMaxRandomVector2.GetRandomValue();
                Debug.Log($"x : {value.x}, y : {value.y}");
            }
        }
    }
}