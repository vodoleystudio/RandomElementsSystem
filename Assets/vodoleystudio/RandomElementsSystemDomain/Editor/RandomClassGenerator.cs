#if UNITY_EDITOR

using UnityEditor;
using System.IO;
using UnityEngine;

namespace RandomElementsSystem.Editor
{
    public class RandomClassGenerator : EditorWindow
    {
        private const string SaveScriptTitle = "Save Script";
        private const string ClassNameTag = "[CLASSNAME]";
        private const string MinMaxRandomTag = "MinMaxRandom";
        private const string RandomEnumTag = "Random";
        private const string RandomPropertyTag = "Random";
        private const string PropertyTag = "Property";
        private const string SelectiveRandomWeightTag = "SelectiveRandomWeight";
        private const string WeightPropertyTag = "WeightProperty";
        private const string ScriptsFolderPath = "Assets/vodoleystudio/RandomElementsSystemDomain/Scripts";

        [MenuItem("Tools/vodoleystudio/RandomElementsSystem/Generate MinMaxRandom for custom class type")]
        private static void GenerateMinMaxScript()
        {
            // Get the user-inputted script name
            string scriptName = EditorUtility.SaveFilePanel(SaveScriptTitle, ScriptsFolderPath, "Set exact name of your custom class type", "cs");

            // Check if the user canceled the save panel
            if (string.IsNullOrEmpty(scriptName))
            {
                return;
            }

            // Create a new MinMaxRandom C# script template
            string scriptContent = GenerateMinMaxRandomContent();

            var name = Path.GetFileNameWithoutExtension(scriptName);
            scriptContent = scriptContent.Replace(ClassNameTag, name);

            scriptName = scriptName.Replace(name, MinMaxRandomTag + name);

            Save(scriptName, scriptContent);
        }

        [MenuItem("Tools/vodoleystudio/RandomElementsSystem/Generate SelectiveRandomWeight for custom class type")]
        private static void GenerateSelectiveScript()
        {
            // Get the user-inputted script name
            string originalScriptName = EditorUtility.SaveFilePanel(SaveScriptTitle, ScriptsFolderPath, "Set exact name of your custom class type", "cs");
            string scriptName = originalScriptName;

            // Check if the user canceled the save panel
            if (string.IsNullOrEmpty(scriptName))
            {
                return;
            }

            // Create a new SelectiveRandomWeight C# script template
            string scriptContent = GenerateSelectiveRandomWeightContent();

            var name = Path.GetFileNameWithoutExtension(scriptName);
            scriptContent = scriptContent.Replace(ClassNameTag, name);

            scriptName = scriptName.Replace(name, SelectiveRandomWeightTag + name);

            Save(scriptName, scriptContent);

            // Create a new C# WeightProperty script template
            scriptName = originalScriptName;
            scriptContent = GenerateWeightPropertyContent();

            name = Path.GetFileNameWithoutExtension(scriptName);
            scriptContent = scriptContent.Replace(ClassNameTag, name);

            scriptName = scriptName.Replace(name, WeightPropertyTag + name);

            Save(scriptName, scriptContent);
        }

        [MenuItem("Tools/vodoleystudio/RandomElementsSystem/Generate RandomEnum for custom enum type")]
        private static void GenerateEnumScript()
        {
            // Get the user-inputted script name
            string scriptName = EditorUtility.SaveFilePanel(SaveScriptTitle, ScriptsFolderPath, "Set exact name of your custom enum type", "cs");

            // Check if the user canceled the save panel
            if (string.IsNullOrEmpty(scriptName))
            {
                return;
            }

            // Create a new MinMaxRandom C# script template
            string scriptContent = GenerateEnumPropertyContent();

            var name = Path.GetFileNameWithoutExtension(scriptName);
            scriptContent = scriptContent.Replace(ClassNameTag, name);

            scriptName = scriptName.Replace(name, RandomEnumTag + name);

            Save(scriptName, scriptContent);
        }

        [MenuItem("Tools/vodoleystudio/RandomElementsSystem/Generate RandomProperty for custom type")]
        private static void GenerateRandomPropertyScript()
        {
            // Get the user-inputted script name
            string scriptName = EditorUtility.SaveFilePanel(SaveScriptTitle, ScriptsFolderPath, "Set exact name of your custom type", "cs");

            // Check if the user canceled the save panel
            if (string.IsNullOrEmpty(scriptName))
            {
                return;
            }

            // Create a new MinMaxRandom C# script template
            string scriptContent = GenerateRandomPropertyContent();

            var name = Path.GetFileNameWithoutExtension(scriptName);
            scriptContent = scriptContent.Replace(ClassNameTag, name);

            scriptName = scriptName.Replace(name, RandomPropertyTag + name + PropertyTag);

            Save(scriptName, scriptContent);
        }

        private static void Save(string scriptName, string scriptContent)
        {
            if (File.Exists(scriptName))
            {
                Debug.LogError($"File {scriptName} already exists, skip");
                return;
            }

            // Save the script to the selected path
            File.WriteAllText(scriptName, scriptContent);

            // Refresh the Unity project window to show the new script
            AssetDatabase.Refresh();
        }

