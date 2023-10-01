namespace ObjectOrientedPractics.View.Tabs.Controls
{
    partial class AddressControl
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
            AddresHeadLabel = new Label();
            PostIndexLabel = new Label();
            IndexTextBox = new TextBox();
            CountryTextBox = new TextBox();
            CountryLabel = new Label();
            CityTextBox = new TextBox();
            CityLabel = new Label();
            StreetTextBox = new TextBox();
            StreetLabel = new Label();
            ApartmentTextBox = new TextBox();
            ApartmentLabel = new Label();
            BuildingTextBox = new TextBox();
            BuildingLabel = new Label();
            SuspendLayout();
            // 
            // AddresHeadLabel
            // 
            AddresHeadLabel.AutoSize = true;
            AddresHeadLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            AddresHeadLabel.Location = new Point(3, 3);
            AddresHeadLabel.Margin = new Padding(3);
            AddresHeadLabel.Name = "AddresHeadLabel";
            AddresHeadLabel.Size = new Size(104, 15);
            AddresHeadLabel.TabIndex = 0;
            AddresHeadLabel.Text = "Delivery Address:";
            // 
            // PostIndexLabel
            // 
            PostIndexLabel.AutoSize = true;
            PostIndexLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PostIndexLabel.Location = new Point(3, 27);
            PostIndexLabel.Margin = new Padding(3);
            PostIndexLabel.Name = "PostIndexLabel";
            PostIndexLabel.Size = new Size(64, 15);
            PostIndexLabel.TabIndex = 1;
            PostIndexLabel.Text = "Post Index:";
            // 
            // IndexTextBox
            // 
            IndexTextBox.Location = new Point(73, 24);
            IndexTextBox.Name = "IndexTextBox";
            IndexTextBox.Size = new Size(100, 23);
            IndexTextBox.TabIndex = 2;
            IndexTextBox.TextChanged += IndexTextBox_TextChanged;
            // 
            // CountryTextBox
            // 
            CountryTextBox.Location = new Point(73, 53);
            CountryTextBox.Name = "CountryTextBox";
            CountryTextBox.Size = new Size(174, 23);
            CountryTextBox.TabIndex = 4;
            CountryTextBox.TextChanged += CountryTextBox_TextChanged;
            // 
            // CountryLabel
            // 
            CountryLabel.AutoSize = true;
            CountryLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CountryLabel.Location = new Point(3, 56);
            CountryLabel.Margin = new Padding(3);
            CountryLabel.Name = "CountryLabel";
            CountryLabel.Size = new Size(53, 15);
            CountryLabel.TabIndex = 3;
            CountryLabel.Text = "Country:";
            // 
            // CityTextBox
            // 
            CityTextBox.Location = new Point(302, 53);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(155, 23);
            CityTextBox.TabIndex = 6;
            CityTextBox.TextChanged += CityTextBox_TextChanged;
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CityLabel.Location = new Point(265, 56);
            CityLabel.Margin = new Padding(3);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(31, 15);
            CityLabel.TabIndex = 5;
            CityLabel.Text = "City:";
            // 
            // StreetTextBox
            // 
            StreetTextBox.Location = new Point(73, 82);
            StreetTextBox.Name = "StreetTextBox";
            StreetTextBox.Size = new Size(384, 23);
            StreetTextBox.TabIndex = 8;
            StreetTextBox.TextChanged += StreetTextBox_TextChanged;
            // 
            // StreetLabel
            // 
            StreetLabel.AutoSize = true;
            StreetLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            StreetLabel.Location = new Point(3, 85);
            StreetLabel.Margin = new Padding(3);
            StreetLabel.Name = "StreetLabel";
            StreetLabel.Size = new Size(40, 15);
            StreetLabel.TabIndex = 7;
            StreetLabel.Text = "Street:";
            // 
            // ApartmentTextBox
            // 
            ApartmentTextBox.Location = new Point(276, 111);
            ApartmentTextBox.Name = "ApartmentTextBox";
            ApartmentTextBox.Size = new Size(87, 23);
            ApartmentTextBox.TabIndex = 12;
            ApartmentTextBox.TextChanged += ApartmentTextBox_TextChanged;
            // 
            // ApartmentLabel
            // 
            ApartmentLabel.AutoSize = true;
            ApartmentLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ApartmentLabel.Location = new Point(203, 114);
            ApartmentLabel.Margin = new Padding(3);
            ApartmentLabel.Name = "ApartmentLabel";
            ApartmentLabel.Size = new Size(67, 15);
            ApartmentLabel.TabIndex = 11;
            ApartmentLabel.Text = "Apartment:";
            // 
            // BuildingTextBox
            // 
            BuildingTextBox.Location = new Point(73, 111);
            BuildingTextBox.Name = "BuildingTextBox";
            BuildingTextBox.Size = new Size(100, 23);
            BuildingTextBox.TabIndex = 10;
            BuildingTextBox.TextChanged += BuildingTextBox_TextChanged;
            // 
            // BuildingLabel
            // 
            BuildingLabel.AutoSize = true;
            BuildingLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BuildingLabel.Location = new Point(3, 114);
            BuildingLabel.Margin = new Padding(3);
            BuildingLabel.Name = "BuildingLabel";
            BuildingLabel.Size = new Size(54, 15);
            BuildingLabel.TabIndex = 9;
            BuildingLabel.Text = "Building:";
            // 
            // AddressControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ApartmentTextBox);
            Controls.Add(ApartmentLabel);
            Controls.Add(BuildingTextBox);
            Controls.Add(BuildingLabel);
            Controls.Add(StreetTextBox);
            Controls.Add(StreetLabel);
            Controls.Add(CityTextBox);
            Controls.Add(CityLabel);
            Controls.Add(CountryTextBox);
            Controls.Add(CountryLabel);
            Controls.Add(IndexTextBox);
            Controls.Add(PostIndexLabel);
            Controls.Add(AddresHeadLabel);
            Name = "AddressControl";
            Size = new Size(481, 382);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AddresHeadLabel;
        private Label PostIndexLabel;
        private TextBox IndexTextBox;
        private TextBox CountryTextBox;
        private Label CountryLabel;
        private TextBox CityTextBox;
        private Label CityLabel;
        private TextBox StreetTextBox;
        private Label StreetLabel;
        private TextBox ApartmentTextBox;
        private Label ApartmentLabel;
        private TextBox BuildingTextBox;
        private Label BuildingLabel;
    }
}
