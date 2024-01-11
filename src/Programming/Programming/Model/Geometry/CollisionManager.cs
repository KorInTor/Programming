using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Статичный класс хранящий проверки на пересечение геометрических оюъектов.
    /// </summary>
    public static class CollisionManager
    {
        /// <summary>
        /// Метод класса <see cref="CollisionManager"/>. Проверяет на пересечние два Прямоугольника типа <see cref="Rectangle"/>.
        /// </summary>
        /// <param name="rectangle1">Первый прямоугольник.</param>
        /// <param name="rectangle2">Второй прямоугольник.</param>
        /// <returns>Возвращает true если есть пересечение, иначе false</returns>
        public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            double dX = Math.Abs((rectangle1.Center.X+rectangle1.Width/2) - (rectangle2.Center.X+rectangle2.Width / 2));
            double dY = Math.Abs((rectangle1.Center.Y+rectangle1.Length/2) - (rectangle2.Center.Y+ rectangle2.Length / 2));

            if (dX < (rectangle1.Width / 2) + (rectangle2.Width / 2) &&
                dY < (rectangle1.Length / 2) + (rectangle2.Length / 2))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Метод класса <see cref="CollisionManager"/>. Проверяет на пересечние два Кольца типа <see cref="Ring"/>.
        /// </summary>
        /// <param name="rectangle1">Первое кольцо.</param>
        /// <param name="rectangle2">Второе кольцо.</param>
        /// <returns>Возвращает true если есть пересечение, иначе false</returns>
        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            if (ring1.Center.X == ring2.Center.X && ring1.Center.Y == ring2.Center.Y)
            {
                return true;
            }
            double dX = Math.Abs(ring1.Center.X - ring2.Center.X);
            double dY = Math.Abs(ring1.Center.Y - ring2.Center.Y);
            double C = Math.Sqrt(Math.Pow(dX, 2)+ Math.Pow(dY, 2));
            if (C < (ring1.OuterRadius+ring2.OuterRadius))
            {
                return true;
            }
            return false;
        }
    }
}
