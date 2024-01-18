using RandomElementsSystem.Types;

using UnityEngine;

using Random = UnityEngine.Random;

namespace RandomElementsSystem.Examples
{
    public class CompareWithDefaultApproachExample4 : MonoBehaviour
    {
        #region Random chance based on percentage comparation using random elements system property and default approach

        private void RandomChanceBasedOnPercentage()
        {
            // Get random chance based on percentage valueusing random elements system property (simple and elegant solution)
            Debug.Log(new RandomPercentageProperty(10f).GetRandomValue());

            // Get random chance based on percentage value using default approach (too much magic numbers and comparation code)
            Debug.Log(Random.Range(0f, 100f) <= 10f);
        }

        #endregion Random chance based on percentage comparation using random elements system property and default approach
    }
}