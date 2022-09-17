using System;


namespace Programming.Model.Classes
{
    /// <summary>
    /// Предоставляет методы для проверки входных данных.
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// Проверяет входную строку на наличие только латинских символов.
        /// </summary>
        /// <param name="value">Строка, которая должны быть проверена.</param>
        /// <param name="propertyName">Имя свойства, из которого был вызван метод.</param>
        /// <exception cref="ArgumentException">Выбрасывается, если в строке есть хотя бы
        /// один не латинский символ.</exception>
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

        /// <summary>
        /// Проверяет передаваемое целое число на положительное значение.
        /// </summary>
        /// <param name="value">Число для проверки.</param>
        /// <param name="propertyName">Имя свойства, из которого был вызван метод.</param>
        /// <exception cref="ArgumentException">Выбрасывается, если число меньше нуля.</exception>
        public static void AssertOnPositiveValue(int value, string propertyName)
        {
            if (value < 0)
            {
                throw new ArgumentException($"Отрицательное значение в поле: {propertyName}");
            }
        }

        /// <summary>
        /// Проверяет передаваемое целое число на положительное значение.
        /// </summary>
        /// <param name="value">Число для проверки.</param>
        /// <param name="propertyName">Имя свойства, из которого был вызван метод.</param>
        /// <exception cref="ArgumentException">Выбрасывается, если число меньше нуля.</exception>
        public static void AssertOnPositiveValue(double value, string propertyName)
        {
            if (value < 0)
            {
                throw new ArgumentException($"Отрицательное значение в поле: {propertyName}");
            }
        }

        /// <summary>
        /// Проверяет, находится ли число в заданном диапазоне.
        /// </summary>
        /// <param name="value">Число для проверки.</param>
        /// <param name="min">Левая граница диапазона(включительно).</param>
        /// <param name="max">Правая граница диапазона(включительно).</param>
        /// <param name="propertyName">Имя свойства, из которого был вызван метод.</param>
        /// <exception cref="ArgumentException">Выбрасывается, если число
        /// выходит за границы диапазона</exception>
        public static void AssertValueInRange(int value, int min, int max, string propertyName)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"Выход за диапазон значений в поле: {propertyName}");
            }
        }

        /// <summary>
        /// Проверяет, находится ли число в заданном диапазоне.
        /// </summary>
        /// <param name="value">Число для проверки.</param>
        /// <param name="min">Левая граница диапазона(включительно).</param>
        /// <param name="max">Правая граница диапазона(включительно).</param>
        /// <param name="propertyName">Имя свойства, из которого был вызван метод.</param>
        /// <exception cref="ArgumentException">Выбрасывается, если число
        /// выходит за границы диапазона</exception>
        public static void AssertValueInRange(double value, double min, double max, string propertyName)
        {
            if (value < min | value > max)
            {
                throw new ArgumentException($"Выход за диапазон значений в поле: {propertyName}");
            }
        }
    }
}
