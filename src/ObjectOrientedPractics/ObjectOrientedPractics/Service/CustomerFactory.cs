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
            "Николай"
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
             "Николаев"
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
            "Николаевич"
        };
        public static Customer CreateRandomCustomer()
        {
            string fullname = ($"{_secondNames[_random.Next(_secondNames.Length)]} {_firstNames[_random.Next(_firstNames.Length)]} {_surNames[_random.Next(_surNames.Length)]}");
            Address address = AddressFactory.CreateRandomAddress();

            return new Customer(fullname, address);
        }
    }

}
