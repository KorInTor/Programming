using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Приоритетный заказ.
    /// </summary>
    public class PriorityOrder:Order
    {
        /// <summary>
        /// Желаемая дата доставки.
        /// </summary>
        private DateTime _desiredDeliveryDate;

        /// <summary>
        /// Желаемое время доставки.
        /// </summary>
        private string _desiredDeliveryTime;

        /// <summary>
        /// Возвращает и задаёт желаемую дату доставки.
        /// </summary>
        public DateTime DesiredDeliveryDate 
        {
            get
            {
                return _desiredDeliveryDate;
            }
            set
            {
                _desiredDeliveryDate = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт желаемое время доставки.
        /// </summary>
        public string DesiredDeliveryTime 
        {
            get
            {
                return _desiredDeliveryTime;
            }
            set
            {
                _desiredDeliveryTime = value;
            }
        }

        /// <summary>
        /// Конструктор данного класса. Принимает значения адреса, списка товаров, желаемых даты и времени доставки.
        /// </summary>
        /// <param name="address">Аддресс заказа.</param>
        /// <param name="items">Список товаров.</param>
        /// <param name="desiredDeliveryDate">Желаемая дата доставки.</param>
        /// <param name="desiredDeliveryTime">Желаемое время доставки.</param>
        public PriorityOrder(Address address, List<Item> items, DateTime desiredDeliveryDate, string desiredDeliveryTime) : base(address, items)
        {
            DesiredDeliveryDate = desiredDeliveryDate;
            DesiredDeliveryTime = desiredDeliveryTime;
        }
    }
}
