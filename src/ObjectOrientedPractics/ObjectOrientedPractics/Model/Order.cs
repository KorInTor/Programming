using ObjectOrientedPractics.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит информацию о заказе.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Уникальный идентификатор заказа.
        /// </summary>
        private int _id;

        /// <summary>
        /// Время оформления заказа.
        /// </summary>
        private DateOnly _date;

        /// <summary>
        /// Адрес доставки.
        /// </summary>
        private Address _address;

        /// <summary>
        /// Список товаров в заказе.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Возвращает сумму цен всех товаров. Если <see cref="Items"/> пуст или равен null то возвращает 0.
        /// </summary>
        public double Amount
        {
            get
            {
                if (_items == null || _items.Count == 0)
                {
                    return 0;
                }
                double value = 0;
                foreach (var item in _items)
                {
                    value += item.Cost;
                }
                return value;
            }
        }

        /// <summary>
        /// Возвращает уникальный идентификатор заказа.
        /// </summary>
        public int Id
        {
            get
            {
                return _id;
            }
        }

        /// <summary>
        /// Возвращает дату оформления заказа.
        /// </summary>
        public DateOnly Date
        {
            get
            {
                return _date;
            }
        }

        /// <summary>
        /// Возвращает и задаёт адрес доставки.
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
        /// Возвращает и задаёт список товаров в заказе.
        /// </summary>
        public List<Item> Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;
            }
        }

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Order() { }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Order"/>.
        /// </summary>
        /// <param name="address"></param>
        /// <param name="items"></param>
        public Order(Address address, List<Item> items)
        {
            Address = address;
            Items = items;
            _id = IdGenerator.GetNextId();
            _date = DateOnly.FromDateTime(DateTime.Now);
        }
    }
}
