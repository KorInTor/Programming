using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Orders;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CartsTab : UserControl
    {
        /// <summary>
        /// Товары для добавления в корзину.
        /// </summary>
        private List<Item> _items = new List<Item>();

        /// <summary>
        /// Покупатели для работы с корзиной.
        /// </summary>
        private List<Customer> _customers = new List<Customer>();

        /// <summary>
        /// Поле для работы с покупателем.
        /// </summary>
        private Customer CurrentCustomer { get; set; } = new Customer();

        /// <summary>
        /// Вовзращает и задёт список покупателей в <see cref="CartsTab"/>
        /// </summary>
        public List<Customer> Customers
        {
            get
            {
                return _customers;
            }
            set
            {
                _customers = value;
            }
        }

        /// <summary>
        /// Вовзращает и задёт список товаров в <see cref="CartsTab"/>
        /// </summary>
        public List<Item> Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;
            }
        }

        public CartsTab()
        {
            InitializeComponent();
            InitItemsListBox();
            InitCustomerComboBox();
        }

        /// <summary>
        /// Обновляет списки товаров и покупателей.
        /// </summary>
        public void RefreshData()
        {
            CurrentCustomer = new Customer();
            CustomerComboBox.SelectedIndex = -1;
            InitItemsListBox();
            InitCustomerComboBox();
            InitCartContent();
        }

        /// <summary>
        /// Заполняет список <see cref="ItemsListBox"/> значениями из <see cref="Items"/>.
        /// </summary>
        private void InitItemsListBox()
        {
            ItemsListBox.Items.Clear();
            foreach (Item item in Items)
            {
                ItemsListBox.Items.Add(item.Name);
            }
        }

        /// <summary>
        /// Заполняет список <see cref="CustomerComboBox"/> значениями из <see cref="Customers"/>.
        /// </summary>
        private void InitCustomerComboBox()
        {
            CustomerComboBox.Items.Clear();
            foreach (var customer in Customers)
            {
                CustomerComboBox.Items.Add(customer.Fullname);
            }
        }

        /// <summary>
        /// Заполняет список <see cref="CartContentListBox"/> значениями из <see cref="CurrentCustomer.Cart.Items"/> и меняет <see cref="FinalAmountLabel"/>.
        /// </summary>
        private void InitCartContent()
        {
            CartContentListBox.Items.Clear();
            if (CurrentCustomer.Cart == null)
            {
                return;
            }
            if (CurrentCustomer.Cart.Items.Count == 0)
            {
                CartContentListBox.Items.Add("Корзина пуста");
                FinalAmountLabel.Text = CurrentCustomer.Cart.Amount.ToString();
                return;
            }
            foreach (var item in CurrentCustomer.Cart.Items)
            {
                CartContentListBox.Items.Add(item.Name);
            }
            FinalAmountLabel.Text = CurrentCustomer.Cart.Amount.ToString();
        }

        private void CustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomerComboBox.SelectedIndex == -1)
            {
                CartContentListBox.Items.Clear();
                return;
            }
            CurrentCustomer = Customers[CustomerComboBox.SelectedIndex];
            InitCartContent();
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            if (CustomerComboBox.SelectedIndex == -1)
            {
                return;
            }
            CurrentCustomer.Cart.Items.Add(Items[ItemsListBox.SelectedIndex]);
            InitCartContent();
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (CustomerComboBox.SelectedIndex == -1)
            {
                return;
            }
            CurrentCustomer.Cart.Items.RemoveAt(CartContentListBox.SelectedIndex);
            InitCartContent();
        }

        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            if (CustomerComboBox.SelectedIndex == -1)
            {
                return;
            }
            CurrentCustomer.Cart.Items.Clear();
            InitCartContent();
        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            if (CurrentCustomer.IsPriority)
            {
                CurrentCustomer.Orders.Add(new PriorityOrder(CurrentCustomer.Address, new List<Item>(CurrentCustomer.Cart.Items),DateTime.Now,""));
            }
            else
            {
                CurrentCustomer.Orders.Add(new Order(CurrentCustomer.Address, new List<Item>(CurrentCustomer.Cart.Items)));
            }
            CurrentCustomer.Cart.Items.Clear();
            InitCartContent();
        }
    }
}
