namespace ObjectOrientedPractics
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            CustomersTabPage = new TabPage();
            CustomersTab = new View.Tabs.CustomersTab();
            ItemsTabPage = new TabPage();
            ItemsTab = new View.Tabs.ItemsTab();
            TabControl = new TabControl();
            CartsTabPage = new TabPage();
            CartsTab = new View.Tabs.CartsTab();
            OrdersTabPage = new TabPage();
            OrdersTab = new View.Tabs.OrdersTab();
            TEST = new TabPage();
            percentDiscountsTab1 = new View.Tabs.PercentDiscountsTab();
            CustomersTabPage.SuspendLayout();
            ItemsTabPage.SuspendLayout();
            TabControl.SuspendLayout();
            CartsTabPage.SuspendLayout();
            OrdersTabPage.SuspendLayout();
            TEST.SuspendLayout();
            SuspendLayout();
            // 
            // CustomersTabPage
            // 
            CustomersTabPage.Controls.Add(CustomersTab);
            CustomersTabPage.Location = new Point(4, 24);
            CustomersTabPage.Name = "CustomersTabPage";
            CustomersTabPage.Padding = new Padding(3);
            CustomersTabPage.Size = new Size(953, 505);
            CustomersTabPage.TabIndex = 1;
            CustomersTabPage.Text = "Customers";
            CustomersTabPage.UseVisualStyleBackColor = true;
            // 
            // CustomersTab
            // 
            CustomersTab.Dock = DockStyle.Fill;
            CustomersTab.Location = new Point(3, 3);
            CustomersTab.Name = "CustomersTab";
            CustomersTab.Size = new Size(947, 499);
            CustomersTab.TabIndex = 0;
            // 
            // ItemsTabPage
            // 
            ItemsTabPage.Controls.Add(ItemsTab);
            ItemsTabPage.Location = new Point(4, 24);
            ItemsTabPage.Name = "ItemsTabPage";
            ItemsTabPage.Padding = new Padding(3);
            ItemsTabPage.Size = new Size(953, 505);
            ItemsTabPage.TabIndex = 0;
            ItemsTabPage.Text = "Items";
            ItemsTabPage.UseVisualStyleBackColor = true;
            // 
            // ItemsTab
            // 
            ItemsTab.Dock = DockStyle.Fill;
            ItemsTab.Location = new Point(3, 3);
            ItemsTab.Name = "ItemsTab";
            ItemsTab.Size = new Size(947, 499);
            ItemsTab.TabIndex = 1;
            // 
            // TabControl
            // 
            TabControl.Controls.Add(ItemsTabPage);
            TabControl.Controls.Add(CustomersTabPage);
            TabControl.Controls.Add(CartsTabPage);
            TabControl.Controls.Add(OrdersTabPage);
            TabControl.Controls.Add(TEST);
            TabControl.Dock = DockStyle.Fill;
            TabControl.Location = new Point(0, 0);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(961, 533);
            TabControl.TabIndex = 1;
            TabControl.SelectedIndexChanged += TabControl_SelectedIndexChanged;
            // 
            // CartsTabPage
            // 
            CartsTabPage.Controls.Add(CartsTab);
            CartsTabPage.Location = new Point(4, 24);
            CartsTabPage.Name = "CartsTabPage";
            CartsTabPage.Padding = new Padding(3);
            CartsTabPage.Size = new Size(953, 505);
            CartsTabPage.TabIndex = 2;
            CartsTabPage.Text = "Carts";
            CartsTabPage.UseVisualStyleBackColor = true;
            // 
            // CartsTab
            // 
            CartsTab.Dock = DockStyle.Fill;
            CartsTab.Location = new Point(3, 3);
            CartsTab.Name = "CartsTab";
            CartsTab.Size = new Size(947, 499);
            CartsTab.TabIndex = 0;
            // 
            // OrdersTabPage
            // 
            OrdersTabPage.Controls.Add(OrdersTab);
            OrdersTabPage.Location = new Point(4, 24);
            OrdersTabPage.Name = "OrdersTabPage";
            OrdersTabPage.Padding = new Padding(3);
            OrdersTabPage.Size = new Size(953, 505);
            OrdersTabPage.TabIndex = 3;
            OrdersTabPage.Text = "Orders";
            OrdersTabPage.UseVisualStyleBackColor = true;
            // 
            // OrdersTab
            // 
            OrdersTab.Customers = null;
            OrdersTab.Dock = DockStyle.Fill;
            OrdersTab.Location = new Point(3, 3);
            OrdersTab.Name = "OrdersTab";
            OrdersTab.Size = new Size(947, 499);
            OrdersTab.TabIndex = 0;
            // 
            // TEST
            // 
            TEST.Controls.Add(percentDiscountsTab1);
            TEST.Location = new Point(4, 24);
            TEST.Name = "TEST";
            TEST.Padding = new Padding(3);
            TEST.Size = new Size(953, 505);
            TEST.TabIndex = 4;
            TEST.Text = "Test Page";
            TEST.UseVisualStyleBackColor = true;
            // 
            // percentDiscountsTab1
            // 
            percentDiscountsTab1.Dock = DockStyle.Fill;
            percentDiscountsTab1.Location = new Point(3, 3);
            percentDiscountsTab1.Name = "percentDiscountsTab1";
            percentDiscountsTab1.Size = new Size(947, 499);
            percentDiscountsTab1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(961, 533);
            Controls.Add(TabControl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Object Oriented Practics";
            CustomersTabPage.ResumeLayout(false);
            ItemsTabPage.ResumeLayout(false);
            TabControl.ResumeLayout(false);
            CartsTabPage.ResumeLayout(false);
            OrdersTabPage.ResumeLayout(false);
            TEST.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage CustomersTabPage;
        private View.Tabs.CustomersTab CustomersTab;
        private TabPage ItemsTabPage;
        private View.Tabs.ItemsTab ItemsTab;
        private TabControl TabControl;
        private TabPage CartsTabPage;
        private View.Tabs.CartsTab CartsTab;
        private TabPage OrdersTabPage;
        private View.Tabs.OrdersTab OrdersTab;
        private TabPage TEST;
        private View.Tabs.PercentDiscountsTab percentDiscountsTab1;
    }
}