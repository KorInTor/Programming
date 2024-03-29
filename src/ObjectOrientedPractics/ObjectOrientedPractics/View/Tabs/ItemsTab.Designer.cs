﻿namespace ObjectOrientedPractics.View.Tabs
{
    partial class ItemsTab
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
            ItemsInfoPanel = new Panel();
            CategoryComboBox = new ComboBox();
            CategoryLabel = new Label();
            DescriptionTextBox = new TextBox();
            NameTextBox = new TextBox();
            IdTextBox = new TextBox();
            CostTextBox = new TextBox();
            DescriptionLabel = new Label();
            NameLabel = new Label();
            CostLabel = new Label();
            IdLabel = new Label();
            SelectedItemLabel = new Label();
            ItemsControlPanel = new Panel();
            OrderByComboBox = new ComboBox();
            OrderByLabel = new Label();
            FindTextBox = new TextBox();
            FindLabel = new Label();
            ItemsListBox = new ListBox();
            ItemsLabel = new Label();
            ButtonstableLayoutPanel = new TableLayoutPanel();
            AddItemButton = new Button();
            RemoveItemButton = new Button();
            ItemsTableLayoutPanel.SuspendLayout();
            ItemsInfoPanel.SuspendLayout();
            ItemsControlPanel.SuspendLayout();
            ButtonstableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ItemsTableLayoutPanel
            // 
            ItemsTableLayoutPanel.ColumnCount = 2;
            ItemsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            ItemsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            ItemsTableLayoutPanel.Controls.Add(ItemsInfoPanel, 1, 0);
            ItemsTableLayoutPanel.Controls.Add(ItemsControlPanel, 0, 0);
            ItemsTableLayoutPanel.Dock = DockStyle.Fill;
            ItemsTableLayoutPanel.Location = new Point(0, 0);
            ItemsTableLayoutPanel.MinimumSize = new Size(500, 0);
            ItemsTableLayoutPanel.Name = "ItemsTableLayoutPanel";
            ItemsTableLayoutPanel.RowCount = 1;
            ItemsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            ItemsTableLayoutPanel.Size = new Size(1039, 560);
            ItemsTableLayoutPanel.TabIndex = 0;
            // 
            // ItemsInfoPanel
            // 
            ItemsInfoPanel.BackColor = SystemColors.Window;
            ItemsInfoPanel.Controls.Add(CategoryComboBox);
            ItemsInfoPanel.Controls.Add(CategoryLabel);
            ItemsInfoPanel.Controls.Add(DescriptionTextBox);
            ItemsInfoPanel.Controls.Add(NameTextBox);
            ItemsInfoPanel.Controls.Add(IdTextBox);
            ItemsInfoPanel.Controls.Add(CostTextBox);
            ItemsInfoPanel.Controls.Add(DescriptionLabel);
            ItemsInfoPanel.Controls.Add(NameLabel);
            ItemsInfoPanel.Controls.Add(CostLabel);
            ItemsInfoPanel.Controls.Add(IdLabel);
            ItemsInfoPanel.Controls.Add(SelectedItemLabel);
            ItemsInfoPanel.Dock = DockStyle.Fill;
            ItemsInfoPanel.Location = new Point(470, 3);
            ItemsInfoPanel.Name = "ItemsInfoPanel";
            ItemsInfoPanel.Padding = new Padding(3);
            ItemsInfoPanel.Size = new Size(566, 554);
            ItemsInfoPanel.TabIndex = 0;
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(72, 101);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(191, 23);
            CategoryComboBox.TabIndex = 13;
            CategoryComboBox.SelectedIndexChanged += CategoryComboBox_SelectedIndexChanged;
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CategoryLabel.Location = new Point(0, 101);
            CategoryLabel.Margin = new Padding(3);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Padding = new Padding(3);
            CategoryLabel.Size = new Size(67, 21);
            CategoryLabel.TabIndex = 12;
            CategoryLabel.Text = "Category: ";
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DescriptionTextBox.Location = new Point(6, 304);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(524, 222);
            DescriptionTextBox.TabIndex = 11;
            DescriptionTextBox.TextChanged += DescriptionTextBox_TextChanged;
            // 
            // NameTextBox
            // 
            NameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NameTextBox.Location = new Point(6, 172);
            NameTextBox.Multiline = true;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(524, 99);
            NameTextBox.TabIndex = 10;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(72, 40);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(104, 23);
            IdTextBox.TabIndex = 9;
            // 
            // CostTextBox
            // 
            CostTextBox.Location = new Point(72, 70);
            CostTextBox.Name = "CostTextBox";
            CostTextBox.Size = new Size(104, 23);
            CostTextBox.TabIndex = 8;
            CostTextBox.TextChanged += CostTextBox_TextChanged;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DescriptionLabel.Location = new Point(0, 277);
            DescriptionLabel.Margin = new Padding(3);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Padding = new Padding(3);
            DescriptionLabel.Size = new Size(76, 21);
            DescriptionLabel.TabIndex = 7;
            DescriptionLabel.Text = "Description:";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            NameLabel.Location = new Point(0, 145);
            NameLabel.Margin = new Padding(3);
            NameLabel.Name = "NameLabel";
            NameLabel.Padding = new Padding(3);
            NameLabel.Size = new Size(48, 21);
            NameLabel.TabIndex = 6;
            NameLabel.Text = "Name:";
            // 
            // CostLabel
            // 
            CostLabel.AutoSize = true;
            CostLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CostLabel.Location = new Point(0, 70);
            CostLabel.Margin = new Padding(3);
            CostLabel.Name = "CostLabel";
            CostLabel.Padding = new Padding(3);
            CostLabel.Size = new Size(43, 21);
            CostLabel.TabIndex = 5;
            CostLabel.Text = "Cost: ";
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
            // SelectedItemLabel
            // 
            SelectedItemLabel.AutoSize = true;
            SelectedItemLabel.Dock = DockStyle.Top;
            SelectedItemLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SelectedItemLabel.Location = new Point(3, 3);
            SelectedItemLabel.Margin = new Padding(3);
            SelectedItemLabel.Name = "SelectedItemLabel";
            SelectedItemLabel.Padding = new Padding(3);
            SelectedItemLabel.Size = new Size(92, 21);
            SelectedItemLabel.TabIndex = 3;
            SelectedItemLabel.Text = "Selected Item";
            // 
            // ItemsControlPanel
            // 
            ItemsControlPanel.Controls.Add(OrderByComboBox);
            ItemsControlPanel.Controls.Add(OrderByLabel);
            ItemsControlPanel.Controls.Add(FindTextBox);
            ItemsControlPanel.Controls.Add(FindLabel);
            ItemsControlPanel.Controls.Add(ItemsListBox);
            ItemsControlPanel.Controls.Add(ItemsLabel);
            ItemsControlPanel.Controls.Add(ButtonstableLayoutPanel);
            ItemsControlPanel.Dock = DockStyle.Fill;
            ItemsControlPanel.Location = new Point(5, 3);
            ItemsControlPanel.Margin = new Padding(5, 3, 3, 3);
            ItemsControlPanel.MinimumSize = new Size(100, 0);
            ItemsControlPanel.Name = "ItemsControlPanel";
            ItemsControlPanel.Padding = new Padding(3);
            ItemsControlPanel.Size = new Size(459, 554);
            ItemsControlPanel.TabIndex = 1;
            // 
            // OrderByComboBox
            // 
            OrderByComboBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OrderByComboBox.FormattingEnabled = true;
            OrderByComboBox.Items.AddRange(new object[] { "Name (Descending)", "Name (Ascending)", "Cost (Descending)", "Cost (Ascending)" });
            OrderByComboBox.Location = new Point(78, 476);
            OrderByComboBox.Name = "OrderByComboBox";
            OrderByComboBox.Size = new Size(378, 23);
            OrderByComboBox.TabIndex = 6;
            OrderByComboBox.SelectedIndexChanged += OrderByComboBox_SelectedIndexChanged;
            // 
            // OrderByLabel
            // 
            OrderByLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            OrderByLabel.AutoSize = true;
            OrderByLabel.Location = new Point(9, 479);
            OrderByLabel.Name = "OrderByLabel";
            OrderByLabel.Size = new Size(59, 15);
            OrderByLabel.TabIndex = 5;
            OrderByLabel.Text = "Order by: ";
            // 
            // FindTextBox
            // 
            FindTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FindTextBox.Location = new Point(49, 24);
            FindTextBox.Name = "FindTextBox";
            FindTextBox.Size = new Size(404, 23);
            FindTextBox.TabIndex = 4;
            FindTextBox.TextChanged += FindTextBox_TextChanged;
            // 
            // FindLabel
            // 
            FindLabel.AutoSize = true;
            FindLabel.Location = new Point(10, 27);
            FindLabel.Name = "FindLabel";
            FindLabel.Size = new Size(33, 15);
            FindLabel.TabIndex = 3;
            FindLabel.Text = "FInd:";
            // 
            // ItemsListBox
            // 
            ItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.IntegralHeight = false;
            ItemsListBox.ItemHeight = 15;
            ItemsListBox.Location = new Point(3, 61);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(450, 409);
            ItemsListBox.TabIndex = 1;
            ItemsListBox.SelectedIndexChanged += ItemsListBox_SelectedIndexChanged;
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
            ItemsLabel.TabIndex = 2;
            ItemsLabel.Text = "Items";
            // 
            // ButtonstableLayoutPanel
            // 
            ButtonstableLayoutPanel.ColumnCount = 3;
            ButtonstableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            ButtonstableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            ButtonstableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            ButtonstableLayoutPanel.Controls.Add(AddItemButton, 0, 0);
            ButtonstableLayoutPanel.Controls.Add(RemoveItemButton, 1, 0);
            ButtonstableLayoutPanel.Dock = DockStyle.Bottom;
            ButtonstableLayoutPanel.Location = new Point(3, 499);
            ButtonstableLayoutPanel.Name = "ButtonstableLayoutPanel";
            ButtonstableLayoutPanel.Padding = new Padding(3);
            ButtonstableLayoutPanel.RowCount = 1;
            ButtonstableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            ButtonstableLayoutPanel.Size = new Size(453, 52);
            ButtonstableLayoutPanel.TabIndex = 0;
            // 
            // AddItemButton
            // 
            AddItemButton.Dock = DockStyle.Fill;
            AddItemButton.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            AddItemButton.Location = new Point(6, 6);
            AddItemButton.Name = "AddItemButton";
            AddItemButton.Padding = new Padding(3);
            AddItemButton.Size = new Size(142, 40);
            AddItemButton.TabIndex = 1;
            AddItemButton.Text = "Add";
            AddItemButton.UseVisualStyleBackColor = true;
            AddItemButton.Click += AddItemButton_Click;
            // 
            // RemoveItemButton
            // 
            RemoveItemButton.Dock = DockStyle.Fill;
            RemoveItemButton.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            RemoveItemButton.Location = new Point(154, 6);
            RemoveItemButton.Name = "RemoveItemButton";
            RemoveItemButton.Padding = new Padding(3);
            RemoveItemButton.Size = new Size(142, 40);
            RemoveItemButton.TabIndex = 0;
            RemoveItemButton.Text = "Remove";
            RemoveItemButton.UseVisualStyleBackColor = true;
            RemoveItemButton.Click += RemoveItemButton_Click;
            // 
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ItemsTableLayoutPanel);
            Name = "ItemsTab";
            Size = new Size(1039, 560);
            ItemsTableLayoutPanel.ResumeLayout(false);
            ItemsInfoPanel.ResumeLayout(false);
            ItemsInfoPanel.PerformLayout();
            ItemsControlPanel.ResumeLayout(false);
            ItemsControlPanel.PerformLayout();
            ButtonstableLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel ItemsTableLayoutPanel;
        private Panel ItemsInfoPanel;
        private Panel ItemsControlPanel;
        private TableLayoutPanel ButtonstableLayoutPanel;
        private Button AddItemButton;
        private Button RemoveItemButton;
        private ListBox ItemsListBox;
        private Label ItemsLabel;
        private Label CostLabel;
        private Label IdLabel;
        private Label SelectedItemLabel;
        private TextBox NameTextBox;
        private TextBox IdTextBox;
        private TextBox CostTextBox;
        private Label DescriptionLabel;
        private Label NameLabel;
        private TextBox DescriptionTextBox;
        private ComboBox CategoryComboBox;
        private Label CategoryLabel;
        private TextBox FindTextBox;
        private Label FindLabel;
        private ComboBox OrderByComboBox;
        private Label OrderByLabel;
    }
}
