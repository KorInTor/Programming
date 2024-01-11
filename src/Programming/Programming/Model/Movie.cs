using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Содержит данные о фильме.
    /// </summary>
    public class Movie
    {
        /// <summary>
        /// Закрытое поле данного класса, содержит продолжительность в минутах.
        /// </summary>
        private int _durationInMinutes;

        /// <summary>
        /// Закрытое поле данного класса, содержит год выпуска.
        /// </summary>
        private int _yearOfRelease;

        /// <summary>
        /// Закрытое поле данного класса, содержит значение оценки.
        /// </summary>
        private int _rating;

        /// <summary>
        /// Возвращает и задаёт название фильма.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Возвращает и задаёт Жанр фильма.
        /// </summary>
        public string Genre { get; set; }

        
        /// <summary>
        /// Возвращает и задаёт продолжительность в минутах. Значение должно быть положительным.
        /// </summary>
        public int DurationInMinutes
        {
            get
            {
                return _durationInMinutes;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(DurationInMinutes));
                _durationInMinutes = value;
            }
        }
        /// <summary>
        /// Возвращает и задаёт значение года выпуска. Должно быть от 1900 до 2023 включительно.
        /// </summary>
        public int YearOfRelease
        {
            get
            {
                return _yearOfRelease;
            }
            set
            {
                Validator.AssertValueInRange(value, 1900, 2023, nameof(YearOfRelease));
                _yearOfRelease = value;
            }
        }
        /// <summary>
        /// Возвращает и задёт значение Оценки фильма. Должно быть от 1 до 10 включительно.
        /// </summary>
        public int Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                Validator.AssertValueInRange(value, 1, 10, nameof(YearOfRelease));
                _rating = value;
            }
        }
        public Movie()
        {
        }
        /// <summary>
        /// Создаёт экземпляр класса <see cref="Movie"/>
        /// </summary>
        /// <param name="durationInMinutes">Продолжительность в минутах. Должна быть положительной</param>
        /// <param name="yearOfRelease">Год выпуска должен быть от 1900 до 2023 включительно</param>
        /// <param name="rating">Оценка фильма. Должна быть от 1 до 10 включительно</param>
        /// <param name="title">Название.</param>
        /// <param name="genre">Жанр.</param>
        public Movie(int durationInMinutes, int yearOfRelease,
            int rating, string title, string genre)
        {
            DurationInMinutes = durationInMinutes;
            YearOfRelease = yearOfRelease;
            Rating = rating;
            Title = title;
            Genre = genre;
        }
    }
}
