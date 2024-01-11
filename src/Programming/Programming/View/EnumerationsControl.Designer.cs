namespace Programming.View
{
    partial class EnumerationsControl
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
            this.EnumsGroupBox = new System.Windows.Forms.GroupBox();
            this.IntValueLabel = new System.Windows.Forms.Label();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.IntValueTextBox = new System.Windows.Forms.TextBox();
            this.EnumsListBoxLabel = new System.Windows.Forms.Label();
            this.ValueListBoxLabel = new System.Windows.Forms.Label();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.EnumsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnumsGroupBox
            // 
            this.EnumsGroupBox.Controls.Add(this.IntValueLabel);
            this.EnumsGroupBox.Controls.Add(this.EnumsListBox);
            this.EnumsGroupBox.Controls.Add(this.IntValueTextBox);
            this.EnumsGroupBox.Controls.Add(this.EnumsListBoxLabel);
            this.EnumsGroupBox.Controls.Add(this.ValueListBoxLabel);
            this.EnumsGroupBox.Controls.Add(this.ValuesListBox);
            this.EnumsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnumsGroupBox.Location = new System.Drawing.Point(0, 0);
            this.EnumsGroupBox.Name = "EnumsGroupBox";
            this.EnumsGroupBox.Size = new System.Drawing.Size(703, 261);
            this.EnumsGroupBox.TabIndex = 4;
            this.EnumsGroupBox.TabStop = false;
            this.EnumsGroupBox.Text = "Enumerations";
            // 
            // IntValueLabel
            // 
            this.IntValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IntValueLabel.AutoSize = true;
            this.IntValueLabel.Location = new System.Drawing.Point(396, 21);
            this.IntValueLabel.Name = "IntValueLabel";
            this.IntValueLabel.Size = new System.Drawing.Size(52, 13);
            this.IntValueLabel.TabIndex = 6;
            this.IntValueLabel.Text = "Int Value:";
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.IntegralHeight = false;
            this.EnumsListBox.Items.AddRange(new object[] {
            "Colors",
            "FormOfStudy",
            "Genre",
            "Manufactures",
            "Season",
            "Weekday",
            "Months"});
            this.EnumsListBox.Location = new System.Drawing.Point(15, 37);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.ScrollAlwaysVisible = true;
            this.EnumsListBox.Size = new System.Drawing.Size(158, 212);
            this.EnumsListBox.TabIndex = 0;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // IntValueTextBox
            // 
            this.IntValueTextBox.Location = new System.Drawing.Point(399, 37);
            this.IntValueTextBox.Name = "IntValueTextBox";
            this.IntValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.IntValueTextBox.TabIndex = 2;
            // 
            // EnumsListBoxLabel
            // 
            this.EnumsListBoxLabel.AutoSize = true;
            this.EnumsListBoxLabel.Location = new System.Drawing.Point(12, 21);
            this.EnumsListBoxLabel.Name = "EnumsListBoxLabel";
            this.EnumsListBoxLabel.Size = new System.Drawing.Size(108, 13);
            this.EnumsListBoxLabel.TabIndex = 4;
            this.EnumsListBoxLabel.Text = "Choose Enumeration:";
            // 
            // ValueListBoxLabel
            // 
            this.ValueListBoxLabel.AutoSize = true;
            this.ValueListBoxLabel.Location = new System.Drawing.Point(209, 21);
            this.ValueListBoxLabel.Name = "ValueListBoxLabel";
            this.ValueListBoxLabel.Size = new System.Drawing.Size(76, 13);
            this.ValueListBoxLabel.TabIndex = 5;
            this.ValueListBoxLabel.Text = "Choose Value:";
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.IntegralHeight = false;
            this.ValuesListBox.Location = new System.Drawing.Point(212, 37);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.ScrollAlwaysVisible = true;
            this.ValuesListBox.Size = new System.Drawing.Size(139, 212);
            this.ValuesListBox.TabIndex = 1;
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // EnumerationsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EnumsGroupBox);
            this.Name = "EnumerationsControl";
            this.Size = new System.Drawing.Size(703, 261);
            this.EnumsGroupBox.ResumeLayout(false);
            this.EnumsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox EnumsGroupBox;
        private System.Windows.Forms.Label IntValueLabel;
        private System.Windows.Forms.ListBox EnumsListBox;
        private System.Windows.Forms.TextBox IntValueTextBox;
        private System.Windows.Forms.Label EnumsListBoxLabel;
        private System.Windows.Forms.Label ValueListBoxLabel;
        private System.Windows.Forms.ListBox ValuesListBox;
    }
}
