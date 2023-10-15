namespace ObjectOrientedPractics.View.Tabs
{
    partial class DataToolsTest
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
            ItemsListBox = new ListBox();
            PriceFilterButton = new Button();
            CategoryFilterButton = new Button();
            SuspendLayout();
            // 
            // ItemsListBox
            // 
            ItemsListBox.Dock = DockStyle.Fill;
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.IntegralHeight = false;
            ItemsListBox.ItemHeight = 15;
            ItemsListBox.Location = new Point(0, 0);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(1156, 609);
            ItemsListBox.TabIndex = 0;
            // 
            // PriceFilterButton
            // 
            PriceFilterButton.Dock = DockStyle.Bottom;
            PriceFilterButton.Location = new Point(0, 632);
            PriceFilterButton.Name = "PriceFilterButton";
            PriceFilterButton.Size = new Size(1156, 23);
            PriceFilterButton.TabIndex = 1;
            PriceFilterButton.Text = "Price >= 5K";
            PriceFilterButton.UseVisualStyleBackColor = true;
            PriceFilterButton.Click += PriceFilterButton_Click;
            // 
            // CategoryFilterButton
            // 
            CategoryFilterButton.Dock = DockStyle.Bottom;
            CategoryFilterButton.Location = new Point(0, 609);
            CategoryFilterButton.Name = "CategoryFilterButton";
            CategoryFilterButton.Size = new Size(1156, 23);
            CategoryFilterButton.TabIndex = 2;
            CategoryFilterButton.Text = "Category = Trim";
            CategoryFilterButton.UseVisualStyleBackColor = true;
            CategoryFilterButton.Click += CategoryFilterButton_Click;
            // 
            // DataToolsTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ItemsListBox);
            Controls.Add(CategoryFilterButton);
            Controls.Add(PriceFilterButton);
            Name = "DataToolsTest";
            Size = new Size(1156, 655);
            ResumeLayout(false);
        }

        #endregion

        private ListBox ItemsListBox;
        private Button PriceFilterButton;
        private Button CategoryFilterButton;
    }
}
