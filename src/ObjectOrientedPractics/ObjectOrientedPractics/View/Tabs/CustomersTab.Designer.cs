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
            tableLayoutPanel1 = new TableLayoutPanel();
            CustomersInfoPanel = new Panel();
            AddressTextBox = new TextBox();
            IdTextBox = new TextBox();
            FullnameTextBox = new TextBox();
            AddressLabel = new Label();
            FullNameLabel = new Label();
            IdLabel = new Label();
            SelectedCustomerLabel = new Label();
            CustomersControlPanel = new Panel();
            CustomersListBox = new ListBox();
            CustomersLabel = new Label();
            buttonsTableLayoutPanel = new TableLayoutPanel();
            AddCustomerButton = new Button();
            RemoveCustomerButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            CustomersInfoPanel.SuspendLayout();
            CustomersControlPanel.SuspendLayout();
            buttonsTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.7524757F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.2475243F));
            tableLayoutPanel1.Controls.Add(CustomersInfoPanel, 1, 0);
            tableLayoutPanel1.Controls.Add(CustomersControlPanel, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.MinimumSize = new Size(500, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(873, 593);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // CustomersInfoPanel
            // 
            CustomersInfoPanel.BackColor = SystemColors.Window;
            CustomersInfoPanel.Controls.Add(AddressTextBox);
            CustomersInfoPanel.Controls.Add(IdTextBox);
            CustomersInfoPanel.Controls.Add(FullnameTextBox);
            CustomersInfoPanel.Controls.Add(AddressLabel);
            CustomersInfoPanel.Controls.Add(FullNameLabel);
            CustomersInfoPanel.Controls.Add(IdLabel);
            CustomersInfoPanel.Controls.Add(SelectedCustomerLabel);
            CustomersInfoPanel.Dock = DockStyle.Fill;
            CustomersInfoPanel.Location = new Point(393, 3);
            CustomersInfoPanel.Name = "CustomersInfoPanel";
            CustomersInfoPanel.Padding = new Padding(3);
            CustomersInfoPanel.Size = new Size(477, 587);
            CustomersInfoPanel.TabIndex = 0;
            // 
            // AddressTextBox
            // 
            AddressTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AddressTextBox.Location = new Point(76, 101);
            AddressTextBox.Multiline = true;
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new Size(395, 170);
            AddressTextBox.TabIndex = 10;
            AddressTextBox.TextChanged += AddressTextBox_TextChanged;
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
            FullnameTextBox.Size = new Size(395, 23);
            FullnameTextBox.TabIndex = 8;
            FullnameTextBox.TextChanged += FullnameTextBox_TextChanged;
            // 
            // AddressLabel
            // 
            AddressLabel.AutoSize = true;
            AddressLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AddressLabel.Location = new Point(0, 99);
            AddressLabel.Margin = new Padding(3);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Padding = new Padding(3);
            AddressLabel.Size = new Size(58, 21);
            AddressLabel.TabIndex = 6;
            AddressLabel.Text = "Address:";
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
            CustomersControlPanel.Size = new Size(382, 587);
            CustomersControlPanel.TabIndex = 1;
            // 
            // CustomersListBox
            // 
            CustomersListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CustomersListBox.FormattingEnabled = true;
            CustomersListBox.IntegralHeight = false;
            CustomersListBox.ItemHeight = 15;
            CustomersListBox.Location = new Point(3, 30);
            CustomersListBox.Name = "CustomersListBox";
            CustomersListBox.Size = new Size(376, 502);
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
            buttonsTableLayoutPanel.Location = new Point(3, 532);
            buttonsTableLayoutPanel.Name = "buttonsTableLayoutPanel";
            buttonsTableLayoutPanel.Padding = new Padding(3);
            buttonsTableLayoutPanel.RowCount = 1;
            buttonsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            buttonsTableLayoutPanel.Size = new Size(376, 52);
            buttonsTableLayoutPanel.TabIndex = 0;
            // 
            // AddCustomerButton
            // 
            AddCustomerButton.Dock = DockStyle.Fill;
            AddCustomerButton.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            AddCustomerButton.Location = new Point(6, 6);
            AddCustomerButton.Name = "AddCustomerButton";
            AddCustomerButton.Padding = new Padding(3);
            AddCustomerButton.Size = new Size(117, 40);
            AddCustomerButton.TabIndex = 1;
            AddCustomerButton.Text = "Add";
            AddCustomerButton.UseVisualStyleBackColor = true;
            AddCustomerButton.Click += AddCustomerButton_Click;
            // 
            // RemoveCustomerButton
            // 
            RemoveCustomerButton.Dock = DockStyle.Fill;
            RemoveCustomerButton.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            RemoveCustomerButton.Location = new Point(129, 6);
            RemoveCustomerButton.Name = "RemoveCustomerButton";
            RemoveCustomerButton.Padding = new Padding(3);
            RemoveCustomerButton.Size = new Size(117, 40);
            RemoveCustomerButton.TabIndex = 0;
            RemoveCustomerButton.Text = "Remove";
            RemoveCustomerButton.UseVisualStyleBackColor = true;
            RemoveCustomerButton.Click += RemoveCustomerButton_Click;
            // 
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "CustomersTab";
            Size = new Size(873, 593);
            tableLayoutPanel1.ResumeLayout(false);
            CustomersInfoPanel.ResumeLayout(false);
            CustomersInfoPanel.PerformLayout();
            CustomersControlPanel.ResumeLayout(false);
            CustomersControlPanel.PerformLayout();
            buttonsTableLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
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
        private TextBox AddressTextBox;
        private TextBox IdTextBox;
        private TextBox FullnameTextBox;
        private Label AddressLabel;
    }
}
