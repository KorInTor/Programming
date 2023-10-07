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
            ItemsTab.Items = _store.Items;
            CustomersTab.Customers = _store.Customers;
            CartsTab.Customers = _store.Customers;
            CartsTab.Items = _store.Items;
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabControl.SelectedIndex == 2) 
            {
                CartsTab.RefreshData();
            }
        }
    }
}