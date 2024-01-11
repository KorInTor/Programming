namespace Programming.View
{
    partial class SeasonHandleControl
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
            this.SeasonHandlerGroupBox = new System.Windows.Forms.GroupBox();
            this.SeasonsComboBox = new System.Windows.Forms.ComboBox();
            this.SeasonHandlerButton = new System.Windows.Forms.Button();
            this.SeasonComboBoxLabel = new System.Windows.Forms.Label();
            this.SeasonHandlerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SeasonHandlerGroupBox
            // 
            this.SeasonHandlerGroupBox.Controls.Add(this.SeasonsComboBox);
            this.SeasonHandlerGroupBox.Controls.Add(this.SeasonHandlerButton);
            this.SeasonHandlerGroupBox.Controls.Add(this.SeasonComboBoxLabel);
            this.SeasonHandlerGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SeasonHandlerGroupBox.Location = new System.Drawing.Point(0, 0);
            this.SeasonHandlerGroupBox.Name = "SeasonHandlerGroupBox";
            this.SeasonHandlerGroupBox.Size = new System.Drawing.Size(341, 163);
            this.SeasonHandlerGroupBox.TabIndex = 6;
            this.SeasonHandlerGroupBox.TabStop = false;
            this.SeasonHandlerGroupBox.Text = "Season Handle";
            // 
            // SeasonsComboBox
            // 
            this.SeasonsComboBox.FormattingEnabled = true;
            this.SeasonsComboBox.Location = new System.Drawing.Point(6, 45);
            this.SeasonsComboBox.Name = "SeasonsComboBox";
            this.SeasonsComboBox.Size = new System.Drawing.Size(121, 21);
            this.SeasonsComboBox.TabIndex = 2;
            // 
            // SeasonHandlerButton
            // 
            this.SeasonHandlerButton.Location = new System.Drawing.Point(133, 45);
            this.SeasonHandlerButton.Name = "SeasonHandlerButton";
            this.SeasonHandlerButton.Size = new System.Drawing.Size(75, 21);
            this.SeasonHandlerButton.TabIndex = 1;
            this.SeasonHandlerButton.Text = "Go!";
            this.SeasonHandlerButton.UseVisualStyleBackColor = true;
            this.SeasonHandlerButton.Click += new System.EventHandler(this.SeasonHandlerButton_Click);
            // 
            // SeasonComboBoxLabel
            // 
            this.SeasonComboBoxLabel.AutoSize = true;
            this.SeasonComboBoxLabel.Location = new System.Drawing.Point(6, 29);
            this.SeasonComboBoxLabel.Name = "SeasonComboBoxLabel";
            this.SeasonComboBoxLabel.Size = new System.Drawing.Size(85, 13);
            this.SeasonComboBoxLabel.TabIndex = 0;
            this.SeasonComboBoxLabel.Text = "Choose Season:";
            // 
            // SeasonHandleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SeasonHandlerGroupBox);
            this.Name = "SeasonHandleControl";
            this.Size = new System.Drawing.Size(341, 163);
            this.SeasonHandlerGroupBox.ResumeLayout(false);
            this.SeasonHandlerGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SeasonHandlerGroupBox;
        private System.Windows.Forms.ComboBox SeasonsComboBox;
        private System.Windows.Forms.Button SeasonHandlerButton;
        private System.Windows.Forms.Label SeasonComboBoxLabel;
    }
}
