using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Model.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Service
{
    public class OrderFactory
    {
        private static Random _random = new Random();
        private static OrderStatus[] _statuses = (OrderStatus[])Enum.GetValues(typeof(OrderStatus));

        /// <summary>
        /// Генерирует и возвращает заказ.
        /// </summary>
        /// <param name="customer">Покупатель для получения его адресса.</param>
        /// <param name="items">Список всех товаров.</param>
        /// <param name="amount">Количество товаров в заказе.</param>
        /// <returns>Новый случайный заказ.</returns>
        public static Order CreateRandomOrder(Customer customer, List<Item> items, int amount)
        {
            List<Item> orderItems = new List<Item>();
            for (int i = 0; i < amount; i++)
            {
                orderItems.Add(items[_random.Next(items.Count)]);
            }
            Order order = new Order(customer.Address, orderItems);
            order.Status = _statuses[_random.Next(_statuses.Length)];
            return order;
        }
    }
}
