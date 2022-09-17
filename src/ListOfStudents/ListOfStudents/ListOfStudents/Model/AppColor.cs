using ListOfStudents.View;
using System.Drawing;
using System.Windows.Forms;

namespace ListOfStudents.Model
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
        /// Цвет не активированного виджета.
        /// </summary>
        public static readonly Color NotEnabledWidget = MainForm.DefaultBackColor;
    }
}
