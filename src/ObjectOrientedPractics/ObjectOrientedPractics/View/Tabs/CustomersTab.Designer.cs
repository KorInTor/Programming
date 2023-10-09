namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            Model.Address address1 = new Model.Address();
            CustmerTableLayoutPanel = new TableLayoutPanel();
            CustomersInfoPanel = new Panel();
            AddressControl = new Controls.AddressControl();
            IdTextBox = new TextBox();
            FullnameTextBox = new TextBox();
            FullNameLabel = new Label();
            IdLabel = new Label();
            SelectedCustomerLabel = new Label();
            CustomersControlPanel = new Panel();
            CustomersListBox = new ListBox();
            CustomersLabel = new Label();
            buttonsTableLayoutPanel = new TableLayoutPanel();
            AddCustomerButton = new Button();
            RemoveCustomerButton = new Button();
            CustmerTableLayoutPanel.SuspendLayout();
            CustomersInfoPanel.SuspendLayout();
            CustomersControlPanel.SuspendLayout();
            buttonsTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // CustmerTableLayoutPanel
            // 
            CustmerTableLayoutPanel.ColumnCount = 2;
            CustmerTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            CustmerTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            CustmerTableLayoutPanel.Controls.Add(CustomersInfoPanel, 1, 0);
            CustmerTableLayoutPanel.Controls.Add(CustomersControlPanel, 0, 0);
            CustmerTableLayoutPanel.Dock = DockStyle.Fill;
            CustmerTableLayoutPanel.Location = new Point(0, 0);
            CustmerTableLayoutPanel.MinimumSize = new Size(500, 0);
            CustmerTableLayoutPanel.Name = "CustmerTableLayoutPanel";
            CustmerTableLayoutPanel.RowCount = 1;
            CustmerTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            CustmerTableLayoutPanel.Size = new Size(879, 382);
            CustmerTableLayoutPanel.TabIndex = 0;
            // 
            // CustomersInfoPanel
            // 
            CustomersInfoPanel.BackColor = SystemColors.Window;
            CustomersInfoPanel.Controls.Add(AddressControl);
            CustomersInfoPanel.Controls.Add(IdTextBox);
            CustomersInfoPanel.Controls.Add(FullnameTextBox);
            CustomersInfoPanel.Controls.Add(FullNameLabel);
            CustomersInfoPanel.Controls.Add(IdLabel);
            CustomersInfoPanel.Controls.Add(SelectedCustomerLabel);
            CustomersInfoPanel.Dock = DockStyle.Fill;
            CustomersInfoPanel.Location = new Point(398, 3);
            CustomersInfoPanel.Name = "CustomersInfoPanel";
            CustomersInfoPanel.Padding = new Padding(3);
            CustomersInfoPanel.Size = new Size(478, 376);
            CustomersInfoPanel.TabIndex = 0;
            // 
            // AddressControl
            // 
            address1.Apartment = "";
            address1.Building = "";
            address1.City = "";
            address1.Country = "";
            address1.Index = 111111;
            address1.Street = "";
            AddressControl.Address = address1;
            AddressControl.Location = new Point(0, 111);
            AddressControl.Name = "AddressControl";
            AddressControl.Size = new Size(474, 150);
            AddressControl.TabIndex = 11;
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(76, 40);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(104, 23);
            IdTextBox.TabIndex = 9;
            // 
            // FullnameTextBox
            // 
            FullnameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FullnameTextBox.Location = new Point(76, 72);
            FullnameTextBox.Name = "FullnameTextBox";
            FullnameTextBox.Size = new Size(396, 23);
            FullnameTextBox.TabIndex = 8;
            FullnameTextBox.TextChanged += FullnameTextBox_TextChanged;
            // 
            // FullNameLabel
            // 
            FullNameLabel.AutoSize = true;
            FullNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FullNameLabel.Location = new Point(0, 72);
            FullNameLabel.Margin = new Padding(3);
            FullNameLabel.Name = "FullNameLabel";
            FullNameLabel.Padding = new Padding(3);
            FullNameLabel.Size = new Size(70, 21);
            FullNameLabel.TabIndex = 5;
            FullNameLabel.Text = "FullName: ";
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            IdLabel.Location = new Point(0, 40);
            IdLabel.Margin = new Padding(3);
            IdLabel.Name = "IdLabel";
            IdLabel.Padding = new Padding(3);
            IdLabel.Size = new Size(30, 21);
            IdLabel.TabIndex = 4;
            IdLabel.Text = "ID: ";
            // 
            // SelectedCustomerLabel
            // 
            SelectedCustomerLabel.AutoSize = true;
            SelectedCustomerLabel.Dock = DockStyle.Top;
            SelectedCustomerLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SelectedCustomerLabel.Location = new Point(3, 3);
            SelectedCustomerLabel.Margin = new Padding(3);
            SelectedCustomerLabel.Name = "SelectedCustomerLabel";
            SelectedCustomerLabel.Padding = new Padding(3);
            SelectedCustomerLabel.Size = new Size(119, 21);
            SelectedCustomerLabel.TabIndex = 3;
            SelectedCustomerLabel.Text = "Selected Customer";
            // 
            // CustomersControlPanel
            // 
            CustomersControlPanel.Controls.Add(CustomersListBox);
            CustomersControlPanel.Controls.Add(CustomersLabel);
            CustomersControlPanel.Controls.Add(buttonsTableLayoutPanel);
            CustomersControlPanel.Dock = DockStyle.Fill;
            CustomersControlPanel.Location = new Point(5, 3);
            CustomersControlPanel.Margin = new Padding(5, 3, 3, 3);
            CustomersControlPanel.MinimumSize = new Size(100, 0);
            CustomersControlPanel.Name = "CustomersControlPanel";
            CustomersControlPanel.Padding = new Padding(3);
            CustomersControlPanel.Size = new Size(387, 376);
            CustomersControlPanel.TabIndex = 1;
            // 
            // CustomersListBox
            // 
            CustomersListBox.Dock = DockStyle.Fill;
            CustomersListBox.FormattingEnabled = true;
            CustomersListBox.IntegralHeight = false;
            CustomersListBox.ItemHeight = 15;
            CustomersListBox.Location = new Point(3, 24);
            CustomersListBox.Name = "CustomersListBox";
            CustomersListBox.Size = new Size(381, 297);
            CustomersListBox.TabIndex = 1;
            CustomersListBox.SelectedIndexChanged += CustomersListBox_SelectedIndexChanged;
            // 
            // CustomersLabel
            // 
            CustomersLabel.AutoSize = true;
            CustomersLabel.Dock = DockStyle.Top;
            CustomersLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CustomersLabel.Location = new Point(3, 3);
            CustomersLabel.Margin = new Padding(3);
            CustomersLabel.Name = "CustomersLabel";
            CustomersLabel.Padding = new Padding(3);
            CustomersLabel.Size = new Size(72, 21);
            CustomersLabel.TabIndex = 2;
            CustomersLabel.Text = "Customers";
            // 
            // buttonsTableLayoutPanel
            // 
            buttonsTableLayoutPanel.ColumnCount = 3;
            buttonsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            buttonsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            buttonsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            buttonsTableLayoutPanel.Controls.Add(AddCustomerButton, 0, 0);
            buttonsTableLayoutPanel.Controls.Add(RemoveCustomerButton, 1, 0);
            buttonsTableLayoutPanel.Dock = DockStyle.Bottom;
            buttonsTableLayoutPanel.Location = new Point(3, 321);
            buttonsTableLayoutPanel.Name = "buttonsTableLayoutPanel";
            buttonsTableLayoutPanel.Padding = new Padding(3);
            buttonsTableLayoutPanel.RowCount = 1;
            buttonsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            buttonsTableLayoutPanel.Size = new Size(381, 52);
            buttonsTableLayoutPanel.TabIndex = 0;
            // 
            // AddCustomerButton
            // 
            AddCustomerButton.Dock = DockStyle.Fill;
            AddCustomerButton.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            AddCustomerButton.Location = new Point(6, 6);
            AddCustomerButton.Name = "AddCustomerButton";
            AddCustomerButton.Padding = new Padding(3);
            AddCustomerButton.Size = new Size(119, 40);
            AddCustomerButton.TabIndex = 1;
            AddCustomerButton.Text = "Add";
            AddCustomerButton.UseVisualStyleBackColor = true;
            AddCustomerButton.Click += AddCustomerButton_Click;
            // 
            // RemoveCustomerButton
            // 
            RemoveCustomerButton.Dock = DockStyle.Fill;
            RemoveCustomerButton.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            RemoveCustomerButton.Location = new Point(131, 6);
            RemoveCustomerButton.Name = "RemoveCustomerButton";
            RemoveCustomerButton.Padding = new Padding(3);
            RemoveCustomerButton.Size = new Size(119, 40);
            RemoveCustomerButton.TabIndex = 0;
            RemoveCustomerButton.Text = "Remove";
            RemoveCustomerButton.UseVisualStyleBackColor = true;
            RemoveCustomerButton.Click += RemoveCustomerButton_Click;
            // 
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CustmerTableLayoutPanel);
            Name = "CustomersTab";
            Size = new Size(879, 382);
            CustmerTableLayoutPanel.ResumeLayout(false);
            CustomersInfoPanel.ResumeLayout(false);
            CustomersInfoPanel.PerformLayout();
            CustomersControlPanel.ResumeLayout(false);
            CustomersControlPanel.PerformLayout();
            buttonsTableLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel CustmerTableLayoutPanel;
        private Panel CustomersInfoPanel;
        private Panel CustomersControlPanel;
        private TableLayoutPanel buttonsTableLayoutPanel;
        private Button AddCustomerButton;
        private Button RemoveCustomerButton;
        private ListBox CustomersListBox;
        private Label CustomersLabel;
        private Label FullNameLabel;
        private Label IdLabel;
        private Label SelectedCustomerLabel;
        private TextBox IdTextBox;
        private TextBox FullnameTextBox;
        private Controls.AddressControl AddressControl;
    }
}
