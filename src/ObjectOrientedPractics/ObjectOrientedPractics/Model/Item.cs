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
        /// <summary>
        /// Закрытое поле данного класса, хранит уникальный идентификатор.
        /// </summary>
        private int _id;

        /// <summary>
        /// Закрытое поле данного класса, хранит Имя продукта.
        /// </summary>
        private string _name;

        /// <summary>
        /// Закрытое поле данного класса, хранит Описание продукта.
        /// </summary>
        private string _info;

        /// <summary>
        /// Закрытое поле данного класса, хранит Стоимость продукта.
        /// </summary>
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
        /// Возвращает и задаёт наименование товара. Должен быть не более 200 символов.
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
        /// Возвращает и задаёт описание товара. Должен быть не более 1000 символов.
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
        /// Возвращает и задаёт цену товара. Должен быть в пределах от 0 до 100000 символов.
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
        /// Возвращает и задёт категорию товара.
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Создает новый экземпляр класса <see cref="Item"/> с заданными значениями имени, информации, стоимости и категории.
        /// </summary>
        /// <param name="name">Имя товара.</param>
        /// <param name="info">Информация о товаре.</param>
        /// <param name="cost">Стоимость товара.</param>
        /// <param name="category">Категория товара</param>
        public Item(string name, string info, double cost, Category category)
        {
            Name = name;
            Info = info;
            Cost = cost;
            Category = category;
            _id = IdGenerator.GetNextId();
        }
    }
}
