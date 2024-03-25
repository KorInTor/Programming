using System.Windows;
using Contacts.Model;
using Contacts.Model.Services;
using Contacts.ViewModel;

namespace Contacts
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainVM();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MainVM DataContext = (MainVM)this.DataContext;
            var contacts = ContactSerializer.LoadContactList();
            DataContext.Contacts.Clear();
            foreach (var contact in contacts)
            {
                DataContext.Contacts.Add(contact);
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MainVM DataContext = (MainVM)this.DataContext;
            ContactSerializer.SaveContactList(new List<Contact>(DataContext.Contacts));
        }
    }
}