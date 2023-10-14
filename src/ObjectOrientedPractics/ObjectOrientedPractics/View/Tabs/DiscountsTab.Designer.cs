namespace ObjectOrientedPractics.View.Tabs
{
    partial class DiscountsTab
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
            PointsInfoLabel = new Label();
            CalculateButton = new Button();
            ApplyButton = new Button();
            UpdateButton = new Button();
            FinalAmountLabel = new Label();
            AmountLabel = new Label();
            FinalDiscountAmountLabel = new Label();
            DiscountAmountLabel = new Label();
            SuspendLayout();
            // 
            // PointsInfoLabel
            // 
            PointsInfoLabel.AutoSize = true;
            PointsInfoLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PointsInfoLabel.Location = new Point(30, 22);
            PointsInfoLabel.Name = "PointsInfoLabel";
            PointsInfoLabel.Size = new Size(36, 15);
            PointsInfoLabel.TabIndex = 0;
            PointsInfoLabel.Text = "Info: ";
            // 
            // CalculateButton
            // 
            CalculateButton.Location = new Point(3, 40);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(95, 53);
            CalculateButton.TabIndex = 1;
            CalculateButton.Text = "Calculate";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // ApplyButton
            // 
            ApplyButton.Location = new Point(104, 40);
            ApplyButton.Name = "ApplyButton";
            ApplyButton.Size = new Size(95, 53);
            ApplyButton.TabIndex = 2;
            ApplyButton.Text = "Apply";
            ApplyButton.UseVisualStyleBackColor = true;
            ApplyButton.Click += ApplyButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(205, 40);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(95, 53);
            UpdateButton.TabIndex = 3;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // FinalAmountLabel
            // 
            FinalAmountLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            FinalAmountLabel.AutoSize = true;
            FinalAmountLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            FinalAmountLabel.Location = new Point(426, 28);
            FinalAmountLabel.Name = "FinalAmountLabel";
            FinalAmountLabel.Size = new Size(88, 25);
            FinalAmountLabel.TabIndex = 23;
            FinalAmountLabel.Text = "4 990,90";
            // 
            // AmountLabel
            // 
            AmountLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AmountLabel.AutoSize = true;
            AmountLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            AmountLabel.Location = new Point(453, 4);
            AmountLabel.Margin = new Padding(3);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Padding = new Padding(3);
            AmountLabel.Size = new Size(61, 21);
            AmountLabel.TabIndex = 22;
            AmountLabel.Text = "Amount:";
            // 
            // FinalDiscountAmountLabel
            // 
            FinalDiscountAmountLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            FinalDiscountAmountLabel.AutoSize = true;
            FinalDiscountAmountLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            FinalDiscountAmountLabel.Location = new Point(426, 80);
            FinalDiscountAmountLabel.Name = "FinalDiscountAmountLabel";
            FinalDiscountAmountLabel.Size = new Size(88, 25);
            FinalDiscountAmountLabel.TabIndex = 25;
            FinalDiscountAmountLabel.Text = "4 990,90";
            // 
            // DiscountAmountLabel
            // 
            DiscountAmountLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            DiscountAmountLabel.AutoSize = true;
            DiscountAmountLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DiscountAmountLabel.Location = new Point(404, 56);
            DiscountAmountLabel.Margin = new Padding(3);
            DiscountAmountLabel.Name = "DiscountAmountLabel";
            DiscountAmountLabel.Padding = new Padding(3);
            DiscountAmountLabel.Size = new Size(113, 21);
            DiscountAmountLabel.TabIndex = 24;
            DiscountAmountLabel.Text = "Discount Amount:";
            // 
            // DiscountsTab
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
            Name = "DiscountsTab";
            Size = new Size(517, 112);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PointsInfoLabel;
        private Button CalculateButton;
        private Button ApplyButton;
        private Button UpdateButton;
        private Label FinalAmountLabel;
        private Label AmountLabel;
        private Label FinalDiscountAmountLabel;
        private Label DiscountAmountLabel;
    }
}
