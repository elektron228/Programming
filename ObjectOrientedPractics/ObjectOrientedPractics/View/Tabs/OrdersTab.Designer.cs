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
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderStatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerFullNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryAddressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCostColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriorityOptionsPanel = new System.Windows.Forms.Panel();
            this.PriorityOptionsLabel = new System.Windows.Forms.Label();
            this.DeliverytimeComboBox = new System.Windows.Forms.ComboBox();
            this.DeliveryTimeLabel = new System.Windows.Forms.Label();
            this.OrderItemsLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.OrderItemsListBox = new System.Windows.Forms.ListBox();
            this.OrderItemsLabel = new System.Windows.Forms.Label();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.AddressControl1 = new ObjectOrientedPractics.View.Controls.AddressControl();
            this.CreatedDateTextBox = new System.Windows.Forms.TextBox();
            this.AmountTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.TotalCostLabel = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.CreatedLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.SelectedOrderLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersTabSplitContainer)).BeginInit();
            this.OrdersTabSplitContainer.Panel1.SuspendLayout();
            this.OrdersTabSplitContainer.Panel2.SuspendLayout();
            this.OrdersTabSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGridView)).BeginInit();
            this.PriorityOptionsPanel.SuspendLayout();
            this.OrderItemsLayoutPanel.SuspendLayout();
            this.AmountTableLayoutPanel.SuspendLayout();
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
            this.OrdersTabSplitContainer.Panel2.Controls.Add(this.PriorityOptionsPanel);
            this.OrdersTabSplitContainer.Panel2.Controls.Add(this.OrderItemsLayoutPanel);
            this.OrdersTabSplitContainer.Panel2.Controls.Add(this.OrderItemsLabel);
            this.OrdersTabSplitContainer.Panel2.Controls.Add(this.StatusComboBox);
            this.OrdersTabSplitContainer.Panel2.Controls.Add(this.AddressControl1);
            this.OrdersTabSplitContainer.Panel2.Controls.Add(this.CreatedDateTextBox);
            this.OrdersTabSplitContainer.Panel2.Controls.Add(this.AmountTableLayoutPanel);
            this.OrdersTabSplitContainer.Panel2.Controls.Add(this.IdTextBox);
            this.OrdersTabSplitContainer.Panel2.Controls.Add(this.StatusLabel);
            this.OrdersTabSplitContainer.Panel2.Controls.Add(this.CreatedLabel);
            this.OrdersTabSplitContainer.Panel2.Controls.Add(this.IdLabel);
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
            // PriorityOptionsPanel
            // 
            this.PriorityOptionsPanel.Controls.Add(this.PriorityOptionsLabel);
            this.PriorityOptionsPanel.Controls.Add(this.DeliverytimeComboBox);
            this.PriorityOptionsPanel.Controls.Add(this.DeliveryTimeLabel);
            this.PriorityOptionsPanel.Location = new System.Drawing.Point(179, 3);
            this.PriorityOptionsPanel.Name = "PriorityOptionsPanel";
            this.PriorityOptionsPanel.Size = new System.Drawing.Size(201, 105);
            this.PriorityOptionsPanel.TabIndex = 11;
            // 
            // PriorityOptionsLabel
            // 
            this.PriorityOptionsLabel.AutoSize = true;
            this.PriorityOptionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriorityOptionsLabel.Location = new System.Drawing.Point(3, 0);
            this.PriorityOptionsLabel.Name = "PriorityOptionsLabel";
            this.PriorityOptionsLabel.Size = new System.Drawing.Size(97, 13);
            this.PriorityOptionsLabel.TabIndex = 18;
            this.PriorityOptionsLabel.Text = "Priority Options:";
            // 
            // DeliverytimeComboBox
            // 
            this.DeliverytimeComboBox.FormattingEnabled = true;
            this.DeliverytimeComboBox.Location = new System.Drawing.Point(83, 23);
            this.DeliverytimeComboBox.Name = "DeliverytimeComboBox";
            this.DeliverytimeComboBox.Size = new System.Drawing.Size(115, 21);
            this.DeliverytimeComboBox.TabIndex = 16;
            this.DeliverytimeComboBox.SelectedIndexChanged += new System.EventHandler(this.DeliverytimeComboBox_SelectedIndexChanged);
            // 
            // DeliveryTimeLabel
            // 
            this.DeliveryTimeLabel.AutoSize = true;
            this.DeliveryTimeLabel.Location = new System.Drawing.Point(3, 27);
            this.DeliveryTimeLabel.Name = "DeliveryTimeLabel";
            this.DeliveryTimeLabel.Size = new System.Drawing.Size(74, 13);
            this.DeliveryTimeLabel.TabIndex = 17;
            this.DeliveryTimeLabel.Text = "Delivery Time:";
            // 
            // OrderItemsLayoutPanel
            // 
            this.OrderItemsLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderItemsLayoutPanel.ColumnCount = 1;
            this.OrderItemsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OrderItemsLayoutPanel.Controls.Add(this.OrderItemsListBox, 0, 0);
            this.OrderItemsLayoutPanel.Location = new System.Drawing.Point(3, 272);
            this.OrderItemsLayoutPanel.Name = "OrderItemsLayoutPanel";
            this.OrderItemsLayoutPanel.RowCount = 1;
            this.OrderItemsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OrderItemsLayoutPanel.Size = new System.Drawing.Size(380, 141);
            this.OrderItemsLayoutPanel.TabIndex = 6;
            // 
            // OrderItemsListBox
            // 
            this.OrderItemsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderItemsListBox.FormattingEnabled = true;
            this.OrderItemsListBox.Location = new System.Drawing.Point(3, 3);
            this.OrderItemsListBox.Name = "OrderItemsListBox";
            this.OrderItemsListBox.Size = new System.Drawing.Size(374, 135);
            this.OrderItemsListBox.TabIndex = 4;
            // 
            // OrderItemsLabel
            // 
            this.OrderItemsLabel.AutoSize = true;
            this.OrderItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderItemsLabel.Location = new System.Drawing.Point(3, 256);
            this.OrderItemsLabel.Name = "OrderItemsLabel";
            this.OrderItemsLabel.Size = new System.Drawing.Size(72, 13);
            this.OrderItemsLabel.TabIndex = 3;
            this.OrderItemsLabel.Text = "Order Items";
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Location = new System.Drawing.Point(53, 77);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(121, 21);
            this.StatusComboBox.TabIndex = 1;
            // 
            // AddressControl1
            // 
            this.AddressControl1.Location = new System.Drawing.Point(3, 114);
            this.AddressControl1.Name = "AddressControl1";
            this.AddressControl1.OurAddress = null;
            this.AddressControl1.Size = new System.Drawing.Size(380, 139);
            this.AddressControl1.TabIndex = 0;
            // 
            // CreatedDateTextBox
            // 
            this.CreatedDateTextBox.Location = new System.Drawing.Point(53, 48);
            this.CreatedDateTextBox.Name = "CreatedDateTextBox";
            this.CreatedDateTextBox.ReadOnly = true;
            this.CreatedDateTextBox.Size = new System.Drawing.Size(121, 20);
            this.CreatedDateTextBox.TabIndex = 4;
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
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(53, 22);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(121, 20);
            this.IdTextBox.TabIndex = 3;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(3, 77);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(40, 13);
            this.StatusLabel.TabIndex = 2;
            this.StatusLabel.Text = "Status:";
            // 
            // CreatedLabel
            // 
            this.CreatedLabel.AutoSize = true;
            this.CreatedLabel.Location = new System.Drawing.Point(3, 51);
            this.CreatedLabel.Name = "CreatedLabel";
            this.CreatedLabel.Size = new System.Drawing.Size(47, 13);
            this.CreatedLabel.TabIndex = 1;
            this.CreatedLabel.Text = "Created:";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(3, 25);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(21, 13);
            this.IdLabel.TabIndex = 0;
            this.IdLabel.Text = "ID:";
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
            this.PriorityOptionsPanel.ResumeLayout(false);
            this.PriorityOptionsPanel.PerformLayout();
            this.OrderItemsLayoutPanel.ResumeLayout(false);
            this.AmountTableLayoutPanel.ResumeLayout(false);
            this.AmountTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer OrdersTabSplitContainer;
        private System.Windows.Forms.DataGridView OrdersDataGridView;
        private System.Windows.Forms.Label OrdersLabel;
        private System.Windows.Forms.Label SelectedOrderLabel;
        private System.Windows.Forms.TableLayoutPanel AmountTableLayoutPanel;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Label TotalCostLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedTimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderStatusColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerFullNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryAddressColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCostColumn;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.TextBox CreatedDateTextBox;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label CreatedLabel;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.ComboBox StatusComboBox;
        public Controls.AddressControl AddressControl1;
        private System.Windows.Forms.ListBox OrderItemsListBox;
        private System.Windows.Forms.Label OrderItemsLabel;
        private System.Windows.Forms.TableLayoutPanel OrderItemsLayoutPanel;
        private System.Windows.Forms.Panel PriorityOptionsPanel;
        private System.Windows.Forms.Label PriorityOptionsLabel;
        private System.Windows.Forms.ComboBox DeliverytimeComboBox;
        private System.Windows.Forms.Label DeliveryTimeLabel;
    }
}
