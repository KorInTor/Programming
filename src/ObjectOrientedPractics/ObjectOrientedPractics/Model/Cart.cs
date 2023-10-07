using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит корзину товаров.
    /// </summary>
    public class Cart
    {
        /// <summary>
        /// Хранит список товаров в корзине.
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
        /// Возвращает и задаёт список товаров.
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
        public Cart()
        {
            _items = new List<Item>();
        }
    }
}
