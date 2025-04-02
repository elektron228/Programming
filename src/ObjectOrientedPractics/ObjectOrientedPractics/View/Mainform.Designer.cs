namespace ObjectOrientedPractics
{
    partial class Mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.CustomerstTabPage = new System.Windows.Forms.TabPage();
            this.CustomersTab1 = new ObjectOrientedPractics.View.Tabs.CustomersTab();
            this.ItemsTabControl = new System.Windows.Forms.TabControl();
            this.ItemsTabPage = new System.Windows.Forms.TabPage();
            this.ItemsTab1 = new ObjectOrientedPractics.View.Tabs.ItemsTab();
            this.CartsTab = new System.Windows.Forms.TabPage();
            this.CartsTab1 = new ObjectOrientedPractics.View.Tabs.CartsTab();
            this.OrdersTabPage = new System.Windows.Forms.TabPage();
            this.OrdersTab1 = new ObjectOrientedPractics.View.Tabs.OrdersTab();
            this.PriorityOrderTabPage = new System.Windows.Forms.TabPage();
            this.PriorityOrdersTab1 = new ObjectOrientedPractics.View.Tabs.PriorityOrdersTab();
            this.CustomerstTabPage.SuspendLayout();
            this.ItemsTabControl.SuspendLayout();
            this.ItemsTabPage.SuspendLayout();
            this.CartsTab.SuspendLayout();
            this.OrdersTabPage.SuspendLayout();
            this.PriorityOrderTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomerstTabPage
            // 
            this.CustomerstTabPage.Controls.Add(this.CustomersTab1);
            this.CustomerstTabPage.Location = new System.Drawing.Point(4, 22);
            this.CustomerstTabPage.Name = "CustomerstTabPage";
            this.CustomerstTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CustomerstTabPage.Size = new System.Drawing.Size(776, 535);
            this.CustomerstTabPage.TabIndex = 2;
            this.CustomerstTabPage.Text = "Customers";
            this.CustomerstTabPage.UseVisualStyleBackColor = true;
            // 
            // CustomersTab1
            // 
            this.CustomersTab1.Customers = null;
            this.CustomersTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomersTab1.Location = new System.Drawing.Point(3, 3);
            this.CustomersTab1.Name = "CustomersTab1";
            this.CustomersTab1.Size = new System.Drawing.Size(770, 529);
            this.CustomersTab1.TabIndex = 0;
            // 
            // ItemsTabControl
            // 
            this.ItemsTabControl.Controls.Add(this.ItemsTabPage);
            this.ItemsTabControl.Controls.Add(this.CustomerstTabPage);
            this.ItemsTabControl.Controls.Add(this.CartsTab);
            this.ItemsTabControl.Controls.Add(this.OrdersTabPage);
            this.ItemsTabControl.Controls.Add(this.PriorityOrderTabPage);
            this.ItemsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsTabControl.Location = new System.Drawing.Point(0, 0);
            this.ItemsTabControl.Name = "ItemsTabControl";
            this.ItemsTabControl.SelectedIndex = 0;
            this.ItemsTabControl.Size = new System.Drawing.Size(784, 561);
            this.ItemsTabControl.TabIndex = 0;
            this.ItemsTabControl.SelectedIndexChanged += new System.EventHandler(this.ItemsTabControl_SelectedIndexChanged);
            // 
            // ItemsTabPage
            // 
            this.ItemsTabPage.Controls.Add(this.ItemsTab1);
            this.ItemsTabPage.Location = new System.Drawing.Point(4, 22);
            this.ItemsTabPage.Name = "ItemsTabPage";
            this.ItemsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ItemsTabPage.Size = new System.Drawing.Size(776, 535);
            this.ItemsTabPage.TabIndex = 1;
            this.ItemsTabPage.Text = "Items";
            this.ItemsTabPage.UseVisualStyleBackColor = true;
            // 
            // ItemsTab1
            // 
            this.ItemsTab1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ItemsTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsTab1.Items = null;
            this.ItemsTab1.Location = new System.Drawing.Point(3, 3);
            this.ItemsTab1.Name = "ItemsTab1";
            this.ItemsTab1.Size = new System.Drawing.Size(770, 529);
            this.ItemsTab1.TabIndex = 0;
            // 
            // CartsTab
            // 
            this.CartsTab.Controls.Add(this.CartsTab1);
            this.CartsTab.Location = new System.Drawing.Point(4, 22);
            this.CartsTab.Name = "CartsTab";
            this.CartsTab.Padding = new System.Windows.Forms.Padding(3);
            this.CartsTab.Size = new System.Drawing.Size(776, 535);
            this.CartsTab.TabIndex = 3;
            this.CartsTab.Text = "Carts";
            this.CartsTab.UseVisualStyleBackColor = true;
            // 
            // CartsTab1
            // 
            this.CartsTab1.Customers = null;
            this.CartsTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CartsTab1.Items = null;
            this.CartsTab1.Location = new System.Drawing.Point(3, 3);
            this.CartsTab1.Name = "CartsTab1";
            this.CartsTab1.Size = new System.Drawing.Size(770, 529);
            this.CartsTab1.TabIndex = 0;
            // 
            // OrdersTabPage
            // 
            this.OrdersTabPage.Controls.Add(this.OrdersTab1);
            this.OrdersTabPage.Location = new System.Drawing.Point(4, 22);
            this.OrdersTabPage.Name = "OrdersTabPage";
            this.OrdersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.OrdersTabPage.Size = new System.Drawing.Size(776, 535);
            this.OrdersTabPage.TabIndex = 4;
            this.OrdersTabPage.Text = "Orders";
            this.OrdersTabPage.UseVisualStyleBackColor = true;
            // 
            // OrdersTab1
            // 
            this.OrdersTab1.Customers = null;
            this.OrdersTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrdersTab1.Location = new System.Drawing.Point(3, 3);
            this.OrdersTab1.Name = "OrdersTab1";
            this.OrdersTab1.Size = new System.Drawing.Size(770, 529);
            this.OrdersTab1.TabIndex = 0;
            // 
            // PriorityOrderTabPage
            // 
            this.PriorityOrderTabPage.Controls.Add(this.PriorityOrdersTab1);
            this.PriorityOrderTabPage.Location = new System.Drawing.Point(4, 22);
            this.PriorityOrderTabPage.Name = "PriorityOrderTabPage";
            this.PriorityOrderTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.PriorityOrderTabPage.Size = new System.Drawing.Size(776, 535);
            this.PriorityOrderTabPage.TabIndex = 5;
            this.PriorityOrderTabPage.Text = "Priority Orders";
            this.PriorityOrderTabPage.UseVisualStyleBackColor = true;
            // 
            // PriorityOrdersTab1
            // 
            this.PriorityOrdersTab1.Customers = null;
            this.PriorityOrdersTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PriorityOrdersTab1.Location = new System.Drawing.Point(3, 3);
            this.PriorityOrdersTab1.Name = "PriorityOrdersTab1";
            this.PriorityOrdersTab1.Size = new System.Drawing.Size(770, 529);
            this.PriorityOrdersTab1.TabIndex = 0;
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.ItemsTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(560, 450);
            this.Name = "Mainform";
            this.Text = "Object Oriented Practics";
            this.CustomerstTabPage.ResumeLayout(false);
            this.ItemsTabControl.ResumeLayout(false);
            this.ItemsTabPage.ResumeLayout(false);
            this.CartsTab.ResumeLayout(false);
            this.OrdersTabPage.ResumeLayout(false);
            this.PriorityOrderTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage CustomerstTabPage;
        private View.Tabs.CustomersTab CustomersTab1;
        private System.Windows.Forms.TabControl ItemsTabControl;
        private System.Windows.Forms.TabPage ItemsTabPage;
        private View.Tabs.ItemsTab ItemsTab1;
        private System.Windows.Forms.TabPage CartsTab;
        private View.Tabs.CartsTab CartsTab1;
        private System.Windows.Forms.TabPage OrdersTabPage;
        private View.Tabs.OrdersTab OrdersTab1;
        private System.Windows.Forms.TabPage PriorityOrderTabPage;
        private View.Tabs.PriorityOrdersTab PriorityOrdersTab1;
    }
}

