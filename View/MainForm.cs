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
            FillEnumListBox();
        }
        private void EnumListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           var select = EnumListBox.SelectedItem;
           var type = (Model) select;
           IntValues.Text = select.ToString();
           switch (type)
           {
                case Model.Color:
                    {
                        ValuesListBox.Items.Clear();
                        var colection = Enum.GetValues(typeof(Color));
                        foreach (var thing in colection)
                        {
                            ValuesListBox.Items.Add(thing.ToString());
                        }
                        break;
                    }
                case Model.EducationForm:
                    {
                        ValuesListBox.Items.Clear();
                        var colection = Enum.GetValues(typeof(EducationForm));
                        foreach (var thing in colection)
                        {
                            ValuesListBox.Items.Add(thing.ToString());
                        }
                        break;
                    }
                case Model.Genre:
                    {
                        ValuesListBox.Items.Clear();
                        var colection = Enum.GetValues(typeof(Genre));
                        foreach (var thing in colection)
                        {
                            ValuesListBox.Items.Add(thing.ToString());
                        }
                        break;
                    }
                case Model.Manufactures:
                    {
                        ValuesListBox.Items.Clear();
                        var colection = Enum.GetValues(typeof(Manufactures));
                        foreach (var thing in colection)
                        {
                            ValuesListBox.Items.Add(thing.ToString());
                        }
                        break;
                    }
                case Model.Season:
                    {
                        ValuesListBox.Items.Clear();
                        var colection = Enum.GetValues(typeof(Season));
                        foreach (var thing in colection)
                        {
                            ValuesListBox.Items.Add(thing.ToString());
                        }
                        break;
                    }
                case Model.Weekday:
                    {
                        ValuesListBox.Items.Clear();
                        var colection = Enum.GetValues(typeof(Weekday));
                        foreach (var thing in colection)
                        {
                            ValuesListBox.Items.Add(thing.ToString());
                        }
                        break;
                    }
            }
        }

        private void IntValues_TextChanged(object sender, EventArgs e)
        {

        }
        private void FillEnumListBox()
        {
            EnumListBox.Items.Add(Model.Color);
            EnumListBox.Items.Add(Model.EducationForm);
            EnumListBox.Items.Add(Model.Genre);
            EnumListBox.Items.Add(Model.Manufactures);
            EnumListBox.Items.Add(Model.Season);
            EnumListBox.Items.Add(Model.Weekday);
            EnumListBox.SetSelected(0, true);
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
