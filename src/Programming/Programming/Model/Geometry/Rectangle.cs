using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Programming.Model
{
    /// <summary>
    /// Хранит информацию о прямоугольнике.
    /// </summary>
    public class Rectangle
    {
        /// <summary>
        /// Закрытый метод данного класса, хранит значение длинны(высоты) прямоугольника.
        /// </summary>
        private double _length;

        /// <summary>
        /// Закрытый метод данного класса, хранит значение ширины прямоугольника.
        /// </summary>
        private double _width;

        /// <summary>
        /// Закрытый метод данного класса, содержит количество всех созданных прямоугольников.
        /// </summary>
        private static double _allRectanglesCount;

        /// <summary>
        /// Возвращает уникальный идентификатор прямоугольника.
        /// </summary>
        public double _id { get; }

        /// <summary>
        /// Возвращает и задаёт название цвета прямоугольника.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Возвращает и задаёт значение координат прямоугольника типа <see cref="Point2D"/>.
        /// </summary>
        public Point2D Center { get; set; }

        /// <summary>
        /// Статичный метод класса <see cref="Rectangle"/>. Возвращает количество всех созданных прямоугольников.
        /// </summary>
        /// <returns>Количесвто созданных прямоугольников.</returns>
        public static double AllRectanglesCount()
        {
            return _allRectanglesCount;
        }
       
        /// <summary>
        /// Возвращает и задаёт значение длинны(высоты) прямоугольника. Значение должно быть положительным.
        /// </summary>
        public double Length
        {
            get
            {
                return _length;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Length));
                _length = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт значение ширины прямоугольника. Значение долно быть положительным.
        /// </summary>
        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Width));
                _width = value; 
            }
        }

        /// <summary>
        /// Создаёт уникальный экземпляр класс<see cref="Rectangle"/>.
        /// </summary>
        /// <param name="length">Параметр длинны(высоты), должен быть положительным.</param>
        /// <param name="width">Параметр ширины, должен быть положительным.</param>
        /// <param name="color">Название цвета.</param>
        /// <param name="center">Координаты в двумерном пространстве типа<see cref="Point2D"/>.</param>
        public Rectangle(double length, double width, string color, Point2D center)
        {
            Length = length;
            Width = width;
            Color = color;
            Center = center;
            _id = _allRectanglesCount;
            _allRectanglesCount = _allRectanglesCount + 1;
        }
        public Rectangle() { }
    }
}
