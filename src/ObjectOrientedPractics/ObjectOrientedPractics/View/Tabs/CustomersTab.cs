using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Forms;
using ObjectOrientedPractics.View.Tabs.Controls;
using ObjectOrientedPractics.Model.Discounts;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        List<Customer> _customers = new();

        private Customer _selectedCustomer = null;

        public CustomersTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Возвращает и задаёт список покупателей. После получения списка, соритрует <see cref="CustomersListBox"/>.
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
                UpdateCustomerList();
            }
        }

        /// <summary>
        /// Сортировка списка <see cref="_customers"/> по свойству <see cref="Customer.Fullname"/> и вывод на <see cref="CustomersListBox"/>.
        /// </summary>
        private void UpdateCustomerList()
        {
            if (_customers == null)
            {
                CustomersListBox.Items.Clear();
                return;
            }
            CustomersListBox.Items.Clear();
            _customers.Sort((p1, p2) => p1.Fullname.CompareTo(p2.Fullname));
            foreach (Customer Customer in _customers)
            {
                CustomersListBox.Items.Add($"{Customer.Fullname}");
            }
            if (_selectedCustomer != null)
            {
                CustomersListBox.SelectedIndex = FindCustomerById();
            }
        }

        /// <summary>
        /// Обновление информации в UI взятая из <see cref="_selectedCustomer"/>.
        /// </summary>
        private void UpdateUIInfo()
        {
            if (CustomersListBox.SelectedIndex == -1)
            {
                return;
            }
            _selectedCustomer = _customers[CustomersListBox.SelectedIndex];

            AddressControl.Address = _selectedCustomer.Address;
            FullnameTextBox.Text = _selectedCustomer.Fullname;
            IdTextBox.Text = _selectedCustomer.Id.ToString();

            if (_selectedCustomer.IsPriority)
            {
                PriorityCheckBox.Checked = true;
            }
            else
            {
                PriorityCheckBox.Checked = false;
            }

            DiscountsListBox.Items.Clear();
            foreach (IDiscount discount in _selectedCustomer.Discounts)
            {
                DiscountsListBox.Items.Add(discount.Info);
            }
        }

        /// <summary>
        /// Поиск индекса покупателя в списке <see cref="_customers"/> с Id совпадающим c <see cref="_selectedCustomer"/>.
        /// </summary>
        /// <returns>Индекс элемента с совпадающим Id.</returns>
        private int FindCustomerById()
        {
            int _index = _customers.FindIndex(customer => customer.Id == _selectedCustomer.Id);
            return _index;
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            var blankCustomer = new Customer("ФИО", new Address());
            _customers.Add(blankCustomer);
            UpdateCustomerList();
        }

        private void RemoveCustomerButton_Click(object sender, EventArgs e)
        {
            if (_selectedCustomer == null)
            {
                return;
            }
            IdTextBox.Clear();
            FullnameTextBox.Clear();
            AddressControl.Clear();
            _customers.RemoveAt(CustomersListBox.SelectedIndex);
            DiscountsListBox.Items.Clear();
            _selectedCustomer = null;
            UpdateCustomerList();
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateUIInfo();
        }

        private void FullnameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_selectedCustomer == null)
            {
                FullnameTextBox.BackColor = Color.White;
                return;
            }
            try
            {
                FullnameTextBox.BackColor = Color.White;
                if (_selectedCustomer.Fullname == FullnameTextBox.Text)
                    return;
                _selectedCustomer.Fullname = FullnameTextBox.Text;
                UpdateCustomerList();
            }
            catch (Exception exception)
            {
                FullnameTextBox.BackColor = Color.LightPink;
            }
            UpdateCustomerList();
        }

        private void PriorityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PriorityCheckBox.Checked)
            {
                _selectedCustomer.IsPriority = true;
            }
            else
            {
                _selectedCustomer.IsPriority = false;
            }
        }

        private void AddDiscountButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex == -1 || _selectedCustomer == null)
            {
                return;
            }
            using (var popup = new AddDiscountForm())
            {
                var result = popup.ShowDialog();
                if (result != DialogResult.OK)
                {
                    return;
                }
                PercentDiscount discount = new PercentDiscount();
                discount.Category = popup.SelectedCategory;
                _selectedCustomer.Discounts.Add(discount);
                UpdateUIInfo();
            }
        }

        private void RemoveDiscount_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex == -1 || _selectedCustomer == null)
            {
                return;
            }
            if (DiscountsListBox.SelectedIndex == 0)
            {
                ToolTip toolTip = new ToolTip();
                toolTip.Show("Накопительную скидку удалить нельзя", this.DiscountsListBox);
                return;
            }
            _selectedCustomer.Discounts.RemoveAt(DiscountsListBox.SelectedIndex);
            UpdateUIInfo();
        }
    }
}
