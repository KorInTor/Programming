using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ObjectOrientedPractics.Service
{
    static class ValueValidator
    {
        /// <summary>
        /// Проверяет не превышает ли строка определённую длинну.
        /// </summary>
        /// <param name="value">Входная строка на проверку.</param>
        /// <param name="maxLength">Максимальная длинна строки.</param>
        /// <param name="propertyName">Место вызова функции.</param>
        /// <exception cref="ArgumentException">Ошибка возникает при превышении заданной длинны.</exception>
        public static void AssertStringOnLength(string value, int maxLength, string propertyName)
        {
            if (value.Length >= maxLength) 
            {
                throw new ArgumentException($"{propertyName} должен быть меньше {maxLength} символов».");
            }
        }

        /// <summary>
        /// Проверяет находится ли число с плавющей точкой в определённых границах.
        /// </summary>
        /// <param name="value">Входное значение на проверку.</param>
        /// <param name="min">Минимальная возможная величина числа.</param>
        /// <param name="max">Максимальная величина числа.</param>
        /// <param name="propertyName">Место вызова функции.</param>
        /// <exception cref="ArgumentException">Ошибка возникает если НЕ находится в заданных границах.</exception>
        public static void AssertValueInRange(double value, double min, double max, string propertyName)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"{propertyName} value must be in range of {min} to {max}");
            }
        }

        /// <summary>
        /// Проверяет находится ли целое число в определённых границах.
        /// </summary>
        /// <param name="value">Входное значение на проверку.</param>
        /// <param name="min">Минимальная возможная величина числа.</param>
        /// <param name="max">Максимальная величина числа.</param>
        /// <param name="propertyName">Место вызова функции.</param>
        /// <exception cref="ArgumentException">Ошибка возникает если НЕ находится в заданных границах.</exception>
        public static void AssertValueInRange(int value, int min, int max, string propertyName)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"{propertyName} value must be in range of {min} to {max}");
            }
        }
    }
}
