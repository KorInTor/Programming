using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Содержит данные о песне.
    /// </summary>
    public class Song
    {
        /// <summary>
        /// Закрытое поле данного класса, хранит данные о продолжительности песни в секундах.
        /// </summary>
        private int _durationInSeconds;

        /// <summary>
        /// Возвращает и задёт Название песни
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Возвращает и задаёт Имя исполнителя
        /// </summary>
        public string Artist { get; set; }

        /// <summary>
        /// Возвращает и задаёт название альбома.
        /// </summary>
        public string Album { get; set; }

       
        /// <summary>
        /// Возвращае и задаёт продолжительность песни в секундах. Должно быть положительным.
        /// </summary>
        public int DurationInSeconds 
        { 
            get 
            { 
                return _durationInSeconds;
            }
            set 
            {
                Validator.AssertOnPositiveValue(DurationInSeconds, nameof(DurationInSeconds));
                _durationInSeconds = value;
            }
        }

        public Song() { }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Song"/>
        /// </summary>
        /// <param name="title">Название песни.</param>
        /// <param name="artist">Имя исполнителя</param>
        /// <param name="album">Название альбома</param>
        /// <param name="durationInSeconds">Продолжительность в секундах. Должно быть положительным</param>
        public Song(string title, string artist, string album, int durationInSeconds)
        {
            Title = title;
            Artist = artist;
            Album = album;
            DurationInSeconds = durationInSeconds;
        }
    }
}
