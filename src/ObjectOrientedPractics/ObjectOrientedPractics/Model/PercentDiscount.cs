using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит процентную скидку на конктретную категорию товаров.
    /// </summary>
    public class PercentDiscount
    {
        /// <summary>
        /// Сумма которую покупатель уже потратил.
        /// </summary>
        private double _amountSpent = 0;

        /// <summary>
        /// Скидка в процентах.
        /// </summary>
        public int Discount { get; private set; } = 1;

        /// <summary>
        /// Категория товаров, на которые действует скидка.
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Возвращает количество накопленных баллов для UI в виде строки;
        /// </summary>
        public string Info
        {
            get
            {
                return ($"Процентная скидка на {Category} - {Discount}%");
            }
        }

        /// <summary>
        /// Принимает список товаров и возвращает размер скидки для товаров с идентичной категорией для поля.
        /// </summary>
        /// <param name="items">Cписок товаров.</param>
        /// <returns>Размер скидки.</returns>
        public double Calculate(List<Item> items)
        {
            int amount = 0;
            foreach (Item item in items)
            {
                if (item.Category == Category)
                {
                    amount = amount + (int)Math.Round(item.Cost);
                }
            }
            return amount * ((double) Discount/100);
        }

        /// <summary>
        /// Применяет скидку к товарам и возвращает размер скидки.
        /// </summary>
        /// <param name="items">Cписок товаров.</param>
        /// <returns>Размер скидки.</returns>
        public double Apply(List<Item> items)
        {
            return Calculate(items);
        }

        /// <summary>
        /// Обновляет скидку на основе полученного списка товаров. За каждую 1000 той же категории добавляет +1 к скидке. Не позволяет скидке быть больше 10 процентов.
        /// </summary>
        /// <param name="items">Cписок товаров.</param>
        public void Update(List<Item> items)
        {
            foreach (Item item in items)
            {
                if (item.Category == Category)
                {
                    _amountSpent = _amountSpent + item.Cost;
                }
            }
            Discount = (int)Math.Round(_amountSpent) / 1000;
            if (Discount > 10)
            {
                Discount = 10;
            }
        }
    }
}
