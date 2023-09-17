namespace EmployeeApp
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.EmployeeListBox = new System.Windows.Forms.ListBox();
            this.SelectedEmployeeInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.EmployeeSalaryTextBox = new System.Windows.Forms.TextBox();
            this.DateOfEmployeementPicker = new System.Windows.Forms.DateTimePicker();
            this.DateOfEmployementLabel = new System.Windows.Forms.Label();
            this.EmployeePositionTextBox = new System.Windows.Forms.TextBox();
            this.SalaryLabel = new System.Windows.Forms.Label();
            this.PositionLabel = new System.Windows.Forms.Label();
            this.EmployeeFullNameTextBox = new System.Windows.Forms.TextBox();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.PictureBoxAdd = new System.Windows.Forms.PictureBox();
            this.PictureBoxRemove = new System.Windows.Forms.PictureBox();
            this.PictureBoxEdit = new System.Windows.Forms.PictureBox();
            this.SelectedEmployeeInfoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeeListBox
            // 
            this.EmployeeListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.EmployeeListBox.FormattingEnabled = true;
            this.EmployeeListBox.IntegralHeight = false;
            this.EmployeeListBox.Location = new System.Drawing.Point(12, 12);
            this.EmployeeListBox.Name = "EmployeeListBox";
            this.EmployeeListBox.Size = new System.Drawing.Size(300, 433);
            this.EmployeeListBox.TabIndex = 0;
            this.EmployeeListBox.SelectedIndexChanged += new System.EventHandler(this.EmployeeListBox_SelectedIndexChanged);
            // 
            // SelectedEmployeeInfoGroupBox
            // 
            this.SelectedEmployeeInfoGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedEmployeeInfoGroupBox.Controls.Add(this.EmployeeSalaryTextBox);
            this.SelectedEmployeeInfoGroupBox.Controls.Add(this.DateOfEmployeementPicker);
            this.SelectedEmployeeInfoGroupBox.Controls.Add(this.DateOfEmployementLabel);
            this.SelectedEmployeeInfoGroupBox.Controls.Add(this.EmployeePositionTextBox);
            this.SelectedEmployeeInfoGroupBox.Controls.Add(this.SalaryLabel);
            this.SelectedEmployeeInfoGroupBox.Controls.Add(this.PositionLabel);
            this.SelectedEmployeeInfoGroupBox.Controls.Add(this.EmployeeFullNameTextBox);
            this.SelectedEmployeeInfoGroupBox.Controls.Add(this.FullNameLabel);
            this.SelectedEmployeeInfoGroupBox.Location = new System.Drawing.Point(318, 12);
            this.SelectedEmployeeInfoGroupBox.Name = "SelectedEmployeeInfoGroupBox";
            this.SelectedEmployeeInfoGroupBox.Size = new System.Drawing.Size(572, 138);
            this.SelectedEmployeeInfoGroupBox.TabIndex = 1;
            this.SelectedEmployeeInfoGroupBox.TabStop = false;
            this.SelectedEmployeeInfoGroupBox.Text = "Selected Employee";
            // 
            // EmployeeSalaryTextBox
            // 
            this.EmployeeSalaryTextBox.Location = new System.Drawing.Point(133, 109);
            this.EmployeeSalaryTextBox.Name = "EmployeeSalaryTextBox";
            this.EmployeeSalaryTextBox.ReadOnly = true;
            this.EmployeeSalaryTextBox.Size = new System.Drawing.Size(55, 20);
            this.EmployeeSalaryTextBox.TabIndex = 7;
            this.EmployeeSalaryTextBox.TextChanged += new System.EventHandler(this.EmployeeSalaryTextBox_TextChanged);
            // 
            // DateOfEmployeementPicker
            // 
            this.DateOfEmployeementPicker.Location = new System.Drawing.Point(133, 83);
            this.DateOfEmployeementPicker.Name = "DateOfEmployeementPicker";
            this.DateOfEmployeementPicker.Size = new System.Drawing.Size(147, 20);
            this.DateOfEmployeementPicker.TabIndex = 7;
            this.DateOfEmployeementPicker.ValueChanged += new System.EventHandler(this.DateOfEmployeementPicker_ValueChanged);
            // 
            // DateOfEmployementLabel
            // 
            this.DateOfEmployementLabel.AutoSize = true;
            this.DateOfEmployementLabel.Location = new System.Drawing.Point(12, 86);
            this.DateOfEmployementLabel.Name = "DateOfEmployementLabel";
            this.DateOfEmployementLabel.Size = new System.Drawing.Size(111, 13);
            this.DateOfEmployementLabel.TabIndex = 6;
            this.DateOfEmployementLabel.Text = "Date of Employement:";
            this.DateOfEmployementLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EmployeePositionTextBox
            // 
            this.EmployeePositionTextBox.Location = new System.Drawing.Point(133, 57);
            this.EmployeePositionTextBox.Name = "EmployeePositionTextBox";
            this.EmployeePositionTextBox.ReadOnly = true;
            this.EmployeePositionTextBox.Size = new System.Drawing.Size(147, 20);
            this.EmployeePositionTextBox.TabIndex = 5;
            this.EmployeePositionTextBox.TextChanged += new System.EventHandler(this.EmployeePositionTextBox_TextChanged);
            // 
            // SalaryLabel
            // 
            this.SalaryLabel.AutoSize = true;
            this.SalaryLabel.Location = new System.Drawing.Point(84, 112);
            this.SalaryLabel.Name = "SalaryLabel";
            this.SalaryLabel.Size = new System.Drawing.Size(39, 13);
            this.SalaryLabel.TabIndex = 3;
            this.SalaryLabel.Text = "Salary:";
            this.SalaryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PositionLabel
            // 
            this.PositionLabel.AutoSize = true;
            this.PositionLabel.Location = new System.Drawing.Point(76, 60);
            this.PositionLabel.Name = "PositionLabel";
            this.PositionLabel.Size = new System.Drawing.Size(47, 13);
            this.PositionLabel.TabIndex = 4;
            this.PositionLabel.Text = "Position:";
            this.PositionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EmployeeFullNameTextBox
            // 
            this.EmployeeFullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeeFullNameTextBox.Location = new System.Drawing.Point(133, 31);
            this.EmployeeFullNameTextBox.Name = "EmployeeFullNameTextBox";
            this.EmployeeFullNameTextBox.ReadOnly = true;
            this.EmployeeFullNameTextBox.Size = new System.Drawing.Size(433, 20);
            this.EmployeeFullNameTextBox.TabIndex = 3;
            this.EmployeeFullNameTextBox.TextChanged += new System.EventHandler(this.EmployeeFullNameTextBox_TextChanged);
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Location = new System.Drawing.Point(69, 34);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(54, 13);
            this.FullNameLabel.TabIndex = 2;
            this.FullNameLabel.Text = "FullName:";
            this.FullNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PictureBoxAdd
            // 
            this.PictureBoxAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PictureBoxAdd.Image = global::EmployeeApp.Properties.Resources.employee_add_48x48_uncolor;
            this.PictureBoxAdd.Location = new System.Drawing.Point(12, 451);
            this.PictureBoxAdd.Name = "PictureBoxAdd";
            this.PictureBoxAdd.Size = new System.Drawing.Size(73, 50);
            this.PictureBoxAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureBoxAdd.TabIndex = 7;
            this.PictureBoxAdd.TabStop = false;
            this.PictureBoxAdd.Click += new System.EventHandler(this.AddEmployeeButton_Click);
            this.PictureBoxAdd.MouseEnter += new System.EventHandler(this.PictureBoxAdd_MouseEnter);
            this.PictureBoxAdd.MouseLeave += new System.EventHandler(this.PictureBoxAdd_MouseLeave);
            // 
            // PictureBoxRemove
            // 
            this.PictureBoxRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PictureBoxRemove.Image = global::EmployeeApp.Properties.Resources.employee_remove_48x48_uncolor;
            this.PictureBoxRemove.Location = new System.Drawing.Point(170, 451);
            this.PictureBoxRemove.Name = "PictureBoxRemove";
            this.PictureBoxRemove.Size = new System.Drawing.Size(73, 50);
            this.PictureBoxRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureBoxRemove.TabIndex = 8;
            this.PictureBoxRemove.TabStop = false;
            this.PictureBoxRemove.Click += new System.EventHandler(this.EmployeeRemoveButton_Click);
            this.PictureBoxRemove.MouseEnter += new System.EventHandler(this.PictureBoxRemove_MouseEnter);
            this.PictureBoxRemove.MouseLeave += new System.EventHandler(this.PictureBoxRemove_MouseLeave);
            // 
            // PictureBoxEdit
            // 
            this.PictureBoxEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PictureBoxEdit.Image = global::EmployeeApp.Properties.Resources.employee_edit_48x48_uncolor;
            this.PictureBoxEdit.Location = new System.Drawing.Point(91, 451);
            this.PictureBoxEdit.Name = "PictureBoxEdit";
            this.PictureBoxEdit.Size = new System.Drawing.Size(73, 50);
            this.PictureBoxEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureBoxEdit.TabIndex = 9;
            this.PictureBoxEdit.TabStop = false;
            this.PictureBoxEdit.Click += new System.EventHandler(this.EmployeeEditButton_Click);
            this.PictureBoxEdit.MouseEnter += new System.EventHandler(this.PictureBoxEdit_MouseEnter);
            this.PictureBoxEdit.MouseLeave += new System.EventHandler(this.PictureBoxEdit_MouseLeave);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 513);
            this.Controls.Add(this.PictureBoxEdit);
            this.Controls.Add(this.PictureBoxRemove);
            this.Controls.Add(this.PictureBoxAdd);
            this.Controls.Add(this.SelectedEmployeeInfoGroupBox);
            this.Controls.Add(this.EmployeeListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "EmployeeApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.SelectedEmployeeInfoGroupBox.ResumeLayout(false);
            this.SelectedEmployeeInfoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox EmployeeListBox;
        private System.Windows.Forms.GroupBox SelectedEmployeeInfoGroupBox;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.TextBox EmployeeFullNameTextBox;
        private System.Windows.Forms.Label SalaryLabel;
        private System.Windows.Forms.TextBox EmployeePositionTextBox;
        private System.Windows.Forms.Label PositionLabel;
        private System.Windows.Forms.DateTimePicker DateOfEmployeementPicker;
        private System.Windows.Forms.Label DateOfEmployementLabel;
        private System.Windows.Forms.TextBox EmployeeSalaryTextBox;
        private System.Windows.Forms.PictureBox PictureBoxAdd;
        private System.Windows.Forms.PictureBox PictureBoxRemove;
        private System.Windows.Forms.PictureBox PictureBoxEdit;
    }
}

