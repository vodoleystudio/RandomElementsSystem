using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Random = UnityEngine.Random;

namespace RandomElementsSystem.Types
{
    /// <summary>
    /// Helper class for generating random strings.
    /// </summary>
    public static class RandomString
    {
        [Flags]
        public enum RandomStringType
        {
            AllCharacters = 1,
            LowerCase = 2 << 0,
            UpperCase = 2 << 1,
            Numbers = 2 << 2,
            SpecialCharactersWithoutSpace = 2 << 3,
            Space = 2 << 4,
            NumbersOnStart = 2 << 5,
            NumbersOnEnd = 2 << 6,
            UniqueCharsOutput = 2 << 7
        }

        private const int NUMBER_CHAR_START_RANGE = 48;
        private const int NUMBER_CHAR_END_RANGE = 58;

        public static string Next(int size, RandomStringType configuration)
        {
            var builder = new StringBuilder(size);

            var charsList = new List<int>();

            var isHasNumbersOnStart = ((configuration & RandomStringType.NumbersOnStart) == RandomStringType.NumbersOnStart);
            var isHasNumbersOnEnd = ((configuration & RandomStringType.NumbersOnEnd) == RandomStringType.NumbersOnEnd);

            if (configuration == RandomStringType.AllCharacters)
            {
                for (int i = 32; i < 127; i++)
                {
                    charsList.Add(i);
                }
            }
            else
            {
                if ((configuration & RandomStringType.LowerCase) == RandomStringType.LowerCase)
                {
                    for (int i = 97; i < 123; i++)
                    {
                        charsList.Add(i);
                    }
                }

                if ((configuration & RandomStringType.UpperCase) == RandomStringType.UpperCase)
                {
                    for (int i = 65; i < 91; i++)
                    {
                        charsList.Add(i);
                    }
                }

                if (((configuration & RandomStringType.Numbers) == RandomStringType.Numbers) || isHasNumbersOnStart || isHasNumbersOnEnd)
                {
                    for (int i = NUMBER_CHAR_START_RANGE; i < NUMBER_CHAR_END_RANGE; i++)
                    {
                        charsList.Add(i);
                    }
                }

                if ((configuration & RandomStringType.Space) == RandomStringType.Space)
                {
                    charsList.Add(32);
                }

                if ((configuration & RandomStringType.SpecialCharactersWithoutSpace) == RandomStringType.SpecialCharactersWithoutSpace)
                {
                    for (int i = 33; i < 48; i++)
                    {
                        charsList.Add(i);
                    }

                    for (int i = 58; i < 65; i++)
                    {
                        charsList.Add(i);
                    }

                    for (int i = 91; i < 97; i++)
                    {
                        charsList.Add(i);
                    }

                    for (int i = 123; i < 127; i++)
                    {
                        charsList.Add(i);
                    }
                }
            }

            List<char> numbersForStart = null;
            if (isHasNumbersOnStart)
            {
                numbersForStart = new List<char>();
            }
            List<char> numbersForEnd = null;
            if (isHasNumbersOnEnd)
            {
                numbersForEnd = new List<char>();
            }

            // generate
            charsList = charsList.Distinct().ToList();
            for (var i = 0; i < size; i++)
            {
                if (charsList.Count == 0)
                {
                    break;
                }

                var charIndex = Random.Range(0, charsList.Count);
                var currentIntChar = charsList[charIndex];

                if (currentIntChar >= NUMBER_CHAR_START_RANGE && currentIntChar < NUMBER_CHAR_END_RANGE)
                {
                    if ((isHasNumbersOnStart) && (isHasNumbersOnEnd))
                    {
                        if (i % 2 == 0)
                        {
                            numbersForStart.Add((char)currentIntChar);
                        }
                        else
                        {
                            numbersForEnd.Add((char)currentIntChar);
                        }
                    }
                    else if (isHasNumbersOnStart)
                    {
                        numbersForStart.Add((char)currentIntChar);
                    }
                    else if (isHasNumbersOnEnd)
                    {
                        numbersForEnd.Add((char)currentIntChar);
                    }
                    else
                    {
                        builder.Append((char)currentIntChar);
                    }
                }
                else
                {
                    builder.Append((char)currentIntChar);
                }

                if ((configuration & RandomStringType.UniqueCharsOutput) == RandomStringType.UniqueCharsOutput)
                {
                    charsList.RemoveAt(charIndex);
                }
            }

            // set choosed numbers accordingly
            if (numbersForStart != null)
            {
                builder.Insert(0, numbersForStart.ToArray());
            }
            if (numbersForEnd != null)
            {
                builder.Append(numbersForEnd.ToArray());
            }

            return builder.ToString();
        }
    }
}