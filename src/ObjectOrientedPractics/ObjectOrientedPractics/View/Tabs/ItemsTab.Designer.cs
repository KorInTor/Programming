namespace ObjectOrientedPractics.View.Tabs
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
            tableLayoutPanel1 = new TableLayoutPanel();
            ItemsInfoPanel = new Panel();
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
            ItemsListBox = new ListBox();
            ItemsLabel = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            AddItemButton = new Button();
            RemoveItemButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            ItemsInfoPanel.SuspendLayout();
            ItemsControlPanel.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.7524757F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.2475243F));
            tableLayoutPanel1.Controls.Add(ItemsInfoPanel, 1, 0);
            tableLayoutPanel1.Controls.Add(ItemsControlPanel, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.MinimumSize = new Size(500, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(873, 593);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // ItemsInfoPanel
            // 
            ItemsInfoPanel.BackColor = SystemColors.Window;
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
            ItemsInfoPanel.Location = new Point(393, 3);
            ItemsInfoPanel.Name = "ItemsInfoPanel";
            ItemsInfoPanel.Padding = new Padding(3);
            ItemsInfoPanel.Size = new Size(477, 587);
            ItemsInfoPanel.TabIndex = 0;
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DescriptionTextBox.Location = new Point(6, 304);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(465, 277);
            DescriptionTextBox.TabIndex = 11;
            DescriptionTextBox.TextChanged += DescriptionTextBox_TextChanged;
            // 
            // NameTextBox
            // 
            NameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NameTextBox.Location = new Point(6, 150);
            NameTextBox.Multiline = true;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(465, 121);
            NameTextBox.TabIndex = 10;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(48, 40);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(104, 23);
            IdTextBox.TabIndex = 9;
            // 
            // CostTextBox
            // 
            CostTextBox.Location = new Point(48, 72);
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
            NameLabel.Location = new Point(0, 123);
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
            CostLabel.Location = new Point(0, 72);
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
            ItemsControlPanel.Controls.Add(ItemsListBox);
            ItemsControlPanel.Controls.Add(ItemsLabel);
            ItemsControlPanel.Controls.Add(tableLayoutPanel2);
            ItemsControlPanel.Dock = DockStyle.Fill;
            ItemsControlPanel.Location = new Point(5, 3);
            ItemsControlPanel.Margin = new Padding(5, 3, 3, 3);
            ItemsControlPanel.MinimumSize = new Size(100, 0);
            ItemsControlPanel.Name = "ItemsControlPanel";
            ItemsControlPanel.Padding = new Padding(3);
            ItemsControlPanel.Size = new Size(382, 587);
            ItemsControlPanel.TabIndex = 1;
            // 
            // ItemsListBox
            // 
            ItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.IntegralHeight = false;
            ItemsListBox.ItemHeight = 15;
            ItemsListBox.Location = new Point(3, 30);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(376, 502);
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
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(AddItemButton, 0, 0);
            tableLayoutPanel2.Controls.Add(RemoveItemButton, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Bottom;
            tableLayoutPanel2.Location = new Point(3, 532);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(3);
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(376, 52);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // AddItemButton
            // 
            AddItemButton.Dock = DockStyle.Fill;
            AddItemButton.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            AddItemButton.Location = new Point(6, 6);
            AddItemButton.Name = "AddItemButton";
            AddItemButton.Padding = new Padding(3);
            AddItemButton.Size = new Size(117, 40);
            AddItemButton.TabIndex = 1;
            AddItemButton.Text = "Add";
            AddItemButton.UseVisualStyleBackColor = true;
            AddItemButton.Click += AddItemButton_Click;
            // 
            // RemoveItemButton
            // 
            RemoveItemButton.Dock = DockStyle.Fill;
            RemoveItemButton.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            RemoveItemButton.Location = new Point(129, 6);
            RemoveItemButton.Name = "RemoveItemButton";
            RemoveItemButton.Padding = new Padding(3);
            RemoveItemButton.Size = new Size(117, 40);
            RemoveItemButton.TabIndex = 0;
            RemoveItemButton.Text = "Remove";
            RemoveItemButton.UseVisualStyleBackColor = true;
            RemoveItemButton.Click += RemoveItemButton_Click;
            // 
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "ItemsTab";
            Size = new Size(873, 593);
            tableLayoutPanel1.ResumeLayout(false);
            ItemsInfoPanel.ResumeLayout(false);
            ItemsInfoPanel.PerformLayout();
            ItemsControlPanel.ResumeLayout(false);
            ItemsControlPanel.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel ItemsInfoPanel;
        private Panel ItemsControlPanel;
        private TableLayoutPanel tableLayoutPanel2;
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
    }
}
