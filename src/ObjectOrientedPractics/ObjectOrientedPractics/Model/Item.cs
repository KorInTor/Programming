using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Service;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит ифнормацию о товаре.
    /// </summary>
    public class Item : ICloneable, IEquatable<object>, IComparable<Item>
    {
        /// <summary>
        /// Хранит уникальный идентификатор.
        /// </summary>
        private int _id;

        /// <summary>
        /// Наименование товара.
        /// </summary>
        private string _name;

        /// <summary>
        /// Описание товара.
        /// </summary>
        private string _info;

        /// <summary>
        /// Стоимость товара.
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
        /// Возвращает и задаёт цену товара. Должен быть в пределах от 0 до 100000.
        /// </summary>
        public double Cost
        {
            get
            {
                return _cost;
            }
            set
            {
                ValueValidator.AssertValueInRange(value, 0, 100000, "Cost");
                _cost = value;
            }
        }

        /// <summary>
        /// Возвращает и задёт категорию товара.
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Создает новый экземпляр класса <see cref="Item"/>.
        /// </summary>
        /// <param name="name">Имя товара. Должно быть не более 200 символов.</param>
        /// <param name="info">Информация о товаре. Должна быть не более 1000 символов.</param>
        /// <param name="cost">Стоимость товара. Должна быть в пределах от 0 до 100000 символов.</param>
        /// <param name="category">Категория товара. Одно из значение <see cref="Enums.Category"/>.</param>
        public Item(string name, string info, double cost, Category category)
        {
            Name = name;
            Info = info;
            Cost = cost;
            Category = category;
            _id = IdGenerator.GetNextId();
        }

        /// <inheritdoc />  
        public object Clone()
        {
            return new Item(this.Name, this.Info, this.Cost,this.Category);
        }

        /// <inheritdoc />  
        public override bool Equals(object other)
        {
            if (other == null)
                return false;
            if (other is not Item)
                return false;
            if (object.ReferenceEquals(this, other))
                return true;
            var item2 = (Item)other;
            return (this.Name == item2.Name) && (this.Info == item2.Info) && 
                (this.Cost == item2.Cost) && (this.Category == item2.Category);
        }

        /// <summary>
        /// Сравнивает два товара по цене и возвращает 1 если изначальная цена товара больше передаваемого, 0 если цены равны, 
        /// -1 если изначальная цена товара меньше передаваемого.
        /// </summary>
        /// <param name="other">Передаваемый товар.</param>
        /// <returns>Результат.</returns>
        public int CompareTo(Item other)
        {
            if(this.Cost < other.Cost)
            {
                return -1;
            }
            else if (this.Cost > other.Cost)
            {
                return 1;
            }
            return 0;
        }
    }
}