        private static string GenerateMinMaxRandomContent()
        {
            return @"
// Auto-generated by RandomElementsSystem.Editor.RandomClassGenerator
using RandomElementsSystem.Types;

using System;
using UnityEngine;

using Random = UnityEngine.Random;

namespace RandomElementsSystem.CustomTypes
{
    [Serializable]
    public class MinMaxRandom[CLASSNAME] : MinMaxRandomProperty<[CLASSNAME]>
    {
        /// <summary>
        /// Do not use this default constructor. It is used only for serialization.
        /// </summary>
        public MinMaxRandom[CLASSNAME]()
        {
        }

        /// <summary>
        /// Creates a new instance of the MinMaxRandom[CLASSNAME] class with the specified min and max range.
        /// </summary>
        /// <param name=""min"">min range of [CLASSNAME] value</param>
        /// <param name=""max"">max range of [CLASSNAME] value</param>
        public MinMaxRandom[CLASSNAME]([CLASSNAME] min, [CLASSNAME] max) : base(min, max)
        {
        }

        protected override [CLASSNAME] GenerateRandomValue()
        {
            throw new NotImplementedException(""Fill your min max logic here"");
        }
    }
}";
        }

        private static string GenerateSelectiveRandomWeightContent()
        {
            return @"
// Auto-generated by RandomElementsSystem.Editor.RandomClassGenerator
using RandomElementsSystem.Types;

using System;
using System.Collections.Generic;

namespace RandomElementsSystem.CustomTypes
{
    [Serializable]
    public class SelectiveRandomWeight[CLASSNAME] : SelectiveRandomWeightPropertyBase<[CLASSNAME], WeightProperty[CLASSNAME]>
    {
        /// <summary>
        /// Do not use this default constructor. It is used only for serialization.
        /// </summary>
        public SelectiveRandomWeight[CLASSNAME]()
        {
        }

        /// <summary>
        /// Creates new instance of SelectiveRandomWeight[CLASSNAME] with equal weight for all items.
        /// </summary>
        /// <param name=""selectableValues"">[CLASSNAME] items</param>
        /// <param name=""isUseEachItemOncePerCycle"">Set this flag to true if you want to use each item once per cycle. (non-repetitions random during each cycle). More info in _isUseEachItemOncePerCycle comment.</param>
        public SelectiveRandomWeight[CLASSNAME](IEnumerable<[CLASSNAME]> selectableValues, bool isUseEachItemOncePerCycle) : base(selectableValues, isUseEachItemOncePerCycle)
        {
        }

        /// <summary>
        /// Creates new instance of SelectiveRandomWeight[CLASSNAME] from collection of [CLASSNAME] values and their weights.
        /// </summary>
        /// <param name=""selectableValues"">Collection of [CLASSNAME] items as Keys and their weights as Values</param>
        /// <param name=""isUseEachItemOncePerCycle"">Set this flag to true if you want to use each item once per cycle. (non-repetitions random during each cycle). More info in _isUseEachItemOncePerCycle comment.</param>
        public SelectiveRandomWeight[CLASSNAME](ICollection<KeyValuePair<[CLASSNAME], float>> selectableValues, bool isUseEachItemOncePerCycle) : base(selectableValues, isUseEachItemOncePerCycle)
        {
        }

        /// <summary>
        /// Creates new instance of SelectiveRandomWeight[CLASSNAME] from collection of WeightProperty[CLASSNAME] and their weights.
        /// </summary>
        /// <param name=""selectableValues"">Collection of WeightProperty[CLASSNAME] items</param>
        /// <param name=""isUseEachItemOncePerCycle"">Set this flag to true if you want to use each item once per cycle. (non-repetitions random during each cycle). More info in _isUseEachItemOncePerCycle comment.</param>
        /// <param name=""isEqualWeightForAllItems"">Set this flag to true if you want that all items have equal weight.</param>
        public SelectiveRandomWeight[CLASSNAME](IEnumerable<WeightProperty[CLASSNAME]> selectableValues, bool isUseEachItemOncePerCycle, bool isEqualWeightForAllItems) : base(selectableValues, isUseEachItemOncePerCycle, isEqualWeightForAllItems)
        {
        }
    }
}";
        }

        private static string GenerateWeightPropertyContent()
        {
            return @"
// Auto-generated by RandomElementsSystem.Editor.RandomClassGenerator
using RandomElementsSystem.Types;

using System;

namespace RandomElementsSystem.CustomTypes
{
    [Serializable]
    public class WeightProperty[CLASSNAME] : WeightProperty<[CLASSNAME]>
    {
        /// <summary>
        /// Do not use this default constructor. It is used only for serialization.
        /// </summary>
        public WeightProperty[CLASSNAME]()
        {
        }

        /// <summary>
        /// Creates a new instance of the WeightProperty[CLASSNAME] class with the specified value and weight.
        /// </summary>
        /// <param name=""value"">Specified value</param>
        /// <param name=""weight"">Value weight in range (0f, float.Max), Default value is 1f</param>
        public WeightProperty[CLASSNAME]([CLASSNAME] value, float weight) : base(value, weight)
        {
        }
    }
}";
        }

        private static string GenerateEnumPropertyContent()
        {
            return @"
// Auto-generated by RandomElementsSystem.Editor.RandomClassGenerator
using RandomElementsSystem.Types;

using System;

namespace RandomElementsSystem.CustomTypes
{
    [Serializable]
    public class Random[CLASSNAME] : RandomEnumProperty<[CLASSNAME]>
    {
    }
}";
        }

        private static string GenerateRandomPropertyContent()
        {
            return @"
// Auto-generated by RandomElementsSystem.Editor.RandomClassGenerator
using RandomElementsSystem.Types;

using System;

using Random = UnityEngine.Random;

namespace RandomElementsSystem.CustomTypes
{
    [Serializable]
    public class Random[CLASSNAME]Property : RandomPropertyBase<[CLASSNAME]>
    {
        protected override [CLASSNAME] GenerateRandomValue()
        {
            throw new NotImplementedException(""Fill your generate random logic here"");
        }
    }
}";
        }
    }
}

#endif