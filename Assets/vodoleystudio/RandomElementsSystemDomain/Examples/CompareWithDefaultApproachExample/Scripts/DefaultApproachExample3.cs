using System;
using System.Collections.Generic;
using UnityEngine;

using Random = UnityEngine.Random;

namespace RandomElementsSystem.Examples
{
    public class DefaultApproachExample3 : MonoBehaviour
    {
        [SerializeField]
        private List<WeightedData> _weightedDataCollection;

        // 1. Need create an extra class that keeps weight and value fields
        [Serializable]
        public class WeightedData
        {
            public float Weight;
            public string Value;
        }

        // 2. Need to implement logic for getting random value from weighted collection
        private void Start()
        {
            // Get random weighted value using default approach
            // (too much code for this simple task)
            if (_weightedDataCollection.Count > 0)
            {
                WeightedData weightedData = null;
                var weightMin = 0f;
                var weightSum = weightMin;

                foreach (var selectableValue in _weightedDataCollection)
                {
                    weightSum += selectableValue.Weight;
                }

                var random = Random.Range(0f, weightSum);
                foreach (var selectableValue in _weightedDataCollection)
                {
                    var weightStep = selectableValue.Weight;
                    var maxRandom = weightMin + weightStep;
                    if ((random > weightMin || Mathf.Approximately(random, weightMin)) && (random < maxRandom || Mathf.Approximately(random, maxRandom)))
                    {
                        weightedData = selectableValue;
                        break;
                    }

                    weightMin += weightStep;
                }

                Debug.Log(weightedData.Value);
            }
        }

        // 3. Need to implement other features that already implemented in RandomElementsSystem
        // (like probability, equal weight for all items, etc)
    }
}