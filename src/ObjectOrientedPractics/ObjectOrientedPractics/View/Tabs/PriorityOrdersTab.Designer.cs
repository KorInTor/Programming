namespace ObjectOrientedPractics.View.Tabs
{
    partial class PriorityOrdersTab
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
            OrderInfoPanel = new Panel();
            AddItemButton = new Button();
            RemoveItemButton = new Button();
            ClearOrderButton = new Button();
            DesiredTimeComboBox = new ComboBox();
            DesiredTimeLabel = new Label();
            PriorityOptionsLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            OrderItemsListBox = new ListBox();
            FinalAmountLabel = new Label();
            AmountLabel = new Label();
            AddressControl = new Controls.AddressControl();
            StatusComboBox = new ComboBox();
            StatusLabel = new Label();
            IdTextBox = new TextBox();
            CreationDateTextBox = new TextBox();
            OrderItemsLabel = new Label();
            CreatedLabel = new Label();
            IdLabel = new Label();
            SelectedOrderLabel = new Label();
            OrderInfoPanel.SuspendLayout();
            SuspendLayout();
            // 
            // OrderInfoPanel
            // 
            OrderInfoPanel.BackColor = SystemColors.Window;
            OrderInfoPanel.Controls.Add(AddItemButton);
            OrderInfoPanel.Controls.Add(RemoveItemButton);
            OrderInfoPanel.Controls.Add(ClearOrderButton);
            OrderInfoPanel.Controls.Add(DesiredTimeComboBox);
            OrderInfoPanel.Controls.Add(DesiredTimeLabel);
            OrderInfoPanel.Controls.Add(PriorityOptionsLabel);
            OrderInfoPanel.Controls.Add(label1);
            OrderInfoPanel.Controls.Add(label2);
            OrderInfoPanel.Controls.Add(OrderItemsListBox);
            OrderInfoPanel.Controls.Add(FinalAmountLabel);
            OrderInfoPanel.Controls.Add(AmountLabel);
            OrderInfoPanel.Controls.Add(AddressControl);
            OrderInfoPanel.Controls.Add(StatusComboBox);
            OrderInfoPanel.Controls.Add(StatusLabel);
            OrderInfoPanel.Controls.Add(IdTextBox);
            OrderInfoPanel.Controls.Add(CreationDateTextBox);
            OrderInfoPanel.Controls.Add(OrderItemsLabel);
            OrderInfoPanel.Controls.Add(CreatedLabel);
            OrderInfoPanel.Controls.Add(IdLabel);
            OrderInfoPanel.Controls.Add(SelectedOrderLabel);
            OrderInfoPanel.Dock = DockStyle.Fill;
            OrderInfoPanel.Location = new Point(0, 0);
            OrderInfoPanel.Name = "OrderInfoPanel";
            OrderInfoPanel.Padding = new Padding(3);
            OrderInfoPanel.Size = new Size(746, 608);
            OrderInfoPanel.TabIndex = 1;
            // 
            // AddItemButton
            // 
            AddItemButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddItemButton.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            AddItemButton.Location = new Point(7, 556);
            AddItemButton.Name = "AddItemButton";
            AddItemButton.Padding = new Padding(3);
            AddItemButton.Size = new Size(101, 40);
            AddItemButton.TabIndex = 30;
            AddItemButton.Text = "Add Item";
            AddItemButton.UseVisualStyleBackColor = true;
            AddItemButton.Click += AddItemButton_Click;
            // 
            // RemoveItemButton
            // 
            RemoveItemButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RemoveItemButton.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            RemoveItemButton.Location = new Point(114, 556);
            RemoveItemButton.Name = "RemoveItemButton";
            RemoveItemButton.Padding = new Padding(3);
            RemoveItemButton.Size = new Size(101, 40);
            RemoveItemButton.TabIndex = 29;
            RemoveItemButton.Text = "Remove Item";
            RemoveItemButton.UseVisualStyleBackColor = true;
            RemoveItemButton.Click += RemoveItemButton_Click;
            // 
            // ClearOrderButton
            // 
            ClearOrderButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ClearOrderButton.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            ClearOrderButton.Location = new Point(637, 556);
            ClearOrderButton.Name = "ClearOrderButton";
            ClearOrderButton.Padding = new Padding(3);
            ClearOrderButton.Size = new Size(101, 40);
            ClearOrderButton.TabIndex = 28;
            ClearOrderButton.Text = "Clear Order";
            ClearOrderButton.UseVisualStyleBackColor = true;
            ClearOrderButton.Click += ClearOrderButton_Click;
            // 
            // DesiredTimeComboBox
            // 
            DesiredTimeComboBox.AutoCompleteCustomSource.AddRange(new string[] { "9:00 – 11:00", "11:00 – 13:00", "13:00 – 15:00", "15:00 – 17:00", "17:00 – 19:00", "19:00 – 21:00" });
            DesiredTimeComboBox.FormattingEnabled = true;
            DesiredTimeComboBox.Items.AddRange(new object[] { "9:00 – 11:00", "11:00 – 13:00", "13:00 – 15:00", "15:00 – 17:00", "17:00 – 19:00", "19:00 – 21:00" });
            DesiredTimeComboBox.Location = new Point(386, 40);
            DesiredTimeComboBox.Name = "DesiredTimeComboBox";
            DesiredTimeComboBox.Size = new Size(191, 23);
            DesiredTimeComboBox.TabIndex = 27;
            // 
            // DesiredTimeLabel
            // 
            DesiredTimeLabel.AutoSize = true;
            DesiredTimeLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DesiredTimeLabel.Location = new Point(289, 40);
            DesiredTimeLabel.Margin = new Padding(3);
            DesiredTimeLabel.Name = "DesiredTimeLabel";
            DesiredTimeLabel.Padding = new Padding(3);
            DesiredTimeLabel.Size = new Size(91, 21);
            DesiredTimeLabel.TabIndex = 26;
            DesiredTimeLabel.Text = "Delivery Time: ";
            // 
            // PriorityOptionsLabel
            // 
            PriorityOptionsLabel.AutoSize = true;
            PriorityOptionsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PriorityOptionsLabel.Location = new Point(289, 3);
            PriorityOptionsLabel.Margin = new Padding(3);
            PriorityOptionsLabel.Name = "PriorityOptionsLabel";
            PriorityOptionsLabel.Padding = new Padding(3);
            PriorityOptionsLabel.Size = new Size(100, 21);
            PriorityOptionsLabel.TabIndex = 25;
            PriorityOptionsLabel.Text = "Priority Options";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(650, 525);
            label1.Name = "label1";
            label1.Size = new Size(88, 25);
            label1.TabIndex = 24;
            label1.Text = "4 990,90";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(677, 501);
            label2.Margin = new Padding(3);
            label2.Name = "label2";
            label2.Padding = new Padding(3);
            label2.Size = new Size(61, 21);
            label2.TabIndex = 23;
            label2.Text = "Amount:";
            // 
            // OrderItemsListBox
            // 
            OrderItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OrderItemsListBox.FormattingEnabled = true;
            OrderItemsListBox.IntegralHeight = false;
            OrderItemsListBox.ItemHeight = 15;
            OrderItemsListBox.Location = new Point(6, 325);
            OrderItemsListBox.Name = "OrderItemsListBox";
            OrderItemsListBox.Size = new Size(732, 170);
            OrderItemsListBox.TabIndex = 22;
            OrderItemsListBox.SelectedIndexChanged += OrderItemsListBox_SelectedIndexChanged;
            // 
            // FinalAmountLabel
            // 
            FinalAmountLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            FinalAmountLabel.AutoSize = true;
            FinalAmountLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            FinalAmountLabel.Location = new Point(1052, 1077);
            FinalAmountLabel.Name = "FinalAmountLabel";
            FinalAmountLabel.Size = new Size(88, 25);
            FinalAmountLabel.TabIndex = 21;
            FinalAmountLabel.Text = "4 990,90";
            // 
            // AmountLabel
            // 
            AmountLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AmountLabel.AutoSize = true;
            AmountLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            AmountLabel.Location = new Point(1079, 1053);
            AmountLabel.Margin = new Padding(3);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Padding = new Padding(3);
            AmountLabel.Size = new Size(61, 21);
            AmountLabel.TabIndex = 20;
            AmountLabel.Text = "Amount:";
            // 
            // AddressControl
            // 
            address1.Apartment = " ";
            address1.Building = " ";
            address1.City = " ";
            address1.Country = " ";
            address1.Index = 111111;
            address1.Street = " ";
            AddressControl.Address = address1;
            AddressControl.Location = new Point(0, 131);
            AddressControl.Name = "AddressControl";
            AddressControl.Size = new Size(570, 158);
            AddressControl.TabIndex = 14;
            // 
            // StatusComboBox
            // 
            StatusComboBox.FormattingEnabled = true;
            StatusComboBox.Location = new Point(72, 101);
            StatusComboBox.Name = "StatusComboBox";
            StatusComboBox.Size = new Size(191, 23);
            StatusComboBox.TabIndex = 13;
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            StatusLabel.Location = new Point(6, 107);
            StatusLabel.Margin = new Padding(3);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Padding = new Padding(3);
            StatusLabel.Size = new Size(51, 21);
            StatusLabel.TabIndex = 12;
            StatusLabel.Text = "Status: ";
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(72, 40);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(191, 23);
            IdTextBox.TabIndex = 9;
            // 
            // CreationDateTextBox
            // 
            CreationDateTextBox.Location = new Point(72, 70);
            CreationDateTextBox.Name = "CreationDateTextBox";
            CreationDateTextBox.ReadOnly = true;
            CreationDateTextBox.Size = new Size(191, 23);
            CreationDateTextBox.TabIndex = 8;
            // 
            // OrderItemsLabel
            // 
            OrderItemsLabel.AutoSize = true;
            OrderItemsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            OrderItemsLabel.Location = new Point(6, 298);
            OrderItemsLabel.Margin = new Padding(3);
            OrderItemsLabel.Name = "OrderItemsLabel";
            OrderItemsLabel.Padding = new Padding(3);
            OrderItemsLabel.Size = new Size(84, 21);
            OrderItemsLabel.TabIndex = 7;
            OrderItemsLabel.Text = "Order Items:";
            // 
            // CreatedLabel
            // 
            CreatedLabel.AutoSize = true;
            CreatedLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CreatedLabel.Location = new Point(6, 76);
            CreatedLabel.Margin = new Padding(3);
            CreatedLabel.Name = "CreatedLabel";
            CreatedLabel.Padding = new Padding(3);
            CreatedLabel.Size = new Size(60, 21);
            CreatedLabel.TabIndex = 5;
            CreatedLabel.Text = "Created: ";
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            IdLabel.Location = new Point(6, 46);
            IdLabel.Margin = new Padding(3);
            IdLabel.Name = "IdLabel";
            IdLabel.Padding = new Padding(3);
            IdLabel.Size = new Size(30, 21);
            IdLabel.TabIndex = 4;
            IdLabel.Text = "ID: ";
            // 
            // SelectedOrderLabel
            // 
            SelectedOrderLabel.AutoSize = true;
            SelectedOrderLabel.Dock = DockStyle.Top;
            SelectedOrderLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SelectedOrderLabel.Location = new Point(3, 3);
            SelectedOrderLabel.Margin = new Padding(3);
            SelectedOrderLabel.Name = "SelectedOrderLabel";
            SelectedOrderLabel.Padding = new Padding(3);
            SelectedOrderLabel.Size = new Size(98, 21);
            SelectedOrderLabel.TabIndex = 3;
            SelectedOrderLabel.Text = "Selected Order";
            // 
            // PriorityOrdersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(OrderInfoPanel);
            Name = "PriorityOrdersTab";
            Size = new Size(746, 608);
            OrderInfoPanel.ResumeLayout(false);
            OrderInfoPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel OrderInfoPanel;
        private Label FinalAmountLabel;
        private Label AmountLabel;
        private Controls.AddressControl AddressControl;
        private ComboBox StatusComboBox;
        private Label StatusLabel;
        private TextBox IdTextBox;
        private TextBox CreationDateTextBox;
        private Label OrderItemsLabel;
        private Label CreatedLabel;
        private Label IdLabel;
        private Label SelectedOrderLabel;
        private Label label1;
        private Label label2;
        private ListBox OrderItemsListBox;
        private Button AddItemButton;
        private Button RemoveItemButton;
        private Button ClearOrderButton;
        private ComboBox DesiredTimeComboBox;
        private Label DesiredTimeLabel;
        private Label PriorityOptionsLabel;
    }
}
