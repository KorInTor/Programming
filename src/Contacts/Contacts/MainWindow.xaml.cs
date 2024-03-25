using Contacts.Model;
using Contacts.Model.Services;
using Contacts.ViewModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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