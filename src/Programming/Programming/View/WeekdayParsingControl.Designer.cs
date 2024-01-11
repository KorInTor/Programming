namespace Programming.View
{
    partial class WeekdayParsingControl
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
            this.WeekdayParsingGroupBox = new System.Windows.Forms.GroupBox();
            this.ParsingResultLabel = new System.Windows.Forms.Label();
            this.WeekdayParsingButton = new System.Windows.Forms.Button();
            this.WeekdayParsingTextBox = new System.Windows.Forms.TextBox();
            this.WeekdayParsingLabel = new System.Windows.Forms.Label();
            this.WeekdayParsingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // WeekdayParsingGroupBox
            // 
            this.WeekdayParsingGroupBox.Controls.Add(this.ParsingResultLabel);
            this.WeekdayParsingGroupBox.Controls.Add(this.WeekdayParsingButton);
            this.WeekdayParsingGroupBox.Controls.Add(this.WeekdayParsingTextBox);
            this.WeekdayParsingGroupBox.Controls.Add(this.WeekdayParsingLabel);
            this.WeekdayParsingGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WeekdayParsingGroupBox.Location = new System.Drawing.Point(0, 0);
            this.WeekdayParsingGroupBox.Name = "WeekdayParsingGroupBox";
            this.WeekdayParsingGroupBox.Size = new System.Drawing.Size(357, 163);
            this.WeekdayParsingGroupBox.TabIndex = 5;
            this.WeekdayParsingGroupBox.TabStop = false;
            this.WeekdayParsingGroupBox.Text = "WeekdayParsing";
            // 
            // ParsingResultLabel
            // 
            this.ParsingResultLabel.AutoSize = true;
            this.ParsingResultLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ParsingResultLabel.Location = new System.Drawing.Point(10, 68);
            this.ParsingResultLabel.Name = "ParsingResultLabel";
            this.ParsingResultLabel.Size = new System.Drawing.Size(123, 13);
            this.ParsingResultLabel.TabIndex = 4;
            this.ParsingResultLabel.Text = "Введите День Недели!";
            // 
            // WeekdayParsingButton
            // 
            this.WeekdayParsingButton.Location = new System.Drawing.Point(199, 45);
            this.WeekdayParsingButton.Name = "WeekdayParsingButton";
            this.WeekdayParsingButton.Size = new System.Drawing.Size(75, 20);
            this.WeekdayParsingButton.TabIndex = 3;
            this.WeekdayParsingButton.Text = "Parse";
            this.WeekdayParsingButton.UseVisualStyleBackColor = true;
            this.WeekdayParsingButton.Click += new System.EventHandler(this.WeekdayParsingButton_Click);
            // 
            // WeekdayParsingTextBox
            // 
            this.WeekdayParsingTextBox.Location = new System.Drawing.Point(9, 45);
            this.WeekdayParsingTextBox.Name = "WeekdayParsingTextBox";
            this.WeekdayParsingTextBox.Size = new System.Drawing.Size(184, 20);
            this.WeekdayParsingTextBox.TabIndex = 1;
            // 
            // WeekdayParsingLabel
            // 
            this.WeekdayParsingLabel.AutoSize = true;
            this.WeekdayParsingLabel.Location = new System.Drawing.Point(6, 29);
            this.WeekdayParsingLabel.Name = "WeekdayParsingLabel";
            this.WeekdayParsingLabel.Size = new System.Drawing.Size(133, 13);
            this.WeekdayParsingLabel.TabIndex = 0;
            this.WeekdayParsingLabel.Text = "Type Weekday for Parsing";
            // 
            // WeekdayParsingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.WeekdayParsingGroupBox);
            this.Name = "WeekdayParsingControl";
            this.Size = new System.Drawing.Size(357, 163);
            this.WeekdayParsingGroupBox.ResumeLayout(false);
            this.WeekdayParsingGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox WeekdayParsingGroupBox;
        private System.Windows.Forms.Label ParsingResultLabel;
        private System.Windows.Forms.Button WeekdayParsingButton;
        private System.Windows.Forms.TextBox WeekdayParsingTextBox;
        private System.Windows.Forms.Label WeekdayParsingLabel;
    }
}
