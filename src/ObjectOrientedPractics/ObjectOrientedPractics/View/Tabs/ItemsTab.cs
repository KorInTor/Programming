﻿using System;
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
        }

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
        }


        private int FindItemById()
        {
            int _index = _items.FindIndex(employee => employee.Id == _selectedItem.Id);
            return _index;
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            var blankItem = new Item("Наименование", "Описание", 1);
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
    }
}
