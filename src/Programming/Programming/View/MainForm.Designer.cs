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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.EnumsTabPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.seasonHandleControl1 = new Programming.View.SeasonHandleControl();
            this.enumerationsControl1 = new Programming.View.EnumerationsControl();
            this.weekdayParsingControl1 = new Programming.View.WeekdayParsingControl();
            this.ClassesTabPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.rectanglesListControl1 = new Programming.View.RectanglesListControl();
            this.filmsListControl1 = new Programming.View.FilmsListControl();
            this.RectanglesTabPage = new System.Windows.Forms.TabPage();
            this.rectanglesCollisionControl1 = new Programming.View.RectanglesCollisionControl();
            this.MainTabControl.SuspendLayout();
            this.EnumsTabPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.ClassesTabPage.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.RectanglesTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.EnumsTabPage);
            this.MainTabControl.Controls.Add(this.ClassesTabPage);
            this.MainTabControl.Controls.Add(this.RectanglesTabPage);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(721, 486);
            this.MainTabControl.TabIndex = 0;
            // 
            // EnumsTabPage
            // 
            this.EnumsTabPage.Controls.Add(this.tableLayoutPanel1);
            this.EnumsTabPage.Location = new System.Drawing.Point(4, 22);
            this.EnumsTabPage.Name = "EnumsTabPage";
            this.EnumsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.EnumsTabPage.Size = new System.Drawing.Size(713, 460);
            this.EnumsTabPage.TabIndex = 0;
            this.EnumsTabPage.Text = "Enums";
            this.EnumsTabPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.seasonHandleControl1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.enumerationsControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.weekdayParsingControl1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(707, 454);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // seasonHandleControl1
            // 
            this.seasonHandleControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seasonHandleControl1.Location = new System.Drawing.Point(356, 230);
            this.seasonHandleControl1.Name = "seasonHandleControl1";
            this.seasonHandleControl1.Size = new System.Drawing.Size(348, 221);
            this.seasonHandleControl1.TabIndex = 8;
            // 
            // enumerationsControl1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.enumerationsControl1, 2);
            this.enumerationsControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enumerationsControl1.Location = new System.Drawing.Point(3, 3);
            this.enumerationsControl1.Name = "enumerationsControl1";
            this.enumerationsControl1.Size = new System.Drawing.Size(701, 221);
            this.enumerationsControl1.TabIndex = 6;
            // 
            // weekdayParsingControl1
            // 
            this.weekdayParsingControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weekdayParsingControl1.Location = new System.Drawing.Point(3, 230);
            this.weekdayParsingControl1.Name = "weekdayParsingControl1";
            this.weekdayParsingControl1.Size = new System.Drawing.Size(347, 221);
            this.weekdayParsingControl1.TabIndex = 7;
            // 
            // ClassesTabPage
            // 
            this.ClassesTabPage.Controls.Add(this.tableLayoutPanel2);
            this.ClassesTabPage.Location = new System.Drawing.Point(4, 22);
            this.ClassesTabPage.Name = "ClassesTabPage";
            this.ClassesTabPage.Size = new System.Drawing.Size(713, 460);
            this.ClassesTabPage.TabIndex = 1;
            this.ClassesTabPage.Text = "Classes";
            this.ClassesTabPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.rectanglesListControl1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.filmsListControl1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(713, 460);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // rectanglesListControl1
            // 
            this.rectanglesListControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rectanglesListControl1.Location = new System.Drawing.Point(3, 3);
            this.rectanglesListControl1.Name = "rectanglesListControl1";
            this.rectanglesListControl1.Size = new System.Drawing.Size(350, 454);
            this.rectanglesListControl1.TabIndex = 10;
            // 
            // filmsListControl1
            // 
            this.filmsListControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filmsListControl1.Location = new System.Drawing.Point(359, 3);
            this.filmsListControl1.Name = "filmsListControl1";
            this.filmsListControl1.Size = new System.Drawing.Size(351, 454);
            this.filmsListControl1.TabIndex = 11;
            // 
            // RectanglesTabPage
            // 
            this.RectanglesTabPage.Controls.Add(this.rectanglesCollisionControl1);
            this.RectanglesTabPage.Location = new System.Drawing.Point(4, 22);
            this.RectanglesTabPage.Name = "RectanglesTabPage";
            this.RectanglesTabPage.Size = new System.Drawing.Size(713, 460);
            this.RectanglesTabPage.TabIndex = 2;
            this.RectanglesTabPage.Text = "Rectangles";
            this.RectanglesTabPage.UseVisualStyleBackColor = true;
            // 
            // rectanglesCollisionControl1
            // 
            this.rectanglesCollisionControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rectanglesCollisionControl1.Location = new System.Drawing.Point(0, 0);
            this.rectanglesCollisionControl1.Name = "rectanglesCollisionControl1";
            this.rectanglesCollisionControl1.Size = new System.Drawing.Size(713, 460);
            this.rectanglesCollisionControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 486);
            this.Controls.Add(this.MainTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Programming";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainTabControl.ResumeLayout(false);
            this.EnumsTabPage.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ClassesTabPage.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.RectanglesTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage EnumsTabPage;
        private System.Windows.Forms.TabPage ClassesTabPage;
        private System.Windows.Forms.TabPage RectanglesTabPage;
        private View.RectanglesCollisionControl rectanglesCollisionControl1;
        private View.SeasonHandleControl seasonHandleControl1;
        private View.RectanglesListControl rectanglesListControl1;
        private View.WeekdayParsingControl weekdayParsingControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private View.EnumerationsControl enumerationsControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private View.FilmsListControl filmsListControl1;
    }
}

