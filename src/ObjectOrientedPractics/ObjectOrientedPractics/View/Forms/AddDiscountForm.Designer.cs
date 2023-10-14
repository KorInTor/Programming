namespace ObjectOrientedPractics.View.Forms
{
    partial class AddDiscountForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDiscountForm));
            PercentDiscountLabel = new Label();
            CategoryLabel = new Label();
            CategoryComboBox = new ComboBox();
            CancelButton = new Button();
            ConfirmButton = new Button();
            SuspendLayout();
            // 
            // PercentDiscountLabel
            // 
            PercentDiscountLabel.AutoSize = true;
            PercentDiscountLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PercentDiscountLabel.Location = new Point(12, 12);
            PercentDiscountLabel.Margin = new Padding(3);
            PercentDiscountLabel.Name = "PercentDiscountLabel";
            PercentDiscountLabel.Padding = new Padding(3);
            PercentDiscountLabel.Size = new Size(115, 21);
            PercentDiscountLabel.TabIndex = 0;
            PercentDiscountLabel.Text = "Percent Discount :";
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Location = new Point(12, 39);
            CategoryLabel.Margin = new Padding(3);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Padding = new Padding(3);
            CategoryLabel.Size = new Size(67, 21);
            CategoryLabel.TabIndex = 1;
            CategoryLabel.Text = "Category: ";
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(85, 39);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(199, 23);
            CategoryComboBox.TabIndex = 2;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(195, 85);
            CancelButton.Name = "CancelButton";
            CancelButton.Padding = new Padding(3);
            CancelButton.Size = new Size(89, 38);
            CancelButton.TabIndex = 4;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // ConfirmButton
            // 
            ConfirmButton.Location = new Point(100, 85);
            ConfirmButton.Name = "ConfirmButton";
            ConfirmButton.Padding = new Padding(3);
            ConfirmButton.Size = new Size(89, 38);
            ConfirmButton.TabIndex = 5;
            ConfirmButton.Text = "Ok";
            ConfirmButton.UseVisualStyleBackColor = true;
            ConfirmButton.Click += ConfirmButton_Click_1;
            // 
            // AddDiscountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(296, 135);
            Controls.Add(ConfirmButton);
            Controls.Add(CancelButton);
            Controls.Add(CategoryComboBox);
            Controls.Add(CategoryLabel);
            Controls.Add(PercentDiscountLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddDiscountForm";
            Text = "Add Discount";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PercentDiscountLabel;
        private Label CategoryLabel;
        private ComboBox CategoryComboBox;
        private Button CancelButton;
        private Button ConfirmButton;
    }
}