using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Tabs.Controls;

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
                SortCustomersList();
            }
        }

        /// <summary>
        /// Сортировка списка <see cref="_customers"/> по свойству <see cref="Customer.Fullname"/>.
        /// </summary>
        private void SortCustomersList()
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
        /// Обновление информации в TextBox'ax взятая из <see cref="_selectedCustomer"/>.
        /// </summary>
        private void UpdateTextBoxesInfo()
        {
            if (CustomersListBox.SelectedIndex == -1)
            {
                return;
            }
            _selectedCustomer = _customers[CustomersListBox.SelectedIndex];

            AddressControl.Address = _selectedCustomer.Address;
            FullnameTextBox.Text = _selectedCustomer.Fullname;
            IdTextBox.Text = _selectedCustomer.Id.ToString();
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
            SortCustomersList();
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
            _selectedCustomer = null;
            SortCustomersList();
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTextBoxesInfo();
        }

        private void FullnameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_selectedCustomer == null)
            {
                return;
            }
            try
            {
                FullnameTextBox.BackColor = Color.White;
                _selectedCustomer.Fullname = FullnameTextBox.Text;
                _customers[FindCustomerById()].Fullname = _selectedCustomer.Fullname;
            }
            catch (Exception exception)
            {
                FullnameTextBox.BackColor = Color.LightPink;
            }
            SortCustomersList();
        }
    }
}
