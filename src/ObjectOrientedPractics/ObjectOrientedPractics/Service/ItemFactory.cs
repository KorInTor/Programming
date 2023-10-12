using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Service
{
    public class ItemFactory
    {
        private static Random _random = new Random();

        private static string[] _names =
        {
            "Тормозные колодки",
            "Воздушный фильтр",
            "Масляный фильтр",
            "Свечи зажигания",
            "Аккумулятор",
            "Ремень ГРМ",
            "Термостат",
            "Стойка стабилизатора",
            "Радиатор охлаждения",
            "Топливный фильтр",
            "Амортизаторы",
            "Сальник распредвала",
            "Прокладка головки блока цилиндров",
            "Подшипник ступицы",
            "Лямбда-зонд",
            "Фильтр салона",
            "Топливный насос",
            "Рулевая рейка",
            "Тормозной диск",
            "Тормозной барабан",
            "Тормозной цилиндр",
            "Трос ручника",
            "Трос газа",
            "Трос сцепления",
            "Подшипник колеса",
            "Радиатор печки",
            "Вискомуфта",
            "Водяной насос",
            "Термостат охлаждения",
            "Ремень сервопривода",
            "Натяжитель ремня",
            "Ролик ремня ГРМ",
            "Ролик ремня сервопривода",
            "Стартер",
            "Генератор",
            "Реле стартера",
            "Катушка зажигания",
            "Модуль зажигания",
            "Датчик положения коленвала",
            "Датчик положения распредвала",
        };

        private static string[] _topics =
        {
            "Производитель: {0}",
            "Срок службы: {0} лет",
            "Совместимость: {0}",
            "Материал: {0}",
            "Вес: {0} г",
            "Размеры: {0}",
            "Цвет: {0}",
            "Тип установки: {0}",
            "Уровень шума: {0} дБ",
            "Энергоэффективность: класс {0}"
        };

        private static string[][] _values =
        {
            new string[] {"Bosch", "Denso", "NGK", "ACDelco", "Motorcraft"},
            new string[] {"1", "2", "3", "4", "5"},
            new string[] {"Toyota Corolla", "Honda Civic", "Ford Focus"},
            new string[] {"Алюминий", "Сталь", "Пластик"},
            new string[] {"100", "200", "300", "400", "500"},
            new string[] {"10x20x30", "40x50x60", "70x80x90"},
            new string[] {"Красный", "Синий", "Зеленый"},
            new string[] {"Ручная", "Автоматическая"},
            new string[] {"10", "20", "30", "40"},
            new string[] {"A", "B", "C"}
        };

        private static Category[] _categories = (Category[])Enum.GetValues(typeof(Category));

        public static Item CreateRandomItem()
        {
            string name = ($"{_names[_random.Next(_names.Length)]}, Модель#{_random.Next(1,100)}");
            double cost = Math.Round(_random.NextDouble() * 10000, 2);
            Category category = _categories[_random.Next(_categories.Length)];

            return new Item(name, CreateItemDesc(), cost, category);
        }


        private static string CreateItemDesc()
        {
            int topicCount = _random.Next(1, _topics.Length + 1);
            List<string> selectedTopics = new List<string>();
            for (int i = 0; i < topicCount; i++)
            {
                int topicIndex = _random.Next(_topics.Length);
                string topic = _topics[topicIndex];
                string value = _values[topicIndex][_random.Next(_values[topicIndex].Length)];

                selectedTopics.Add(string.Format(topic, value));
            }
            string desc = string.Join("; ", selectedTopics);
            return desc;
        }
    }

}
