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
            this.Enum = new System.Windows.Forms.TabPage();
            this.IntValues = new System.Windows.Forms.TextBox();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.EnumListBox = new System.Windows.Forms.ListBox();
            this.tabControl.SuspendLayout();
            this.Enum.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.Enum);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(800, 450);
            this.tabControl.TabIndex = 0;
            // 
            // Enum
            // 
            this.Enum.Controls.Add(this.IntValues);
            this.Enum.Controls.Add(this.ValuesListBox);
            this.Enum.Controls.Add(this.EnumListBox);
            this.Enum.Location = new System.Drawing.Point(4, 22);
            this.Enum.Name = "Enum";
            this.Enum.Padding = new System.Windows.Forms.Padding(3);
            this.Enum.Size = new System.Drawing.Size(792, 424);
            this.Enum.TabIndex = 0;
            this.Enum.Text = "Enums";
            this.Enum.UseVisualStyleBackColor = true;
            // 
            // IntValues
            // 
            this.IntValues.Location = new System.Drawing.Point(360, 43);
            this.IntValues.Name = "IntValues";
            this.IntValues.Size = new System.Drawing.Size(100, 20);
            this.IntValues.TabIndex = 2;
            this.IntValues.TextChanged += new System.EventHandler(this.IntValues_TextChanged);
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.Location = new System.Drawing.Point(175, 43);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.Size = new System.Drawing.Size(134, 290);
            this.ValuesListBox.TabIndex = 1;
            // 
            // EnumListBox
            // 
            this.EnumListBox.FormattingEnabled = true;
            this.EnumListBox.Location = new System.Drawing.Point(6, 43);
            this.EnumListBox.Name = "EnumListBox";
            this.EnumListBox.Size = new System.Drawing.Size(138, 290);
            this.EnumListBox.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.Enum.ResumeLayout(false);
            this.Enum.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage Enum;
        private System.Windows.Forms.TextBox IntValues;
        private System.Windows.Forms.ListBox ValuesListBox;
        private System.Windows.Forms.ListBox EnumListBox;
    }
}

