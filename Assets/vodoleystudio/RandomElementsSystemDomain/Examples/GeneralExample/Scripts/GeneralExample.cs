using RandomElementsSystem.Types;

using System.Collections.Generic;
using UnityEngine;

namespace RandomElementsSystem.Examples
{
    public class GeneralExample : MonoBehaviour
    {
        [SerializeField]
        private MinMaxRandomInt _minMaxRandomIntConfiguratedInEditor;

        private void Start()
        {
            // Get random value from range that confiurated in editor
            // return random value in range configurated in editor inspector
            Debug.Log(_minMaxRandomIntConfiguratedInEditor.GetRandomValue());

            // Configurated and executed in code
            // return random value between 0 inclusive and 10 ecxlusive
            Debug.Log(new MinMaxRandomInt(0, 10).GetRandomValue());

            // Created and executed new type in code
            // return random value from possible values of AnimationBlendMode enum
            Debug.Log(new RandomEnumProperty<AnimationBlendMode>().GetRandomValue());

            // Configurated and executed in code
            // return random value from 0, 1, 2, 3, 4 with weights 1, 1, 1, 1, 6
            // (for all except value 4 the probability is 10%, for value 4 the probability is 60%)
            Debug.Log(new SelectiveRandomWeightInt(new Dictionary<int, float>
            {
                { 0, 1f },
                { 1, 1f },
                { 2, 1f },
                { 3, 1f },
                { 4, 6f }
            },
            false).GetRandomValue());

            // Configurated and executed in code with _isUseEachItemOncePerCycle enabled
            // in first call return random value from 0, 1, 2 with weights 1, 3, 6 (10%, 30% and 60% respectively)
            //
            // for exampe :
            //  if in first call 0 was generated, then in next call the probability of 0 will be 0%
            //  and the probability of 1 will be 33.33%
            //  and the probability of 2 will be 66.66%
            //  after second call the probability of the last item will be 100%
            //  on fourth call the probabilities will be with initial values 10%, 30% and 60% respectively
            Debug.Log(new SelectiveRandomWeightInt(new Dictionary<int, float>
            {
                { 0, 1f },
                { 1, 3f },
                { 2, 6f }
            },
            // _isUseEachItemOncePerCycle flag means :
            //  the generated value will be not generated again until all other values will be not generated
            //  the probability of all remain items will be changed each time when value will be generated
            true
            ).GetRandomValue());
        }
    }
}