using ObjectOrientedPractics.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class Item
    {
        private int _id;

        private string _name;

        private string _info;

        private double _cost;

        /// <summary>
        /// Возвращает уникальный идентификатор товара.
        /// </summary>
        public int Id
        {
            get
            {
                return _id;
            }
        }

        /// <summary>
        /// Возвращает и задаё наименование товара. Должен быть не более 200 символов.
        /// </summary>
        public string Name 
        {
            get
            { 
                return _name;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, "Name");
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задаё описание товара. Должен быть не более 1000 символов.
        /// </summary>
        public string Info
        {
            get
            {
                return _info;
            }
            set 
            {
                ValueValidator.AssertStringOnLength(value, 1000, "Info");
                _info = value;
            }
        }

        /// <summary>
        /// Возвращает и задаё цену товара. Должен быть в пределах от 0 до 100000 символов.
        /// </summary>
        public double Cost
        {
            get
            {
                return _cost;
            }
            set
            {
                ValueValidator.AssertValueInRange(value, 0, 10000, "Cost");
                _cost = value;
            }
        }

        /// <summary>
        /// Создает новый экземпляр класса <see cref="Item"/> с заданными значениями имени, информации и стоимости.
        /// </summary>
        /// <param name="name">Имя товара.</param>
        /// <param name="info">Информация о товаре.</param>
        /// <param name="cost">Стоимость товара.</param>
        public Item(string name, string info, double cost)
        {
            Name = name;
            Info = info;
            Cost = cost;
            _id = IdGenerator.GetNextId();
        }
    }
}
