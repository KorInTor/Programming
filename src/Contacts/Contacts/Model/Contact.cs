using System.ComponentModel;

namespace Contacts.Model
{
    public class Contact : INotifyPropertyChanged
    {
        private string _name;

        private string _phoneNumber;

        private string _email;

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

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
