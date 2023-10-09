﻿using ObjectOrientedPractics.Model;
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
        private static string[] _infos =
        {
            "Высококачественный товар, изготовленный с использованием передовых технологий",
            "Продукт премиум-класса, созданный с использованием инновационных материалов",
            "Этот товар произведен в стране, известной своим качеством и надежностью",
            "Конструкция этого товара продумана до мелочей для вашего удобства",
            "Изделие отличается превосходным качеством деталей и долговечностью",
            "Товар прошел строгий контроль качества и соответствует всем стандартам",
            "Этот продукт сочетает в себе стиль, функциональность и непревзойденное качество",
            "Изготовлено с использованием экологически чистых материалов и технологий",
            "Продукт предлагает превосходное соотношение цены и качества",
            "Этот товар обеспечит вам комфорт и удовлетворение от использования на долгие годы"
        };

        private static Category[] _categories = (Category[])Enum.GetValues(typeof(Category));

        public static Item CreateRandomItem()
        {
            string name = ($"{_names[_random.Next(_names.Length)]}, Модель#{_random.Next(1,100)}");
            string info = _infos[_random.Next(_infos.Length)];
            double cost = Math.Round(_random.NextDouble() * 10000, 2);
            Category category = _categories[_random.Next(_categories.Length)];

            return new Item(name, info, cost, category);
        }
    }

}
