using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Service;
using ObjectOrientedPractics.View.Tabs;
using System;

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
            CreateRandomObjects();
            ItemsTab.Items = _store.Items;
            CustomersTab.Customers = _store.Customers;
            CartsTab.Customers = _store.Customers;
            CartsTab.Items = _store.Items;
            OrdersTab.Customers = _store.Customers;
        }

        private void CreateRandomObjects()
        {
            Random _random = new Random();
            do
            {
                for (int i = 0; i < _random.Next(10, 20); i++)
                {
                    _store.Items.Add(ItemFactory.CreateRandomItem());
                    _store.Customers.Add(CustomerFactory.CreateRandomCustomer());
                }
                foreach (Customer customer in _store.Customers)
                {
                    for (int i = 0; i <= _random.Next(1, 10); i++)
                    {
                        customer.Orders.Add(OrderFactory.CreateRandomOrder(customer, _store.Items, _random.Next(1, 10)));
                    }
                }
            } while (IdGenerator.GetNextId() < 100);
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabControl.SelectedIndex == 2)
            {
                CartsTab.RefreshData();
            }
            if (TabControl.SelectedIndex == 3)
            {
                OrdersTab.RefreshData();
            }
            if (TabControl.SelectedIndex == 4)
            {
                return;
            }
        }
    }
}