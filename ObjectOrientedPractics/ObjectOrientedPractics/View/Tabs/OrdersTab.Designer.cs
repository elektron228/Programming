namespace ObjectOrientedPractics.View.Tabs
{
    partial class OrdersTab
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OrdersTabSplitContainer = new System.Windows.Forms.SplitContainer();
            this.OrdersLabel = new System.Windows.Forms.Label();
            this.OrdersDataGridView = new System.Windows.Forms.DataGridView();
            this.AmountTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.TotalCostLabel = new System.Windows.Forms.Label();
            this.SelectedOrderTebleLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.OrderItemsLabel = new System.Windows.Forms.Label();
            this.OrderStatusTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CreatedDateTextBox = new System.Windows.Forms.TextBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.CreatedLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.OrderItemsListBox = new System.Windows.Forms.ListBox();
            this.SelectedOrderLabel = new System.Windows.Forms.Label();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderStatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerFullNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryAddressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCostColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressControl1 = new ObjectOrientedPractics.View.Controls.AddressControl();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersTabSplitContainer)).BeginInit();
            this.OrdersTabSplitContainer.Panel1.SuspendLayout();
            this.OrdersTabSplitContainer.Panel2.SuspendLayout();
            this.OrdersTabSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGridView)).BeginInit();
            this.AmountTableLayoutPanel.SuspendLayout();
            this.SelectedOrderTebleLayoutPanel.SuspendLayout();
            this.OrderStatusTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrdersTabSplitContainer
            // 
            this.OrdersTabSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrdersTabSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.OrdersTabSplitContainer.Name = "OrdersTabSplitContainer";
            // 
            // OrdersTabSplitContainer.Panel1
            // 
            this.OrdersTabSplitContainer.Panel1.Controls.Add(this.OrdersLabel);
            this.OrdersTabSplitContainer.Panel1.Controls.Add(this.OrdersDataGridView);
            // 
            // OrdersTabSplitContainer.Panel2
            // 
            this.OrdersTabSplitContainer.Panel2.Controls.Add(this.AmountTableLayoutPanel);
            this.OrdersTabSplitContainer.Panel2.Controls.Add(this.SelectedOrderTebleLayoutPanel);
            this.OrdersTabSplitContainer.Panel2.Controls.Add(this.SelectedOrderLabel);
            this.OrdersTabSplitContainer.Size = new System.Drawing.Size(740, 530);
            this.OrdersTabSplitContainer.SplitterDistance = 350;
            this.OrdersTabSplitContainer.TabIndex = 0;
            // 
            // OrdersLabel
            // 
            this.OrdersLabel.AutoSize = true;
            this.OrdersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrdersLabel.Location = new System.Drawing.Point(0, 0);
            this.OrdersLabel.Name = "OrdersLabel";
            this.OrdersLabel.Size = new System.Drawing.Size(44, 13);
            this.OrdersLabel.TabIndex = 1;
            this.OrdersLabel.Text = "Orders";
            // 
            // OrdersDataGridView
            // 
            this.OrdersDataGridView.AllowUserToAddRows = false;
            this.OrdersDataGridView.AllowUserToDeleteRows = false;
            this.OrdersDataGridView.AllowUserToResizeColumns = false;
            this.OrdersDataGridView.AllowUserToResizeRows = false;
            this.OrdersDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrdersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.CreatedTimeColumn,
            this.OrderStatusColumn,
            this.CustomerFullNameColumn,
            this.DeliveryAddressColumn,
            this.TotalCostColumn});
            this.OrdersDataGridView.Location = new System.Drawing.Point(3, 16);
            this.OrdersDataGridView.MultiSelect = false;
            this.OrdersDataGridView.Name = "OrdersDataGridView";
            this.OrdersDataGridView.ReadOnly = true;
            this.OrdersDataGridView.RowHeadersVisible = false;
            this.OrdersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrdersDataGridView.Size = new System.Drawing.Size(344, 514);
            this.OrdersDataGridView.TabIndex = 0;
            this.OrdersDataGridView.SelectionChanged += new System.EventHandler(this.OrdersDataGridView_SelectionChanged);
            // 
            // AmountTableLayoutPanel
            // 
            this.AmountTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountTableLayoutPanel.ColumnCount = 2;
            this.AmountTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AmountTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AmountTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.AmountTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.AmountTableLayoutPanel.Controls.Add(this.AmountLabel, 1, 0);
            this.AmountTableLayoutPanel.Controls.Add(this.TotalCostLabel, 1, 1);
            this.AmountTableLayoutPanel.Location = new System.Drawing.Point(3, 419);
            this.AmountTableLayoutPanel.Name = "AmountTableLayoutPanel";
            this.AmountTableLayoutPanel.RowCount = 2;
            this.AmountTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AmountTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AmountTableLayoutPanel.Size = new System.Drawing.Size(380, 47);
            this.AmountTableLayoutPanel.TabIndex = 5;
            // 
            // AmountLabel
            // 
            this.AmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountLabel.Location = new System.Drawing.Point(324, 0);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(53, 13);
            this.AmountLabel.TabIndex = 9;
            this.AmountLabel.Text = "Amount:";
            // 
            // TotalCostLabel
            // 
            this.TotalCostLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalCostLabel.AutoSize = true;
            this.TotalCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TotalCostLabel.Location = new System.Drawing.Point(343, 23);
            this.TotalCostLabel.Name = "TotalCostLabel";
            this.TotalCostLabel.Size = new System.Drawing.Size(34, 20);
            this.TotalCostLabel.TabIndex = 5;
            this.TotalCostLabel.Text = "0,0";
            // 
            // SelectedOrderTebleLayoutPanel
            // 
            this.SelectedOrderTebleLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedOrderTebleLayoutPanel.ColumnCount = 1;
            this.SelectedOrderTebleLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SelectedOrderTebleLayoutPanel.Controls.Add(this.OrderItemsLabel, 0, 2);
            this.SelectedOrderTebleLayoutPanel.Controls.Add(this.AddressControl1, 0, 1);
            this.SelectedOrderTebleLayoutPanel.Controls.Add(this.OrderStatusTableLayoutPanel, 0, 0);
            this.SelectedOrderTebleLayoutPanel.Controls.Add(this.OrderItemsListBox, 0, 3);
            this.SelectedOrderTebleLayoutPanel.Location = new System.Drawing.Point(0, 16);
            this.SelectedOrderTebleLayoutPanel.Name = "SelectedOrderTebleLayoutPanel";
            this.SelectedOrderTebleLayoutPanel.RowCount = 4;
            this.SelectedOrderTebleLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.SelectedOrderTebleLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.25F));
            this.SelectedOrderTebleLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.75F));
            this.SelectedOrderTebleLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.SelectedOrderTebleLayoutPanel.Size = new System.Drawing.Size(386, 400);
            this.SelectedOrderTebleLayoutPanel.TabIndex = 0;
            // 
            // OrderItemsLabel
            // 
            this.OrderItemsLabel.AutoSize = true;
            this.OrderItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderItemsLabel.Location = new System.Drawing.Point(3, 249);
            this.OrderItemsLabel.Name = "OrderItemsLabel";
            this.OrderItemsLabel.Size = new System.Drawing.Size(72, 13);
            this.OrderItemsLabel.TabIndex = 3;
            this.OrderItemsLabel.Text = "Order Items";
            // 
            // OrderStatusTableLayoutPanel
            // 
            this.OrderStatusTableLayoutPanel.ColumnCount = 2;
            this.OrderStatusTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.OrderStatusTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.OrderStatusTableLayoutPanel.Controls.Add(this.CreatedDateTextBox, 1, 1);
            this.OrderStatusTableLayoutPanel.Controls.Add(this.IdLabel, 0, 0);
            this.OrderStatusTableLayoutPanel.Controls.Add(this.CreatedLabel, 0, 1);
            this.OrderStatusTableLayoutPanel.Controls.Add(this.StatusLabel, 0, 2);
            this.OrderStatusTableLayoutPanel.Controls.Add(this.IdTextBox, 1, 0);
            this.OrderStatusTableLayoutPanel.Controls.Add(this.StatusComboBox, 1, 2);
            this.OrderStatusTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderStatusTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.OrderStatusTableLayoutPanel.Name = "OrderStatusTableLayoutPanel";
            this.OrderStatusTableLayoutPanel.RowCount = 3;
            this.OrderStatusTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.OrderStatusTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.OrderStatusTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.OrderStatusTableLayoutPanel.Size = new System.Drawing.Size(380, 90);
            this.OrderStatusTableLayoutPanel.TabIndex = 2;
            // 
            // CreatedDateTextBox
            // 
            this.CreatedDateTextBox.Location = new System.Drawing.Point(60, 33);
            this.CreatedDateTextBox.Name = "CreatedDateTextBox";
            this.CreatedDateTextBox.ReadOnly = true;
            this.CreatedDateTextBox.Size = new System.Drawing.Size(121, 20);
            this.CreatedDateTextBox.TabIndex = 4;
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(3, 0);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(21, 13);
            this.IdLabel.TabIndex = 0;
            this.IdLabel.Text = "ID:";
            // 
            // CreatedLabel
            // 
            this.CreatedLabel.AutoSize = true;
            this.CreatedLabel.Location = new System.Drawing.Point(3, 30);
            this.CreatedLabel.Name = "CreatedLabel";
            this.CreatedLabel.Size = new System.Drawing.Size(47, 13);
            this.CreatedLabel.TabIndex = 1;
            this.CreatedLabel.Text = "Created:";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(3, 60);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(40, 13);
            this.StatusLabel.TabIndex = 2;
            this.StatusLabel.Text = "Status:";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(60, 3);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(121, 20);
            this.IdTextBox.TabIndex = 3;
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Location = new System.Drawing.Point(60, 63);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(121, 21);
            this.StatusComboBox.TabIndex = 5;
            this.StatusComboBox.SelectedIndexChanged += new System.EventHandler(this.StatusComboBox_SelectedIndexChanged);
            // 
            // OrderItemsListBox
            // 
            this.OrderItemsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderItemsListBox.FormattingEnabled = true;
            this.OrderItemsListBox.Location = new System.Drawing.Point(3, 271);
            this.OrderItemsListBox.Name = "OrderItemsListBox";
            this.OrderItemsListBox.Size = new System.Drawing.Size(380, 126);
            this.OrderItemsListBox.TabIndex = 4;
            // 
            // SelectedOrderLabel
            // 
            this.SelectedOrderLabel.AutoSize = true;
            this.SelectedOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedOrderLabel.Location = new System.Drawing.Point(3, 3);
            this.SelectedOrderLabel.Name = "SelectedOrderLabel";
            this.SelectedOrderLabel.Size = new System.Drawing.Size(90, 13);
            this.SelectedOrderLabel.TabIndex = 1;
            this.SelectedOrderLabel.Text = "Selected order";
            // 
            // IdColumn
            // 
            this.IdColumn.HeaderText = "ID";
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.ReadOnly = true;
            this.IdColumn.Width = 30;
            // 
            // CreatedTimeColumn
            // 
            this.CreatedTimeColumn.HeaderText = "Created";
            this.CreatedTimeColumn.Name = "CreatedTimeColumn";
            this.CreatedTimeColumn.ReadOnly = true;
            // 
            // OrderStatusColumn
            // 
            this.OrderStatusColumn.HeaderText = "Order Status";
            this.OrderStatusColumn.Name = "OrderStatusColumn";
            this.OrderStatusColumn.ReadOnly = true;
            // 
            // CustomerFullNameColumn
            // 
            this.CustomerFullNameColumn.HeaderText = "Customer Full Name";
            this.CustomerFullNameColumn.Name = "CustomerFullNameColumn";
            this.CustomerFullNameColumn.ReadOnly = true;
            this.CustomerFullNameColumn.Width = 130;
            // 
            // DeliveryAddressColumn
            // 
            this.DeliveryAddressColumn.HeaderText = "Delivery Address";
            this.DeliveryAddressColumn.Name = "DeliveryAddressColumn";
            this.DeliveryAddressColumn.ReadOnly = true;
            this.DeliveryAddressColumn.Width = 250;
            // 
            // TotalCostColumn
            // 
            this.TotalCostColumn.HeaderText = "Total Cost";
            this.TotalCostColumn.Name = "TotalCostColumn";
            this.TotalCostColumn.ReadOnly = true;
            // 
            // AddressControl1
            // 
            this.AddressControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddressControl1.Location = new System.Drawing.Point(3, 99);
            this.AddressControl1.Name = "AddressControl1";
            this.AddressControl1.OurAddress = null;
            this.AddressControl1.Size = new System.Drawing.Size(380, 147);
            this.AddressControl1.TabIndex = 0;
            // 
            // OrdersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.OrdersTabSplitContainer);
            this.Name = "OrdersTab";
            this.Size = new System.Drawing.Size(740, 530);
            this.Load += new System.EventHandler(this.OrdersTab_Load);
            this.OrdersTabSplitContainer.Panel1.ResumeLayout(false);
            this.OrdersTabSplitContainer.Panel1.PerformLayout();
            this.OrdersTabSplitContainer.Panel2.ResumeLayout(false);
            this.OrdersTabSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersTabSplitContainer)).EndInit();
            this.OrdersTabSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGridView)).EndInit();
            this.AmountTableLayoutPanel.ResumeLayout(false);
            this.AmountTableLayoutPanel.PerformLayout();
            this.SelectedOrderTebleLayoutPanel.ResumeLayout(false);
            this.SelectedOrderTebleLayoutPanel.PerformLayout();
            this.OrderStatusTableLayoutPanel.ResumeLayout(false);
            this.OrderStatusTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer OrdersTabSplitContainer;
        private System.Windows.Forms.DataGridView OrdersDataGridView;
        private System.Windows.Forms.TableLayoutPanel SelectedOrderTebleLayoutPanel;
        private System.Windows.Forms.Label OrdersLabel;
        private System.Windows.Forms.Label SelectedOrderLabel;
        private System.Windows.Forms.TableLayoutPanel OrderStatusTableLayoutPanel;
        private System.Windows.Forms.TextBox CreatedDateTextBox;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label CreatedLabel;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.ComboBox StatusComboBox;
        private System.Windows.Forms.Label OrderItemsLabel;
        private System.Windows.Forms.ListBox OrderItemsListBox;
        private System.Windows.Forms.TableLayoutPanel AmountTableLayoutPanel;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Label TotalCostLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedTimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderStatusColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerFullNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryAddressColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCostColumn;
        public Controls.AddressControl AddressControl1;
    }
}
