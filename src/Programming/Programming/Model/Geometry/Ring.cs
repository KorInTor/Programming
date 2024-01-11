using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Хранит данные о двемрном кольце.
    /// </summary>
    public class Ring
    {
        /// <summary>
        /// Закрытое поле данного класса, хранит значение внутреннего радиуса.
        /// </summary>
        private double _innerRadius;

        /// <summary>
        /// Закрытое поле данного класса, хранит значение внешнего радиуса.
        /// </summary>
        private double _outerRadius;

        /// <summary>
        /// Возвращает и задаёт значение координат кольца типа <see cref="Point2D"/>.
        /// </summary>
        public Point2D Center { get; set; }
        
        /// <summary>
        /// Возвращает и задаёт значение внешнего радиуса. 
        /// Значение должно быть положительным и не выходить на рамки double.
        /// </summary>
        public double OuterRadius
        {
            get
            {
                return _outerRadius;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(OuterRadius));
                Validator.AssertValueInRange(value, InnerRadius,
                    double.PositiveInfinity, nameof(OuterRadius));
                _outerRadius = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт значение внутреннего радиуса. 
        /// Значение должно быть положительным и не выходить на рамки double.
        /// </summary>
        public double InnerRadius
        {
            get
            {
                return _innerRadius;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(InnerRadius));
                Validator.AssertValueInRange(value, 0, OuterRadius,
                    nameof(InnerRadius));
                _innerRadius = value;
            }
        }

        /// <summary>
        /// Метод класса <see cref="Ring"/>. Вычисляет значение площади кольца.
        /// </summary>
        public double Area
        {
            get
            {
                return Math.PI * Math.Pow(OuterRadius, 2) - Math.PI * Math.Pow(InnerRadius, 2);
            }
        }
        public Ring() { }

        /// <summary>
        /// Создаёт уникальный экземпляр класс<see cref="Ring"/>.
        /// </summary>
        /// <param name="innerRadius">Значение внутреннего радиуса. Должно быть положительным.</param>
        /// <param name="outerRadius">Значение внешнего радиуса. Должно быть положительным.</param>
        /// <param name="center">Координаты в двумерном пространстве типа<see cref="Point2D"/>.</param>
        public Ring(double innerRadius, double outerRadius, Point2D center)
        {
            InnerRadius = innerRadius;
            OuterRadius = outerRadius;
            Center = center;
        }
    }
}
