namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Хранит функционал для создания id.
    /// </summary>
    public static class IdGenerator
    {
        /// <summary>
        /// Уникальный идентификатор.
        /// </summary>
        private static int _id = 0;

        /// <summary>
        /// Предоставляет генерацию id.
        /// </summary>
        /// <returns>id в виде целочисленного числа.</returns>
        public static int GetIdNext()
        {
            return _id++;
        }
    }
}
