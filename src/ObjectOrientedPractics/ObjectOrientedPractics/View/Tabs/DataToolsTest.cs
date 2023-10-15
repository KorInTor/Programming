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
using ObjectOrientedPractics.Service;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class DataToolsTest : UserControl
    {

        public List<Item> Items { get; set; } = new List<Item>();

        private List<Item> _displayedItems = new List<Item>();
        public DataToolsTest()
        {
            InitializeComponent();
        }

        public void RefreshData(List<Item> items)
        {
            Items = items;
            foreach (Item item in Items)
            {
                ItemsListBox.Items.Add($"{item.Name}, cost:{item.Cost},category:{item.Category}");
            }
        }

        private void UpdateListBox()
        {
            ItemsListBox.Items.Clear();
            foreach (Item item in _displayedItems)
            {
                ItemsListBox.Items.Add($"{item.Name}, cost:{item.Cost},category:{item.Category}");
            }
        }

        private void CategoryFilterButton_Click(object sender, EventArgs e)
        {
            _displayedItems = DataTools.FilterItems(Items, DataTools.IsCategoryTrim);
            UpdateListBox();
        }

        private void PriceFilterButton_Click(object sender, EventArgs e)
        {
            _displayedItems = DataTools.FilterItems(Items, DataTools.IsPriceBig);
            UpdateListBox();
        }
    }
}
