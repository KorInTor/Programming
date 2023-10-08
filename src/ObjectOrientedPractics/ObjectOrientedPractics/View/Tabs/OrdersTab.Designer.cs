﻿using ObjectOrientedPractics.Model;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    partial class OrdersTab
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
            Address address2 = new Address();
            OrdersTableLayoutPanel = new TableLayoutPanel();
            OrderInfoPanel = new Panel();
            FinalAmountLabel = new Label();
            AmountLabel = new Label();
            OrderItemsListBox = new ListBox();
            AddressControl = new Controls.AddressControl();
            StatusComboBox = new ComboBox();
            StatusLabel = new Label();
            IdTextBox = new TextBox();
            CreationDateTextBox = new TextBox();
            OrderItemsLabel = new Label();
            CreatedLabel = new Label();
            IdLabel = new Label();
            SelectedOrderLabel = new Label();
            ItemsControlPanel = new Panel();
            OrdersDataGridView = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Created = new DataGridViewTextBoxColumn();
            OrderStatus = new DataGridViewTextBoxColumn();
            Fullname = new DataGridViewTextBoxColumn();
            DeliveryAddress = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            OrdersLabel = new Label();
            OrdersTableLayoutPanel.SuspendLayout();
            OrderInfoPanel.SuspendLayout();
            ItemsControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OrdersDataGridView).BeginInit();
            SuspendLayout();
            // 
            // OrdersTableLayoutPanel
            // 
            OrdersTableLayoutPanel.ColumnCount = 2;
            OrdersTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            OrdersTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            OrdersTableLayoutPanel.Controls.Add(OrderInfoPanel, 1, 0);
            OrdersTableLayoutPanel.Controls.Add(ItemsControlPanel, 0, 0);
            OrdersTableLayoutPanel.Dock = DockStyle.Fill;
            OrdersTableLayoutPanel.Location = new Point(0, 0);
            OrdersTableLayoutPanel.MinimumSize = new Size(500, 0);
            OrdersTableLayoutPanel.Name = "OrdersTableLayoutPanel";
            OrdersTableLayoutPanel.RowCount = 1;
            OrdersTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            OrdersTableLayoutPanel.Size = new Size(1110, 612);
            OrdersTableLayoutPanel.TabIndex = 1;
            // 
            // OrderInfoPanel
            // 
            OrderInfoPanel.BackColor = SystemColors.Window;
            OrderInfoPanel.Controls.Add(FinalAmountLabel);
            OrderInfoPanel.Controls.Add(AmountLabel);
            OrderInfoPanel.Controls.Add(OrderItemsListBox);
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
            OrderInfoPanel.Location = new Point(502, 3);
            OrderInfoPanel.Name = "OrderInfoPanel";
            OrderInfoPanel.Padding = new Padding(3);
            OrderInfoPanel.Size = new Size(605, 606);
            OrderInfoPanel.TabIndex = 0;
            // 
            // FinalAmountLabel
            // 
            FinalAmountLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            FinalAmountLabel.AutoSize = true;
            FinalAmountLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            FinalAmountLabel.Location = new Point(511, 578);
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
            AmountLabel.Location = new Point(538, 554);
            AmountLabel.Margin = new Padding(3);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Padding = new Padding(3);
            AmountLabel.Size = new Size(61, 21);
            AmountLabel.TabIndex = 20;
            AmountLabel.Text = "Amount:";
            // 
            // OrderItemsListBox
            // 
            OrderItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OrderItemsListBox.FormattingEnabled = true;
            OrderItemsListBox.IntegralHeight = false;
            OrderItemsListBox.ItemHeight = 15;
            OrderItemsListBox.Location = new Point(6, 322);
            OrderItemsListBox.Name = "OrderItemsListBox";
            OrderItemsListBox.Size = new Size(593, 226);
            OrderItemsListBox.TabIndex = 15;
            // 
            // AddressControl
            // 
            address2.Apartment = " ";
            address2.Building = " ";
            address2.City = " ";
            address2.Country = " ";
            address2.Index = 111111;
            address2.Street = " ";
            AddressControl.Address = address2;
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
            StatusComboBox.SelectedIndexChanged += StatusComboBox_SelectedIndexChanged;
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            StatusLabel.Location = new Point(3, 104);
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
            OrderItemsLabel.Location = new Point(3, 295);
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
            CreatedLabel.Location = new Point(3, 73);
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
            IdLabel.Location = new Point(3, 43);
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
            // ItemsControlPanel
            // 
            ItemsControlPanel.Controls.Add(OrdersDataGridView);
            ItemsControlPanel.Controls.Add(OrdersLabel);
            ItemsControlPanel.Dock = DockStyle.Fill;
            ItemsControlPanel.Location = new Point(5, 3);
            ItemsControlPanel.Margin = new Padding(5, 3, 3, 3);
            ItemsControlPanel.MinimumSize = new Size(100, 0);
            ItemsControlPanel.Name = "ItemsControlPanel";
            ItemsControlPanel.Padding = new Padding(3);
            ItemsControlPanel.Size = new Size(491, 606);
            ItemsControlPanel.TabIndex = 1;
            // 
            // OrdersDataGridView
            // 
            OrdersDataGridView.AllowUserToAddRows = false;
            OrdersDataGridView.AllowUserToDeleteRows = false;
            OrdersDataGridView.AllowUserToResizeRows = false;
            OrdersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrdersDataGridView.Columns.AddRange(new DataGridViewColumn[] { Id, Created, OrderStatus, Fullname, DeliveryAddress, Amount });
            OrdersDataGridView.Dock = DockStyle.Fill;
            OrdersDataGridView.Location = new Point(3, 24);
            OrdersDataGridView.MultiSelect = false;
            OrdersDataGridView.Name = "OrdersDataGridView";
            OrdersDataGridView.ReadOnly = true;
            OrdersDataGridView.RowHeadersVisible = false;
            OrdersDataGridView.RowTemplate.Height = 25;
            OrdersDataGridView.Size = new Size(485, 579);
            OrdersDataGridView.TabIndex = 3;
            OrdersDataGridView.SelectionChanged += OrdersDataGridView_SelectionChanged;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Created
            // 
            Created.HeaderText = "Created";
            Created.Name = "Created";
            Created.ReadOnly = true;
            Created.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // OrderStatus
            // 
            OrderStatus.HeaderText = "Order Status";
            OrderStatus.Name = "OrderStatus";
            OrderStatus.ReadOnly = true;
            OrderStatus.Resizable = DataGridViewTriState.True;
            OrderStatus.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Fullname
            // 
            Fullname.HeaderText = "Customer Fullname";
            Fullname.Name = "Fullname";
            Fullname.ReadOnly = true;
            Fullname.SortMode = DataGridViewColumnSortMode.NotSortable;
            Fullname.Width = 200;
            // 
            // DeliveryAddress
            // 
            DeliveryAddress.HeaderText = "Delivery Address";
            DeliveryAddress.Name = "DeliveryAddress";
            DeliveryAddress.ReadOnly = true;
            DeliveryAddress.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Amount
            // 
            Amount.HeaderText = "Amount";
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            Amount.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // OrdersLabel
            // 
            OrdersLabel.AutoSize = true;
            OrdersLabel.Dock = DockStyle.Top;
            OrdersLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            OrdersLabel.Location = new Point(3, 3);
            OrdersLabel.Margin = new Padding(3);
            OrdersLabel.Name = "OrdersLabel";
            OrdersLabel.Padding = new Padding(3);
            OrdersLabel.Size = new Size(45, 21);
            OrdersLabel.TabIndex = 2;
            OrdersLabel.Text = "Items";
            // 
            // OrdersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(OrdersTableLayoutPanel);
            Name = "OrdersTab";
            Size = new Size(1110, 612);
            OrdersTableLayoutPanel.ResumeLayout(false);
            OrderInfoPanel.ResumeLayout(false);
            OrderInfoPanel.PerformLayout();
            ItemsControlPanel.ResumeLayout(false);
            ItemsControlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)OrdersDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel OrdersTableLayoutPanel;
        private Panel OrderInfoPanel;
        private ComboBox StatusComboBox;
        private Label StatusLabel;
        private TextBox IdTextBox;
        private TextBox CreationDateTextBox;
        private Label OrderItemsLabel;
        private Label CreatedLabel;
        private Label IdLabel;
        private Label SelectedOrderLabel;
        private Panel ItemsControlPanel;
        private Label OrdersLabel;
        private DataGridView OrdersDataGridView;
        private Controls.AddressControl AddressControl;
        private ListBox OrderItemsListBox;
        private Label FinalAmountLabel;
        private Label AmountLabel;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Created;
        private DataGridViewTextBoxColumn OrderStatus;
        private DataGridViewTextBoxColumn Fullname;
        private DataGridViewTextBoxColumn DeliveryAddress;
        private DataGridViewTextBoxColumn Amount;
    }
}