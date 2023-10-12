namespace ObjectOrientedPractics.View.Tabs
{
    partial class PercentDiscountsTab
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
            FinalDiscountAmountLabel = new Label();
            DiscountAmountLabel = new Label();
            FinalAmountLabel = new Label();
            AmountLabel = new Label();
            UpdateButton = new Button();
            ApplyButton = new Button();
            CalculateButton = new Button();
            PointsInfoLabel = new Label();
            SuspendLayout();
            // 
            // FinalDiscountAmountLabel
            // 
            FinalDiscountAmountLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            FinalDiscountAmountLabel.AutoSize = true;
            FinalDiscountAmountLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            FinalDiscountAmountLabel.Location = new Point(514, 87);
            FinalDiscountAmountLabel.Name = "FinalDiscountAmountLabel";
            FinalDiscountAmountLabel.Size = new Size(88, 25);
            FinalDiscountAmountLabel.TabIndex = 33;
            FinalDiscountAmountLabel.Text = "4 990,90";
            // 
            // DiscountAmountLabel
            // 
            DiscountAmountLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            DiscountAmountLabel.AutoSize = true;
            DiscountAmountLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DiscountAmountLabel.Location = new Point(492, 63);
            DiscountAmountLabel.Margin = new Padding(3);
            DiscountAmountLabel.Name = "DiscountAmountLabel";
            DiscountAmountLabel.Padding = new Padding(3);
            DiscountAmountLabel.Size = new Size(113, 21);
            DiscountAmountLabel.TabIndex = 32;
            DiscountAmountLabel.Text = "Discount Amount:";
            // 
            // FinalAmountLabel
            // 
            FinalAmountLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            FinalAmountLabel.AutoSize = true;
            FinalAmountLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            FinalAmountLabel.Location = new Point(514, 35);
            FinalAmountLabel.Name = "FinalAmountLabel";
            FinalAmountLabel.Size = new Size(88, 25);
            FinalAmountLabel.TabIndex = 31;
            FinalAmountLabel.Text = "4 990,90";
            // 
            // AmountLabel
            // 
            AmountLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AmountLabel.AutoSize = true;
            AmountLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            AmountLabel.Location = new Point(541, 11);
            AmountLabel.Margin = new Padding(3);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Padding = new Padding(3);
            AmountLabel.Size = new Size(61, 21);
            AmountLabel.TabIndex = 30;
            AmountLabel.Text = "Amount:";
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(216, 36);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(95, 53);
            UpdateButton.TabIndex = 29;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // ApplyButton
            // 
            ApplyButton.Location = new Point(115, 36);
            ApplyButton.Name = "ApplyButton";
            ApplyButton.Size = new Size(95, 53);
            ApplyButton.TabIndex = 28;
            ApplyButton.Text = "Apply";
            ApplyButton.UseVisualStyleBackColor = true;
            ApplyButton.Click += ApplyButton_Click;
            // 
            // CalculateButton
            // 
            CalculateButton.Location = new Point(14, 36);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(95, 53);
            CalculateButton.TabIndex = 27;
            CalculateButton.Text = "Calculate";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // PointsInfoLabel
            // 
            PointsInfoLabel.AutoSize = true;
            PointsInfoLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PointsInfoLabel.Location = new Point(41, 18);
            PointsInfoLabel.Name = "PointsInfoLabel";
            PointsInfoLabel.Size = new Size(36, 15);
            PointsInfoLabel.TabIndex = 26;
            PointsInfoLabel.Text = "Info: ";
            // 
            // PercentDiscountsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(FinalDiscountAmountLabel);
            Controls.Add(DiscountAmountLabel);
            Controls.Add(FinalAmountLabel);
            Controls.Add(AmountLabel);
            Controls.Add(UpdateButton);
            Controls.Add(ApplyButton);
            Controls.Add(CalculateButton);
            Controls.Add(PointsInfoLabel);
            Name = "PercentDiscountsTab";
            Size = new Size(605, 113);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FinalDiscountAmountLabel;
        private Label DiscountAmountLabel;
        private Label FinalAmountLabel;
        private Label AmountLabel;
        private Button UpdateButton;
        private Button ApplyButton;
        private Button CalculateButton;
        private Label PointsInfoLabel;
    }
}
