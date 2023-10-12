using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Service
{
    public class CustomerFactory
    {
        private static Random _random = new Random();
        private static string[] _firstNames =
        {
            "Иван",
            "Петр",
            "Сергей",
            "Алексей",
            "Дмитрий",
            "Андрей",
            "Владимир",
            "Михаил",
            "Александр",
            "Николай",
            "Василий",
            "Георгий",
            "Евгений",
            "Антон",
            "Виктор",
            "Игорь",
            "Роман",
            "Олег",
            "Ярослав",
            "Артем"
        };
        private static string[] _secondNames =
        {
            "Иванов",
            "Петров",
            "Сергеев",
            "Алексеев",
            "Дмитриев",
            "Андреев",
            "Владимиров",
            "Михайлов",
            "Александров",
            "Николаев",
            "Васильев",
            "Георгиев",
            "Евгеньев",
            "Антонов",
            "Викторов",
            "Игорев",
            "Романов",
            "Олегов",
            "Ярославов",
            "Артемов"
        };
        private static string[] _surNames =
        {
            "Иванович",
            "Петрович",
            "Сергеевич",
            "Алексеевич",
            "Дмитриевич",
            "Андреевич",
            "Владимирович",
            "Михайлович",
            "Александрович",
            "Николаевич",
            "Васильевич",
            "Георгиевич",
            "Евгеньевич",
            "Антонович",
            "Викторович",
            "Игоревич",
            "Романович",
            "Олегович",
            "Ярославович",
            "Артемович"
        };
        public static Customer CreateRandomCustomer()
        {
            string fullname = ($"{_secondNames[_random.Next(_secondNames.Length)]} {_firstNames[_random.Next(_firstNames.Length)]} {_surNames[_random.Next(_surNames.Length)]}");
            Address address = AddressFactory.CreateRandomAddress();

            return new Customer(fullname, address);
        }
    }

}
