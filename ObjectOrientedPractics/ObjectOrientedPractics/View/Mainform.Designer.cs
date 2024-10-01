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
            this.CustomerstTabPage.SuspendLayout();
            this.ItemsTabControl.SuspendLayout();
            this.ItemsTabPage.SuspendLayout();
            this.CartsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomerstTabPage
            // 
            this.CustomerstTabPage.Controls.Add(this.CustomersTab1);
            this.CustomerstTabPage.Location = new System.Drawing.Point(4, 22);
            this.CustomerstTabPage.Name = "CustomerstTabPage";
            this.CustomerstTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CustomerstTabPage.Size = new System.Drawing.Size(576, 385);
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
            this.CustomersTab1.Size = new System.Drawing.Size(570, 379);
            this.CustomersTab1.TabIndex = 0;
            // 
            // ItemsTabControl
            // 
            this.ItemsTabControl.Controls.Add(this.ItemsTabPage);
            this.ItemsTabControl.Controls.Add(this.CustomerstTabPage);
            this.ItemsTabControl.Controls.Add(this.CartsTab);
            this.ItemsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsTabControl.Location = new System.Drawing.Point(0, 0);
            this.ItemsTabControl.Name = "ItemsTabControl";
            this.ItemsTabControl.SelectedIndex = 0;
            this.ItemsTabControl.Size = new System.Drawing.Size(584, 411);
            this.ItemsTabControl.TabIndex = 0;
            this.ItemsTabControl.SelectedIndexChanged += new System.EventHandler(this.ItemsTabControl_SelectedIndexChanged);
            // 
            // ItemsTabPage
            // 
            this.ItemsTabPage.Controls.Add(this.ItemsTab1);
            this.ItemsTabPage.Location = new System.Drawing.Point(4, 22);
            this.ItemsTabPage.Name = "ItemsTabPage";
            this.ItemsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ItemsTabPage.Size = new System.Drawing.Size(576, 385);
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
            this.ItemsTab1.Size = new System.Drawing.Size(570, 379);
            this.ItemsTab1.TabIndex = 0;
            // 
            // CartsTab
            // 
            this.CartsTab.Controls.Add(this.CartsTab1);
            this.CartsTab.Location = new System.Drawing.Point(4, 22);
            this.CartsTab.Name = "CartsTab";
            this.CartsTab.Padding = new System.Windows.Forms.Padding(3);
            this.CartsTab.Size = new System.Drawing.Size(576, 385);
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
            this.CartsTab1.Size = new System.Drawing.Size(570, 379);
            this.CartsTab1.TabIndex = 0;
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.ItemsTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(560, 450);
            this.Name = "Mainform";
            this.Text = "Object Oriented Practics";
            this.CustomerstTabPage.ResumeLayout(false);
            this.ItemsTabControl.ResumeLayout(false);
            this.ItemsTabPage.ResumeLayout(false);
            this.CartsTab.ResumeLayout(false);
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
    }
}

