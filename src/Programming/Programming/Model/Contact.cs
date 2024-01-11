using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Хранит данные о человеке и его конактых данных
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Закрытое поле хранящее информацию о номере телефона.
        /// </summary>
        private int _phoneNumber;

        /// <summary>
        /// Закрытое поле хранящее информацию о имени.
        /// </summary>
        private string _name;

        /// <summary>
        /// Закрытое поле хранящее информацию о фамилии.
        /// </summary>
        private string _surname;

        /// <summary>
        /// Возвращает и задаёт электронную почту контакта.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Возвращает и задаёт адресс контакта.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Возвращает и задаёт имя контакта. Должно состоять только из букв.
        /// </summary>
        public string Name 
        { 
            get
            {
                return _name;
            }
            set
            {
                if (!AssertStringContainsOnlyLetters(Name))
                    throw new ArgumentException("Name must contain English letters only");
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт фамилию контакта. Должна состоять только из букв.
        /// </summary>
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                if (!AssertStringContainsOnlyLetters(Name))
                    throw new ArgumentException("Surname must contain English letters only");
                _surname = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт номер телефона контакта. Должен быть положительным.
        /// </summary>
        public int PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(PhoneNumber));
                _phoneNumber = value;
            }
        }

        /// <summary>
        /// Проверяет что строка состоит только из букв.
        /// </summary>
        /// <param name="value">Проверяемая строка</param>
        /// <returns>Возвращает true если строка состоит только из английских символов.
        /// Возвращает false если есть хотябы одна не буква(en)</returns>
        private bool AssertStringContainsOnlyLetters(string value)
        {
            int code;
            foreach (char symbol in value)
            {
                code = symbol;
                if (code < 65 || code > 122 || (code > 90 && code < 97))
                    return false;
            }
            return true;
        }

        public Contact() { }

        /// <summary> 
        /// Создаёт экземпляр класса <see cref="Contact"/>. 
        /// </summary>
        /// <param name="surname">Фамилия. Должна состоять только из букв.</param>
        /// <param name="name">Имя. Должно состоять только из букв.</param>
        /// <param name="email">Электронная почта.</param>
        /// <param name="phoneNumber">Номер телефона. Должен быть положительным.</param>
        /// <param name="addres">Адресс контакта.</param>
        public Contact(string name, string surname, int phoneNumber, string email, string addres)
        {
            Name = name;
            Surname = surname;
            PhoneNumber = phoneNumber;
            Email = email;
            Address = addres;
        }
    }
}
