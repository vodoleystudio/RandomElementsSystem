using RandomElementsSystem.Types;

using UnityEngine;

namespace RandomElementsSystem.Examples
{
    public class InitializeAtRuntimeExample : MonoBehaviour
    {
        private void Start()
        {
            var itterations = 10;

            var selectiveRandomWeightFloat = new SelectiveRandomWeightFloat(new float[] { 1f, 2f, 3f }, false);

            for (int i = 0; i < itterations; i++)
            {
                Debug.Log(selectiveRandomWeightFloat.GetRandomValue());
            }

            // one line run option
            Debug.Log($"One line run option : {new SelectiveRandomWeightString(new string[] { "One", "Two", "Three" }, false).GetRandomValue()}");
        }
    }
}