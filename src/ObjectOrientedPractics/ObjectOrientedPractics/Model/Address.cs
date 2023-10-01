using ObjectOrientedPractics.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит информацию о адрессе.
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Уникальный идентификатор данного класса.
        /// </summary>
        private int _index;

        /// <summary>
        /// Наименование страны.
        /// </summary>
        private string _country;

        /// <summary>
        /// Наименование города.
        /// </summary>
        private string _city;

        /// <summary>
        /// Наименование улицы.
        /// </summary>
        private string _street;

        /// <summary>
        /// Номер дома.
        /// </summary>
        private string _building;

        /// <summary>
        /// Номер квартиры.
        /// </summary>
        private string _apartment;

        /// <summary>
        /// Возвращает и задаёт индекс адреса. Должен быть шестизначным.
        /// </summary>
        public int Index
        {
            get
            {
                return _index;
            }
            set
            {
                ValueValidator.AssertValueInRange(value, 99999, 1000000, "Index");
                _index = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт наименование страны. Должен быть не более 50 символов.
        /// </summary>
        public string Country
        {
            get
            {
                return _country;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 50, "Country");
                _country = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт наименование города. Должен быть не более 50 символов.
        /// </summary>
        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value,50, "City");
                _city = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт наименование улицы. Должен быть не более 50 символов.
        /// </summary>
        public string Street
        {
            get 
            { 
                return _street;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value,50,"Street");
                _street = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт номер дома. Должен быть не более 10 символов.
        /// </summary>
        public string Building
        {
            get
            {
                return _building;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 10, "Building");
                _building = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт номер квартиры. Должен быть не более 10 символов.
        /// </summary>
        public string Apartment
        {
            get
            {
                return _apartment;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 10, "Apartment");
                _apartment = value;
            }
        }

        /// <summary>
        /// Создает новый экземпляр класса <see cref="Address"/>.
        /// </summary>
        /// <param name="index">Индекс. Должен быть шестизначным.</param>
        /// <param name="country">Страна. Должен быть не более 50 символов.</param>
        /// <param name="city">Город. Должен быть не более 50 символов.</param>
        /// <param name="street">Улица. Должен быть не более 50 символов.</param>
        /// <param name="building">Номер дома. Должен быть не более 10 символов.</param>
        /// <param name="apartment">Номер квартиры/помещения. Должен быть не более 10 символов.</param>
        public Address(int index, string country, string city, string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }

        public Address() { }
    }
}
