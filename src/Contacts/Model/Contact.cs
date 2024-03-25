using System.ComponentModel;
using System.Text.RegularExpressions;

namespace Contacts.Model
{
    public partial class Contact : INotifyPropertyChanged, IDataErrorInfo
    {
        private string _name = string.Empty;

        private string _phoneNumber = string.Empty;

        private string _email = string.Empty;

        public Contact() { }

        public Contact( Contact other)
        {
            this.Name = other.Name;
            this.PhoneNumber = other.PhoneNumber;
            this.Email = other.Email;
        }

        public string this[string columnName]
        {
            get
            {
                string result = string.Empty;

                if (columnName == nameof(Name))
                {
                    if (this.Name.Length == 0 || this.Name.Length > 100)
                    {
                        result = "Имя должно быть не пустым и не длиннее 100 символов";
                    }
                }

                if (columnName == nameof(PhoneNumber))
                {
                    if (string.IsNullOrEmpty(PhoneNumber))
                        result = "Номер телефона не может быть пустым.";

                    if (PhoneNumber.Length > 100)
                        result = "Номер телефона не должен быть длиннее 100 символов.";

                    if (!PhoneNumberRegEx().IsMatch(PhoneNumber))
                        result = "Номер телефона содержит недопустимые символы.";
                }

                if (columnName == nameof(Email))
                {
                    if (string.IsNullOrEmpty(Email))
                    {
                        result = "Email не может быть пустым.";
                    }
                    if (Email.Length > 100)
                    {
                        result = "Email не должен быть длиннее 100 символов.";
                    }
                    if (!SimpleEmailRegEx().IsMatch(Email))
                    {
                        result = "Неккоректный Email.";
                    }
                }
                return result;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
            }
        }

        public string PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                _phoneNumber = value;
                PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(nameof(PhoneNumber)));
            }
        }

        public string Email
        {
            get
            { 
                return _email; 
            }
            set 
            { 
                _email = value;
                PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(nameof(Email)));
            }
        }

        public string Error
        {
            get
            {
                var nameError = this[nameof(Name)];
                var phoneNumberError = this[nameof(PhoneNumber)];
                var emailError = this[nameof(Email)];

                if (!string.IsNullOrEmpty(nameError))
                {
                    return nameError;
                }
                if (!string.IsNullOrEmpty(phoneNumberError))
                {
                    return phoneNumberError;
                }
                if (!string.IsNullOrEmpty(emailError))
                {
                    return emailError;
                }

                return string.Empty;
            }
        }



        public event PropertyChangedEventHandler? PropertyChanged;

        [GeneratedRegex(@"^[\+]?[\d\-\(\)]+$")]
        private static partial Regex PhoneNumberRegEx();

        [GeneratedRegex(@"^[^@]+@[^@]+$")]
        private static partial Regex SimpleEmailRegEx();
    }
}
