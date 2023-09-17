using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    static class Validator
    {
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

        /// <summary>
        /// Метод класса <see cref="Validator"/>. Проверяет, превышает ли количество символов в строчке заданный максимум.
        /// </summary>
        /// <param name="value"> Строковое значение которое будет проверятся.</param>
        /// <param name="max">Максимальное количество символов.</param>
        /// <param name="propertyName">Название метода где был вызван.</param>
        /// <exception cref="ArgumentException"></exception>
        public static void AssertStringLengthInRange(string value, int max, string propertyName)
        {
            if (value.Length > max)
                throw new ArgumentException($"{propertyName} maximum legth is: {max}");
        }
        /// <summary>
        /// Метод класса <see cref="Validator"/>. Проверяет, находится ли дата в будущем.
        /// </summary>
        /// <param name="Date">Значение даты типа <see cref="DateTime"/>.</param>
        /// <param name="propertyName">Название метода где был вызван.</param>
        /// <exception cref="ArgumentException"></exception>
        public static void AssertDateIsntFuture(DateTime Date, string propertyName)
        {
            DateTime today = DateTime.Today;
            if ((Date.Day > today.Day && Date.Month == today.Month && Date.Year == today.Year) 
                || (Date.Month > today.Month && Date.Year == today.Year) 
                || (Date.Year > today.Year))
                throw new ArgumentException($"{propertyName} canot be in Future, must be in Present or Past");
        }
    }
}
