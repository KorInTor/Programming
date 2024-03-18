using Contacts.Model;
using Contacts.Model.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Contacts.ViewModel
{
    public class LoadCommand : ICommand
    {
        public event Action<Contact> ContactLoaded;
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            ContactLoaded?.Invoke(ContactSerializer.LoadContact());
        }
    }
}
