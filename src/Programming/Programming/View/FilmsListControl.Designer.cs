namespace Programming.View
{
    partial class FilmsListControl
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
            this.FilmsGroupBox = new System.Windows.Forms.GroupBox();
            this.FilmsRatingTextBox = new System.Windows.Forms.TextBox();
            this.FilmsRatingLabel = new System.Windows.Forms.Label();
            this.FilmsGenreTextBox = new System.Windows.Forms.TextBox();
            this.FilmsGenreLabel = new System.Windows.Forms.Label();
            this.FilmsFindMaxRatingButton = new System.Windows.Forms.Button();
            this.FilmsYearOfReleaseTextBox = new System.Windows.Forms.TextBox();
            this.FilmsYearOfReleaseLabel = new System.Windows.Forms.Label();
            this.FilmsDurationTextBox = new System.Windows.Forms.TextBox();
            this.FilmsDurationLabel = new System.Windows.Forms.Label();
            this.FilmsTitleTextBox = new System.Windows.Forms.TextBox();
            this.FilmsListBox = new System.Windows.Forms.ListBox();
            this.FilmsTitleLabel = new System.Windows.Forms.Label();
            this.FilmsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // FilmsGroupBox
            // 
            this.FilmsGroupBox.Controls.Add(this.FilmsRatingTextBox);
            this.FilmsGroupBox.Controls.Add(this.FilmsRatingLabel);
            this.FilmsGroupBox.Controls.Add(this.FilmsGenreTextBox);
            this.FilmsGroupBox.Controls.Add(this.FilmsGenreLabel);
            this.FilmsGroupBox.Controls.Add(this.FilmsFindMaxRatingButton);
            this.FilmsGroupBox.Controls.Add(this.FilmsYearOfReleaseTextBox);
            this.FilmsGroupBox.Controls.Add(this.FilmsYearOfReleaseLabel);
            this.FilmsGroupBox.Controls.Add(this.FilmsDurationTextBox);
            this.FilmsGroupBox.Controls.Add(this.FilmsDurationLabel);
            this.FilmsGroupBox.Controls.Add(this.FilmsTitleTextBox);
            this.FilmsGroupBox.Controls.Add(this.FilmsListBox);
            this.FilmsGroupBox.Controls.Add(this.FilmsTitleLabel);
            this.FilmsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilmsGroupBox.Location = new System.Drawing.Point(0, 0);
            this.FilmsGroupBox.Name = "FilmsGroupBox";
            this.FilmsGroupBox.Size = new System.Drawing.Size(361, 297);
            this.FilmsGroupBox.TabIndex = 10;
            this.FilmsGroupBox.TabStop = false;
            this.FilmsGroupBox.Text = "Films";
            // 
            // FilmsRatingTextBox
            // 
            this.FilmsRatingTextBox.Location = new System.Drawing.Point(131, 191);
            this.FilmsRatingTextBox.Name = "FilmsRatingTextBox";
            this.FilmsRatingTextBox.Size = new System.Drawing.Size(100, 20);
            this.FilmsRatingTextBox.TabIndex = 12;
            this.FilmsRatingTextBox.TextChanged += new System.EventHandler(this.FilmsRatingTextBox_TextChanged);
            // 
            // FilmsRatingLabel
            // 
            this.FilmsRatingLabel.AutoSize = true;
            this.FilmsRatingLabel.Location = new System.Drawing.Point(131, 175);
            this.FilmsRatingLabel.Name = "FilmsRatingLabel";
            this.FilmsRatingLabel.Size = new System.Drawing.Size(38, 13);
            this.FilmsRatingLabel.TabIndex = 11;
            this.FilmsRatingLabel.Text = "Rating";
            // 
            // FilmsGenreTextBox
            // 
            this.FilmsGenreTextBox.Location = new System.Drawing.Point(131, 152);
            this.FilmsGenreTextBox.Name = "FilmsGenreTextBox";
            this.FilmsGenreTextBox.Size = new System.Drawing.Size(100, 20);
            this.FilmsGenreTextBox.TabIndex = 10;
            this.FilmsGenreTextBox.TextChanged += new System.EventHandler(this.FilmsGenreTextBox_TextChanged);
            // 
            // FilmsGenreLabel
            // 
            this.FilmsGenreLabel.AutoSize = true;
            this.FilmsGenreLabel.Location = new System.Drawing.Point(131, 136);
            this.FilmsGenreLabel.Name = "FilmsGenreLabel";
            this.FilmsGenreLabel.Size = new System.Drawing.Size(36, 13);
            this.FilmsGenreLabel.TabIndex = 9;
            this.FilmsGenreLabel.Text = "Genre";
            // 
            // FilmsFindMaxRatingButton
            // 
            this.FilmsFindMaxRatingButton.Location = new System.Drawing.Point(131, 260);
            this.FilmsFindMaxRatingButton.Name = "FilmsFindMaxRatingButton";
            this.FilmsFindMaxRatingButton.Size = new System.Drawing.Size(100, 23);
            this.FilmsFindMaxRatingButton.TabIndex = 8;
            this.FilmsFindMaxRatingButton.Text = "Find";
            this.FilmsFindMaxRatingButton.UseVisualStyleBackColor = true;
            this.FilmsFindMaxRatingButton.Click += new System.EventHandler(this.FilmsFindMaxRatingButton_Click);
            // 
            // FilmsYearOfReleaseTextBox
            // 
            this.FilmsYearOfReleaseTextBox.Location = new System.Drawing.Point(131, 113);
            this.FilmsYearOfReleaseTextBox.Name = "FilmsYearOfReleaseTextBox";
            this.FilmsYearOfReleaseTextBox.Size = new System.Drawing.Size(100, 20);
            this.FilmsYearOfReleaseTextBox.TabIndex = 7;
            this.FilmsYearOfReleaseTextBox.TextChanged += new System.EventHandler(this.FilmsYearOfReleaseTextBox_TextChanged);
            // 
            // FilmsYearOfReleaseLabel
            // 
            this.FilmsYearOfReleaseLabel.AutoSize = true;
            this.FilmsYearOfReleaseLabel.Location = new System.Drawing.Point(131, 97);
            this.FilmsYearOfReleaseLabel.Name = "FilmsYearOfReleaseLabel";
            this.FilmsYearOfReleaseLabel.Size = new System.Drawing.Size(83, 13);
            this.FilmsYearOfReleaseLabel.TabIndex = 6;
            this.FilmsYearOfReleaseLabel.Text = "Year of Release";
            // 
            // FilmsDurationTextBox
            // 
            this.FilmsDurationTextBox.Location = new System.Drawing.Point(131, 74);
            this.FilmsDurationTextBox.Name = "FilmsDurationTextBox";
            this.FilmsDurationTextBox.Size = new System.Drawing.Size(100, 20);
            this.FilmsDurationTextBox.TabIndex = 5;
            this.FilmsDurationTextBox.TextChanged += new System.EventHandler(this.FilmsDurationTextBox_TextChanged);
            // 
            // FilmsDurationLabel
            // 
            this.FilmsDurationLabel.AutoSize = true;
            this.FilmsDurationLabel.Location = new System.Drawing.Point(131, 58);
            this.FilmsDurationLabel.Name = "FilmsDurationLabel";
            this.FilmsDurationLabel.Size = new System.Drawing.Size(102, 13);
            this.FilmsDurationLabel.TabIndex = 4;
            this.FilmsDurationLabel.Text = "Duration(In Minutes)";
            // 
            // FilmsTitleTextBox
            // 
            this.FilmsTitleTextBox.Location = new System.Drawing.Point(131, 35);
            this.FilmsTitleTextBox.Name = "FilmsTitleTextBox";
            this.FilmsTitleTextBox.Size = new System.Drawing.Size(100, 20);
            this.FilmsTitleTextBox.TabIndex = 3;
            this.FilmsTitleTextBox.TextChanged += new System.EventHandler(this.FilmsTitleTextBox_TextChanged);
            // 
            // FilmsListBox
            // 
            this.FilmsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.FilmsListBox.FormattingEnabled = true;
            this.FilmsListBox.IntegralHeight = false;
            this.FilmsListBox.Items.AddRange(new object[] {
            "Film 1",
            "Film 2",
            "Film 3",
            "Film 4",
            "Film 5"});
            this.FilmsListBox.Location = new System.Drawing.Point(5, 19);
            this.FilmsListBox.Name = "FilmsListBox";
            this.FilmsListBox.Size = new System.Drawing.Size(120, 264);
            this.FilmsListBox.TabIndex = 0;
            this.FilmsListBox.SelectedIndexChanged += new System.EventHandler(this.FilmsListBox_SelectedIndexChanged);
            // 
            // FilmsTitleLabel
            // 
            this.FilmsTitleLabel.AutoSize = true;
            this.FilmsTitleLabel.Location = new System.Drawing.Point(131, 19);
            this.FilmsTitleLabel.Name = "FilmsTitleLabel";
            this.FilmsTitleLabel.Size = new System.Drawing.Size(27, 13);
            this.FilmsTitleLabel.TabIndex = 2;
            this.FilmsTitleLabel.Text = "Title";
            // 
            // FilmsListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FilmsGroupBox);
            this.Name = "FilmsListControl";
            this.Size = new System.Drawing.Size(361, 297);
            this.FilmsGroupBox.ResumeLayout(false);
            this.FilmsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox FilmsGroupBox;
        private System.Windows.Forms.TextBox FilmsRatingTextBox;
        private System.Windows.Forms.Label FilmsRatingLabel;
        private System.Windows.Forms.TextBox FilmsGenreTextBox;
        private System.Windows.Forms.Label FilmsGenreLabel;
        private System.Windows.Forms.Button FilmsFindMaxRatingButton;
        private System.Windows.Forms.TextBox FilmsYearOfReleaseTextBox;
        private System.Windows.Forms.Label FilmsYearOfReleaseLabel;
        private System.Windows.Forms.TextBox FilmsDurationTextBox;
        private System.Windows.Forms.Label FilmsDurationLabel;
        private System.Windows.Forms.TextBox FilmsTitleTextBox;
        private System.Windows.Forms.ListBox FilmsListBox;
        private System.Windows.Forms.Label FilmsTitleLabel;
    }
}
