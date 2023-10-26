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
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Service;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        public event EventHandler<EventArgs> ItemsChanged;

        List<Item> _items = new();

        List<Item> _displayedItems = new();

        private Item _selectedItem = null;

        public ItemsTab()
        {
            InitializeComponent();
            InitCategoryComboBox();
            OrderByComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Возраващет и задаёт список товаров.
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
                _displayedItems = new List<Item>(_items);
                DisplayItems();
            }
        }

        /// <summary>
        /// Отображение и сортировка списка <see cref="_displayedItems"/>.
        /// </summary>
        private void DisplayItems()
        {
            _displayedItems = new List<Item>(_items);
            if (_displayedItems == null)
            {
                ItemsListBox.Items.Clear();
                return;
            }
            ItemsListBox.Items.Clear();
            switch (OrderByComboBox.SelectedIndex)
            {
                case 0:
                    _displayedItems = DataTools.SortItems(_displayedItems, DataTools.SortByNameDesc);
                    break;
                case 1:
                    _displayedItems = DataTools.SortItems(_displayedItems, DataTools.SortByNameAsc);
                    break;
                case 2:
                    _displayedItems = DataTools.SortItems(_displayedItems, DataTools.SortByCostDesc);
                    break;
                case 3:
                    _displayedItems = DataTools.SortItems(_displayedItems, DataTools.SortByCostAsc);
                    break;
            }
            if (FindTextBox.Text != "")
            {
                _displayedItems = DataTools.FilterItems(_displayedItems, (item) => { return item.Name.ToLower().Contains(FindTextBox.Text.ToLower()); });
            }
            foreach (Item item in _displayedItems)
            {
                ItemsListBox.Items.Add($"name: {item.Name}, cost: {item.Cost}");
            }
            if (_selectedItem != null)
            {
                ItemsListBox.SelectedIndex = FindItemById(_displayedItems, _selectedItem);
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

            NameTextBox.Text = _selectedItem.Name;
            CostTextBox.Text = _selectedItem.Cost.ToString();
            DescriptionTextBox.Text = _selectedItem.Info;
            IdTextBox.Text = _selectedItem.Id.ToString();
            CategoryComboBox.SelectedIndex = ((int)_selectedItem.Category - 1);
        }

        /// <summary>
        /// Возвращает индекс элемента в списке товаров с совпадающим полем искомого товара Id.
        /// </summary>
        /// <param name="listItems">Список товаров.</param>
        /// <param name="item">Товар который нужно найти в списке.</param>
        /// <returns>Индекс.</returns>
        private int FindItemById(List<Item> listItems, Item item)
        {
            int _index = listItems.FindIndex(listItems => listItems.Id == item.Id);
            return _index;
        }

        /// <summary>
        /// Заполнение CategoryComboBox значениями из <see cref="Category"/>
        /// </summary>
        private void InitCategoryComboBox()
        {
            foreach (var category in Enum.GetValues(typeof(Category)))
            {
                CategoryComboBox.Items.Add(category);
            }
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            var blankItem = new Item("Наименование", "Описание", 1, Category.Accessory);
            _items.Add(blankItem);
            DisplayItems();
            
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (_selectedItem == null)
            {
                return;
            }
            _items.RemoveAt(FindItemById(_items, _selectedItem));
            _selectedItem = null;
            IdTextBox.Clear();
            CostTextBox.Clear();
            DescriptionTextBox.Clear();
            NameTextBox.Clear();
            CategoryComboBox.SelectedItem = null;
            DisplayItems();
            ItemsChanged?.Invoke(this, EventArgs.Empty);
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedItem = _items[FindItemById(_items, _displayedItems[ItemsListBox.SelectedIndex])];
            UpdateTextBoxesInfo();
        }

        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_selectedItem == null)
            {
                CostTextBox.BackColor = Color.White;
                return;
            }
            try
            {
                CostTextBox.BackColor = Color.White;
                if (_selectedItem.Cost == double.Parse(CostTextBox.Text))
                    return;
                _selectedItem.Cost = double.Parse(CostTextBox.Text);
                DisplayItems();
                ItemsChanged?.Invoke(this, EventArgs.Empty);
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
                NameTextBox.BackColor = Color.White;
                return;
            }
            try
            {
                NameTextBox.BackColor = Color.White;
                if (_selectedItem.Name == NameTextBox.Text)
                    return;
                _selectedItem.Name = NameTextBox.Text;
                DisplayItems();
                ItemsChanged?.Invoke(this, EventArgs.Empty);
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
                DescriptionTextBox.BackColor = Color.White;
                return;
            }
            try
            {
                DescriptionTextBox.BackColor = Color.White;
                _selectedItem.Info = DescriptionTextBox.Text;
                ItemsChanged?.Invoke(this, EventArgs.Empty);
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
            if (_selectedItem.Category == (Category)CategoryComboBox.SelectedItem)
                return;
            _selectedItem.Category = (Category)CategoryComboBox.SelectedItem;
            DisplayItems();
            ItemsChanged?.Invoke(this, EventArgs.Empty);
        }

        private void FindTextBox_TextChanged(object sender, EventArgs e)
        {
            DisplayItems();
        }

        private void OrderByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayItems();
        }
    }
}
