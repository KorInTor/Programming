using Programming.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programming.View;
using static Programming.Model.AppColors;

namespace Programming.View
{
    public partial class SeasonHandleControl : UserControl
    {
        public SeasonHandleControl()
        {
            InitializeComponent();
            foreach (Season season in Enum.GetValues(typeof(Season)))
            {
                SeasonsComboBox.Items.Add(season);
            }
            SeasonsComboBox.SelectedIndex = 0;
        }
        private void SeasonHandlerButton_Click(object sender, EventArgs e)
        {
            Season SelectedSeason = (Season)SeasonsComboBox.SelectedItem;
            switch (SelectedSeason)
            {
                case Season.Winter:
                    {
                        MessageBox.Show("Бррр! Холодно!");
                        break;
                    }
                case Season.Spring:
                    {
                        SeasonHandlerGroupBox.BackColor = SpringColor;
                        break;
                    }
                case Season.Autumn:
                    {
                        SeasonHandlerGroupBox.BackColor = AutumnColor;
                        break;
                    }
                case Season.Summer:
                    {
                        MessageBox.Show("Ура! Солнце!");
                        break;
                    }
            }
        }
    }
}
