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
using ObjectOrientedPractics.Model.Discounts;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class DiscountsTab : UserControl
    {
        public List<Item> Items { get; set; } = new List<Item>();
        private double _finalAmount;
        private PointsDiscount _points;
        public DiscountsTab()
        {
            InitializeComponent();
            _points = new PointsDiscount();
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
            FinalDiscountAmountLabel.Text = _points.Calculate(Items).ToString();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            _finalAmount -= _points.Apply(Items);
            FinalAmountLabel.Text = _finalAmount.ToString();
            PointsInfoLabel.Text = ($"Info: {_points.Info}");
            FinalDiscountAmountLabel.Text = _points.Calculate(Items).ToString();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            _points.Update(Items);
            PointsInfoLabel.Text = ($"Info: {_points.Info}");
        }
    }
}
