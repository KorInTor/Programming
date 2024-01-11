using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Содержит данные о полёте.
    /// </summary>
    public class Flight
    {
        /// <summary>
        /// Закрытое поле данного класса, хранит информацию о продолжительности полёта в минутах.
        /// </summary>
        private int _flightTimeInMinutes;

        /// <summary>
        /// Возвращает и задаёт место отправления.
        /// </summary>
        public string Departure { get; set; }

        /// <summary>
        /// Возвращает и задаёт место назначения.
        /// </summary>
        public string Destination { get; set; }

        
        /// <summary>
        /// Возвращает и задаёт длительность полёта в минутах. Должно быть положительныи.
        /// </summary>
        public int FlightTimeInMinutes
        {
            get
            {
                return _flightTimeInMinutes;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(FlightTimeInMinutes));
                _flightTimeInMinutes = value;
            }
        }

        public Flight(){}

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Flight"/>
        /// </summary>
        /// <param name="flightTimeInMinutes">Продолжительность полёта. Должно быть положительным</param>
        /// <param name="departure">Место отправления.</param>
        /// <param name="destination">Место прибытия.</param>
        public Flight(int flightTimeInMinutes, string departure, string destination)
        {
            FlightTimeInMinutes = flightTimeInMinutes;
            Departure = departure;
            Destination = destination;
        }
    }
}
