using System.Drawing;


namespace Programming.Model.Classes
{
    /// <summary>
    /// Класс хранящий в себе используемые цвета.
    /// </summary>
    public static class AppColor
    {
        /// <summary>
        /// Цвет корректного значения.
        /// </summary>
        public static readonly Color ErrorBackColor = Color.LightPink;

        /// <summary>
        /// Цвет некорректного значения.
        /// </summary>
        public static readonly Color NormalBackColor = Color.White;

        /// <summary>
        /// Цвет непересекающихся фигур.
        /// </summary>
        public static readonly Color NotCollision = Color.FromArgb(127, 127, 255, 127);

        /// <summary>
        /// Цвет пересекающихся фигур.
        /// </summary>
        public static readonly Color Collision = Color.FromArgb(127, 255, 127, 127);
    } 
}
