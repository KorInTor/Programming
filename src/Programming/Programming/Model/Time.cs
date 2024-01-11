using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Содержит данные о времени.
    /// </summary>
    public class Time
    {
        public Time() { }
        /// <summary>
        /// Закрытое поле данного класса, содержит значение часов.
        /// </summary>
        private int _hours;

        /// <summary>
        /// Закрытое поле данного класса, содержит значение минут.
        /// </summary>
        private int _minutes;

        /// <summary>
        /// Закрытое поле данного класса, содержит значение секунд.
        /// </summary>
        private int _seconds;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Time"/>
        /// </summary>
        /// <param name="hours">Час. Значение должно быть от 0 до 24.</param>
        /// <param name="minutes">Минуты. Значение должно быть от 0 до 60.</param>
        /// <param name="seconds">Секунды. Значение должно быть от 0 до 60.</param>
       
        /// <summary>
        /// Возвращает и задаёт значение Часов. Должно быть от 0 до 24.
        /// </summary>
        public int Hours
        {
            get
            {
                return _hours;
            }
            set
            {
                Validator.AssertValueInRange(value, 0, 24, nameof(Hours));
                _hours = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт значение Минут. Должно быть от 0 до 60.
        /// </summary>
        public int Minutes
        {
            get
            {
                return _minutes;
            }
            set
            {
                Validator.AssertValueInRange(value, 0, 60, nameof(Minutes));
                _minutes = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт значение Секунд. Должно быть от 0 до 60.
        /// </summary>
        public int Seconds
        {
            get
            {
                return _seconds;
            }
            set
            {
                Validator.AssertValueInRange(value, 0, 60, nameof(Seconds));
                _seconds = value;
            }
        }

        public Time(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
    }
}
