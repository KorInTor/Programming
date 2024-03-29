﻿using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Orders
{
    /// <summary>
    /// Хранит информацию о заказе.
    /// </summary>
    public class Order : IEquatable<Object>
    {
        /// <summary>
        /// Уникальный идентификатор заказа.
        /// </summary>
        private int _id;

        /// <summary>
        /// Время оформления заказа.
        /// </summary>
        private DateTime _date;

        /// <summary>
        /// Адрес доставки.
        /// </summary>
        private Address _address;

        /// <summary>
        /// Статус заказа.
        /// </summary>
        private OrderStatus _status;

        /// <summary>
        /// Список товаров в заказе.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Размер скидки.
        /// </summary>
        public double DiscountAmount { get; set; }

        public double Total
        {
            get
            {
                return Amount - DiscountAmount;
            }
        }
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
        public DateTime Date
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
        /// Возвращает и задаёт статус заказа.
        /// </summary>
        public OrderStatus Status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
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
            _date = DateTime.Now;
            _status = OrderStatus.New;
        }

        public override bool Equals(object other)
        {
            if (other == null)
                return false;
            if (other is not Order)
                return false;
            if (object.ReferenceEquals(this, other))
                return true;
            var order2 = (Order)other;
            return (this.Items == order2.Items) && (this.Address == order2.Address) &&
                (this.Status == order2.Status) && (this.Date == order2.Date) &&
                (this.DiscountAmount == order2.DiscountAmount);
        }
    }
}
