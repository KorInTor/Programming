using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Статичный класс, содержит методы валидации.
    /// </summary>
    static class Validator
    {
        /// <summary>
        /// Метод класса <see cref="Validator"/>. Проверяет, является ли вещественное значение положительным.
        /// </summary>
        /// <param name="value">Значение которое будет проверятся.</param>
        /// <param name="propertyName">Название метода где был вызван.</param>
        /// <exception cref="ArgumentException"></exception>
        public static void AssertOnPositiveValue(double value, string propertyName)
        {
            if (value < 0)
            {
                throw new ArgumentException($"Value of {propertyName} must be positive");
            }
        }

        /// <summary>
        /// Метод класса <see cref="Validator"/>. Проверяет, является ли целочисленное значение положительным.
        /// </summary>
        /// <param name="value">Значение которое будет проверятся.</param>
        /// <param name="propertyName">Название метода где был вызван.</param>
        /// <exception cref="ArgumentException"></exception>
        public static void AssertOnPositiveValue(int value, string propertyName)
        {
            if (value < 0)
            {
                throw new ArgumentException($"Value of {propertyName} must be positive");
            }
        }

        /// <summary>
        /// Метод класса <see cref="Validator"/>. Проверяет, находится ли целочисленное значение в заданых границах.
        /// </summary>
        /// <param name="value">Значение для проверки.</param>
        /// <param name="min">Минимальное значение аргумента.</param>
        /// <param name="max">Максимальное значение аргумента.</param>
        /// <param name="propertyName">Название метода где был вызван.</param>
        /// <exception cref="ArgumentException"></exception>
        public static void AssertValueInRange(int value, int min, int max, string propertyName)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"{propertyName} value must be in range of {min} to {max}");
            }
        }

        /// <summary>
        /// Метод класса <see cref="Validator"/>. Проверяет, находится ли вещественное значение в заданых границах.
        /// </summary>
        /// <param name="value">Значение для проверки.</param>
        /// <param name="min">Минимальное значение аргумента.</param>
        /// <param name="max">Максимальное значение аргумента.</param>
        /// <param name="propertyName">Название метода где был вызван.</param>
        /// <exception cref="ArgumentException"></exception>
        public static void AssertValueInRange(double value, double min, double max, string propertyName)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"{propertyName} value must be in range of {min} to {max}");
            }
        }
    }
}
