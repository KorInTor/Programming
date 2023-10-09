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

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        
        List<Item> _items = new();

        private Item _selectedItem = null;

        public ItemsTab()
        {
            InitializeComponent();
            InitCategoryComboBox();
        }

        /// <summary>
        /// Возраващет и задаёт список товаров.После получения списка, соритрует <see cref="ItemsListBox"/>.
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
                SortItemsList();
            }
        }

        /// <summary>
        /// Сортировка списка <see cref="_items"/> по свойству <see cref="Item.Name"/>.
        /// </summary>
        private void SortItemsList()
        {
            if (_items == null)
            {
                ItemsListBox.Items.Clear();
                return;
            }
            ItemsListBox.Items.Clear();
            _items.Sort((p1, p2) => p1.Name.CompareTo(p2.Name));
            foreach (Item item in _items)
            {
                ItemsListBox.Items.Add($"{item.Name}");
            }
            if (_selectedItem != null)
            {
                ItemsListBox.SelectedIndex = FindItemById();
            }
        }

        /// <summary>
        /// Обновление информации в Полях информации взятая из <see cref="_selectedItem"/>.
        /// </summary>
        private void UpdateTextBoxesInfo()
        {
            if (ItemsListBox.SelectedIndex == -1)
            {
                return;
            }
            _selectedItem = _items[ItemsListBox.SelectedIndex];

            NameTextBox.Text = _selectedItem.Name;
            CostTextBox.Text = _selectedItem.Cost.ToString();
            DescriptionTextBox.Text = _selectedItem.Info;
            IdTextBox.Text = _selectedItem.Id.ToString();
            CategoryComboBox.SelectedItem = _selectedItem.Category;
        }

        /// <summary>
        /// Поиск индекса предмета в списке <see cref="_items"/> с Id совпадающим c <see cref="_selectedItem"/>.
        /// </summary>
        /// <returns>Индекс элемента с совпадающим Id.</returns>
        private int FindItemById()
        {
            int _index = _items.FindIndex(item => item.Id == _selectedItem.Id);
            return _index;
        }

        /// <summary>
        /// Заполнение CategoryComboBox значениями из <see cref="Category"/>
        /// </summary>
        private void InitCategoryComboBox()
        {
            foreach (var season in Enum.GetValues(typeof(Category)))
            {
                CategoryComboBox.Items.Add(season);
            }
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            var blankItem = new Item("Наименование", "Описание", 1, Category.Accessory);
            _items.Add(blankItem);
            SortItemsList();
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (_selectedItem == null)
            {
                return;
            }
            IdTextBox.Clear();
            CostTextBox.Clear();
            DescriptionTextBox.Clear();
            NameTextBox.Clear();
            CategoryComboBox.SelectedItem = null;
            _items.RemoveAt(ItemsListBox.SelectedIndex);
            _selectedItem = null;
            SortItemsList();
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTextBoxesInfo();
        }

        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_selectedItem == null)
            {
                return;
            }
            try
            {
                CostTextBox.BackColor = Color.White;
                _selectedItem.Cost = double.Parse(CostTextBox.Text);
                _items[FindItemById()].Cost = _selectedItem.Cost;
            }
            catch (Exception exception)
            {
                CostTextBox.BackColor = Color.LightPink;
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_selectedItem == null)
            {
                return;
            }
            try
            {
                NameTextBox.BackColor = Color.White;
                _selectedItem.Name = NameTextBox.Text;
                _items[FindItemById()].Name = _selectedItem.Name;
                SortItemsList();
            }
            catch (Exception exception)
            {
                NameTextBox.BackColor = Color.LightPink;
            }
        }

        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_selectedItem == null)
            {
                return;
            }
            try
            {
                DescriptionTextBox.BackColor = Color.White;
                _selectedItem.Info = DescriptionTextBox.Text;
                _items[FindItemById()].Info = _selectedItem.Info;
            }
            catch (Exception exception)
            {
                DescriptionTextBox.BackColor = Color.LightPink;
            }
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_selectedItem == null)
            {
                return;
            }
            _selectedItem.Category = (Category)CategoryComboBox.SelectedItem;
            _items[FindItemById()].Category = _selectedItem.Category;
        }
    }
}
