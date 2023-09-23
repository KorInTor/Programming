using ObjectOrientedPractics.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class Customer
    {
        private int _id;

        private string _fullname;

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
        /// Возвращает и задаё адрес покупателя. Тип <see cref="Model.Address"/>.
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
        /// Создает новый экземпляр класса Customer с заданным именем и адресом.
        /// </summary>
        /// <param name="fullname">Полное имя покупателя.</param>
        /// <param name="address">Адрес покупателя.</param>
        public Customer(string fullname, Address address)
        {
            Fullname = fullname;
            Address = address;
            _id = IdGenerator.GetNextId();
        }

    }
}
