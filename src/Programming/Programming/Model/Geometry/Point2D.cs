using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Хранит координаты в двумерном пространстве.
    /// </summary>
    public class Point2D
    {
        /// <summary>
        /// Закрытое поле данного класса. Содержит координату X.
        /// </summary>
        private double _x;

        /// <summary>
        /// Закрытое поле данного класса. Содержит координату Y.
        /// </summary>
        private double _y;

        
        /// <summary>
        /// Возвращает и задаёт значение координаты X. Значение должно быть положительным.
        /// </summary>
        public double X
        { 
            get
            {
                return _x;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(X));
                _x = value;
            }
        }
        /// <summary>
        /// Возвращает и задаёт значение координаты Y. Значение должно быть положительным.
        /// </summary>
        public double Y
        {
            get
            {
                return _y;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Y));
                _y = value;
            }
        }

        /// <summary>
        /// Создаёт уникальный экземпляр класса <see cref="Point2D"/>.
        /// </summary>
        /// <param name="x">Координата X. Должна быть положительной.</param>
        /// <param name="y">Координата Y. Должна быть положительной.</param>
        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}
