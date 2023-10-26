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
    public class Address : ICloneable, IEquatable<object>
    {
        public event EventHandler<EventArgs> AddressChanged;

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
                if (_index != value)
                {
                    ValueValidator.AssertValueInRange(value, 99999, 1000000, "Index");
                    _index = value;
                    AddressChanged?.Invoke(this, EventArgs.Empty);
                }
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
                if (_country != value)
                {
                    ValueValidator.AssertStringOnLength(value, 50, "Country");
                    _country = value;
                    AddressChanged?.Invoke(this, EventArgs.Empty);
                }
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
                if (_city != value)
                {
                    ValueValidator.AssertStringOnLength(value, 50, "City");
                    _city = value;
                    AddressChanged?.Invoke(this, EventArgs.Empty);
                }
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
                if (_street != value)
                {
                    ValueValidator.AssertStringOnLength(value, 50, "Street");
                    _street = value;
                    AddressChanged?.Invoke(this, EventArgs.Empty);
                }
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
                if (_building != value)
                {
                    ValueValidator.AssertStringOnLength(value, 10, "Building");
                    _building = value;
                    AddressChanged?.Invoke(this, EventArgs.Empty);
                }
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
                if (_apartment != value)
                {
                    ValueValidator.AssertStringOnLength(value, 10, "Apartment");
                    _apartment = value;
                    AddressChanged?.Invoke(this, EventArgs.Empty);
                }
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

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Address() { }

        /// <summary>
        /// Возвращает значение адреса в одну строку.
        /// </summary>
        /// <returns>Аддресс строчного типа.</returns>
        public override string ToString()
        {
            return $"{Country}, г.{City}, ул.{Street}, дом.{Building}, кв.{Apartment}.";
        }

        public object Clone()
        {
            return (new Address(this.Index, this.Country, this.City, this.Street, this.Building, this.Apartment));
        }

        public override bool Equals(object other)
        {
            if (other == null)
                return false;
            if (other is not Address)
                return false;
            if (object.ReferenceEquals(this, other))
                return true;
            var address2 = (Address)other;
            return (this.Index == address2.Index) && (this.Country == address2.Country) &&
           (this.City == address2.City) && (this.Street == address2.Street) &&
           (this.Building == address2.Building) && (this.Apartment == address2.Apartment);
        }
    }
}
