using UnityEngine;

using Random = UnityEngine.Random;

namespace RandomElementsSystem.Examples
{
    public class DefaultApproachExample2 : MonoBehaviour
    {
        // Need two fields for configurate min max random Vector3 in inspector
        // (too much extra fields for this simple task)
        [SerializeField]
        private Vector3 _minRandomVector3;

        [SerializeField]
        private Vector3 _maxRandomVector3;

        private void Start()
        {
            // Get random Vector3 value from range using default approach
            // (too much code for this simple task)
            Debug.Log(new Vector3(Random.Range(_minRandomVector3.x, _maxRandomVector3.x),
                                  Random.Range(_minRandomVector3.y, _maxRandomVector3.y),
                                  Random.Range(_minRandomVector3.z, _maxRandomVector3.z)));
        }
    }
}