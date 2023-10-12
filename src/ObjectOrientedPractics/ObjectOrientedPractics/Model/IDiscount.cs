using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public interface IDiscount
    {
        /// <summary>
        /// Возвращает информацию о скидке.
        /// </summary>
        string Info { get; }
        
        /// <summary>
        /// Возвращает значение скидки на основе списка товаров.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Значение скидки.</returns>
        double Calculate(List<Item> items);

        /// <summary>
        /// Применяте и вовзвращает скидку на освнове списка товаров.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Значение скидки.</returns>
        double Apply(List<Item> items);

        /// <summary>
        /// Обновляет скидку на освнове списка товаров.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        void Update(List<Item> items);
    }
}
