using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Model.Orders;
using ObjectOrientedPractics.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class PriorityOrdersTab : UserControl
    {
        private static Random _random = new Random();
        public List<Item> Items { get; set; } = new List<Item>();
        private Customer _customer = CustomerFactory.CreateRandomCustomer();

        private PriorityOrder _order;
        public PriorityOrdersTab()
        {
            InitializeComponent();
            foreach (OrderStatus status in Enum.GetValues(typeof(OrderStatus)))
            {
                StatusComboBox.Items.Add(status);
            }
            _order = new PriorityOrder(_customer.Address, new List<Item>(), DateTime.Now, "9:00 – 11:00");
            _order.Items = new List<Item>();
            for (int i = 0; i < _random.Next(10, 20); i++)
            {
                _order.Items.Add(ItemFactory.CreateRandomItem());
            }
            AddressControl.Address = _customer.Address;
            IdTextBox.Text = _order.Id.ToString();
            CreationDateTextBox.Text = _order.Date.ToString();
            StatusComboBox.Text = _order.Status.ToString();
            DesiredTimeComboBox.Text = _order.DesiredDeliveryTime;
        }

        /// <summary>
        /// Инициализирует список товаров заказа на UI значениями из <see cref="_order.Items"/>
        /// </summary>
        public void InitOrderItemsList()
        {
            if (_order.Items.Count == 0)
            {
                return;
            }
            OrderItemsListBox.Items.Clear();
            foreach (Item item in _order.Items)
            {
                OrderItemsListBox.Items.Add(item.Name);
            }
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            _order.Items.Add(Items[_random.Next(Items.Count)]);
            OrderItemsListBox.Items.Add(_order.Items.Last().Name);
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            _order.Items.RemoveAt(OrderItemsListBox.SelectedIndex);
            int lastIndex = OrderItemsListBox.SelectedIndex;
            OrderItemsListBox.Items.RemoveAt(OrderItemsListBox.SelectedIndex);
            if (OrderItemsListBox.Items.Count == lastIndex)
            {
                OrderItemsListBox.SelectedIndex = OrderItemsListBox.Items.Count - 1;
                return;
            }
            OrderItemsListBox.SelectedIndex = lastIndex;
        }

        private void ClearOrderButton_Click(object sender, EventArgs e)
        {
            _order = new PriorityOrder();
            _order.Items = new List<Item>();
            OrderItemsListBox.Items.Clear();
        }

        private void OrderItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
