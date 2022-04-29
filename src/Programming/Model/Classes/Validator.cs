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
                    throw new ArgumentException($"Некорректное значение в поле: {propertyName}.");
                }
            }
        }

        public static void AssertOnPositiveValue(int value, string propertyName)
        {
            if (value < 0)
            {
                throw new ArgumentException($"Отрицательное значение в поле: {propertyName}");
            }
        }

        public static void AssertOnPositiveValue(double value, string propertyName)
        {
            if (value < 0)
            {
                throw new ArgumentException($"Отрицательное значение в поле: {propertyName}");
            }
        }

        public static void AssertValueInRange(int value, int min, int max, string propertyName)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"Выход за диапазон значений в поле: {propertyName}");
            }
        }

        public static void AssertValueInRange(double value, double min, double max, string propertyName)
        {
            if (value < min | value > max)
            {
                throw new ArgumentException($"Выход за диапазон значений в поле: {propertyName}");
            }
        }
    }
}
