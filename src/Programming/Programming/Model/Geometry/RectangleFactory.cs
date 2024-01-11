using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Colors = Programming.Model.Colors;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Статический класс хранит метод создания нового прямоугольника типа <see cref="Rectangle"/>
    /// </summary>
    public static class RectangleFactory
    {
        /// <summary>
        /// Закрытое статичное поле типа <see cref="Random"/>.
        /// </summary>
        private static readonly Random _random = new Random();

        /// <summary>
        /// Создаёт и возвращает новый экземпляр класса <see cref="Rectangle"/> 
        /// заполняя значения случайно но не выходя за заданные рамки.
        /// </summary>
        /// <param name="rectangleWidth">Максимальное значение Ширины.</param>
        /// <param name="rectangleHeight">Максимальное значение Длинны(высоты).</param>
        /// <returns>Новый экземпляр класса <see cref="Rectangle"/>.</returns>
        public static Rectangle Randomize(int rectangleWidth, int rectangleHeight)
        {
            int lengthColor = Enum.GetNames(typeof(Colors)).Length;
            var x = _random.Next(1, rectangleWidth - 1);
            var y = _random.Next(1, rectangleHeight - 1);
            var color = ((Colors)_random.Next(lengthColor)).ToString();
            var width = _random.Next(1, rectangleWidth - x);
            var length = _random.Next(1, rectangleHeight - y);
            var rectangle = new Rectangle(length, width, color, new Point2D(x, y));
            return rectangle;
        }
    }
}
