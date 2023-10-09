using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Service
{
    public class AddressFactory
    {
        private static Random _random = new Random();
        private static string[] _countries = { "Россия", "Украина", "Беларусь" };
        private static string[] _cities =
        {
            "Москва",
            "Киев",
            "Минск",
            "Санкт-Петербург",
            "Новосибирск",
            "Екатеринбург",
            "Нижний Новгород",
            "Самара",
            "Омск",
            "Казань",
            "Челябинск",
            "Ростов-на-Дону",
            "Уфа",
            "Волгоград",
            "Пермь",
            "Красноярск",
            "Воронеж",
            "Саратов",
            "Краснодар",
            "Тольятти"
        };

        private static string[] _streets =
        {
            "Ленина",
            "Советская",
            "Мира",
            "Гагарина",
            "Космонавтов",
            "Проспект Мира",
            "Арбат",
            "Тверская",
            "Рублевское шоссе",
            "Лубянка",
            "Кутузовский проспект",
            "Невский проспект",
            "Красная площадь",
            "Старый Арбат",
            "Новый Арбат",
            "Садовое кольцо",
            "Бульварное кольцо",
            "Кольцевая линия",
            "Профсоюзная улица",
            "Ленинградское шоссе"
        };

        public static Address CreateRandomAddress()
        {
            int index = _random.Next(100000, 1000000);
            string country = _countries[_random.Next(_countries.Length)];
            string city = _cities[_random.Next(_cities.Length)];
            string street = _streets[_random.Next(_streets.Length)];
            string building = _random.Next(1,100).ToString();
            string apartment = _random.Next(1, 100).ToString();

            return new Address(index, country, city, street, building, apartment);
        }
    }
}
