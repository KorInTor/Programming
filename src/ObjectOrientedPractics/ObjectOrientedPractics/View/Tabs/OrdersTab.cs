using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Tabs.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class OrdersTab : UserControl
    {
        /// <summary>
        /// Выбранный заказ.
        /// </summary>
        private Order _currentOrder = new Order();

        /// <summary>
        /// Список покупателей.
        /// </summary>
        public List<Customer> Customers { get; set; }

        /// <summary>
        /// Список заказов
        /// </summary>
        private List<Order> Orders { get; set; } = new List<Order>();

        public OrdersTab()
        {
            InitializeComponent();
            foreach (OrderStatus status in Enum.GetValues(typeof(OrderStatus)))
            {
                StatusComboBox.Items.Add(status);
            }
        }

        /// <summary>
        /// Обновляет список заказов и выводит данные на <see cref="OrdersDataGridView"/>.
        /// </summary>
        public void UpdateOrders()
        {
            OrdersDataGridView.Rows.Clear();
            foreach (Customer customer in Customers)
            {
                foreach (Order order in customer.Orders)
                {
                    Orders.Add(order);
                    OrdersDataGridView.Rows.Add(order.Id, order.Date, order.Status, customer.Fullname, order.Address.ToString(), order.Amount);
                }
            }
        }

        /// <summary>
        /// Обновляет список заказов.
        /// </summary>
        public void RefreshData()
        {
            _currentOrder = new Order();
            UpdateOrders();
        }

        private void OrdersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            _currentOrder = Orders[OrdersDataGridView.CurrentRow.Index];
            AddressControl.Address = _currentOrder.Address;
            OrderItemsListBox.Items.Clear();
            foreach (Item item in _currentOrder.Items)
            {
                OrderItemsListBox.Items.Add(item.Name);
            }
            IdTextBox.Text = _currentOrder.Id.ToString();
            CreationDateTextBox.Text = _currentOrder.Date.ToString();
            StatusComboBox.SelectedItem = _currentOrder.Status;
            FinalAmountLabel.Text = _currentOrder.Amount.ToString();

            if (_currentOrder is PriorityOrder priority)
            {
                PriorityPanel.Visible = true;
                DesiredTimeComboBox.Text = priority.DesiredDeliveryTime;
            }
            else
            {
                PriorityPanel.Visible = false;
            }
        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_currentOrder == null)
            {
                return;
            }
            _currentOrder.Status = (OrderStatus)Enum.Parse(typeof(OrderStatus), StatusComboBox.SelectedItem.ToString());
            OrdersDataGridView.CurrentRow.Cells["OrderStatus"].Value = StatusComboBox.SelectedItem.ToString();
        }

        private void DesiredTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_currentOrder is PriorityOrder priority)
            {
                priority.DesiredDeliveryTime = DesiredTimeComboBox.SelectedItem.ToString();
            }
        }
    }
}
