using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Discounts
{
    /// <summary>
    /// Хранит информацию о накопительных баллах.
    /// </summary>
    public class PointsDiscount : IDiscount
    {
        /// <summary>
        /// Количество накопленных баллов.
        /// </summary>
        public int Points { get; private set; }

        /// <summary>
        /// Возвращает количество накопленных баллов для UI в виде строки;
        /// </summary>
        public string Info
        {
            get
            {
                return $"Накопительная – {Points} баллов";
            }
        }

        /// <summary>
        /// Принимает список товаров и возвращает размер скидки, доступной для этого списка товаров с текущим количеством баллов.
        /// </summary>
        /// <param name="items">Cписок товаров.</param>
        /// <returns>Размер скидки.</returns>
        public double Calculate(List<Item> items)
        {
            int amount = 0;
            foreach (Item item in items)
            {
                amount = amount + (int)Math.Round(item.Cost);
            }
            if (Points > amount * 0.3)
            {
                return Math.Round(amount * 0.30);
            }
            return Points;
        }

        /// <summary>
        /// Применяет скидку к товарам и забирает все накопленные баллы.
        /// </summary>
        /// <param name="items">Cписок товаров.</param>
        /// <returns>Размер скидки.</returns>
        public double Apply(List<Item> items)
        {
            double discount = Calculate(items);
            Points -= (int)discount;
            return discount;
        }

        /// <summary>
        /// Добавляет баллы на основе полученного списка товаров.
        /// </summary>
        /// <param name="items">Cписок товаров.</param>
        public void Update(List<Item> items)
        {
            foreach (Item item in items)
            {
                Points = Points + (int)Math.Ceiling(item.Cost * 0.1);
            }
        }
    }
}
