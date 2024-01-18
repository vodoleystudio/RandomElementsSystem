using RandomElementsSystem.Types;

using UnityEngine;

namespace RandomElementsSystem.Examples
{
    public class RandomElementsSystemExample2 : MonoBehaviour
    {
        // Need only one field for configurate min max random Vector3 in inspector
        // (better organized inspector)
        [SerializeField]
        private MinMaxRandomVector3 _minMaxRandomVector3Property;

        private void Start()
        {
            // Get random Vector3 value from range using random elements system property
            // (compact and encapsulated code)
            Debug.Log(_minMaxRandomVector3Property.GetRandomValue());
        }
    }
}