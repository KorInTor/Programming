using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.Service
{
    delegate List<Item> SortType(List<Item> items);

    /// <summary>
    /// Класс содержит инструменты для фильтрации и сортировки <see cref="List{Item}<"/>.
    /// </summary>
    static class DataTools
    {
        /// <summary>
        /// Проверяет цену товара. Возвращает true если цена >= 5000 иначе false.
        /// </summary>
        /// <param name="item">Товар.</param>
        /// <returns>Результат.</returns>
        public static bool IsPriceBig(Item item)
        {
            if (item.Cost >= 5000)
                return true; 
            return false;
        }

        /// <summary>
        /// Проверяет категорию товара. Возвращает true если категория <see cref="Category.Trim"/> иначе false.
        /// </summary>
        /// <param name="item">Товар.</param>
        /// <returns>Результат.</returns>
        public static bool IsCategoryTrim(Item item)
        {
            if (item.Category == Category.Trim)
                return true;
            return false;
        }

        /// <summary>
        /// Возвращает отфильтрованные список товаров в зависимости от параметра фильтра.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <param name="filterType">Параметр фильтра.</param>
        /// <returns>Отфильтрованные список.</returns>
        public static List<Item> FilterItems(List<Item> items, Func<Item, bool> filterType)
        {
            List<Item> result = new List<Item>();
            foreach(Item item in items)
            {
                if (filterType(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }

        /// <summary>
        /// Возвращает список товаров отсортированный по имени по убыванию.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Отсортированный список товаров.</returns>
        public static List<Item> SortByNameDesc(List<Item> items)
        {
            List<Item> sortedItems = new List<Item>(items);
            sortedItems.Sort((p1, p2) => p1.Name.CompareTo(p2.Name));
            return sortedItems;
        }

        /// <summary>
        /// Возвращает список товаров отсортированный по имени по возрастанию.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Отсортированный список товаров.</returns>
        public static List<Item> SortByNameAsc(List<Item> items)
        {
            List<Item> sortedItems = new List<Item>(items);
            sortedItems.Sort((p1, p2) => p2.Name.CompareTo(p1.Name));
            return sortedItems;
        }

        /// <summary>
        /// Возвращает список товаров отсортированный по цене по убыванию.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Отсортированный список товаров.</returns>
        public static List<Item> SortByCostDesc(List<Item> items)
        {
            List<Item> sortedItems = new List<Item>(items);
            sortedItems.Sort((p1, p2) => p2.Cost.CompareTo(p1.Cost));
            return sortedItems;
        }

        /// <summary>
        /// Возвращает список товаров отсортированный по цене по возрастанию.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Отсортированный список товаров.</returns>
        public static List<Item> SortByCostAsc(List<Item> items)
        {
            List<Item> sortedItems = new List<Item>(items);
            sortedItems.Sort((p1, p2) => p1.Cost.CompareTo(p2.Cost));
            return sortedItems;
        }

        /// <summary>
        /// Возвращает отсортированный список товаров в зависимости от параметра сортировки.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <param name="sortType">Параметр сортировки.</param>
        /// <returns>Отсортированный список товаров.</returns>
        public static List<Item> SortItems(List<Item> items, SortType sortType)
        {
            return sortType(items);
        }
    }
}
