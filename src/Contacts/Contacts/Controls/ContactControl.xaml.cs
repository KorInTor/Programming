using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Contacts.Controls
{
    /// <summary>
    /// Логика взаимодействия для ContactControl.xaml
    /// </summary>
    public partial class ContactControl : UserControl
    {
        public ContactControl()
        {
            InitializeComponent();

            // Обработчик события PreviewTextInput
            PhoneNumberTextBox.PreviewTextInput += PhoneNumberTextBox_PreviewTextInput;

            // Обработчик события DataObject.Pasting
            DataObject.AddPastingHandler(PhoneNumberTextBox, PhoneNumberTextBox_Pasting);
        }

        private void PhoneNumberTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // Проверка вводимых символов
            if (!IsTextAllowed(e.Text)) e.Handled = true;
        }

        private void PhoneNumberTextBox_Pasting(object sender, DataObjectPastingEventArgs e)
        {
            // Проверка вставляемых из буфера обмена данных
            if (e.DataObject.GetDataPresent(typeof(String)))
            {
                String text = (String)e.DataObject.GetData(typeof(String));
                if (!IsTextAllowed(text)) e.CancelCommand();
            }
            else
            {
                e.CancelCommand();
            }
        }

        private bool IsTextAllowed(string text)
        {
            return Array.TrueForAll<Char>(text.ToCharArray(), delegate (Char c) { return Char.IsDigit(c) || Char.IsControl(c) || c.Equals("+") || c.Equals("(") || c.Equals(")") || c.Equals(" "); });
        }
    }
}
