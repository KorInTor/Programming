﻿using Contacts.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace Contacts.ViewModel
{
    public class MainVM : INotifyPropertyChanged
    {

        private Contact _selectedContact = new();

        private ObservableCollection<Contact> _contacts = [];

        private bool _canApplyCommand;
        private bool _canAddCommand = true;
        private bool _canEditCommand;
        private bool _canRemoveCommand;
        private bool _canEditData = false;
        private int _selectedContactIndex = -1;

        public event PropertyChangedEventHandler? PropertyChanged;

        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand RemoveCommand { get; set; }
        public ICommand ApplyCommand { get; set; }

        private void AddContact(object parameter)
        {
            BlockButtons();
            SelectedContact = new Contact();
            SelectedContactIndex = -1;
            CanApplyCommand = true;
        }

        private void EditContact(object obj)
        {
            BlockButtons();
            CanApplyCommand = true;
        }

        private void RemoveContact(object obj)
        {
            int lastIndex = SelectedContactIndex;
            if (Contacts.Count == 1)
            {
                SelectedContactIndex = -1;
            }
            if (SelectedContactIndex == Contacts.Count - 1)
            {
                SelectedContactIndex --;
            }
            SelectedContactIndex++;
            Contacts.RemoveAt(lastIndex);
        }

        private void ApplyChanges(object obj)
        {
            if (SelectedContactIndex == -1)
            {
                Contacts.Add(SelectedContact);
            }
            UnblockButtons();
            CanApplyCommand = false;
        }

        public bool CanEditData
        {
            get
            {
                return _canEditData;
            }
            set
            {
                _canEditData = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CanEditData)));
            }
        }
        public int SelectedContactIndex
        {
            get
            {
                return _selectedContactIndex;
            }
            set
            {
                _selectedContactIndex = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SelectedContactIndex)));
            }
        }
        public bool CanApplyCommand
        {
            get 
            { 
                return _canApplyCommand; 
            }
            set
            {
                _canApplyCommand = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CanApplyCommand)));
            }
        }

        public ObservableCollection<Contact> Contacts
        {
            get
            {
                return _contacts;
            }
            set
            {
                _contacts = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Contacts)));
            }
        }

        public Contact SelectedContact
        {
            get
            {
                return _selectedContact;
            }
            set
            {
                _selectedContact = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SelectedContact)));
            }
        }

        public MainVM()
        {
            AddCommand = new RelayCommand(AddContact, param => CanAddCommand);
            EditCommand = new RelayCommand(EditContact, param => CanEditCommand);
            RemoveCommand = new RelayCommand(RemoveContact, param => CanRemoveCommand);
            ApplyCommand = new RelayCommand(ApplyChanges, param => CanApplyCommand);
            PropertyChanged += OnPropertyChanged;
        }

        private void OnPropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(SelectedContactIndex) && SelectedContactIndex != -1)
            {
                CanEditCommand = true;
                CanRemoveCommand = true;
            }
        }

        public string Name
        {
            get
            {
                return SelectedContact.Name;
            }
            set
            {
                SelectedContact.Name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
            }
        }

        public string PhoneNumber
        {
            get
            {
                return SelectedContact.PhoneNumber;
            }
            set
            {
                SelectedContact.PhoneNumber = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PhoneNumber)));
            }
        }

        public string Email
        {
            get
            {
                return SelectedContact.Email;
            }
            set
            {
                SelectedContact.Email = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Email)));
            }
        }

        public bool CanAddCommand 
        {
            get
            {
                return _canAddCommand;
            }
            set 
            { 
                _canAddCommand = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CanAddCommand)));
            } 
        }

        public bool CanEditCommand 
        { 
            get 
            {
                if (SelectedContact == null || Contacts.Count == 0)
                {
                    _canEditCommand = false;
                }
                return _canEditCommand;
            }
            set 
            { 
                _canEditCommand = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CanEditCommand)));
            }
        }

        public bool CanRemoveCommand 
        {
            get 
            {
                if (SelectedContact == null || Contacts.Count == 0)
                {
                    _canRemoveCommand = false;
                }
                return _canRemoveCommand;
            }
            set 
            {
                _canRemoveCommand = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CanRemoveCommand)));
            }
        }

        private void BlockButtons()
        {
            CanAddCommand = false;
            CanEditCommand = false;
            CanRemoveCommand = false;
        }

        private void UnblockButtons()
        {
            CanAddCommand = true;
            if (SelectedContactIndex != -1)
            {
                CanEditCommand = true;
                CanRemoveCommand = true;
            }
        }
    }
}
