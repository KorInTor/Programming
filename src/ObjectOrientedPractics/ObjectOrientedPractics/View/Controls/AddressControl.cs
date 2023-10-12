using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Tabs.Controls
{
    public partial class AddressControl : UserControl
    {
        /// <summary>
        /// Закрытое поле данного класса, типа <see cref="Model.Address"/>, хранит адрес.
        /// </summary>
        private Address _address;

        public AddressControl()
        {
            _address = new Address();
            InitializeComponent();
        }

        /// <summary>
        /// Возвращает и задаёт значения адреса в <see cref="AddressControl"/>.
        /// </summary>
        public Address Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
                UpdateTextBoxInfo(_address);
            }
        }

        /// <summary>
        /// Обновляет содержимое TextBox элементов на данные из принимаемого адреса.
        /// </summary>
        /// <param name="address">Принимаемый адрес.</param>
        private void UpdateTextBoxInfo(Address address)
        {
            IndexTextBox.Text = address.Index.ToString();
            CountryTextBox.Text = address.Country;
            CityTextBox.Text = address.City;
            StreetTextBox.Text = address.Street;
            BuildingTextBox.Text = address.Building;
            ApartmentTextBox.Text = address.Apartment;
        }

        private void IndexTextBox_TextChanged(object sender, EventArgs e)
        {
            IndexTextBox.BackColor = Color.White;
            try
            {
                _address.Index = int.Parse(IndexTextBox.Text);
            }
            catch (Exception exception)
            {
                IndexTextBox.BackColor = Color.LightPink;
                ToolTip toolTip = new ToolTip();
                toolTip.Show(exception.Message, this.IndexTextBox);

            }
        }

        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            CountryTextBox.BackColor = Color.White;
            try
            {
                _address.Country = CountryTextBox.Text;
            }
            catch (Exception exception)
            {
                CountryTextBox.BackColor = Color.LightPink;
                ToolTip toolTip = new ToolTip();
                toolTip.Show(exception.Message, this.CountryTextBox);

            }
        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            CityTextBox.BackColor = Color.White;
            try
            {
                _address.City = CityTextBox.Text;
            }
            catch (Exception exception)
            {
                CityTextBox.BackColor = Color.LightPink;
                ToolTip toolTip = new ToolTip();
                toolTip.Show(exception.Message, this.CityTextBox);
            }
        }

        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            StreetTextBox.BackColor = Color.White;
            try
            {
                _address.Street = StreetTextBox.Text;
            }
            catch (Exception exception)
            {
                StreetTextBox.BackColor = Color.LightPink;
                ToolTip toolTip = new ToolTip();
                toolTip.Show(exception.Message, this.StreetTextBox);
            }
        }

        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            BuildingTextBox.BackColor = Color.White;
            try
            {
                _address.Building = BuildingTextBox.Text;
            }
            catch (Exception exception)
            {
                BuildingTextBox.BackColor = Color.LightPink;
                ToolTip toolTip = new ToolTip();
                toolTip.Show(exception.Message, this.BuildingTextBox);
            }
        }

        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            ApartmentTextBox.BackColor = Color.White;
            try
            {
                _address.Apartment = ApartmentTextBox.Text;
            }
            catch (Exception exception)
            {
                ApartmentTextBox.BackColor = Color.LightPink;
                ToolTip toolTip = new ToolTip();
                toolTip.Show(exception.Message, this.ApartmentTextBox);
            }
        }

        public void Clear()
        {
            IndexTextBox.Text = "111111";
            CountryTextBox.Text = "";
            CityTextBox.Text = "";
            StreetTextBox.Text = "";
            BuildingTextBox.Text = "";
            ApartmentTextBox.Text = "";

            IndexTextBox.BackColor = Color.White;
            CountryTextBox.BackColor = Color.White;
            CityTextBox.BackColor = Color.White;
            StreetTextBox.BackColor = Color.White;
            BuildingTextBox.BackColor = Color.White;
            ApartmentTextBox.BackColor = Color.White;
        }
    }
}
