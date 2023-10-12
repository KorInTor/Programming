using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class PercentDiscountsTab : UserControl
    {
        public List<Item> Items { get; set; } = new List<Item>();
        private double _finalAmount;
        private PercentDiscount _discount;

        public PercentDiscountsTab()
        {
            InitializeComponent();
            _discount = new PercentDiscount();
            _discount.Category = Category.Accessory;
        }

        public void RefreshData()
        {
            _finalAmount = 0;
            foreach (Item item in Items)
            {
                _finalAmount += item.Cost;
            }
            FinalAmountLabel.Text = _finalAmount.ToString();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            FinalDiscountAmountLabel.Text = _discount.Calculate(Items).ToString();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            _finalAmount -= _discount.Apply(Items);
            FinalAmountLabel.Text = _finalAmount.ToString();
            PointsInfoLabel.Text = ($"Info: {_discount.Info}");
            FinalDiscountAmountLabel.Text = _discount.Calculate(Items).ToString();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            _discount.Update(Items);
            PointsInfoLabel.Text = ($"Info: {_discount.Info}");
        }
    }
}
