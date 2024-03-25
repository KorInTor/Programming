using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Contacts.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Input;

namespace Contacts.ViewModel
{
    public partial class MainVM : ObservableObject
    {
        [ObservableProperty]
        private bool _canAddCommand = true;

        [ObservableProperty]
        private bool _canApplyAndNoErrors;

        [ObservableProperty]
        private bool _canApplyCommand = false;

        [ObservableProperty]
        private bool _canEditCommand;

        [ObservableProperty]
        private bool _canRemoveCommand;

        [ObservableProperty]
        private ObservableCollection<Contact> _contacts = [];

        [ObservableProperty]
        private bool _isDataReadOnly = true;

        [ObservableProperty]
        private Contact _selectedContact = new();
        [ObservableProperty]
        private int _selectedContactIndex = -1;
        public RelayCommand AddCommand { get; set; }

        public RelayCommand ApplyCommand { get; set; }

        public RelayCommand EditCommand { get; set; }

        public bool HasValidationErrors
        {
            get
            {
                if (!string.IsNullOrEmpty(SelectedContact.Error))
                {
                    return true;
                }

                return false;
            }
        }

        public RelayCommand RemoveCommand { get; set; }

        public MainVM()
        {
            AddCommand = new RelayCommand(AddContact, () => CanAddCommand);
            EditCommand = new RelayCommand(EditContact, () => CanEditCommand);
            RemoveCommand = new RelayCommand(RemoveContact, () => CanRemoveCommand);
            ApplyCommand = new RelayCommand(ApplyChanges, () => CanApplyCommand);

            SelectedContact.PropertyChanged += OnContactPropertyChanged;
        }

        private void AddContact()
        {
            BlockButtons();
            SelectedContact = new Contact();
            SelectedContact.PropertyChanged += OnContactPropertyChanged;
            SelectedContactIndex = -1;
            IsDataReadOnly = false;
            CanApplyCommand = true;

            NotifyCanExecuteChanged();
        }

        private void ApplyChanges()
        {
            if (SelectedContactIndex == -1)
            {
                Contacts.Add(SelectedContact);
            }
            else
            {
                Contacts[SelectedContactIndex] = SelectedContact;
            }
            UnblockButtons();
            CanApplyCommand = false;
            IsDataReadOnly = true;

            NotifyCanExecuteChanged();
        }

        private void EditContact()
        {
            BlockButtons();
            SelectedContact = new Contact(Contacts[SelectedContactIndex]);
            SelectedContact.PropertyChanged += OnContactPropertyChanged;
            IsDataReadOnly = false;
            CanApplyCommand = true;

            NotifyCanExecuteChanged();
        }

        private void NotifyCanExecuteChanged()
        {
            AddCommand?.NotifyCanExecuteChanged();
            EditCommand?.NotifyCanExecuteChanged();
            RemoveCommand?.NotifyCanExecuteChanged();
            ApplyCommand?.NotifyCanExecuteChanged();
        }

        partial void OnCanApplyCommandChanged(bool value)
        {
            CanApplyAndNoErrors = !HasValidationErrors && CanApplyCommand;
            Debug.WriteLine($"HasValidationErrors={HasValidationErrors} CanApplyCommand={CanApplyCommand}");
        }

        private void OnContactPropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            Debug.WriteLine($"Called by {e}");
            CanApplyAndNoErrors = !HasValidationErrors && CanApplyCommand;
            Debug.WriteLine($"HasValidationErrors={HasValidationErrors} CanApplyCommand={CanApplyCommand}");
        }

        partial void OnSelectedContactIndexChanged(int value)
        {
            if (value != -1)
            {
                SelectedContact = Contacts[SelectedContactIndex];
                IsDataReadOnly = true;
                CanApplyCommand = false;
                CanEditCommand = true;
                CanRemoveCommand = true;
                NotifyCanExecuteChanged();
            }
        }

        private void RemoveContact()
        {
            int lastIndex = SelectedContactIndex;
            if (Contacts.Count == 1)
            {
                SelectedContactIndex = -1;
            }
            if (SelectedContactIndex == Contacts.Count - 1)
            {
                SelectedContactIndex--;
            }
            SelectedContactIndex++;
            Contacts.RemoveAt(lastIndex);

            NotifyCanExecuteChanged();
        }

        private void BlockButtons()
        {
            CanAddCommand = false;
            CanEditCommand = false;
            CanRemoveCommand = false;
            NotifyCanExecuteChanged();
        }

        private void UnblockButtons()
        {
            CanAddCommand = true;
            if (SelectedContactIndex != -1)
            {
                CanEditCommand = true;
                CanRemoveCommand = true;
            }
            NotifyCanExecuteChanged();
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
