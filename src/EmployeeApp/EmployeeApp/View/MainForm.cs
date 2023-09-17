using static EmployeeApp.AppColors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Newtonsoft.Json;
using System.IO;
using System.Runtime.InteropServices.ComTypes;
using EmployeeApp.Properties;

namespace EmployeeApp
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// List типа <see cref="Employee"/> содержит список сотрудников.
        /// </summary>
        private List<Employee> _employeeList = EmployeeSerializer.LoadFromFile();

        /// <summary>
        /// Переменная типа <see cref="Employee"/> используется для работы с одним сотруднико
        /// из списка.
        /// </summary>
        private Employee _selectedEmployee = null;

        public MainForm()
        {
            InitializeComponent();

            SortEmployeeList();
        }

        /// <summary>
        /// Сортирует лист <see cref="_employeeList"/> по значениям <see cref="Employee.FullName"/>.
        /// затем в очищенный ListBox добавляет данные значения, и если присвоено значение <see cref="_selectedEmployee"/> то
        /// автоматически делает его выбранным в ListBox, нужное значение индекса получаем при помощи <see cref="FindEmployeeById"/>.
        /// </summary>
        private void SortEmployeeList()
        {
            if (_employeeList == null)
            {
                return;
            }
            EmployeeListBox.Items.Clear();
            _employeeList.Sort((p1, p2) => p1.FullName.CompareTo(p2.FullName));
            foreach (Employee employee in _employeeList)
            {
                EmployeeListBox.Items.Add($"{employee.FullName}");
            }
            TextBoxesReadOnlyTrue();
            if (_selectedEmployee != null)
            {
                EmployeeListBox.SelectedIndex = FindEmployeeById();
                TextBoxesReadOnlyFalse();
            }
        }

        /// <summary>
        /// Если в ListBox выбран предмет то <see cref="_selectedEmployee"/> присваивается значение из <see cref="_employeeList"/>
        /// по выбранному индексу.
        /// Затем все TextBox приравниваются к соответствующим значениям из <see cref="_selectedEmployee"/>.
        /// </summary>
        private void UpdateTextBoxesInfo()
        {
            if (EmployeeListBox.SelectedIndex == -1)
            {
                return;
            }
            _selectedEmployee = _employeeList[EmployeeListBox.SelectedIndex];

            EmployeeFullNameTextBox.Text = _selectedEmployee.FullName;
            EmployeePositionTextBox.Text = _selectedEmployee.Position;
            DateOfEmployeementPicker.Value = _selectedEmployee.DateOfEmployment;
            EmployeeSalaryTextBox.Text = _selectedEmployee.Salary.ToString();
        }

        /// <summary>
        /// Очищает информацию во всех TextBox.
        /// </summary>
        private void TextBoxInfoClear()
        {
            EmployeeFullNameTextBox.Clear();
            EmployeePositionTextBox.Clear();
            EmployeeSalaryTextBox.Clear();

            TextBoxesReadOnlyTrue();
        }

        /// <summary>
        /// Возвращает значение индекса из списка <see cref="_employeeList"/> с совпадающим id с <see cref="_selectedEmployee"/>.
        /// </summary>
        /// <returns>index найденного экземпляра в списке.</returns>
        private int FindEmployeeById()
        {
            int _index = _employeeList.FindIndex(employee => employee.Id == _selectedEmployee.Id);
            return _index;
        }

        /// <summary>
        /// Возвращает значение типа <see cref="Point"/> координат для tooltip для появления под конкретным объектом
        /// (значение задаётся с учётом того что объект находится в <see cref="SelectedEmployeeInfoGroupBox.Location"/>.
        /// </summary>
        /// <param name="elementLocation">Координаты конкретного объекта.</param>
        /// <returns>Координаты для ToolTip</returns>
        private Point GetToolTipLocation(Point elementLocation)
        {
            Point location = new Point(0, SystemInformation.CaptionHeight * 2);
            location.Offset(SelectedEmployeeInfoGroupBox.Location);
            location.Offset(elementLocation);
            return location;
        }

        /// <summary>
        /// Делает Значение всех TextBox только для чтения.
        /// </summary>
        private void TextBoxesReadOnlyTrue()
        {
            EmployeeFullNameTextBox.ReadOnly = true;
            EmployeePositionTextBox.ReadOnly = true;
            EmployeeSalaryTextBox.ReadOnly = true;
            DateOfEmployeementPicker.Enabled = false;

            EmployeeFullNameTextBox.BackColor = this.BackColor;
            EmployeePositionTextBox.BackColor = this.BackColor;
            EmployeeSalaryTextBox.BackColor = this.BackColor;

        }

        /// <summary>
        /// Делает Значение всех TextBox досутп для редактирования пользователю.
        /// </summary>
        private void TextBoxesReadOnlyFalse()
        {
            EmployeeFullNameTextBox.ReadOnly = false;
            EmployeePositionTextBox.ReadOnly = false;
            EmployeeSalaryTextBox.ReadOnly = false;
            DateOfEmployeementPicker.Enabled = true;

            EmployeeFullNameTextBox.BackColor = NormalColor;
            EmployeePositionTextBox.BackColor = NormalColor;
            EmployeeSalaryTextBox.BackColor = NormalColor;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                EmployeeSerializer.SaveToFile(_employeeList);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void EmployeeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTextBoxesInfo();
            TextBoxesReadOnlyTrue();
        }
        private void EmployeeFullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_selectedEmployee == null || EmployeeFullNameTextBox.ReadOnly == true)
            {
                return;
            }
            try
            {
                EmployeeFullNameTextBox.BackColor = NormalColor;
                _selectedEmployee.FullName = EmployeeFullNameTextBox.Text;
                _employeeList[FindEmployeeById()].FullName = _selectedEmployee.FullName;
                SortEmployeeList();
            }
            catch (Exception exception)
            {
                EmployeeFullNameTextBox.BackColor = ErrorColor;
                ToolTip toolTip = new ToolTip();
                toolTip.Show(exception.Message, this, GetToolTipLocation(EmployeeFullNameTextBox.Location), 5000);
            }
        }

        private void EmployeePositionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_selectedEmployee == null || EmployeePositionTextBox.ReadOnly == true)
            {
                return;
            }
            try
            {
                EmployeePositionTextBox.BackColor = NormalColor;
                _selectedEmployee.Position = EmployeePositionTextBox.Text;
                _employeeList[FindEmployeeById()].Position = _selectedEmployee.Position;
                SortEmployeeList();
            }
            catch (Exception exception)
            {
                EmployeePositionTextBox.BackColor = ErrorColor;
                ToolTip toolTip = new ToolTip();
                toolTip.Show(exception.Message, this, GetToolTipLocation(EmployeePositionTextBox.Location), 5000);
            }
        }

        private void DateOfEmployeementPicker_ValueChanged(object sender, EventArgs e)
        {
            if (_selectedEmployee == null)
            {
                return;
            }

            try
            {
                DateOfEmployeementPicker.BackColor = NormalColor;
                _selectedEmployee.DateOfEmployment = DateOfEmployeementPicker.Value;
                _employeeList[FindEmployeeById()].DateOfEmployment = _selectedEmployee.DateOfEmployment;
                SortEmployeeList();
            }
            catch (Exception exception)
            {
                DateOfEmployeementPicker.BackColor = ErrorColor;
                ToolTip toolTip = new ToolTip();
                toolTip.Show(exception.Message, this, GetToolTipLocation(DateOfEmployeementPicker.Location), 5000);
            }
        }

        private void EmployeeSalaryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_selectedEmployee == null || EmployeeSalaryTextBox.ReadOnly == true)
            {
                return;
            }
            try
            {
                EmployeeSalaryTextBox.BackColor = NormalColor;
                _selectedEmployee.Salary = double.Parse(EmployeeSalaryTextBox.Text);
                _employeeList[FindEmployeeById()].Salary = _selectedEmployee.Salary;
                SortEmployeeList();
            }
            catch (FormatException)
            {
                EmployeeSalaryTextBox.BackColor = ErrorColor;
                ToolTip toolTip = new ToolTip();
                toolTip.Show("Зарплата должна быть числом", this, GetToolTipLocation(EmployeeSalaryTextBox.Location), 5000);
            }
            catch (Exception exception)
            {
                EmployeeSalaryTextBox.BackColor = ErrorColor;
                ToolTip toolTip = new ToolTip();
                toolTip.Show(exception.Message, this, GetToolTipLocation(EmployeeSalaryTextBox.Location), 5000);
            }
        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            var blankEmployee = new Employee("Имя", "Должность", DateTime.Today, 100);
            _employeeList.Add(blankEmployee);
            SortEmployeeList();
            TextBoxesReadOnlyTrue();
        }

        private void EmployeeRemoveButton_Click(object sender, EventArgs e)
        {
            if (EmployeeListBox.SelectedIndex == -1)
            {
                return;
            }
            _employeeList.RemoveAt(EmployeeListBox.SelectedIndex);
            _selectedEmployee = null;
            EmployeeListBox.Items.Remove(EmployeeListBox.SelectedIndex);
            TextBoxInfoClear();
            SortEmployeeList();
        }

        private void EmployeeEditButton_Click(object sender, EventArgs e)
        {
            if (EmployeeListBox.SelectedIndex != -1)
            {
                TextBoxesReadOnlyFalse();
            }
        }

        //Код ниже меняет цвета кнопок когда мышь входит в контейнер и выходит
        private void PictureBoxAdd_MouseEnter(object sender, EventArgs e)
        {
            PictureBoxAdd.Image = Resources.employee_add_48x48;
        }

        private void PictureBoxAdd_MouseLeave(object sender, EventArgs e)
        {
            PictureBoxAdd.Image = Resources.employee_add_48x48_uncolor;
        }

        private void PictureBoxEdit_MouseEnter(object sender, EventArgs e)
        {
            PictureBoxEdit.Image = Resources.employee_edit_48x48;
        }

        private void PictureBoxEdit_MouseLeave(object sender, EventArgs e)
        {
            PictureBoxEdit.Image = Resources.employee_edit_48x48_uncolor;
        }

        private void PictureBoxRemove_MouseEnter(object sender, EventArgs e)
        {
            PictureBoxRemove.Image = Resources.employee_remove_48x48;
        }

        private void PictureBoxRemove_MouseLeave(object sender, EventArgs e)
        {
            PictureBoxRemove.Image = Resources.employee_remove_48x48_uncolor;
        }
    }
}
