using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Tabs;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// ���������� � ������.
        /// </summary>
        Store _store = new Store();

        /// <summary>
        /// ������� ��������� ������ <see cref="MainForm"/>
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