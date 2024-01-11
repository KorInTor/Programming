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

namespace Programming.View
{
    public partial class WeekdayParsingControl : UserControl
    {
        public WeekdayParsingControl()
        {
            InitializeComponent();
        }
        private void WeekdayParsingButton_Click(object sender, EventArgs e)
        {
            Weekday weekdayvalue;
            if (Enum.TryParse<Weekday>(WeekdayParsingTextBox.Text, out weekdayvalue))
            {
                ParsingResultLabel.Text = string.Format($"Это день недели ({weekdayvalue.ToString()} = {((int)weekdayvalue).ToString()})");
            }
            else
            {
                ParsingResultLabel.Text = "Нет такого дня недели";
            }
        }
    }
}
