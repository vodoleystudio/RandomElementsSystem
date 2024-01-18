using RandomElementsSystem.Types;

using System.Collections.Generic;
using UnityEngine;

namespace RandomElementsSystem.Examples
{
    public class CreateNewTypeAtRuntimeExample : MonoBehaviour
    {
        private void Start()
        {
            Debug.Log("Random on fly type :");
            var random = new SelectiveRandomWeightPropertyBase<double, WeightProperty<double>>(
                new Dictionary<double, float>()
                {
                    { 10000000000000000000000000000000000d, 10f },
                    { 3000000000d, 30f },
                    { 7000000000d, 70f }
                },
                true // all values will be proceeded once
            );

            // all values will be proceeded once
            for (int i = 0; i < 3; i++)
            {
                Debug.Log(random.GetRandomValue());
            }
        }
    }
}