using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.View.Forms
{
    public partial class AddDiscountForm : Form
    {
        public Category SelectedCategory { get; set; }
        public AddDiscountForm()
        {
            InitializeComponent();
            InitCategoryComboBox();
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

        private void ConfirmButton_Click_1(object sender, EventArgs e)
        {
            this.SelectedCategory = (Category)CategoryComboBox.SelectedItem; // значение из ComboBox
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
