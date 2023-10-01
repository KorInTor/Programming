using ObjectOrientedPractics.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит информацию о покупателе.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Уникальный идентификатор данного класса.
        /// </summary>
        private int _id;

        /// <summary>
        /// Полное имя.
        /// </summary>
        private string _fullname;

        /// <summary>
        /// Данные адреса.
        /// </summary>
        private Address _address;

        /// <summary>
        /// Возвращает уникальный идентификатор покупателя.
        /// </summary>
        public int Id 
        {
            get 
            { 
                return _id; 
            } 
        }

        /// <summary>
        /// Возвращает и задаё полное имя покупателя. Должен быть не более 200 символов.
        /// </summary>
        public string Fullname
        {
            get
            {
                return _fullname;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, "Fullanme");
                _fullname = value;
            }
        }

        /// <summary>
        /// Возвращает и задаё адрес покупателя.
        /// </summary>
        public Address Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }

        /// <summary>
        /// Создает новый экземпляр класса <see cref="Customer"/>
        /// </summary>
        /// <param name="fullname">Полное имя покупателя. Должен быть не более 200 символов.</param>
        /// <param name="address">Адрес покупателя.</param>
        public Customer(string fullname, Address address)
        {
            Fullname = fullname;
            Address = address;
            _id = IdGenerator.GetNextId();
        }

    }
}
