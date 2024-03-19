using Contacts.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.ViewModel
{
    public class MainVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public SaveCommand SaveCommand { get; } = new();

        public LoadCommand LoadCommand { get; } = new();

        private Contact _contact = new();

        public Contact Contact
        {
            get 
            { 
                return _contact; 
            }
            set
            {
                _contact = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Contact)));
            }
        }

        public MainVM()
        {
            LoadCommand.ContactLoaded += OnContactLoaded;
        }

        private void OnContactLoaded(Contact loadedContact)
        {
            Contact = loadedContact;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PhoneNumber)));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Email)));
        }

        public string Name 
        {
            get
            {
                return Contact.Name;
            }
            set
            {
                Contact.Name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
            }
        }

        public string PhoneNumber 
        {
            get
            {
                return Contact.PhoneNumber;
            }
            set
            {
                Contact.PhoneNumber = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PhoneNumber)));
            }
        }

        public string Email 
        {
            get
            {
                return Contact.Email;
            }
            set
            {
                Contact.Email = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Email)));
            }
        }
    }
}
