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
            FillEnumListBox();
            EnumListBox.SetSelected(0,true);
        }
        private void EnumListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           object select = EnumListBox.SelectedItem.ToString();
           switch (select)
           {
               case Color:
                   {

                   }
           }
        }

        private void IntValues_TextChanged(object sender, EventArgs e)
        {

        }
        private void FillEnumListBox()
        {
            int ind = 0;
            int i = 0;
            string path = @"C:\Users\Danil\source\repos\Programming\Model";
            string[] ENTRIES = Directory.GetFiles(path);
            foreach (string e in ENTRIES)
            {
                ind = ENTRIES[i].Length - 3;
                ENTRIES[i] = ENTRIES[i].Remove(ind);
                ENTRIES[i] = ENTRIES[i].Remove(0, 46);
                i++;
            }
            EnumListBox.Items.AddRange(ENTRIES);
        }
    }
}
