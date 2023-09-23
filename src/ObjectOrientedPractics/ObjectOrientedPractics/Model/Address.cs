using ObjectOrientedPractics.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class Address
    {
        /// <summary>
        /// Закрытое поле данного класса, хранит индекс.
        /// </summary>
        private int _index;

        /// <summary>
        /// Закрытое поле данного класса, хранит наименование страны.
        /// </summary>
        private string _country;

        /// <summary>
        /// Закрытое поле данного класса, хранит наименование города.
        /// </summary>
        private string _city;

        /// <summary>
        /// Закрытое поле данного класса, хранит наименование улицы.
        /// </summary>
        private string _street;

        /// <summary>
        /// Закрытое поле данного класса, хранит номер дома.
        /// </summary>
        private string _building;

        /// <summary>
        /// Закрытое поле данного класса, хранит нмоер квартиры.
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
        /// Создает новый экземпляр класса <see cref="Address"/> с заданными значениями.
        /// </summary>
        /// <param name="index">Индекс.</param>
        /// <param name="country">Страна.</param>
        /// <param name="city">Город.</param>
        /// <param name="street">Улица.</param>
        /// <param name="building">Номер дома.</param>
        /// <param name="apartment">Номер квартиры/помещения.</param>
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
