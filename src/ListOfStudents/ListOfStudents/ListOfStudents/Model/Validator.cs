using System;


namespace ListOfStudents.Model
{
    /// <summary>
    /// Предоставляет методы для проверки входных данных.
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// Проверяет переданную строку на кол-во символов.
        /// </summary>
        /// <param name="value">Строка.</param>
        /// <param name="maxLength">Максимальная длина строки.</param>
        /// <param name="propertyName">Имя метода.</param>
        /// <exception cref="ArgumentException">Если строка оказалась длиннее чем заданное
        /// максимальное значения длины.</exception>
        public static void AssertLengthString(string value, int maxLength, string propertyName)
        {
            if (value.Length > maxLength)
            {
                throw new ArgumentException($"Строка превышает максимальную длину: " +
                                            $"{maxLength} в поле {propertyName}.");
            }
        }

        /// <summary>
        /// Проверяет является ли переданная строка пустой.
        /// </summary>
        /// <param name="value">Строка.</param>
        /// <param name="propertyName">Имя свойства.</param>
        /// <exception cref="ArgumentException">Если строка оказалась пустой.</exception>
        public static void AssertEmptyValue(string value, string propertyName)
        {
            if (value == "")
            {
                throw new ArgumentException($"Строка не может быть пустой в поле {propertyName}");
            }
        }
    }
}
