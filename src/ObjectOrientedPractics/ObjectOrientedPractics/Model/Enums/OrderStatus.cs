using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Enums
{
    /// <summary>
    /// Хранит виды статусов заказа.
    /// </summary>
    public enum OrderStatus
    {
        New = 1, //Новый заказ.
        Processing, //Обрабатывается.
        Assembly, //Собирается на складе.
        Sent, //Отправлен.
        Delivered, //Доставлен.
        Returned, //Возврат.
        Abandoned //Отменен (со стороны магазина)
    }
}
