using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Tabs;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Покупатели и товары.
        /// </summary>
        Store _store = new Store();

        /// <summary>
        /// Создает экземпляр класса <see cref="MainForm"/>
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            Store _store = new Store();
            ItemsTab.Items = _store.Items;
            CustomersTab.Customers = _store.Customers;
        }
    }
}