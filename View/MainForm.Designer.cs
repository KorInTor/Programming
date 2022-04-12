namespace Programming
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.Enums = new System.Windows.Forms.TabPage();
            this.IntValuesLabel = new System.Windows.Forms.Label();
            this.ValuesLBLabel = new System.Windows.Forms.Label();
            this.EnumLBLabel = new System.Windows.Forms.Label();
            this.IntValues = new System.Windows.Forms.TextBox();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.EnumListBox = new System.Windows.Forms.ListBox();
            this.EnumGroupBox = new System.Windows.Forms.GroupBox();
            this.ParsingGroupBox = new System.Windows.Forms.GroupBox();
            this.ParsingResult = new System.Windows.Forms.Label();
            this.ParsingButton = new System.Windows.Forms.Button();
            this.ParsingTextBox = new System.Windows.Forms.TextBox();
            this.ParsingLabel = new System.Windows.Forms.Label();
            this.SeasonGroupBox = new System.Windows.Forms.GroupBox();
            this.SeasonCombobox = new System.Windows.Forms.ComboBox();
            this.SeasonsCBLabel = new System.Windows.Forms.Label();
            this.SeasonButton = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.Enums.SuspendLayout();
            this.ParsingGroupBox.SuspendLayout();
            this.SeasonGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.Enums);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(904, 557);
            this.tabControl.TabIndex = 0;
            // 
            // Enums
            // 
            this.Enums.BackColor = System.Drawing.Color.Transparent;
            this.Enums.Controls.Add(this.SeasonGroupBox);
            this.Enums.Controls.Add(this.IntValuesLabel);
            this.Enums.Controls.Add(this.ValuesLBLabel);
            this.Enums.Controls.Add(this.EnumLBLabel);
            this.Enums.Controls.Add(this.IntValues);
            this.Enums.Controls.Add(this.ValuesListBox);
            this.Enums.Controls.Add(this.EnumListBox);
            this.Enums.Controls.Add(this.EnumGroupBox);
            this.Enums.Controls.Add(this.ParsingGroupBox);
            this.Enums.Location = new System.Drawing.Point(4, 22);
            this.Enums.Name = "Enums";
            this.Enums.Padding = new System.Windows.Forms.Padding(3);
            this.Enums.Size = new System.Drawing.Size(896, 531);
            this.Enums.TabIndex = 0;
            this.Enums.Text = "Enums";
            // 
            // IntValuesLabel
            // 
            this.IntValuesLabel.AutoSize = true;
            this.IntValuesLabel.Location = new System.Drawing.Point(369, 25);
            this.IntValuesLabel.Name = "IntValuesLabel";
            this.IntValuesLabel.Size = new System.Drawing.Size(52, 13);
            this.IntValuesLabel.TabIndex = 5;
            this.IntValuesLabel.Text = "Int Value:";
            // 
            // ValuesLBLabel
            // 
            this.ValuesLBLabel.AutoSize = true;
            this.ValuesLBLabel.Location = new System.Drawing.Point(184, 25);
            this.ValuesLBLabel.Name = "ValuesLBLabel";
            this.ValuesLBLabel.Size = new System.Drawing.Size(76, 13);
            this.ValuesLBLabel.TabIndex = 4;
            this.ValuesLBLabel.Text = "Choose Value:";
            // 
            // EnumLBLabel
            // 
            this.EnumLBLabel.AutoSize = true;
            this.EnumLBLabel.Location = new System.Drawing.Point(15, 25);
            this.EnumLBLabel.Name = "EnumLBLabel";
            this.EnumLBLabel.Size = new System.Drawing.Size(113, 13);
            this.EnumLBLabel.TabIndex = 3;
            this.EnumLBLabel.Text = "Choose Enumerations:";
            // 
            // IntValues
            // 
            this.IntValues.Location = new System.Drawing.Point(372, 41);
            this.IntValues.Name = "IntValues";
            this.IntValues.Size = new System.Drawing.Size(100, 20);
            this.IntValues.TabIndex = 2;
            this.IntValues.TextChanged += new System.EventHandler(this.IntValues_TextChanged);
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.Location = new System.Drawing.Point(187, 41);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.Size = new System.Drawing.Size(134, 290);
            this.ValuesListBox.TabIndex = 1;
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // EnumListBox
            // 
            this.EnumListBox.FormattingEnabled = true;
            this.EnumListBox.Location = new System.Drawing.Point(18, 41);
            this.EnumListBox.Name = "EnumListBox";
            this.EnumListBox.Size = new System.Drawing.Size(138, 290);
            this.EnumListBox.TabIndex = 0;
            // 
            // EnumGroupBox
            // 
            this.EnumGroupBox.Location = new System.Drawing.Point(6, 6);
            this.EnumGroupBox.Name = "EnumGroupBox";
            this.EnumGroupBox.Size = new System.Drawing.Size(882, 359);
            this.EnumGroupBox.TabIndex = 6;
            this.EnumGroupBox.TabStop = false;
            this.EnumGroupBox.Text = "Enumerations";
            // 
            // ParsingGroupBox
            // 
            this.ParsingGroupBox.Controls.Add(this.ParsingResult);
            this.ParsingGroupBox.Controls.Add(this.ParsingButton);
            this.ParsingGroupBox.Controls.Add(this.ParsingTextBox);
            this.ParsingGroupBox.Controls.Add(this.ParsingLabel);
            this.ParsingGroupBox.Location = new System.Drawing.Point(7, 372);
            this.ParsingGroupBox.Name = "ParsingGroupBox";
            this.ParsingGroupBox.Size = new System.Drawing.Size(414, 153);
            this.ParsingGroupBox.TabIndex = 7;
            this.ParsingGroupBox.TabStop = false;
            this.ParsingGroupBox.Text = "WeekDay Parsing";
            // 
            // ParsingResult
            // 
            this.ParsingResult.AutoSize = true;
            this.ParsingResult.Location = new System.Drawing.Point(11, 74);
            this.ParsingResult.Name = "ParsingResult";
            this.ParsingResult.Size = new System.Drawing.Size(102, 13);
            this.ParsingResult.TabIndex = 3;
            this.ParsingResult.Text = "Введите значение!";
            // 
            // ParsingButton
            // 
            this.ParsingButton.Location = new System.Drawing.Point(221, 47);
            this.ParsingButton.Name = "ParsingButton";
            this.ParsingButton.Size = new System.Drawing.Size(75, 20);
            this.ParsingButton.TabIndex = 2;
            this.ParsingButton.Text = "Parse";
            this.ParsingButton.UseVisualStyleBackColor = true;
            this.ParsingButton.Click += new System.EventHandler(this.ParsingButton_Click);
            // 
            // ParsingTextBox
            // 
            this.ParsingTextBox.Location = new System.Drawing.Point(11, 47);
            this.ParsingTextBox.Name = "ParsingTextBox";
            this.ParsingTextBox.Size = new System.Drawing.Size(204, 20);
            this.ParsingTextBox.TabIndex = 1;
            // 
            // ParsingLabel
            // 
            this.ParsingLabel.AutoSize = true;
            this.ParsingLabel.Location = new System.Drawing.Point(8, 30);
            this.ParsingLabel.Name = "ParsingLabel";
            this.ParsingLabel.Size = new System.Drawing.Size(116, 13);
            this.ParsingLabel.TabIndex = 0;
            this.ParsingLabel.Text = "Type Value for parsing:\r\n";
            // 
            // SeasonGroupBox
            // 
            this.SeasonGroupBox.Controls.Add(this.SeasonButton);
            this.SeasonGroupBox.Controls.Add(this.SeasonsCBLabel);
            this.SeasonGroupBox.Controls.Add(this.SeasonCombobox);
            this.SeasonGroupBox.Location = new System.Drawing.Point(427, 372);
            this.SeasonGroupBox.Name = "SeasonGroupBox";
            this.SeasonGroupBox.Size = new System.Drawing.Size(461, 153);
            this.SeasonGroupBox.TabIndex = 8;
            this.SeasonGroupBox.TabStop = false;
            this.SeasonGroupBox.Text = "Season Handle";
            // 
            // SeasonCombobox
            // 
            this.SeasonCombobox.FormattingEnabled = true;
            this.SeasonCombobox.Location = new System.Drawing.Point(22, 36);
            this.SeasonCombobox.Name = "SeasonCombobox";
            this.SeasonCombobox.Size = new System.Drawing.Size(176, 21);
            this.SeasonCombobox.TabIndex = 0;
            // 
            // SeasonsCBLabel
            // 
            this.SeasonsCBLabel.AutoSize = true;
            this.SeasonsCBLabel.Location = new System.Drawing.Point(19, 20);
            this.SeasonsCBLabel.Name = "SeasonsCBLabel";
            this.SeasonsCBLabel.Size = new System.Drawing.Size(82, 13);
            this.SeasonsCBLabel.TabIndex = 1;
            this.SeasonsCBLabel.Text = "Choose Season";
            // 
            // SeasonButton
            // 
            this.SeasonButton.Location = new System.Drawing.Point(204, 36);
            this.SeasonButton.Name = "SeasonButton";
            this.SeasonButton.Size = new System.Drawing.Size(75, 21);
            this.SeasonButton.TabIndex = 2;
            this.SeasonButton.Text = "Go!";
            this.SeasonButton.UseVisualStyleBackColor = true;
            this.SeasonButton.Click += new System.EventHandler(this.SeasonButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 557);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.Enums.ResumeLayout(false);
            this.Enums.PerformLayout();
            this.ParsingGroupBox.ResumeLayout(false);
            this.ParsingGroupBox.PerformLayout();
            this.SeasonGroupBox.ResumeLayout(false);
            this.SeasonGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage Enums;
        private System.Windows.Forms.TextBox IntValues;
        private System.Windows.Forms.ListBox ValuesListBox;
        private System.Windows.Forms.ListBox EnumListBox;
        private System.Windows.Forms.Label IntValuesLabel;
        private System.Windows.Forms.Label ValuesLBLabel;
        private System.Windows.Forms.Label EnumLBLabel;
        private System.Windows.Forms.GroupBox EnumGroupBox;
        private System.Windows.Forms.GroupBox ParsingGroupBox;
        private System.Windows.Forms.Label ParsingResult;
        private System.Windows.Forms.Button ParsingButton;
        private System.Windows.Forms.TextBox ParsingTextBox;
        private System.Windows.Forms.Label ParsingLabel;
        private System.Windows.Forms.GroupBox SeasonGroupBox;
        private System.Windows.Forms.Button SeasonButton;
        private System.Windows.Forms.Label SeasonsCBLabel;
        private System.Windows.Forms.ComboBox SeasonCombobox;
    }
}

