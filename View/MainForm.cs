using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            EnumListBox.SelectedIndexChanged += EnumListBox_SelectedIndexChanged;
            ValuesListBox.SelectedIndexChanged += ValuesListBox_SelectedIndexChanged;
            FillEnumsAndSeasons();
        }
        private void EnumListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           var select = EnumListBox.SelectedItem;
           var type = (Model) select;
           switch (type)
           {
                case Model.Color:
                    {
                        ValuesListBox.Items.Clear();
                        var colection = Enum.GetValues(typeof(Color));
                        foreach (var thing in colection)
                        {
                            ValuesListBox.Items.Add(thing);
                        }
                        break;
                    }
                case Model.EducationForm:
                    {
                        ValuesListBox.Items.Clear();
                        var colection = Enum.GetValues(typeof(EducationForm));
                        foreach (var thing in colection)
                        {
                            ValuesListBox.Items.Add(thing);
                        }
                        break;
                    }
                case Model.Genre:
                    {
                        ValuesListBox.Items.Clear();
                        var colection = Enum.GetValues(typeof(Genre));
                        foreach (var thing in colection)
                        {
                            ValuesListBox.Items.Add(thing);
                        }
                        break;
                    }
                case Model.Manufactures:
                    {
                        ValuesListBox.Items.Clear();
                        var colection = Enum.GetValues(typeof(Manufactures));
                        foreach (var thing in colection)
                        {
                            ValuesListBox.Items.Add(thing);
                        }
                        break;
                    }
                case Model.Season:
                    {
                        ValuesListBox.Items.Clear();
                        var colection = Enum.GetValues(typeof(Season));
                        foreach (var thing in colection)
                        {
                            ValuesListBox.Items.Add(thing);
                        }
                        break;
                    }
                case Model.Weekday:
                    {
                        ValuesListBox.Items.Clear();
                        var colection = Enum.GetValues(typeof(Weekday));
                        foreach (var thing in colection)
                        {
                            ValuesListBox.Items.Add(thing);
                        }
                        break;
                    }
            }
        }
        private void IntValues_TextChanged(object sender, EventArgs e)
        {

        }
        private void FillEnumsAndSeasons()
        {
            var colection = Enum.GetValues(typeof(Model));
            foreach (var thing in colection)
            {
                EnumListBox.Items.Add(thing);
            }
            EnumListBox.SetSelected(0, true);
            colection = Enum.GetValues(typeof(Season));
            foreach (var thing in colection)
            {
                SeasonCombobox.Items.Add(thing);
            }
        }
        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = (int)ValuesListBox.SelectedItem; 
            IntValues.Text = x.ToString();
        }
        private void ParsingButton_Click(object sender, EventArgs e)
        {
            bool result = Enum.TryParse(ParsingTextBox.Text, out Weekday a);
            if (result == true)
            {
            ParsingResult.Text = $"Это день недели ({Enum.Parse(typeof(Weekday), ParsingTextBox.Text)} = {(int)Enum.Parse(typeof(Weekday), ParsingTextBox.Text)})";
            }
            else
            {
                ParsingResult.Text = "Нет такого дня недели";
            }
        }
        private void SeasonButton_Click(object sender, EventArgs e)
        {
            var select = SeasonCombobox.SelectedItem;
            var type = (Season)select;
            switch (type)
            {
                case Season.Autumn:
                    {
                        MessageBox.Show("Время собирать урожай!");
                        break;
                    }
                case Season.Spring:
                    {
                        MessageBox.Show("Время сажать урожай!");
                        break;
                    }
                case Season.Summer:
                    {
                        Enums.BackColor = ColorTranslator.FromHtml("#00fc2a");
                        break;
                    }
                case Season.Winter:
                    {
                        Enums.BackColor = ColorTranslator.FromHtml("#00b5fc");
                        break;
                    }
            }
        }
        public enum Model
        {
            Color,
            EducationForm,
            Genre,
            Manufactures,
            Season,
            Weekday
        }
    }
}
