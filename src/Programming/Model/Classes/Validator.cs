using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public static class Validator
    {
        public static void AssertStringContainsOnlyLettersEnglish(string value, string propertyName)
        {
            string lowercaseWord = value.ToLower();

            for (int i = 0; i < lowercaseWord.Length; i++)
            {
                if (!((lowercaseWord[i] >= 'a') && (lowercaseWord[i] <= 'z')))
                {
                    throw new ArgumentException($"Invalid value in the field: {propertyName}.");
                }
            }

        }

        public static void AssertOnPositiveValue(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("");
            }
        }
    }
}
