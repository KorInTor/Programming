using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace EmployeeApp
{
    /// <summary>
    /// Статичный класс хранящий основные цвета используемые в проекте.
    /// </summary>
    public static class AppColors
    {
        /// <summary>
        /// Статичное поле типа Color имеющие цвет LightPink.
        /// </summary>
        public static readonly Color ErrorColor = Color.LightPink;

        /// <summary>
        /// Статичное поле типа Color имеющие цвет White.
        /// </summary>
        public static readonly Color NormalColor = Color.White;

        /// <summary>
        /// Статичное поле типа Color имеющие цвет Black.
        /// </summary>
        public static readonly Color BlackColor = Color.Black;
    }
}
