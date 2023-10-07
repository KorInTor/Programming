﻿namespace ObjectOrientedPractics.View.Tabs
{
    partial class CartsTab
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
            ItemsTableLayoutPanel = new TableLayoutPanel();
            ItemsListPanel = new Panel();
            ItemsListBox = new ListBox();
            ButtonstableLayoutPanel = new TableLayoutPanel();
            AddToCartButton = new Button();
            ItemsLabel = new Label();
            CartInfoPanel = new Panel();
            CartContentListBox = new ListBox();
            CreateOrderButton = new Button();
            RemoveItemButton = new Button();
            ClearCartButton = new Button();
            FinalAmountLabel = new Label();
            AmountLabel = new Label();
            CustomerComboBox = new ComboBox();
            CustomerLabel = new Label();
            CartLabel = new Label();
            ItemsTableLayoutPanel.SuspendLayout();
            ItemsListPanel.SuspendLayout();
            ButtonstableLayoutPanel.SuspendLayout();
            CartInfoPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ItemsTableLayoutPanel
            // 
            ItemsTableLayoutPanel.ColumnCount = 2;
            ItemsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            ItemsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            ItemsTableLayoutPanel.Controls.Add(ItemsListPanel, 0, 0);
            ItemsTableLayoutPanel.Controls.Add(CartInfoPanel, 1, 0);
            ItemsTableLayoutPanel.Dock = DockStyle.Fill;
            ItemsTableLayoutPanel.Location = new Point(0, 0);
            ItemsTableLayoutPanel.Name = "ItemsTableLayoutPanel";
            ItemsTableLayoutPanel.RowCount = 1;
            ItemsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            ItemsTableLayoutPanel.Size = new Size(876, 555);
            ItemsTableLayoutPanel.TabIndex = 0;
            // 
            // ItemsListPanel
            // 
            ItemsListPanel.Controls.Add(ItemsListBox);
            ItemsListPanel.Controls.Add(ButtonstableLayoutPanel);
            ItemsListPanel.Controls.Add(ItemsLabel);
            ItemsListPanel.Dock = DockStyle.Fill;
            ItemsListPanel.Location = new Point(5, 3);
            ItemsListPanel.Margin = new Padding(5, 3, 3, 3);
            ItemsListPanel.Name = "ItemsListPanel";
            ItemsListPanel.Padding = new Padding(3);
            ItemsListPanel.Size = new Size(386, 549);
            ItemsListPanel.TabIndex = 2;
            // 
            // ItemsListBox
            // 
            ItemsListBox.Dock = DockStyle.Fill;
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.IntegralHeight = false;
            ItemsListBox.ItemHeight = 15;
            ItemsListBox.Location = new Point(3, 24);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(380, 470);
            ItemsListBox.TabIndex = 1;
            // 
            // ButtonstableLayoutPanel
            // 
            ButtonstableLayoutPanel.ColumnCount = 3;
            ButtonstableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            ButtonstableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            ButtonstableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            ButtonstableLayoutPanel.Controls.Add(AddToCartButton, 0, 0);
            ButtonstableLayoutPanel.Dock = DockStyle.Bottom;
            ButtonstableLayoutPanel.Location = new Point(3, 494);
            ButtonstableLayoutPanel.Name = "ButtonstableLayoutPanel";
            ButtonstableLayoutPanel.Padding = new Padding(3);
            ButtonstableLayoutPanel.RowCount = 1;
            ButtonstableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            ButtonstableLayoutPanel.Size = new Size(380, 52);
            ButtonstableLayoutPanel.TabIndex = 3;
            // 
            // AddToCartButton
            // 
            AddToCartButton.Dock = DockStyle.Fill;
            AddToCartButton.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            AddToCartButton.Location = new Point(6, 6);
            AddToCartButton.Name = "AddToCartButton";
            AddToCartButton.Padding = new Padding(3);
            AddToCartButton.Size = new Size(118, 40);
            AddToCartButton.TabIndex = 1;
            AddToCartButton.Text = "Add to Cart";
            AddToCartButton.UseVisualStyleBackColor = true;
            AddToCartButton.Click += AddToCartButton_Click;
            // 
            // ItemsLabel
            // 
            ItemsLabel.AutoSize = true;
            ItemsLabel.Dock = DockStyle.Top;
            ItemsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ItemsLabel.Location = new Point(3, 3);
            ItemsLabel.Margin = new Padding(3);
            ItemsLabel.Name = "ItemsLabel";
            ItemsLabel.Padding = new Padding(3);
            ItemsLabel.Size = new Size(45, 21);
            ItemsLabel.TabIndex = 3;
            ItemsLabel.Text = "Items";
            // 
            // CartInfoPanel
            // 
            CartInfoPanel.Controls.Add(CartContentListBox);
            CartInfoPanel.Controls.Add(CreateOrderButton);
            CartInfoPanel.Controls.Add(RemoveItemButton);
            CartInfoPanel.Controls.Add(ClearCartButton);
            CartInfoPanel.Controls.Add(FinalAmountLabel);
            CartInfoPanel.Controls.Add(AmountLabel);
            CartInfoPanel.Controls.Add(CustomerComboBox);
            CartInfoPanel.Controls.Add(CustomerLabel);
            CartInfoPanel.Controls.Add(CartLabel);
            CartInfoPanel.Dock = DockStyle.Fill;
            CartInfoPanel.Location = new Point(397, 3);
            CartInfoPanel.Name = "CartInfoPanel";
            CartInfoPanel.Padding = new Padding(3);
            CartInfoPanel.Size = new Size(476, 549);
            CartInfoPanel.TabIndex = 4;
            // 
            // CartContentListBox
            // 
            CartContentListBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CartContentListBox.FormattingEnabled = true;
            CartContentListBox.ItemHeight = 15;
            CartContentListBox.Location = new Point(0, 82);
            CartContentListBox.Name = "CartContentListBox";
            CartContentListBox.Size = new Size(470, 154);
            CartContentListBox.TabIndex = 22;
            // 
            // CreateOrderButton
            // 
            CreateOrderButton.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            CreateOrderButton.Location = new Point(6, 298);
            CreateOrderButton.Name = "CreateOrderButton";
            CreateOrderButton.Padding = new Padding(3);
            CreateOrderButton.Size = new Size(101, 40);
            CreateOrderButton.TabIndex = 21;
            CreateOrderButton.Text = "Create Order";
            CreateOrderButton.UseVisualStyleBackColor = true;
            CreateOrderButton.Click += CreateOrderButton_Click;
            // 
            // RemoveItemButton
            // 
            RemoveItemButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RemoveItemButton.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            RemoveItemButton.Location = new Point(262, 298);
            RemoveItemButton.Name = "RemoveItemButton";
            RemoveItemButton.Padding = new Padding(3);
            RemoveItemButton.Size = new Size(101, 40);
            RemoveItemButton.TabIndex = 20;
            RemoveItemButton.Text = "Remove Item";
            RemoveItemButton.UseVisualStyleBackColor = true;
            RemoveItemButton.Click += RemoveItemButton_Click;
            // 
            // ClearCartButton
            // 
            ClearCartButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ClearCartButton.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            ClearCartButton.Location = new Point(369, 298);
            ClearCartButton.Name = "ClearCartButton";
            ClearCartButton.Padding = new Padding(3);
            ClearCartButton.Size = new Size(101, 40);
            ClearCartButton.TabIndex = 2;
            ClearCartButton.Text = "Clear Cart";
            ClearCartButton.UseVisualStyleBackColor = true;
            ClearCartButton.Click += ClearCartButton_Click;
            // 
            // FinalAmountLabel
            // 
            FinalAmountLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            FinalAmountLabel.AutoSize = true;
            FinalAmountLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            FinalAmountLabel.Location = new Point(377, 270);
            FinalAmountLabel.Name = "FinalAmountLabel";
            FinalAmountLabel.Size = new Size(88, 25);
            FinalAmountLabel.TabIndex = 19;
            FinalAmountLabel.Text = "4 990,90";
            // 
            // AmountLabel
            // 
            AmountLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AmountLabel.AutoSize = true;
            AmountLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            AmountLabel.Location = new Point(413, 246);
            AmountLabel.Margin = new Padding(3);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Padding = new Padding(3);
            AmountLabel.Size = new Size(61, 21);
            AmountLabel.TabIndex = 18;
            AmountLabel.Text = "Amount:";
            // 
            // CustomerComboBox
            // 
            CustomerComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CustomerComboBox.FormattingEnabled = true;
            CustomerComboBox.Location = new Point(79, 25);
            CustomerComboBox.Name = "CustomerComboBox";
            CustomerComboBox.Size = new Size(391, 23);
            CustomerComboBox.TabIndex = 17;
            CustomerComboBox.SelectedIndexChanged += CustomerComboBox_SelectedIndexChanged;
            // 
            // CustomerLabel
            // 
            CustomerLabel.AutoSize = true;
            CustomerLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CustomerLabel.Location = new Point(0, 27);
            CustomerLabel.Margin = new Padding(3);
            CustomerLabel.Name = "CustomerLabel";
            CustomerLabel.Padding = new Padding(3);
            CustomerLabel.Size = new Size(73, 21);
            CustomerLabel.TabIndex = 16;
            CustomerLabel.Text = "Customer: ";
            // 
            // CartLabel
            // 
            CartLabel.AutoSize = true;
            CartLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CartLabel.Location = new Point(0, 55);
            CartLabel.Margin = new Padding(3);
            CartLabel.Name = "CartLabel";
            CartLabel.Padding = new Padding(3);
            CartLabel.Size = new Size(38, 21);
            CartLabel.TabIndex = 14;
            CartLabel.Text = "Cart:";
            // 
            // CartsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ItemsTableLayoutPanel);
            Name = "CartsTab";
            Size = new Size(876, 555);
            ItemsTableLayoutPanel.ResumeLayout(false);
            ItemsListPanel.ResumeLayout(false);
            ItemsListPanel.PerformLayout();
            ButtonstableLayoutPanel.ResumeLayout(false);
            CartInfoPanel.ResumeLayout(false);
            CartInfoPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel ItemsTableLayoutPanel;
        private ListBox ItemsListBox;
        private Panel ItemsListPanel;
        private Label ItemsLabel;
        private TableLayoutPanel ButtonstableLayoutPanel;
        private Button AddToCartButton;
        private Panel CartInfoPanel;
        private ComboBox CustomerComboBox;
        private Label CustomerLabel;
        private Label CartLabel;
        private Label FinalAmountLabel;
        private Label AmountLabel;
        private Button ClearCartButton;
        private Button CreateOrderButton;
        private Button RemoveItemButton;
        private ListBox CartContentListBox;
    }
}
