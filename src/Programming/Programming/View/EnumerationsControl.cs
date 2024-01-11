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
    public partial class EnumerationsControl : UserControl
    {
        public EnumerationsControl()
        {
            InitializeComponent();
            EnumsListBox.SelectedIndex = 0;
        }
        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValuesListBox.Items.Clear();
            var item = EnumsListBox.SelectedItem;
            Array enumValues = null;
            switch (item)
            {
                case "Colors":
                    enumValues = Enum.GetValues(typeof(Colors));
                    break;
                case "Genre":
                    enumValues = Enum.GetValues(typeof(Genre));
                    break;
                case "Manufactures":
                    enumValues = Enum.GetValues(typeof(Manufactures));
                    break;
                case "FormOfStudy":
                    enumValues = Enum.GetValues(typeof(FormOfStudy));
                    break;
                case "Season":
                    enumValues = Enum.GetValues(typeof(Season));
                    break;
                case "Weekday":
                    enumValues = Enum.GetValues(typeof(Weekday));
                    break;
                case "Months":
                    enumValues = Enum.GetValues(typeof(Months));
                    break;
            }
            foreach (var value in enumValues)
            {
                ValuesListBox.Items.Add(value);
            }
        }
        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IntValueTextBox.Text = ((int)ValuesListBox.SelectedItem).ToString();
        }
    }
}
